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
        }

        private void Window_Activated(object sender, System.EventArgs e)
        {
            StartCloseTimer();
        }

        private void StartCloseTimer()
        {
            var timer = new DispatcherTimer {Interval = TimeSpan.FromSeconds(3d)};
            timer.Tick += Timer_Tick;
            timer.Start();

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            var time = (DispatcherTimer) sender;
            time.Stop();
            time.Tick -= Timer_Tick;
            this.Close();
        }
    }
}