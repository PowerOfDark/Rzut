using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Rzut.Core.Prefab;
using tainicom.Aether.Physics2D;
using tainicom.Aether.Physics2D.Dynamics;
using tainicom.Aether.Physics2D.Samples.DrawingSystem;
using tainicom.Aether.Physics2D.Samples.ScreenSystem;
using Rzut.Interface.Data.ViewModels.DataEntry;
using EmptyKeys.UserInterface.Generated;
using System.Collections.ObjectModel;
using Rzut.Interface.Data.ViewModels.RzutOverlay;
using EmptyKeys.UserInterface;
using EmptyKeys.UserInterface.Controls;
using EmptyKeys.UserInterface.Media;

namespace Rzut.Core
{
    internal class RzutScreen : PhysicsGameScreen, IDemoScreen, IOverlayContext<Ball>
    {
        private List<Body> _ramps;
        public ObservableCollection<Ball> Balls { get; set; }
        private Sprite _rectangleSprite;
        public DataEntryContext DataEntryContext { get; set; }
        public static SpriteFont DetailsFont { get; set; }
        public RzutOverlay Overlay { get; set; }
        public ListBox List { get; set; }
        public static Camera2D CameraInstance;

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
            CameraInstance = Camera;
            DetailsFont = ScreenManager.Content.Load<SpriteFont>("UI/Segoe_UI_30_Regular");
            _ramps = new List<Body>();
            Balls = new ObservableCollection<Ball>();

            _ramps.Add(World.CreateEdge(new Vector2(-100000, 0f), new Vector2(1000000, 0f)));
            _ramps[0].SetCollidesWith(Category.All);
            _ramps[0].SetFriction(50);


            int i = 0;
            foreach(var entity in DataEntryContext.Entities)
            {
                var ball = new Ball(World, entity, ScreenManager.Assets);
                Balls.Add(ball);
                if(entity == DataEntryContext.ActiveEntity)
                {
                    Camera.TrackingBody = ball.Body;
                }
                //ball.Body.Position = new Vector2(i, -(++i * 100 + 20));
            }
         
            Camera.Position = ConvertUnits.ToDisplayUnits(Camera.TrackingBody.Position);
            Camera.Jump2Target();
            Camera.EnablePositionTracking = true;
            Camera.MinPosition = new Vector2(float.MinValue, float.MinValue);
            Camera.MaxPosition = new Vector2(float.MaxValue, -(ScreenManager.GraphicsDevice.Viewport.Height/2f -20f));
            // Create sprite based on body

            Overlay = new RzutOverlay() { DataContext = this };
            FontManager.Instance.LoadFonts(ScreenManager.Content, "UI/");
            ImageManager.Instance.LoadImages(ScreenManager.Content, "UI/");
            List = VisualTreeHelper.Instance.FindElementByName(Overlay, "list") as ListBox;
            List.SelectionChanged += List_SelectionChanged;
            _rectangleSprite = new Sprite(ScreenManager.Content.Load<Texture2D>("Materials/kamil"));
        }

        private void List_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var body = (e.AddedItems[0] as Ball).Body;
            Camera.Position = ConvertUnits.ToDisplayUnits(body.Position);
            Camera.TrackingBody = body;
            Camera.Jump2Target();
            

        }

        public override void Draw(GameTime gameTime)
        {
            ScreenManager.SpriteBatch.Begin(0, null, null, null, null, null, Camera.View);
            foreach(var ball in Balls)
            {
                ball.Draw(gameTime, ScreenManager.SpriteBatch);
            }
            ScreenManager.SpriteBatch.End();

            ScreenManager.LineBatch.Begin(Camera.SimProjection, Camera.SimView);
            
            for (int i = 0; i < _ramps.Count; ++i)
            {
                ScreenManager.LineBatch.DrawLineShape(_ramps[i].FixtureList[0].Shape, Color.Black);
            }
            ScreenManager.LineBatch.End();

            Overlay.Draw(gameTime.ElapsedGameTime.TotalMilliseconds);

            base.Draw(gameTime);
        }

        public override void Update(GameTime gameTime, bool otherScreenHasFocus, bool coveredByOtherScreen)
        {
            if (!otherScreenHasFocus && !coveredByOtherScreen)
            {
                foreach (var ball in Balls)
                {
                    ball.Update(gameTime);
                }
                Overlay.UpdateInput(gameTime.ElapsedGameTime.TotalMilliseconds);
                Overlay.UpdateLayout(gameTime.ElapsedGameTime.TotalMilliseconds);
            }
            base.Update(gameTime, otherScreenHasFocus, coveredByOtherScreen);
        }

        public override void HandleInput(InputHelper input, GameTime gameTime)
        {
            foreach(var ball in Balls)
            {
                ball.HandleInput(input, gameTime);
            }
            base.HandleInput(input, gameTime);
        }

        public void UpdateContext(DataEntryContext context)
        {
            DataEntryContext = context;
        }
    }
}
