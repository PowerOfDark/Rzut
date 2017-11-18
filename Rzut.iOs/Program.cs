using System;
using Foundation;
using UIKit;
using Rzut.Core;

namespace Rzut.iOs
{
    [Register("AppDelegate")]
    class Program : UIApplicationDelegate
    {
        private static RzutGame game;

        internal static void RunGame()
        {
            game = new RzutGame(Platform.Apple);
            game.Run();
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            UIApplication.Main(args, null, "AppDelegate");
        }

        public override void FinishedLaunching(UIApplication app)
        {
            RunGame();
        }
    }
}
