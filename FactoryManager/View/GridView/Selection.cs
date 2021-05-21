using System;
using System.Windows.Forms;
using FactoryManager.View;
using FactoryManager.AppService.ApplicationLogger;
using FactoryManager.AppService.ConfigurationReader;
using FactoryManager.AppService.DateTimeCounting;
using FactoryManager.AppService.FormInitialization;
using FactoryManager.ViewService.DialogProvider;
using System.Drawing;

namespace FactoryManager.View.GridView
{
    public partial class Selection : Form
    {
        private readonly ILogHelper _logHelper;
        private static log4net.ILog _loggerLog;
        private readonly IFormInitializationHelper _formInitializeHelper;
        private readonly IDialogMessageHelper _dialogMessageHelper;
        private readonly ICurrentDateTimeHelper _currentDateTimeHelper;
        private static IConfigurationReader _configurationReader;
        public Selection()
        {
            _logHelper = (ILogHelper)Program.ServiceProvider.GetService(typeof(ILogHelper));
            _loggerLog = _logHelper.GetLogger();
            _formInitializeHelper = (IFormInitializationHelper)Program.ServiceProvider.GetService(typeof(IFormInitializationHelper));
            _dialogMessageHelper = (IDialogMessageHelper)Program.ServiceProvider.GetService(typeof(IDialogMessageHelper));
            _currentDateTimeHelper = (ICurrentDateTimeHelper)Program.ServiceProvider.GetService(typeof(ICurrentDateTimeHelper));
            _configurationReader = (IConfigurationReader)Program.ServiceProvider.GetService(typeof(IConfigurationReader));

            InitializeComponent();
        }

        private void TabelSelection_Load(object sender, EventArgs e)
        {

        }

        private void Activity_Click(object sender, EventArgs e)
        {
            MainForm.SectionIndicator.Text = (sender as Button).Text.ToUpper();
            if (_formInitializeHelper.CheckIfFormIsAlreadyOpened((sender as Button).Name) == false)
            {
                _formInitializeHelper.CloseAllOpenForms((sender as Button).Name);
                MainForm.FormList.SelectedIndex = MainForm.FormList.FindStringExact((sender as Button).Name);
                _formInitializeHelper.OpenDockingForm(MainForm.MainFormPublic);
            }
        }

        private void User_Click(object sender, EventArgs e)
        {
            MainForm.SectionIndicator.Text = (sender as Button).Text.ToUpper();
            if (_formInitializeHelper.CheckIfFormIsAlreadyOpened((sender as Button).Name) == false)
            {
                _formInitializeHelper.CloseAllOpenForms((sender as Button).Name);
                MainForm.FormList.SelectedIndex = MainForm.FormList.FindStringExact((sender as Button).Name);
                _formInitializeHelper.OpenDockingForm(MainForm.MainFormPublic);
            }
        }

        private void UserRole_Click(object sender, EventArgs e)
        {
            MainForm.SectionIndicator.Text = (sender as Button).Text.ToUpper();
            if (_formInitializeHelper.CheckIfFormIsAlreadyOpened((sender as Button).Name) == false)
            {
                _formInitializeHelper.CloseAllOpenForms((sender as Button).Name);
                MainForm.FormList.SelectedIndex = MainForm.FormList.FindStringExact((sender as Button).Name);
                _formInitializeHelper.OpenDockingForm(MainForm.MainFormPublic);
            }
        }

        private void Component_Click(object sender, EventArgs e)
        {
            MainForm.SectionIndicator.Text = (sender as Button).Text.ToUpper();
            if (_formInitializeHelper.CheckIfFormIsAlreadyOpened((sender as Button).Name) == false)
            {
                _formInitializeHelper.CloseAllOpenForms((sender as Button).Name);
                MainForm.FormList.SelectedIndex = MainForm.FormList.FindStringExact((sender as Button).Name);
                _formInitializeHelper.OpenDockingForm(MainForm.MainFormPublic);
            }
        }

        private void Factory_Click(object sender, EventArgs e)
        {
            MainForm.SectionIndicator.Text = (sender as Button).Text.ToUpper();
            if (_formInitializeHelper.CheckIfFormIsAlreadyOpened((sender as Button).Name) == false)
            {
                _formInitializeHelper.CloseAllOpenForms((sender as Button).Name);
                MainForm.FormList.SelectedIndex = MainForm.FormList.FindStringExact((sender as Button).Name);
                _formInitializeHelper.OpenDockingForm(MainForm.MainFormPublic);
            }
        }

