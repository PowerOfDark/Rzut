using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Rzut.Interface.Data.ViewModels.DataEntry;
using Rzut.Interface.Data.ViewModels.RzutOverlay;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tainicom.Aether.Physics2D;
using tainicom.Aether.Physics2D.Dynamics;
using tainicom.Aether.Physics2D.Samples.DrawingSystem;
using tainicom.Aether.Physics2D.Samples.ScreenSystem;

namespace Rzut.Core.Prefab
{
    public class Ball : BallBase
    {
        public override EntityViewModel Data { get; set; }
        public override Body Body { get; set; }
        public Sprite Sprite { get; set; }
        public Trail Trail { get; set; }
        public Marker Marker { get; set; }

        public Ball(World world, EntityViewModel data, AssetCreator creator)
        {
            const MaterialType material = MaterialType.Squares;
            Data = data;
            Body = CreateBody(world, data);
            Sprite = new Sprite(creator.CircleTexture(data.Radius, material, data.Color, 1f));
            Trail = new Trail(new Sprite(creator.CircleTexture(data.Radius/2f, MaterialType.Blank, new Color(data.Color, 0.25f), 1f)), data.Radius*2f);
            StartPosition = Body.Position;
            Body.OnCollision += Body_OnCollision;
            Marker = new Marker(creator, data.Radius, 1.5f, data.Color, 0.5f);
            Marker.Add(StartPosition);
        }

        private bool Body_OnCollision(Fixture sender, Fixture other, tainicom.Aether.Physics2D.Dynamics.Contacts.Contact contact)
        {
            Marker.Add(Body.Position);
            return true;
        }

        public static Body CreateBody(World world, EntityViewModel model)
        {
            var b = world.CreateCircle(model.Radius, 1f, default(Vector2), BodyType.Dynamic);
            float angle = (float)(Math.PI / 180) * (model.StartAngle - 90) % 360 ;
            if (!(model.Context as DataEntryContext).EnableCollision)
            {
                b.SetCollidesWith(Category.All & ~Category.Cat2);
            }
            b.SetCollisionCategories(Category.Cat2);
            b.Mass = model.Mass;
            b.Position = new Vector2(model.StartX, -model.StartY);
            b.LinearVelocity = new Vector2((float)Math.Cos( angle ) * model.Velocity, (float)Math.Sin( angle ) * model.Velocity);
            b.AngularVelocity = model.AngularVelocity;
            b.SetRestitution(model.Restitution);
            return b;
        }

        public static Sprite CreateTexture(float radius, Color color, AssetCreator creator)
        {
            return new Sprite(creator.CircleTexture(radius, MaterialType.Squares, color, 2f/ConvertUnits.Ratio));
        }
        public override void Update(GameTime time)
        {
            Body.ApplyForce(new Vector2(0, Body.Mass * Data.GravitationalAcceleration));
            var area = (float)(Math.PI * Data.Radius * Data.Radius);
            if (Data.AirResistance > float.Epsilon)
            {
                Body.ApplyForce(Body.LinearVelocity * -Data.AirResistance * area * Data.AirDensity);
            }
            var V = ((4.0f / 3.0f) * (float)Math.PI * (float)Math.Pow(Data.Radius, 3.0));
            Body.ApplyForce(new Vector2(0, -Data.AirDensity * Data.GravitationalAcceleration * V));
            if (Data.AngularDrag > float.Epsilon)
            {
                Body.ApplyTorque(-Body.Inertia / Body.Mass * area * Body.AngularVelocity * Data.AngularDrag);
            }
            Trail.Update(time, Body);
            base.Update(time);
        }

        public void Draw(GameTime time, SpriteBatch batch)
        {
            Trail.Draw(time, batch);
            Marker.Draw(time, batch);
            batch.Draw(Sprite.Texture, ConvertUnits.ToDisplayUnits(Body.Position), null, Color.White, Body.Rotation, Sprite.Origin, 1f, SpriteEffects.None, 0f);
        }

        public void HandleInput(InputHelper input, GameTime gameTime)
        {
            Marker.HandleInput(input, gameTime);
        }
    }
}
