using System;
using System.Windows.Forms;
using FactoryManager.AppService.DateTimeCounting;
using FactoryManager.AppService.ApplicationLogger;
using FactoryManager.ViewService.DialogProvider;
using FactoryManager.AppService.ConfigurationReader;
using FactoryManager.View.AppDialog;
using FactoryManager.ViewModel.LoginForm;
using FactoryManager.AppData.Services.Login;

namespace FactoryManager.View
{
    public partial class LoginForm : Form
    {
        private readonly ILogHelper _logHelper;
        private static log4net.ILog _loggerLog;
        private static IConfigurationReader _configurationReader;
        private readonly ICurrentDateTimeHelper _currentDateTimeHelper;
        private readonly IDialogMessageHelper _dialogMessageHelper;

        public LoginForm()
        {
            _logHelper = (ILogHelper)Program.ServiceProvider.GetService(typeof(ILogHelper));
            _loggerLog = _logHelper.GetLogger();
            _configurationReader = (IConfigurationReader)Program.ServiceProvider.GetService(typeof(IConfigurationReader));
            _currentDateTimeHelper = (ICurrentDateTimeHelper)Program.ServiceProvider.GetService(typeof(ICurrentDateTimeHelper));
            _dialogMessageHelper = (IDialogMessageHelper)Program.ServiceProvider.GetService(typeof(IDialogMessageHelper));

            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            AppVersionLabel.Text = _configurationReader.GetAppName() + " v " + _configurationReader.GetAppVersion();
            CopyrightLabel.Text = _configurationReader.GetAppCopyright() + _currentDateTimeHelper.GetCopyrightYear();

            Bounds = Screen.PrimaryScreen.WorkingArea;
        }

        private void ButtonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ButtoneExit_Click(object sender, EventArgs e)
        {
            _dialogMessageHelper.AskToCloseApplication();
        }

        private void PerformLoginAction()
        {
            try
            {
                LoadingScreen.ShowLoadingScreen("AUTENTISERING", "Vänta en stund innan du loggar in!");
                
                var isUserValid = LoginService.ValidateUser(LoginTextBox.Text);

                if (isUserValid == true)
                {
                    MainForm MainForm = new MainForm
                    {
                        Owner = this,
                    };
                    MainForm.ab(LoginTextBox.Text.ToString());
                    LoginTextBox.ResetText();
                    MainForm.Show();
                    _loggerLog.Info("User validation succesfull!");
                }
                else
                {
                    NotificationDialog.ShowBox(
                        "Your password was incorrect! " +
                        "\n\n" +
                        "Please make sure you have entered everything correctly taking care of uppercase and lowercase letters. " +
                        "\n\n" +
                        "If the problem persists please contact your system administrator.",
                        "LOGIN ERROR");
                    _loggerLog.Info("User login refused! No users with provided password!");
                }
            }

            catch (Exception ex)
            {
                _loggerLog.Error(ex.Message.ToString());
            }
        }

        private void LoginTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                PerformLoginAction();
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            PerformLoginAction();
        }

        private void LoginTextBox_Enter(object sender, EventArgs e)
        {
            LoginTextBox.Text = "";
            LoginTextBox.isPassword = true;
        }
    }
}