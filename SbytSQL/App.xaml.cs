using System.Windows;

namespace SbytSQL
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        System.Threading.Mutex m;

        public App()
        {
            bool isnew;
            m = new System.Threading.Mutex(true, "SBYTSQL_NEW_WPF", out isnew);
            if (!isnew)
            {
               //MessageBoxMod.CustomMessageBox.PositionBox(this., this.Top, this.Width, this.Height);
                
               MessageBoxMod.CustomMessageBox.Show("Программа уже запущена!");
                System.Environment.Exit(0);
            }
        }

    }
}