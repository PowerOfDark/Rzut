using Rzut;
using tainicom.Aether.Physics2D.Samples.ScreenSystem;

[assembly: Xamarin.Forms.Dependency(typeof(AndroidMethods))]
namespace Rzut
{
    public class AndroidMethods : IAndroidMethods
    {
        public void CloseApp()
        {
            //Activity1.Instance.Finish();
            //Android.OS.Process.KillProcess(Android.OS.Process.MyPid());
        }
    }
}