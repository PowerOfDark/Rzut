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
using tainicom.Aether.Physics2D.Samples.ScreenSystem;

namespace Rzut.Core.Prefab
{
    public class Marker
    {
        public class MarkerData
        {
            public Vector2 Position;
        }

        public Color Color { get; set; }
        public Texture2D Texture { get; set; }
        public Texture2D Border { get; set; }
        public LinkedList<MarkerData> Data { get; set; }
        public float Step { get; set; }
        public float Size { get; set; }
        private Vector2 _cursor;


        public Marker(AssetCreator creator, float step, float size, Color color, float alpha)
        {
            Size = size;
            Data = new LinkedList<MarkerData>();
            Step = step;
            Texture = new Texture2D(creator.Device, 1, 1);
            Texture.SetData(new[] { color * alpha });
            Border = new Texture2D(creator.Device, 1, 1);
            Border.SetData(new[] { Color.Black * alpha});
            Color = Color;
        }

        public void Add(Vector2 pos)
        {
            if (Data.Count > 0)
            {
                var last = Data.Last.Value;
                var dist = pos - last.Position;
                if (dist.Length() + Size < Step) return;
            }
            Data.AddLast(new MarkerData() { Position = pos});
        }

        public void Draw(GameTime time, SpriteBatch batch)
        {
            //batch.Draw(Texture,)
            foreach (var point in Data)
            {
                var targetRect = ConvertUnits.ToDisplayUnits(point.Position.X - Size, point.Position.Y - Size, Size * 2, Size * 2);
                var borderRect = new Rectangle(targetRect.X - 2, targetRect.Y - 2, targetRect.Width + 4, targetRect.Height + 4);
                batch.Draw(Border, borderRect, Color.White);
                batch.Draw(Texture,targetRect, Color.White);
                var mouseVect = ConvertUnits.ToDisplayUnits(RzutScreen.CameraInstance.ConvertScreenToWorld(_cursor));
                if(targetRect.Contains(mouseVect.X, mouseVect.Y))
                batch.DrawString(RzutScreen.DetailsFont, $"X: {point.Position.X:0.0}m\nY: {point.Position.Y:0.0}m", new Vector2(targetRect.X, targetRect.Y-50), Color.White);
            }
        }

        public void HandleInput(InputHelper input, GameTime gameTime)
        {
            _cursor = input.Cursor;
        }
    }
}
