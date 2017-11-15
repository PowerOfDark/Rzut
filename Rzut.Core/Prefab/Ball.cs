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
            b.Mass = model.Mass;
            b.BodyType = BodyType.Dynamic;
            b.Position = new Vector2(0,-model.Height-model.Radius);
            b.SetCollidesWith(Category.All& ~Category.Cat2);
            b.SetCollisionCategories(Category.Cat2);
            b.LinearVelocity = new Vector2(5, -10);
            b.LinearDamping = 0.1f;
            b.AngularDamping = 0.1f;
            b.SetFriction(50);
            return b;
        }

        public override void PreUpdate(GameTime time)
        {
            base.PreUpdate(time);
        }

        public override void PostUpdate(GameTime time)
        {
            Trail.Update(time, Body);
            base.PostUpdate(time);
        }

        public void Draw(GameTime time, SpriteBatch batch)
        {
            Trail.Draw(time, batch);
            batch.Draw(Sprite.Texture, ConvertUnits.ToDisplayUnits(Body.Position), null, Color.White, Body.Rotation, Sprite.Origin, 1f, SpriteEffects.None, 0f);

        }
    }
}
