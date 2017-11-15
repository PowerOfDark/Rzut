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

namespace Rzut.Core.Prefab
{
    public class Ball : BallBase
    {
        public override EntityViewModel Data { get; set; }
        public override Body Body { get; set; }
        public Sprite Sprite { get; set; }
        public Trail Trail { get; set; }

        public Ball(World world, EntityViewModel data, AssetCreator creator)
        {
            const MaterialType material = MaterialType.Squares;
            Data = data;
            Body = CreateBody(world, data);
            Sprite = new Sprite(creator.CircleTexture(data.Radius, material, data.Color, 1f));
            Trail = new Trail(new Sprite(creator.CircleTexture(data.Radius, material, new Color(data.Color, 0.25f), 1f)), data.Radius*2f);
        }

        public static Body CreateBody(World world, EntityViewModel model)
        {
            var b = world.CreateCircle(model.Radius, 1f);
            float angle = (float)(Math.PI / 180) * (model.StartAngle - 90) % 360 ;
            b.SetCollidesWith(Category.All & ~Category.Cat2);
            b.SetCollisionCategories(Category.Cat2);
            b.Mass = model.Mass;
            b.BodyType = BodyType.Dynamic;
            b.Position = new Vector2(model.StartX,-model.StartY-model.StartY);
            b.LinearVelocity = new Vector2((float)Math.Cos( angle ) * model.Velocity, (float)Math.Sin( angle ) * model.Velocity);
            b.LinearDamping = 0;// 1.1f;
            b.AngularDamping = 0;// 0.1f;
            b.SetFriction(50);
            return b;
        }

        public void Update(GameTime time)
        {
            Trail.Update(time, Body);
            base.Update(time);
        }

        public void Draw(GameTime time, SpriteBatch batch)
        {
            Trail.Draw(time, batch);
            batch.Draw(Sprite.Texture, ConvertUnits.ToDisplayUnits(Body.Position), null, Color.White, Body.Rotation, Sprite.Origin, 1f, SpriteEffects.None, 0f);
        }
    }
}
