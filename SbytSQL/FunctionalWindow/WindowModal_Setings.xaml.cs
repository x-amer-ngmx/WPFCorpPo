using System.ComponentModel;
using System.Windows;

namespace SbytSQL.FunctionalWindow
{
    /// <summary>
    /// Логика взаимодействия для Window_Setings.xaml
    /// </summary>
    public partial class Window_Setings : Window
    {
        private string patchesSet = string.Empty;

        public Window_Setings()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Open in the window!");
        }

        private void Window_Closing(object sender, CancelEventArgs e)
        {
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenDir();
            p1.Text = patchesSet;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            OpenDir();
            p2.Text = patchesSet;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            OpenDir();
            p3.Text = patchesSet;
        }

        private void OpenDir()
        {
            using (System.Windows.Forms.FolderBrowserDialog browser = new System.Windows.Forms.FolderBrowserDialog())
            {
                browser.ShowNewFolderButton = true;
                System.Windows.Forms.DialogResult result = browser.ShowDialog();
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    patchesSet = browser.SelectedPath;
                }
                else
                {
                    var res = MessageBox.Show("Закрыть окно?", "Закрыть окно?", MessageBoxButton.OKCancel, MessageBoxImage.Question);
                    if (res == MessageBoxResult.OK)
                    {
                        return;
                    }
                }
            }
            if (patchesSet == string.Empty) { OpenDir(); }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void timeOff_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            sliderValuer.Text = e.NewValue.ToString();
        }
    }
}