        private void Order_Click(object sender, EventArgs e)
        {
            MainForm.SectionIndicator.Text = (sender as Button).Text.ToUpper();
            if (_formInitializeHelper.CheckIfFormIsAlreadyOpened((sender as Button).Name) == false)
            {
                _formInitializeHelper.CloseAllOpenForms((sender as Button).Name);
                MainForm.FormList.SelectedIndex = MainForm.FormList.FindStringExact((sender as Button).Name);
                _formInitializeHelper.OpenDockingForm(MainForm.MainFormPublic);
            }
        }

        private void Construction_Click(object sender, EventArgs e)
        {
            MainForm.SectionIndicator.Text = (sender as Button).Text.ToUpper();
            if (_formInitializeHelper.CheckIfFormIsAlreadyOpened((sender as Button).Name) == false)
            {
                _formInitializeHelper.CloseAllOpenForms((sender as Button).Name);
                MainForm.FormList.SelectedIndex = MainForm.FormList.FindStringExact((sender as Button).Name);
                _formInitializeHelper.OpenDockingForm(MainForm.MainFormPublic);
            }
        }

        private void Employee_Click(object sender, EventArgs e)
        {
            MainForm.SectionIndicator.Text = (sender as Button).Text.ToUpper();
            if (_formInitializeHelper.CheckIfFormIsAlreadyOpened((sender as Button).Name) == false)
            {
                _formInitializeHelper.CloseAllOpenForms((sender as Button).Name);
                MainForm.FormList.SelectedIndex = MainForm.FormList.FindStringExact((sender as Button).Name);
                _formInitializeHelper.OpenDockingForm(MainForm.MainFormPublic);
            }
        }

        private void Account_Click(object sender, EventArgs e)
        {
            MainForm.SectionIndicator.Text = (sender as Button).Text.ToUpper();
            if (_formInitializeHelper.CheckIfFormIsAlreadyOpened((sender as Button).Name) == false)
            {
                _formInitializeHelper.CloseAllOpenForms((sender as Button).Name);
                MainForm.FormList.SelectedIndex = MainForm.FormList.FindStringExact((sender as Button).Name);
                _formInitializeHelper.OpenDockingForm(MainForm.MainFormPublic);
            }
        }

        private void SupplierAddress_Click(object sender, EventArgs e)
        {
            MainForm.SectionIndicator.Text = (sender as Button).Text.ToUpper();
            if (_formInitializeHelper.CheckIfFormIsAlreadyOpened((sender as Button).Name) == false)
            {
                _formInitializeHelper.CloseAllOpenForms((sender as Button).Name);
                MainForm.FormList.SelectedIndex = MainForm.FormList.FindStringExact((sender as Button).Name);
                _formInitializeHelper.OpenDockingForm(MainForm.MainFormPublic);
            }
        }

        private void Supplier_Click(object sender, EventArgs e)
        {
            MainForm.SectionIndicator.Text = (sender as Button).Text.ToUpper();
            if (_formInitializeHelper.CheckIfFormIsAlreadyOpened((sender as Button).Name) == false)
            {
                _formInitializeHelper.CloseAllOpenForms((sender as Button).Name);
                MainForm.FormList.SelectedIndex = MainForm.FormList.FindStringExact((sender as Button).Name);
                _formInitializeHelper.OpenDockingForm(MainForm.MainFormPublic);
            }
        }

        private void ApartmentType_Click(object sender, EventArgs e)
        {
            MainForm.SectionIndicator.Text = (sender as Button).Text.ToUpper();
            if (_formInitializeHelper.CheckIfFormIsAlreadyOpened((sender as Button).Name) == false)
            {
                _formInitializeHelper.CloseAllOpenForms((sender as Button).Name);
                MainForm.FormList.SelectedIndex = MainForm.FormList.FindStringExact((sender as Button).Name);
                _formInitializeHelper.OpenDockingForm(MainForm.MainFormPublic);
            }
        }

        private void Module_Click(object sender, EventArgs e)
        {
            MainForm.SectionIndicator.Text = (sender as Button).Text.ToUpper();
            if (_formInitializeHelper.CheckIfFormIsAlreadyOpened((sender as Button).Name) == false)
            {
                _formInitializeHelper.CloseAllOpenForms((sender as Button).Name);
                MainForm.FormList.SelectedIndex = MainForm.FormList.FindStringExact((sender as Button).Name);
                _formInitializeHelper.OpenDockingForm(MainForm.MainFormPublic);
            }
        }

