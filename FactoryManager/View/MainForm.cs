using FactoryManager.AppData.Services.Login;
using FactoryManager.AppService.ApplicationLogger;
using FactoryManager.AppService.ConfigurationReader;
using FactoryManager.AppService.DateTimeCounting;
using FactoryManager.AppService.FormInitialization;
using FactoryManager.View.AppDialog;
using FactoryManager.ViewModel.LoginForm;
using FactoryManager.ViewService.DialogProvider;
using System;
using System.Windows.Forms;

namespace FactoryManager.View
{
    public partial class MainForm : Form
    {
        private readonly ILogHelper _logHelper;
        private static log4net.ILog _loggerLog;
        private readonly IFormInitializationHelper _formInitializeHelper;
        private readonly IDialogMessageHelper _dialogMessageHelper;
        private readonly ICurrentDateTimeHelper _currentDateTimeHelper;
        private static IConfigurationReader _configurationReader;
        private readonly IMenuServiceHelper _menuServiceHelper;

        public static Form MainFormPublic;
        public static ComboBox FormList;
        public static Label SectionIndicator;
        public static Panel DockingPanel;

        public static string b = "";

        public MainForm()
        {          
            _logHelper = (ILogHelper)Program.ServiceProvider.GetService(typeof(ILogHelper));
            _loggerLog = _logHelper.GetLogger();
            _formInitializeHelper = (IFormInitializationHelper)Program.ServiceProvider.GetService(typeof(IFormInitializationHelper));
            _dialogMessageHelper = (IDialogMessageHelper)Program.ServiceProvider.GetService(typeof(IDialogMessageHelper));
            _currentDateTimeHelper = (ICurrentDateTimeHelper)Program.ServiceProvider.GetService(typeof(ICurrentDateTimeHelper));
            _configurationReader = (IConfigurationReader)Program.ServiceProvider.GetService(typeof(IConfigurationReader));
            _menuServiceHelper = (IMenuServiceHelper)Program.ServiceProvider.GetService(typeof(IMenuServiceHelper));

            InitializeComponent();

            MainFormPublic = this;
            FormList = cboAppForms;
            DockingPanel = MainPanel;
            SectionIndicator = LabelIndicator;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Bounds = Screen.FromHandle(this.Handle).WorkingArea;
            _formInitializeHelper.RegisterAllForms();
            DisplayHomePage();
            UserViewModel user = LoginService.GetLogedInUser(b.ToString());
            LabelUserInfo.Text = user.FirstName + " " + user.LastName;
            UserRoleLabel.Text = user.RoleName.ToUpper();
        }

        public static void ab(string a)
        {
            b = a.ToString();
        }

        private void DisplayHomePage()
        {
            LabelIndicator.Text = "HEMSIDA";
            cboAppForms.SelectedIndex = cboAppForms.FindStringExact("Home");
            _formInitializeHelper.OpenDockingForm(this);
        }

        private void ButtoneExit_Click(object sender, EventArgs e)
        {
            _dialogMessageHelper.AskToCloseApplication();
        }

        private void DateTimeTimer_Tick(object sender, EventArgs e)
        {
            var dateTime = _currentDateTimeHelper.GetAllDateTimeValues();
            string separator = " \u2022 ";

            CurrentDateTimeLabel.Text = dateTime.CurrentDay + separator + dateTime.CurrentDate + separator + dateTime.CurrentTime;
            CurrentWeekLabel.Text = "VECKA " + dateTime.WeekNumber.ToString();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            LoadingScreen.ShowLoadingScreen("LOGGAR UT", "Vänta en stund innan du loggar ut!");
            Owner.Show();
            Hide();
            _loggerLog.Info("User logged OUT!");
        }


        private void Home_Click(object sender, EventArgs e)
        {
            LabelIndicator.Text = (sender as Button).Text.ToUpper();
            if (_formInitializeHelper.CheckIfFormIsAlreadyOpened((sender as Button).Name) == false)
            {
                _formInitializeHelper.CloseAllOpenForms((sender as Button).Name);
                cboAppForms.SelectedIndex = cboAppForms.FindStringExact((sender as Button).Name);
                _formInitializeHelper.OpenDockingForm(this);
            }
        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            LabelIndicator.Text = (sender as Button).Text.ToUpper();
            if (_formInitializeHelper.CheckIfFormIsAlreadyOpened((sender as Button).Name) == false)
            {
                _formInitializeHelper.CloseAllOpenForms((sender as Button).Name);
                cboAppForms.SelectedIndex = cboAppForms.FindStringExact((sender as Button).Name);
                _formInitializeHelper.OpenDockingForm(this);
            }
        }

        private void Production_Click(object sender, EventArgs e)
        {
            _menuServiceHelper.ShowSubmenu(ProductionPanel);
        }


        private void Project_Click(object sender, EventArgs e)
        {
            LabelIndicator.Text = (sender as Button).Text.ToUpper();
            if (_formInitializeHelper.CheckIfFormIsAlreadyOpened((sender as Button).Name) == false)
            {
                _formInitializeHelper.CloseAllOpenForms((sender as Button).Name);
                cboAppForms.SelectedIndex = cboAppForms.FindStringExact((sender as Button).Name);
                _formInitializeHelper.OpenDockingForm(this);
            }
        }

        private void BackOffice_Click(object sender, EventArgs e)
        {       
            LabelIndicator.Text = "VAL AV TABELL";
            if (_formInitializeHelper.CheckIfFormIsAlreadyOpened((sender as Button).Name) == false)
            {
                _formInitializeHelper.CloseAllOpenForms((sender as Button).Name);
                cboAppForms.SelectedIndex = cboAppForms.FindStringExact((sender as Button).Name);
                _formInitializeHelper.OpenDockingForm(this);
            }
            else
            {
                _formInitializeHelper.CloseAllOpenForms((sender as Button).Name);
            }
        }
    }
}
