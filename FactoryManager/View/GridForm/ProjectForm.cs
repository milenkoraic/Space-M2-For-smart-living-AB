using System;
using System.Linq;
using System.Windows.Forms;
using FactoryManager.AppData.DataModel;
using FactoryManager.View.GridView;
using FactoryManager.ViewModel.GridForm;

namespace FactoryManager.View.GridForm
{
    public partial class ProjectForm : Form
    {
        static ProjectForm projectForm;
        public ProjectForm()
        {
            InitializeComponent();
        }

        public static Form ReturnForm(ProjectViewModel projectViewModel)
        {
            projectForm = new ProjectForm
            {
                TopLevel = false,
                Dock = DockStyle.Top
            };

            projectForm.tboxProjectId.Text = projectViewModel.ProjectId.ToString();
            projectForm.tboxProjectNumber.Text = projectViewModel.ProjectNumber;
            projectForm.tboxProjectName.Text = projectViewModel.ProjectName;
            projectForm.tboxDescription.Text = projectViewModel.ProjectDescription;
            projectForm.cboProjectStatus.SelectedIndex = projectForm.cboProjectStatus.FindStringExact(projectViewModel.ProjectStatus);
            projectForm.tboxMunicipality.Text = projectViewModel.Municipality;
            projectForm.tboxCustomer.Text = projectViewModel.Customer;

            return projectForm;
        }

        public static Form ShowDeleteForm()
        {
            projectForm = new ProjectForm
            {
                TopLevel = false,
                Dock = DockStyle.Bottom,
            };

            projectForm.tboxProjectId.Text = "";
            projectForm.tboxProjectNumber.Text = "";
            projectForm.tboxProjectName.Text = "";
            projectForm.tboxDescription.Text = "";
            projectForm.cboProjectStatus.SelectedIndex = -1;
            projectForm.tboxMunicipality.Text = "";
            projectForm.tboxCustomer.Text = "";

            return projectForm;
        }

        private void ButtoneExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
