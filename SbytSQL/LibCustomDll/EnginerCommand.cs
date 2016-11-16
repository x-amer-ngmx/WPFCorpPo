using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace CommendEnginering
{
    public class EnginerCommand : Window
    {
        #region --- CloseCommand ---

        public TabControl tab;
        public ValueSource Condext;

        public EnginerCommand(Window thises)
        {
            this.DataContext = thises;
        }

        public object dataCont()
        {
            return this.DataContext;
            
        }

        private Utils.RelayCommand _cmdCloseCommand;
        private Utils.RelayCommand _menuExecuteCommand;

        public ICommand CloseCommand
        {
            get
            {
                if (_cmdCloseCommand == null)
                {
                    _cmdCloseCommand = new Utils.RelayCommand(
                        param => this.CloseTab_Execute(param),
                        param => this.CloseTab_CanExecute(param)
                        );
                }
                return _cmdCloseCommand;
            }
        }

        public ICommand Setings
        {
            get
            {
                if (_menuExecuteCommand == null)
                {
                    _menuExecuteCommand = new Utils.RelayCommand(
                        param => this.Setings_Execute(param));
                }
                return _menuExecuteCommand;
            }
        }

        private void Setings_Execute(object parm)
        {
            MessageBox.Show("Setings");
        }

        /// <summary>
        /// Called when the command is to be executed.
        /// </summary>
        /// <param name="parm">
        /// The TabItem in which the Close-button was clicked.
        /// </param>
        private void CloseTab_Execute(object parm)
        {
            TabItem ti = parm as TabItem;
            if (ti != null)
                tab.Items.Remove(parm);
        }

        /// <summary>
        /// Called when the availability of the Close command needs to be determined.
        /// </summary>
        /// <param name="parm">
        /// The TabItem for which to determine the availability of the Close-command.
        /// </param>
        private bool CloseTab_CanExecute(object parm)
        {
            //For the sample, the closing of TabItems will only be
            //unavailable for disabled TabItems and the very first TabItem.
            TabItem ti = parm as TabItem;
            if (ti != null)

                //We have a valid reference to a TabItem, so return
                //true if the TabItem is enabled.
                return ti.IsEnabled;

            //If no reference to a TabItem could be obtained, the command
            //cannot be executed
            return false;
        }

        #endregion --- CloseCommand ---
    }
}