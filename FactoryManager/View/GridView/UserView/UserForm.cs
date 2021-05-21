using System;
using System.Windows.Forms;
using FactoryManager.BLL;
using FactoryManager.ViewModel.GridForm;

namespace FactoryManager.View.GridView
{
    public partial class UserForm : Form
    {
        static UserForm userForm;
        public UserForm()
        {
            InitializeComponent();
        }

        public static Form ReturnForm(UserModel userModel)
        {
            userForm = new UserForm
            {
                TopLevel = false,
                Dock = DockStyle.Top
            };

            if (userModel.FirstName == null)
            {
                var autoincrementValue = 
                AutoincrementService.GetAutoincrementNumber
                (
                    User.DataGridView.Columns[0].FieldName, 
                    User.DataGridView.Columns[1].FieldName, 
                    MainForm.SectionIndicator.Text.ToUpperInvariant()
                );
                //userForm.tboxProjectId.Text = autoincrementValue.Id.ToString();
                //userForm.tboxProjectNumber.Text = autoincrementValue.Number.ToString();

                userForm.InsertContinue.Show();
                userForm.InsertClose.Show();
            }
            else
            {
                //userForm.tboxProjectId.Text = userModel.Id.ToString();
                //userForm.tboxProjectNumber.Text = userModel.Number.ToString();

                userForm.SaveChanges.Show();
            }

            return userForm;
        }

        public static void FocusLastDataGridRow()
        {
            User.DataGridView.MoveLast();
        }

        private void CloseProjectAddingForm()
        {
            User.CloseFormButton.PerformClick();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            ProjectModel project = new ProjectModel
            {
                //ProjectNumber = tboxProjectNumber.Text,
                //ProjectName = tboxProjectName.Text,
                //ProjectStatus = cboProjectStatus.Text,
                //ProjectDescription = tboxDescription.Text,
                //Customer = tboxCustomer.Text,
                //Municipality = tboxMunicipality.Text
            };

            ProjectService.InsertProject(project);

            User.RefreshDataGridSource();
            FocusLastDataGridRow();
            CloseProjectAddingForm();
        }

        private void SaveChanges_Click(object sender, EventArgs e)
        {

        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            this.användareTableAdapter.Fill(this.spaceM2Dataset.Användare);
        }
    }
}
