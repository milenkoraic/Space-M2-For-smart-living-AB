using System;
using System.Windows.Forms;

namespace FactoryManager.View.AppDialog
{
    public partial class NotificationDialog : DevExpress.XtraEditors.XtraForm
    {
        static NotificationDialog newNotificationBox;
        static string Button_id;

        public NotificationDialog()
        {
            InitializeComponent();
        }

        public static string ShowBox(string txtMessage, string txtTitle)
        {
            newNotificationBox = new NotificationDialog
            {
                TopLevel = true,
            };
            newNotificationBox.Title.Text = txtTitle;
            newNotificationBox.Message.Text = txtMessage;
            newNotificationBox.ShowDialog();
            return Button_id;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            Button_id = "1";
            newNotificationBox.Close();
        }
    }
}