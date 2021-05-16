using System;
using System.Windows.Forms;

namespace FactoryManager.View.AppDialog
{
    public partial class LoadingScreen : Form
    {
        static LoadingScreen splashLoader;
        public Timer ShutdownTimer;

        int disposeFormTimer;

        public LoadingScreen()
        {
            InitializeComponent();
            this.Bounds = Screen.FromHandle(this.Handle).WorkingArea;
            bunifuElipse1.ApplyElipse(GridPanel, 7);
        }

        private void SplashLoader_Load(object sender, EventArgs e)
        {
            disposeFormTimer = 3;
            ShutdownTimer = new Timer
            {
                Interval = 1000,
                Enabled = true
            };
            ShutdownTimer.Start();
            ShutdownTimer.Tick += new EventHandler(this.Timer_tick);
        }


        public static Form ShowLoadingScreen(string txtTitle, string txtMessage)
        {
            splashLoader = new LoadingScreen
            {
                TopLevel = true,
            };
            splashLoader.TitleLabel.Text = txtTitle;
            splashLoader.MessageLabel.Text = txtMessage;
            splashLoader.ShowDialog();
            return splashLoader;
        }

        private void Timer_tick(object sender, EventArgs e)
        {
            disposeFormTimer--;

            if (disposeFormTimer == 0)
            {
                splashLoader.ShutdownTimer.Stop();
                splashLoader.ShutdownTimer.Dispose();
                splashLoader.Close();
            }
        }
    }
}