        private void ModuleType_Click(object sender, EventArgs e)
        {
            MainForm.SectionIndicator.Text = (sender as Button).Text.ToUpper();
            if (_formInitializeHelper.CheckIfFormIsAlreadyOpened((sender as Button).Name) == false)
            {
                _formInitializeHelper.CloseAllOpenForms((sender as Button).Name);
                MainForm.FormList.SelectedIndex = MainForm.FormList.FindStringExact((sender as Button).Name);
                _formInitializeHelper.OpenDockingForm(MainForm.MainFormPublic);
            }
        }

        private void Quantity_Click(object sender, EventArgs e)
        {
            MainForm.SectionIndicator.Text = (sender as Button).Text.ToUpper();
            if (_formInitializeHelper.CheckIfFormIsAlreadyOpened((sender as Button).Name) == false)
            {
                _formInitializeHelper.CloseAllOpenForms((sender as Button).Name);
                MainForm.FormList.SelectedIndex = MainForm.FormList.FindStringExact((sender as Button).Name);
                _formInitializeHelper.OpenDockingForm(MainForm.MainFormPublic);
            }
        }

        private void Pricelis_Click(object sender, EventArgs e)
        {
            MainForm.SectionIndicator.Text = (sender as Button).Text.ToUpper();
            if (_formInitializeHelper.CheckIfFormIsAlreadyOpened((sender as Button).Name) == false)
            {
                _formInitializeHelper.CloseAllOpenForms((sender as Button).Name);
                MainForm.FormList.SelectedIndex = MainForm.FormList.FindStringExact((sender as Button).Name);
                _formInitializeHelper.OpenDockingForm(MainForm.MainFormPublic);
            }
        }

        private void Project_Click(object sender, EventArgs e)
        {
            MainForm.SectionIndicator.Text = (sender as Button).Text.ToUpper();
            if (_formInitializeHelper.CheckIfFormIsAlreadyOpened((sender as Button).Name) == false)
            {
                _formInitializeHelper.CloseAllOpenForms((sender as Button).Name);
                MainForm.FormList.SelectedIndex = MainForm.FormList.FindStringExact((sender as Button).Name);
                _formInitializeHelper.OpenDockingForm(MainForm.MainFormPublic);
            }
        }

        private void Station_Click(object sender, EventArgs e)
        {
            MainForm.SectionIndicator.Text = (sender as Button).Text.ToUpper();
            if (_formInitializeHelper.CheckIfFormIsAlreadyOpened((sender as Button).Name) == false)
            {
                _formInitializeHelper.CloseAllOpenForms((sender as Button).Name);
                MainForm.FormList.SelectedIndex = MainForm.FormList.FindStringExact((sender as Button).Name);
                _formInitializeHelper.OpenDockingForm(MainForm.MainFormPublic);
            }
        }

        private void Selfcontrol_Click(object sender, EventArgs e)
        {
            MainForm.SectionIndicator.Text = (sender as Button).Text.ToUpper();
            if (_formInitializeHelper.CheckIfFormIsAlreadyOpened((sender as Button).Name) == false)
            {
                _formInitializeHelper.CloseAllOpenForms((sender as Button).Name);
                MainForm.FormList.SelectedIndex = MainForm.FormList.FindStringExact((sender as Button).Name);
                _formInitializeHelper.OpenDockingForm(MainForm.MainFormPublic);
            }
        }

        private void ModuletypeWalls_Click(object sender, EventArgs e)
        {
            MainForm.SectionIndicator.Text = (sender as Button).Text.ToUpper();
            if (_formInitializeHelper.CheckIfFormIsAlreadyOpened((sender as Button).Name) == false)
            {
                _formInitializeHelper.CloseAllOpenForms((sender as Button).Name);
                MainForm.FormList.SelectedIndex = MainForm.FormList.FindStringExact((sender as Button).Name);
                _formInitializeHelper.OpenDockingForm(MainForm.MainFormPublic);
            }
        }

        private void Walls_Click(object sender, EventArgs e)
        {
            MainForm.SectionIndicator.Text = (sender as Button).Text.ToUpper();
            if (_formInitializeHelper.CheckIfFormIsAlreadyOpened((sender as Button).Name) == false)
            {
                _formInitializeHelper.CloseAllOpenForms((sender as Button).Name);
                MainForm.FormList.SelectedIndex = MainForm.FormList.FindStringExact((sender as Button).Name);
                _formInitializeHelper.OpenDockingForm(MainForm.MainFormPublic);
            }
        }
    }
}
