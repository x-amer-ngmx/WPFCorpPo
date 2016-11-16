using SbytSQL.FunctionalWindow;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using MessageBoxMod;

namespace SbytSQL
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private TabItem newItem;
        private Window itGEtWin;

        public MainWindow()
        {
            InitializeComponent();
            new LoginWin().ShowDialog();
            new SplashScreen().ShowDialog();

            this.DataContext = this;
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
            {
                //MessageBox.Show("Закрыть ?");
                TabControls.Items.Remove(parm);
                itGEtWin.Close();
            }
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

        private void CascadeCommand_Executed(object sender, RoutedEventArgs e)
        {
        }

        private void TileCommand_Executed(object sender, RoutedEventArgs e)
        {
        }

        private void VerticallCascadeCommand_Executed(object sender, RoutedEventArgs e)
        {
        }

        private void HorizontallCascadeCommand_Executed(object sender, RoutedEventArgs e)
        {
        }

        #region -- MenuItem event --

        private void MenuItem_Setings(object sender, RoutedEventArgs e)
        {
            AddItemTab("pageProperty", sender, new Window_Setings());
        }

        private void MenuItem_PageOption(object sender, RoutedEventArgs e)
        {
            AddItemTab("pageOption", sender, new SplashScreen());
        }

        private void MenuItem_Open(object sender, RoutedEventArgs e)
        {
            AddItemTab("open", sender, new SplashScreen());
        }

        private void MenuItem_AccountPeriod(object sender, RoutedEventArgs e)
        {
            AddItemTab("accountPeriod", sender, new SplashScreen());
        }

        private void MenuItem_DataExport(object sender, RoutedEventArgs e)
        {
            AddItemTab("dataExport", sender, new SplashScreen());
        }

        private void MenuItem_UpDateBaseUSZN(object sender, RoutedEventArgs e)
        {
            AddItemTab("upDateBaseUSZN", sender, new SplashScreen());
        }

        private void MenuItem_BackUpDataBase(object sender, RoutedEventArgs e)
        {
            AddItemTab("backUpDataBase", sender, new SplashScreen());
        }

        private void MenuItem_CheckTheIntegrity(object sender, RoutedEventArgs e)
        {
            AddItemTab("checkTheIntegrity", sender, new SplashScreen());
        }

        private void MenuItem_Reindexing(object sender, RoutedEventArgs e)
        {
            AddItemTab("reindexing", sender, new SplashScreen());
        }

        private void MenuItem_Exit(object sender, RoutedEventArgs e)
        {
            AddItemTab("exit", sender, new SplashScreen());
        }

        private void MenuItem_Calculator(object sender, RoutedEventArgs e)
        {
            AddItemTab("calculator", sender, new SplashScreen());
        }

        private void MenuItem_NotepadEvents(object sender, RoutedEventArgs e)
        {
            AddItemTab("notepadEvents", sender, new SplashScreen());
        }

        private void MenuItem_InputReading(object sender, RoutedEventArgs e)
        {
            AddItemTab("inputReading", sender, new SplashScreen());
        }

        private void MenuItem_GetListOfAccounts(object sender, RoutedEventArgs e)
        {
            AddItemTab("getListOfAccounts", sender, new SplashScreen());
        }

        private void MenuItem_ReserveOfAccounts(object sender, RoutedEventArgs e)
        {
            AddItemTab("reserveOfAccounts", sender, new SplashScreen());
        }

        private void MenuItem_OnTemplate(object sender, RoutedEventArgs e)
        {
            AddItemTab("onTemplate", sender, new SplashScreen());
        }

        private void MenuItem_BlankCard(object sender, RoutedEventArgs e)
        {
            AddItemTab("blankCard", sender, new SplashScreen());
        }

        private void MenuItem_ListOfRoutes(object sender, RoutedEventArgs e)
        {
            AddItemTab("listOfRoutes", sender, new SplashScreen());
        }

        private void MenuItem_ListControlRem(object sender, RoutedEventArgs e)
        {
            AddItemTab("listControlRem", sender, new SplashScreen());
        }

        private void MenuItem_BypassRoutes(object sender, RoutedEventArgs e)
        {
            AddItemTab("bypassRoutes", sender, new SplashScreen());
        }

        private void MenuItem_BypassSubscriber(object sender, RoutedEventArgs e)
        {
            AddItemTab("BypassSubscriber", sender, new SplashScreen());
        }

        private void MenuItem_WorksInspectors(object sender, RoutedEventArgs e)
        {
            AddItemTab("worksInspectors", sender, new SplashScreen());
        }

        private void MenuItem_Balance(object sender, RoutedEventArgs e)
        {
            AddItemTab("balance", sender, new SplashScreen());
        }

        private void MenuItem_TurnoverPeriod(object sender, RoutedEventArgs e)
        {
            AddItemTab("turnoverPeriod", sender, new SplashScreen());
        }
		
		private void JournalS(object sender, RoutedEventArgs e)
		{
			AddItemTab("journalSelect", sender, new Window_JournalS());
		}
		
        private void AddItemTab(string tagName, object sender, Window setWin)
        {
            try
            {
                var mItem = TabControls.Items.Cast<TabItem>().Where(item => item.Name == tagName).FirstOrDefault();

                if (mItem != null) { TabControls.SelectedItem = mItem; return; }

                string aHead = string.Empty;
                try
                {
                    MenuItem val = (MenuItem)sender;
                    aHead = val.Header as String;
                }
                catch
                {
                    Button val = (Button)sender;
                    aHead = val.Content as String;
                }
                String StrHeader = aHead;
                StrHeader = StrHeader != null ? StrHeader : String.Empty;
                itGEtWin = setWin;
                newItem = new TabItem { Name = tagName, Header = StrHeader, Content = itGEtWin.Content };

                TabControls.Items.Add(newItem);
                TabControls.SelectedItem = newItem;
            }
            catch (Exception ex)
            {
                MessageBox.Show("УПС возникла ХЕРНЯ))) \n\n" + ex.Message);
            }
        }

        #endregion -- MenuItem event --

        private void LockedNS(object sender, RoutedEventArgs e)
        {
            new LoginWin().ShowDialog();
        }

        private void Window_Closing(object sender, CancelEventArgs e)
        {
            CustomMessageBox.PositionBox(this.Left, this.Top, this.Width, this.Height);
            if (CustomMessageBox.ShowYesNo("Закрыть окно?", "Уведомление","Закрыть","Отменить") == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}