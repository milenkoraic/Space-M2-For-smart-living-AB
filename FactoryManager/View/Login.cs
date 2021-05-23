using System;
using System.Windows.Forms;
using FactoryManager.AppService.DateTimeCounting;
using FactoryManager.AppService.ApplicationLogger;
using FactoryManager.AppService.ConfigurationReader;
using FactoryManager.View.AppDialog;
using FactoryManager.BLL;
using System.Threading;
using DevExpress.XtraSplashScreen;
using FactoryManager.ViewService.DialogProvider;

namespace FactoryManager.View
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        private readonly ILogHelper _logHelper;
        private static log4net.ILog _loggerLog;   
        private static IConfigurationReader _configurationReader;
        private readonly ICurrentDateTimeHelper _currentDateTimeHelper;
        private readonly IDialogMessageHelper _dialogMessageHelper;

        public Login()
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
        }

        private void PerformLoginAction()
        {
            try
            {

                SplashScreenManager.ShowForm(this, typeof(LoadingScreen), true, true, false);
                for (int i = 1; i <= 100; i++)
                {
                    SplashScreenManager.Default.SetWaitFormCaption("AUTENTISERING");
                    SplashScreenManager.Default.SetWaitFormDescription("Vänta medan dina data valideras!");
                    Thread.Sleep(50);
                }
                SplashScreenManager.CloseForm(false);

                var isUserValid = UserService.ValidateUser(LoginTextBox.Text);
                if (isUserValid == true)
                {
                    UserViewModel user = UserService.GetLogedInUser(LoginTextBox.Text);
                    MainForm mainForm = new MainForm(user)
                    {
                        TopLevel = true,
                        Owner = this
                    };
                    LoginTextBox.ResetText();
                    mainForm.Show();
                    Hide();
                    _loggerLog.Info("User validation succesfull!");
                }
                else
                {
                    NotificationDialog.ShowBox(
                        "Ditt lösenord var felaktigt!" +
                        "\n" +
                        "Kontrollera att du har angett allt korrekt ta hand om versaler och gemener. " +
                        "\n" +
                        "Om problemet kvarstår kontaktar du systemadministratören. ",
                        "LOGIN ERROR");
                    _loggerLog.Info("User login refused! No users with provided password!");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                _loggerLog.Error(ex.Message.ToString());
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

        private void Maximize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void ButtoneExit_Click(object sender, EventArgs e)
        {
            _dialogMessageHelper.AskToCloseApplication();
        }

        private void LoginTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                PerformLoginAction();
            }
        }
    }
}