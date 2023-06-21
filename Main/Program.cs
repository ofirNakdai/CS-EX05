using UI;

namespace Main
{
    public class Program
    {
        public static void Main()
        {
            SettingsDialog gameSettings = new SettingsDialog();
            gameSettings.ShowDialog();
            //UserInterface gameInterface = new UserInterface();
            //gameInterface.Start();
        }
    }
}
