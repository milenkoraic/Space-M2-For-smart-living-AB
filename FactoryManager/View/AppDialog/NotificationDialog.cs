using System;
using System.Windows.Forms;

namespace FactoryManager.View.AppDialog
{
    public partial class NotificationDialog : Form
    {
        static NotificationDialog newNotificationBox;
        static string Button_id;

        public NotificationDialog()
        {
            InitializeComponent();
            this.Bounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.bunifuElipse1.ApplyElipse(GridPanel, 7);
        }

        public static string ShowBox(string txtMessage, string txtTitle)
        {
            newNotificationBox = new NotificationDialog
            {
                TopLevel = true,
            };
            newNotificationBox.lblTitle.Text = txtTitle;
            newNotificationBox.lblMessage.Text = txtMessage;
            newNotificationBox.ShowDialog();
            return Button_id;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Button_id = "1";
            newNotificationBox.Close();
        }
    }
}