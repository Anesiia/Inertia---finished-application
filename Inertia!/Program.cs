using WMPLib;

namespace Inertia_
{
    internal static class Program
    {
        public static WindowsMediaPlayer musicPlayer = new WindowsMediaPlayer();
        public static WindowsMediaPlayer soundPlayer = new WindowsMediaPlayer();

        [STAThread]
        static void Main()
        {
            musicPlayer.URL = @"Resources\Audio\Music.wav";
            Application.Run(new Menu());
        }
    }
}