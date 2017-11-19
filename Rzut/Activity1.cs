using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views;
using Rzut.Core;

namespace Rzut
{
    [Activity(Label = "Rzut"
        , MainLauncher = true
        , Icon = "@drawable/icon"
        , Theme = "@style/Theme.Splash"
        , AlwaysRetainTaskState = false
        , LaunchMode = Android.Content.PM.LaunchMode.SingleInstance
        , ScreenOrientation = ScreenOrientation.SensorLandscape
        , ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.Keyboard | ConfigChanges.KeyboardHidden | ConfigChanges.ScreenSize)]
    
    public class Activity1 : Microsoft.Xna.Framework.AndroidGameActivity
    {
        public static Activity1 Instance;
        public RzutGame Game;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            //Xamarin.Forms.Forms.Init(this, bundle);
            Instance = this;
            Game = new Rzut.Core.RzutGame(Core.Platform.Android);
            SetContentView((View)Game.Services.GetService(typeof(View)));
            Game.Run();
            int test = 10;
        }

        protected override void OnResume()
        {
            Game.GraphicsDevice?.Reset();
            base.OnResume();
        }
        protected override void OnPause()
        {
            if (RzutGame.IsDead)
            {
                Process.KillProcess(Process.MyPid());
                return;
            }
            base.OnPause();
        }

    }

}



