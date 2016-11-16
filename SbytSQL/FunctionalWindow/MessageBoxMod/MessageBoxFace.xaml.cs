using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


namespace MessageBoxMod
{
    /// <summary>
    /// Логика взаимодействия для WpfMessageBox.xaml
    /// </summary>
    internal partial class MessageBoxFace : Window
    {
        public double left { private get; set; }
        public double top { private get; set; }
        public double width { private get; set; }
        public double height { private get; set; }
        
        internal string Caption { get { return this.Title; } set { this.Title = value; } }
        internal string Message { get { return TextBlock_Message.Text; } set { TextBlock_Message.Text = value; } }
        internal string OKButtonText { get { return TextBlock_OK.Text; } set { TextBlock_OK.Text = value; } }
        internal string CancelButtonText { get { return TextBlock_Cancel.Text; } set { TextBlock_Cancel.Text = value; } }
        internal string YesButtonText { get { return TextBlock_Yes.Text; } set { TextBlock_Yes.Text = value; } }
        internal string NoButtonText { get { return TextBlock_No.Text; } set { TextBlock_No.Text = value; } }

        public MessageBoxResult Result { get; set; }

        internal MessageBoxFace(string message)
        {
           
            InitializeComponent();
            
            Message = message;
            Image_MessageBox.Visibility = System.Windows.Visibility.Collapsed;
            DisplayButtons(MessageBoxButton.OK);

        }

       internal MessageBoxFace(string message, string caption)
        {
            InitializeComponent();
            
            Message = message;
            Caption = caption;
            Image_MessageBox.Visibility = System.Windows.Visibility.Collapsed;
            DisplayButtons(MessageBoxButton.OK);
        }

        internal MessageBoxFace(string message, string caption, MessageBoxButton button)
        {
            InitializeComponent();
            
            Message = message;
            Caption = caption;
            Image_MessageBox.Visibility = System.Windows.Visibility.Collapsed;

            DisplayButtons(button);
        }

        internal MessageBoxFace(string message, string caption, MessageBoxImage image)
        {
            InitializeComponent();
            
            Message = message;
            Caption = caption;
            DisplayImage(image);
            DisplayButtons(MessageBoxButton.OK);
        }

        internal MessageBoxFace(string message, string caption, MessageBoxButton button, MessageBoxImage image)
        {
            InitializeComponent();

            Message = message;
            Caption = caption;
            Image_MessageBox.Visibility = System.Windows.Visibility.Collapsed;
            
            DisplayButtons(button);
            DisplayImage(image);
        }

        private void DisplayButtons(MessageBoxButton button)
        {
            switch (button)
            {
                case MessageBoxButton.OKCancel:
                    // Hide all but OK, Cancel
                    MsBox.Icon = (DrawingImage)MsBox.FindResource("quest");
                    Button_OK.Visibility = System.Windows.Visibility.Visible;
                    Button_OK.Focus();
                    Button_Cancel.Visibility = System.Windows.Visibility.Visible;

                    Button_Yes.Visibility = System.Windows.Visibility.Collapsed;
                    Button_No.Visibility = System.Windows.Visibility.Collapsed;
                    break;
                case MessageBoxButton.YesNo:
                    // Hide all but Yes, No
                    Button_Yes.Visibility = System.Windows.Visibility.Visible;
                    Button_Yes.Focus();
                    Button_No.Visibility = System.Windows.Visibility.Visible;

                    Button_OK.Visibility = System.Windows.Visibility.Collapsed;
                    Button_Cancel.Visibility = System.Windows.Visibility.Collapsed;
                    break;
                case MessageBoxButton.YesNoCancel:
                    // Hide only OK
                    Button_Yes.Visibility = System.Windows.Visibility.Visible;
                    Button_Yes.Focus();
                    Button_No.Visibility = System.Windows.Visibility.Visible;
                    Button_Cancel.Visibility = System.Windows.Visibility.Visible;

                    Button_OK.Visibility = System.Windows.Visibility.Collapsed;
                    break;
                default:
                    // Hide all but OK
                    MsBox.Icon = (DrawingImage)MsBox.FindResource("Iserror");
                    Button_OK.Visibility = System.Windows.Visibility.Visible;
                    Button_OK.Focus();

                    Button_Yes.Visibility = System.Windows.Visibility.Collapsed;
                    Button_No.Visibility = System.Windows.Visibility.Collapsed;
                    Button_Cancel.Visibility = System.Windows.Visibility.Collapsed;
                    break;
            }
        }

        private void DisplayImage(MessageBoxImage image)
        {
            Icon icon;

            switch (image)
            {
                case MessageBoxImage.Exclamation:       // Enumeration value 48 - also covers "Warning"
                    icon = SystemIcons.Exclamation;
                    break;
                case MessageBoxImage.Error:             // Enumeration value 16, also covers "Hand" and "Stop"
                    icon = SystemIcons.Hand;
                    break;
                case MessageBoxImage.Information:       // Enumeration value 64 - also covers "Asterisk"
                    icon = SystemIcons.Information;
                    break;
                case MessageBoxImage.Question:
                    icon = SystemIcons.Question;
                    break;
                default:
                    icon = SystemIcons.Information;
                    break;
            }

            Image_MessageBox.Source = icon.ToImageSource();
            Image_MessageBox.Visibility = System.Windows.Visibility.Visible;
        }

        private void Button_OK_Click(object sender, RoutedEventArgs e)
        {
            Result = MessageBoxResult.OK;
            this.Close();
        }

        private void Button_Cancel_Click(object sender, RoutedEventArgs e)
        {
            Result = MessageBoxResult.Cancel;
            this.Close();
        }

        private void Button_Yes_Click(object sender, RoutedEventArgs e)
        {
            Result = MessageBoxResult.Yes;
            this.Close();
        }

        private void Button_No_Click(object sender, RoutedEventArgs e)
        {
            Result = MessageBoxResult.No;
            this.Close();
        }

        private void MsBox_Loaded(object sender, RoutedEventArgs e)
        {
            this.Left = left + (width - this.ActualWidth) / 2;
            this.Top = top + (height - this.ActualHeight) / 2;
        }        

    }
}
