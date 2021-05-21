using System;
using System.Windows.Forms;
using FactoryManager.ViewModel.GridForm;

namespace FactoryManager.View.AppDialog
{
    public partial class MessageDialog : DevExpress.XtraEditors.XtraForm
    {
        static MessageDialog newMessageBox;
        static string Button_id;

        public MessageDialog()
        {
            InitializeComponent();
        }

        public static string ShowBox(string txtMessage, string txtTitle)
        {
            newMessageBox = new MessageDialog();
            newMessageBox.Title.Text = txtTitle;
            newMessageBox.Message.Text = txtMessage;
            newMessageBox.ShowDialog();
            return Button_id;
        }

        private void YES_Click(object sender, EventArgs e)
        {
            Button_id = "1";
            newMessageBox.Close();
        }

        private void NO_Click(object sender, EventArgs e)
        {
            Button_id = "2";
            newMessageBox.Close();
        }
    }
}