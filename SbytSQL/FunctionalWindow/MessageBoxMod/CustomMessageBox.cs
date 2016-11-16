namespace MessageBoxMod
{
    using System.Windows;

    public static class CustomMessageBox
    {
        private static double left = 0;
        private static double top = 0;
        private static double width = 0;
        private static double height = 0;

        public static void PositionBox(double l, double t, double w, double h)
        {
            left = l;
            top = t;
            width = w;
            height = h;
        }
        public static MessageBoxResult Show(string messageBoxText)
        {
            MessageBoxFace msg = new MessageBoxFace(messageBoxText);
            msg.left = left;
            msg.top = top;
            msg.width = width;
            msg.height = height;
            msg.ShowDialog();

            return msg.Result;
        }

        public static MessageBoxResult Show(string messageBoxText, string caption)
        {
            MessageBoxFace msg = new MessageBoxFace(messageBoxText, caption);
            msg.left = left;
            msg.top = top;
            msg.width = width;
            msg.height = height;
            msg.ShowDialog();

            return msg.Result;
        }

        public static MessageBoxResult Show(Window owner, string messageBoxText)
        {
            MessageBoxFace msg = new MessageBoxFace(messageBoxText);
            msg.Owner = owner;
            msg.left = left;
            msg.top = top;
            msg.width = width;
            msg.height = height;
            msg.ShowDialog();

            return msg.Result;
        }

        public static MessageBoxResult Show(Window owner, string messageBoxText, string caption)
        {
            MessageBoxFace msg = new MessageBoxFace(messageBoxText, caption);
            msg.Owner = owner;
            msg.left = left;
            msg.top = top;
            msg.width = width;
            msg.height = height;
            msg.ShowDialog();

            return msg.Result;
        }

        public static MessageBoxResult Show(string messageBoxText, string caption, MessageBoxButton button)
        {
            MessageBoxFace msg = new MessageBoxFace(messageBoxText, caption, button);
            msg.left = left;
            msg.top = top;
            msg.width = width;
            msg.height = height;
            msg.ShowDialog();

            return msg.Result;
        }

        public static MessageBoxResult Show(string messageBoxText, string caption, MessageBoxButton button, MessageBoxImage icon)
        {
            MessageBoxFace msg = new MessageBoxFace(messageBoxText, caption, button, icon);
            msg.left = left;
            msg.top = top;
            msg.width = width;
            msg.height = height;
            msg.ShowDialog();

            return msg.Result;
        }

        public static MessageBoxResult ShowOK(string messageBoxText, string caption, string okButtonText)
        {
            MessageBoxFace msg = new MessageBoxFace(messageBoxText, caption, MessageBoxButton.OK);
            msg.left = left;
            msg.top = top;
            msg.width = width;
            msg.height = height;
            msg.OKButtonText = okButtonText;
            msg.ShowDialog();

            return msg.Result;
        }

        public static MessageBoxResult ShowOK(string messageBoxText, string caption, string okButtonText, MessageBoxImage icon)
        {
            MessageBoxFace msg = new MessageBoxFace(messageBoxText, caption, MessageBoxButton.OK, icon);
            msg.left = left;
            msg.top = top;
            msg.width = width;
            msg.height = height;
            msg.OKButtonText = okButtonText;
            msg.ShowDialog();

            return msg.Result;
        }

        public static MessageBoxResult ShowOKCancel(string messageBoxText, string caption, string okButtonText, string cancelButtonText)
        {
            MessageBoxFace msg = new MessageBoxFace(messageBoxText, caption, MessageBoxButton.OKCancel);
            msg.left = left;
            msg.top = top;
            msg.width = width;
            msg.height = height;
            msg.OKButtonText = okButtonText;
            msg.CancelButtonText = cancelButtonText;

            msg.ShowDialog();

            return msg.Result;
        }

        public static MessageBoxResult ShowOKCancel(string messageBoxText, string caption, string okButtonText, string cancelButtonText, MessageBoxImage icon)
        {
            MessageBoxFace msg = new MessageBoxFace(messageBoxText, caption, MessageBoxButton.OKCancel, icon);
            msg.left = left;
            msg.top = top;
            msg.width = width;
            msg.height = height;
            msg.OKButtonText = okButtonText;
            msg.CancelButtonText = cancelButtonText;

            msg.ShowDialog();

            return msg.Result;
        }

        public static MessageBoxResult ShowYesNo(string messageBoxText, string caption, string yesButtonText, string noButtonText)
        {
            MessageBoxFace msg = new MessageBoxFace(messageBoxText, caption, MessageBoxButton.YesNo);
            msg.left = left;
            msg.top = top;
            msg.width = width;
            msg.height = height;
            msg.YesButtonText = yesButtonText;
            msg.NoButtonText = noButtonText;

            msg.ShowDialog();

            MessageBoxResult result = msg.Result == MessageBoxResult.None ? MessageBoxResult.No : msg.Result;

            return result;
        }

        public static MessageBoxResult ShowYesNo(string messageBoxText, string caption, string yesButtonText, string noButtonText, MessageBoxImage icon)
        {
            MessageBoxFace msg = new MessageBoxFace(messageBoxText, caption, MessageBoxButton.YesNo, icon);
            msg.left = left;
            msg.top = top;
            msg.width = width;
            msg.height = height;
            msg.YesButtonText = yesButtonText;
            msg.NoButtonText = noButtonText;

            msg.ShowDialog();

            return msg.Result;
        }

        public static MessageBoxResult ShowYesNoCancel(string messageBoxText, string caption, string yesButtonText, string noButtonText, string cancelButtonText)
        {
            MessageBoxFace msg = new MessageBoxFace(messageBoxText, caption, MessageBoxButton.YesNoCancel);
            msg.left = left;
            msg.top = top;
            msg.width = width;
            msg.height = height;
            msg.YesButtonText = yesButtonText;
            msg.NoButtonText = noButtonText;
            msg.CancelButtonText = cancelButtonText;

            msg.ShowDialog();

            return msg.Result;
        }

        public static MessageBoxResult ShowYesNoCancel(string messageBoxText, string caption, string yesButtonText, string noButtonText, string cancelButtonText, MessageBoxImage icon)
        {
            MessageBoxFace msg = new MessageBoxFace(messageBoxText, caption, MessageBoxButton.YesNoCancel, icon);
            msg.left = left;
            msg.top = top;
            msg.width = width;
            msg.height = height;
            msg.YesButtonText = yesButtonText;
            msg.NoButtonText = noButtonText;
            msg.CancelButtonText = cancelButtonText;

            msg.ShowDialog();

            return msg.Result;
        }

    }
}
