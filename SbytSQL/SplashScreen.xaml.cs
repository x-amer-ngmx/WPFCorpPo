using System;
using System.Threading;
using System.Windows;
using System.Windows.Threading;

namespace SbytSQL
{
    /// <summary>
    /// Логика взаимодействия для SplashScreen.xaml
    /// </summary>
    public partial class SplashScreen : Window
    {
        
        public SplashScreen()
        {
            InitializeComponent();

            var myTimer = new System.Windows.Forms.Timer();
            myTimer.Interval = 3000;
            myTimer.Tick += myTimer_Tick;
            myTimer.Start();
            
        }

        void myTimer_Tick(object sender, System.EventArgs e)
        {
            var myTimer = (System.Windows.Forms.Timer) sender;
            myTimer.Stop();
            myTimer.Tick -= myTimer_Tick;
            Close();
        }
    }

}