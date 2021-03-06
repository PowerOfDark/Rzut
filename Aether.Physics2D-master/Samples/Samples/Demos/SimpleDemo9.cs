﻿/* Original source Farseer Physics Engine:
 * Copyright (c) 2014 Ian Qvist, http://farseerphysics.codeplex.com
 * Microsoft Permissive License (Ms-PL) v1.1
 */

using System.Collections.Generic;
using System.Text;
using tainicom.Aether.Physics2D.Dynamics;
using tainicom.Aether.Physics2D.Samples.Demos.Prefabs;
using tainicom.Aether.Physics2D.Samples.DrawingSystem;
using tainicom.Aether.Physics2D.Samples.ScreenSystem;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace tainicom.Aether.Physics2D.Samples.Demos
{
    internal class SimpleDemo9 : PhysicsGameScreen, IDemoScreen
    {
        private Border _border;
        private List<Body> _ramps;
        private Body[] _rectangle = new Body[5];
        private Sprite _circleSprite;
        private Sprite _rectangleSprite;

        #region IDemoScreen Members

        public string GetTitle()
        {
            return "Friction";
        }

        public string GetDetails()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("This demo shows several bodys with varying friction.");
            sb.AppendLine(string.Empty);
            sb.AppendLine("GamePad:");
            sb.AppendLine("  - Move cursor: left thumbstick");
            sb.AppendLine("  - Grab object (beneath cursor): A button");
            sb.AppendLine("  - Drag grabbed object: left thumbstick");
            sb.AppendLine("  - Exit to menu: Back button");
            sb.AppendLine(string.Empty);
            sb.AppendLine("Keyboard:");
            sb.AppendLine("  - Exit to menu: Escape");
            sb.AppendLine(string.Empty);
            sb.AppendLine("Mouse / Touchscreen");
            sb.AppendLine("  - Grab object (beneath cursor): Left click");
            sb.AppendLine("  - Drag grabbed object: move mouse / finger");
            return sb.ToString();
        }

        #endregion

        public override void LoadContent()
        {
            base.LoadContent();

            World.Gravity = new Vector2(0f, 10f);

            _border = new Border(World, ScreenManager, Camera);

            _ramps = new List<Body>();
            /*_ramps.Add(World.CreateEdge(new Vector2(-20f, -11.2f), new Vector2(10f, -3.8f)));
            _ramps.Add(World.CreateEdge(new Vector2(12f, -5.6f), new Vector2(12f, -3.2f)));
            _ramps.Add(World.CreateEdge(new Vector2(-10f, 4.4f), new Vector2(20f, -1.4f)));
            _ramps.Add(World.CreateEdge(new Vector2(-12f, 2.6f), new Vector2(-12f, 5f)));
            _ramps.Add(World.CreateEdge(new Vector2(-20f, 6.8f), new Vector2(10f, 11.5f)));*/

            float[] friction = { 0.75f, 0.45f, 0.28f, 0.17f, 0.0f };
            for (int i = 0; i < 4; ++i)
            {
                _rectangle[i] = World.CreateRectangle(1.5f, 1.5f, 1f);
                _rectangle[i].BodyType = BodyType.Dynamic;
                _rectangle[i].Position = new Vector2(-18f + 5.2f * i, -13.0f + 1.282f * i);
                _rectangle[i].SetFriction(friction[i]);
            }
            _rectangle[4] = World.CreateCircle(1.5f, 1f);
            _rectangle[4].Position = new Vector2(-19f, -13f);
            _rectangle[4].SetFriction(0.05f);
            _rectangle[4].BodyType = BodyType.Dynamic;
            
            _rectangle[4].LinearVelocity = new Vector2(10f, -10f);

            // Create sprite based on body
            _circleSprite = new Sprite(ScreenManager.Assets.CircleTexture(1.5f, MaterialType.Squares, Color.Red, 0.7f));
            _rectangleSprite = new Sprite(ScreenManager.Assets.TextureFromShape(_rectangle[0].FixtureList[0].Shape, MaterialType.Squares, Color.ForestGreen, 0.8f));
        }

        public override void Draw(GameTime gameTime)
        {
            ScreenManager.SpriteBatch.Begin(0, null, null, null, null, null, Camera.View);
            for (int i = 0; i < 4; ++i)
            {
                ScreenManager.SpriteBatch.Draw(_rectangleSprite.Texture, ConvertUnits.ToDisplayUnits(_rectangle[i].Position), null, Color.White, _rectangle[i].Rotation, _rectangleSprite.Origin, 1f, SpriteEffects.None, 0f);
            }
            ScreenManager.SpriteBatch.Draw(_circleSprite.Texture, ConvertUnits.ToDisplayUnits(_rectangle[4].Position), null, Color.White,
                _rectangle[4].Rotation, _circleSprite.Origin, 1f, SpriteEffects.None, 0);
            ScreenManager.SpriteBatch.End();
            
            ScreenManager.LineBatch.Begin(Camera.SimProjection, Camera.SimView);
            for (int i = 0; i < _ramps.Count; ++i)
            {
                ScreenManager.LineBatch.DrawLineShape(_ramps[i].FixtureList[0].Shape, Color.Black);
            }
            ScreenManager.LineBatch.End();

            base.DebugView.DrawString(Camera.ConvertWorldToScreen(_rectangle[4].Position), $"Vx: {_rectangle[4].LinearVelocity.X}\nVy:{_rectangle[4].LinearVelocity.Y}");
           

            _border.Draw();
            base.Draw(gameTime);
        }

        public override void Update(GameTime gameTime, bool otherScreenHasFocus, bool coveredByOtherScreen)
        {
            //var p = _rectangle[4].LinearVelocity;
            //_rectangle[4].Position = new Vector2(_rectangle[4].Position.X + (float) gameTime.ElapsedGameTime.TotalSeconds * p.X,
            //    _rectangle[4].Position.Y + (float)gameTime.ElapsedGameTime.TotalSeconds * p.Y);
            //_rectangle[4].LinearVelocity = new Vector2(p.X, p.Y - (float)(World.Gravity.Y * gameTime.ElapsedGameTime.TotalSeconds));

            if (_rectangle[4].LinearVelocity.Y == 0f)
            {
                _rectangle[4].Position = new Vector2(-19f, -5f);
                _rectangle[4].LinearVelocity = new Vector2(10f, -10f);
                _rectangle[4].AngularVelocity = 0;
                _rectangle[4].LinearDamping = 0.08f;
            }
            base.Update(gameTime, otherScreenHasFocus, coveredByOtherScreen);
        }
    }
}