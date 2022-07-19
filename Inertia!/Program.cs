using WMPLib;

namespace Inertia_
{
    internal static class Program
    {
        public static WindowsMediaPlayer musicPlayer = new WindowsMediaPlayer();
        public static WindowsMediaPlayer soundPlayer = new WindowsMediaPlayer();

        [STAThread]
        static void Main()// если статик то можно обращатьч€ напр€мую к класс.поле, без создани€ экземпл€ра расса
        {
            musicPlayer.URL = @"Resources\Audio\Music.wav";
            Application.Run(new Menu());
        }
    }
}