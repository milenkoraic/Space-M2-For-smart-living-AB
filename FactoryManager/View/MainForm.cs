﻿using DevExpress.XtraSplashScreen;
using FactoryManager.AppService.ApplicationLogger;
using FactoryManager.AppService.ConfigurationReader;
using FactoryManager.AppService.DateTimeCounting;
using FactoryManager.AppService.FormInitialization;
using FactoryManager.BLL;
using FactoryManager.View.AppDialog;
using FactoryManager.ViewService.DialogProvider;
using System;
using System.Threading;
using System.Windows.Forms;

namespace FactoryManager.View
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
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
        public static Panel DockingPanel;
        public static Label SectionIndicator;

        public MainForm(UserModel user)
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

            LabelUserName.Text = user.FirstName + " " + user.LastName;
            LabelUserRole.Text = user.RoleName;
        }

        private void DisplayHomePage()
        {
            //LabelIndicator.Text = "HEMSIDA";
            //if (_formInitializeHelper.CheckIfFormIsAlreadyOpened("Home") == false)
            //{
            //    _formInitializeHelper.CloseAllOpenForms("Home");
            //    cboAppForms.SelectedIndex = cboAppForms.FindStringExact("Home");
            //    _formInitializeHelper.OpenDockingForm(this);
            //}
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _formInitializeHelper.RegisterAllForms();
            DisplayHomePage();
        }

        private void Maximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                Maximize.IconChar = FontAwesome.Sharp.IconChar.Compress;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
                Maximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            }
        }

        private void ButtoneExit_Click(object sender, EventArgs e)
        {
            _dialogMessageHelper.AskToCloseApplication();
        }

        private void DateTimeTimer_Tick(object sender, EventArgs e)
        {
            var dateTime = _currentDateTimeHelper.GetAllDateTimeValues();
            CurrentDateTimeLabel.Text = dateTime.CurrentDate ;
            CurrentWeekLabel.Text = "VECKA " + dateTime.WeekNumber.ToString();
        }
        private void ShowLogoutWaitForm()
        {
            SplashScreenManager.ShowForm(this, typeof(LoadingScreen), true, true, false);
            for (int i = 1; i <= 100; i++)
            {
                SplashScreenManager.Default.SetWaitFormCaption("LOGGAR UT");
                SplashScreenManager.Default.SetWaitFormDescription("Vänta en stund innan du loggar ut!!");
                Thread.Sleep(50);
            }
            SplashScreenManager.CloseForm(false);
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            ShowLogoutWaitForm();
            Hide();
            Owner.Show();
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

        private void TabelSelection_Click(object sender, EventArgs e)
        {
            LabelIndicator.Text = (sender as Button).Text.ToUpper();
            if (_formInitializeHelper.CheckIfFormIsAlreadyOpened((sender as Button).Name) == false)
            {
                _formInitializeHelper.CloseAllOpenForms((sender as Button).Name);
                cboAppForms.SelectedIndex = cboAppForms.FindStringExact((sender as Button).Name);
                _formInitializeHelper.OpenDockingForm(this);
            }
        }
    }
}
