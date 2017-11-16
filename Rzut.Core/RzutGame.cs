using System;
using EmptyKeys.UserInterface;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Rzut.Core.Screens;
using tainicom.Aether.Physics2D;
using tainicom.Aether.Physics2D.Samples.ScreenSystem;
using Rzut.Core.UI.DataEntry;

namespace Rzut.Core
{
    public enum Platform
    {
        Android = 1, Desktop = 2, WindowsDesktop = 3
    }
    public class RzutGame : Game
    {
        private GraphicsDeviceManager _graphics;
        private int _nativeScreenWidth;
        private int _nativeScreenHeight;

        public static Platform Platform { get; protected set; }
        public ScreenManager ScreenManager { get; set; }

        public RzutGame(Platform platform)
        {
            Platform = platform;
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            TargetElapsedTime = TimeSpan.FromTicks(166666);
            //_graphics.PreparingDeviceSettings += _graphics_PreparingDeviceSettings;
            _graphics_PreparingDeviceSettings(null, null);
            _graphics.DeviceCreated += _graphics_DeviceCreated;

            ScreenManager = new ScreenManager(this);
            Components.Add(ScreenManager);
            FrameRateCounter frameRateCounter = new FrameRateCounter(ScreenManager);
            frameRateCounter.DrawOrder = 101;
            Components.Add(frameRateCounter);

        }

        private void _graphics_PreparingDeviceSettings(object sender, PreparingDeviceSettingsEventArgs e)
        {
            _nativeScreenWidth = _graphics.PreferredBackBufferWidth;
            _nativeScreenHeight = _graphics.PreferredBackBufferHeight;
            _graphics.SynchronizeWithVerticalRetrace = false;
            _graphics.GraphicsProfile = Microsoft.Xna.Framework.Graphics.GraphicsProfile.Reach;
            //_graphics.GraphicsProfile = Microsoft.Xna.Framework.Graphics.GraphicsProfile.Reach;

            _graphics.PreferredBackBufferWidth = 1280;
            _graphics.PreferredBackBufferHeight = 720;
            _graphics.IsFullScreen = Platform == Platform.Android;
            if (Platform == Platform.Android)
            {
                ConvertUnits.SetDisplayUnitToSimUnitRatio(30f);
            }
            else
            {
                ConvertUnits.SetDisplayUnitToSimUnitRatio(10f);
            }
            IsMouseVisible = true;

        }

        private void _graphics_DeviceCreated(object sender, EventArgs e)
        {
            Engine engine = new MonoGameEngine(GraphicsDevice, _graphics.GraphicsDevice.Viewport.Width, _graphics.GraphicsDevice.Viewport.Height);
        }

        protected override void Initialize()
        {
            base.Initialize();

            //var rzut = new RzutScreen();
            //var menu = new MenuScreen("Ayy lmao");
            //menu.AddMenuItem("Daj kamienia", EntryType.Screen, rzut);
            //menu.AddMenuItem("", EntryType.Separator, null);
            //menu.AddMenuItem("Exit", EntryType.ExitItem, null);
            ScreenManager.AddScreen(new BackgroundScreen());
            //ScreenManager.AddScreen(menu);
            //ScreenManager.AddScreen(new DataEntryScreen());
            ScreenManager.AddScreen(new LanguageSelectionScreen());
        }

        protected override void LoadContent()
        {
            base.LoadContent();
        }

    }
}
