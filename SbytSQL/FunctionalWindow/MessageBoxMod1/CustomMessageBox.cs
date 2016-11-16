namespace GenericUIID.MessageBoxMod
{
    using System.Windows;

    public static class CustomMessageBox
    {
        public static MessageBoxResult Show(string messageBoxText)
        {
            WpfMessageBox msg = new WpfMessageBox(messageBoxText);
            msg.ShowDialog();

            return msg.Result;
        }

        public static MessageBoxResult Show(string messageBoxText, string caption)
        {
            WpfMessageBox msg = new WpfMessageBox(messageBoxText, caption);
            msg.ShowDialog();

            return msg.Result;
        }

        public static MessageBoxResult Show(Window owner, string messageBoxText)
        {
            WpfMessageBox msg = new WpfMessageBox(messageBoxText);
            msg.Owner = owner;
            msg.ShowDialog();

            return msg.Result;
        }

        public static MessageBoxResult Show(Window owner, string messageBoxText, string caption)
        {
            WpfMessageBox msg = new WpfMessageBox(messageBoxText, caption);
            msg.Owner = owner;
            msg.ShowDialog();

            return msg.Result;
        }

        public static MessageBoxResult Show(string messageBoxText, string caption, MessageBoxButton button)
        {
            WpfMessageBox msg = new WpfMessageBox(messageBoxText, caption, button);
            msg.ShowDialog();

            return msg.Result;
        }

        public static MessageBoxResult Show(string messageBoxText, string caption, MessageBoxButton button, MessageBoxImage icon)
        {
            WpfMessageBox msg = new WpfMessageBox(messageBoxText, caption, button, icon);
            msg.ShowDialog();

            return msg.Result;
        }

        public static MessageBoxResult ShowOK(string messageBoxText, string caption, string okButtonText)
        {
            WpfMessageBox msg = new WpfMessageBox(messageBoxText, caption, MessageBoxButton.OK);
            msg.OKButtonText = okButtonText;

            msg.ShowDialog();

            return msg.Result;
        }

        public static MessageBoxResult ShowOK(string messageBoxText, string caption, string okButtonText, MessageBoxImage icon)
        {
            WpfMessageBox msg = new WpfMessageBox(messageBoxText, caption, MessageBoxButton.OK, icon);
            msg.OKButtonText = okButtonText;

            msg.ShowDialog();

            return msg.Result;
        }

        public static MessageBoxResult ShowOKCancel(string messageBoxText, string caption, string okButtonText, string cancelButtonText)
        {
            WpfMessageBox msg = new WpfMessageBox(messageBoxText, caption, MessageBoxButton.OKCancel);
            msg.OKButtonText = okButtonText;
            msg.CancelButtonText = cancelButtonText;

            msg.ShowDialog();

            return msg.Result;
        }

        public static MessageBoxResult ShowOKCancel(string messageBoxText, string caption, string okButtonText, string cancelButtonText, MessageBoxImage icon)
        {
            WpfMessageBox msg = new WpfMessageBox(messageBoxText, caption, MessageBoxButton.OKCancel, icon);
            msg.OKButtonText = okButtonText;
            msg.CancelButtonText = cancelButtonText;

            msg.ShowDialog();

            return msg.Result;
        }

        public static MessageBoxResult ShowYesNo(string messageBoxText, string caption, string yesButtonText, string noButtonText)
        {
            WpfMessageBox msg = new WpfMessageBox(messageBoxText, caption, MessageBoxButton.YesNo);
            msg.YesButtonText = yesButtonText;
            msg.NoButtonText = noButtonText;

            msg.ShowDialog();

            return msg.Result;
        }

        public static MessageBoxResult ShowYesNo(string messageBoxText, string caption, string yesButtonText, string noButtonText, MessageBoxImage icon)
        {
            WpfMessageBox msg = new WpfMessageBox(messageBoxText, caption, MessageBoxButton.YesNo, icon);
            msg.YesButtonText = yesButtonText;
            msg.NoButtonText = noButtonText;

            msg.ShowDialog();

            return msg.Result;
        }

        public static MessageBoxResult ShowYesNoCancel(string messageBoxText, string caption, string yesButtonText, string noButtonText, string cancelButtonText)
        {
            WpfMessageBox msg = new WpfMessageBox(messageBoxText, caption, MessageBoxButton.YesNoCancel);
            msg.YesButtonText = yesButtonText;
            msg.NoButtonText = noButtonText;
            msg.CancelButtonText = cancelButtonText;

            msg.ShowDialog();

            return msg.Result;
        }

        public static MessageBoxResult ShowYesNoCancel(string messageBoxText, string caption, string yesButtonText, string noButtonText, string cancelButtonText, MessageBoxImage icon)
        {
            WpfMessageBox msg = new WpfMessageBox(messageBoxText, caption, MessageBoxButton.YesNoCancel, icon);
            msg.YesButtonText = yesButtonText;
            msg.NoButtonText = noButtonText;
            msg.CancelButtonText = cancelButtonText;

            msg.ShowDialog();

            return msg.Result;
        }

    }
}
