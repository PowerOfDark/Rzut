using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
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
    public class Trail
    {
        public class TrailData
        {
            public Vector2 Position;
            public float Rotation;
        }

        public Color Color { get; set; }
        public Sprite Texture { get; set; }
        public LinkedList<TrailData> Data { get; set; }
        public float Step { get; set; }


        public Trail(Sprite texture, float step)
        {
            Data = new LinkedList<TrailData>();
            Step = step;
            Texture = texture;
        }

        public void Update(GameTime time, Body body)
        {
            if(Data.Count > 0)
            {
                var last = Data.Last.Value;
                var dist = body.Position - last.Position;
                if (dist.Length() < Step) return;
            }
            Data.AddLast(new TrailData() { Position = body.Position, Rotation = body.Rotation });
        }

        public void Draw(GameTime time, SpriteBatch batch)
        {
            //batch.Draw(Texture,)
            foreach(var point in Data)
            {
                batch.Draw(Texture.Texture, ConvertUnits.ToDisplayUnits(point.Position), null, Color.White, point.Rotation, Texture.Origin, 1f, SpriteEffects.None, 0f);
            }
        }
    }
}
