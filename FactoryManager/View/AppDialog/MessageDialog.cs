using System;
using System.Windows.Forms;
using FactoryManager.ViewModel.GridForm;

namespace FactoryManager.View.AppDialog
{
    public partial class MessageDialog : Form
    {
        static MessageDialog newMessageBox;
        static string Button_id;

        public MessageDialog()
        {
            InitializeComponent();
            this.Bounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        public static string ShowBox(string txtMessage, string txtTitle)
        {
            newMessageBox = new MessageDialog();
            newMessageBox.lblTitle.Text = txtTitle;
            newMessageBox.lblMessage.Text = txtMessage;
            newMessageBox.ShowDialog();
            return Button_id;
        }

        private void FormDisplayPanel_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 100 && this.Opacity != 100)
            {
                this.Opacity += 0.035;
            }

            else
            {
                FormDisplayPanel.Stop();
            }
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