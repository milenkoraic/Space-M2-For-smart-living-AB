using System;
using System.Drawing;
using System.Windows.Forms;
using FactoryManager.BLL;
using FactoryManager.View.AppDialog;
using FactoryManager.ViewModel.GridForm;
using FactoryManager.ViewService.FormValidation;

namespace FactoryManager.View.GridView
{
    public partial class ProjectForm : Form
    {
        static ProjectForm projectForm;

        public ProjectForm()
        {
            InitializeComponent();
        }

        public static ProjectModel GetViewByButtonName(string buttonName, DevExpress.XtraGrid.Views.Grid.GridView DataGridView)
        {
            ProjectModel projectModel = new ProjectModel();

            switch (buttonName)
            {
                case "AddRow":
                    var autoincrementModel = AutoincrementService.GetAutoincrementNumber(DataGridView.Columns[0].FieldName, DataGridView.Columns[1].FieldName, MainForm.SectionIndicator.Text.ToUpperInvariant());
                    projectModel = new ProjectModel
                    {
                        ProjectId = autoincrementModel.Id,
                        ProjectNumber = autoincrementModel.Number.ToString()
                    };

                    break;
                case "EditRow":
                    projectModel.ProjectId = Convert.ToInt32(DataGridView.GetFocusedDataRow()["ID"]);
                    projectModel.ProjectNumber = DataGridView.GetFocusedDataRow()["Projektnummer"].ToString();
                    projectModel.ProjectName = DataGridView.GetFocusedDataRow()["Projektnamn"].ToString();
                    projectModel.ProjectStatus = DataGridView.GetFocusedDataRow()["Projektstatus"].ToString();
                    projectModel.ProjectDescription = DataGridView.GetFocusedDataRow()["Beskrivning"].ToString();
                    projectModel.Customer = DataGridView.GetFocusedDataRow()["Kundnamn"].ToString();
                    projectModel.Municipality = DataGridView.GetFocusedDataRow()["Kommun"].ToString();
                    break;
            }
            return projectModel;
        }

        public static Form ReturnNewForm(DevExpress.XtraGrid.Views.Grid.GridView DataGridView)
        {
            projectForm = new ProjectForm
            {
                TopLevel = false,
                Dock = DockStyle.Top
            };

            var autoincrementModel = AutoincrementService.GetAutoincrementNumber(DataGridView.Columns[0].FieldName, DataGridView.Columns[1].FieldName, MainForm.SectionIndicator.Text.ToUpperInvariant());
            projectForm.tboxProjectId.Text = autoincrementModel.Id.ToString();
            projectForm.tboxProjectNumber.Text = autoincrementModel.Number.ToString();
            projectForm.tboxProjectName.Text ="";
            projectForm.tboxDescription.Text = "";
            projectForm.cboProjectStatus.SelectedText = "";
            projectForm.tboxMunicipality.Text = "";
            projectForm.tboxCustomer.Text = "";

            projectForm.InsertBtn.Show();

            return projectForm;
        }

        public static Form ReturnEditForm(ProjectModel projectModel)
        {
            projectForm = new ProjectForm
            {
                TopLevel = false,
                Dock = DockStyle.Top
            };

            projectForm.tboxProjectId.Text = projectModel.ProjectId.ToString();
            projectForm.tboxProjectNumber.Text = projectModel.ProjectNumber.ToString();
            projectForm.tboxProjectName.Text = projectModel.ProjectName.ToString();
            projectForm.tboxDescription.Text = projectModel.ProjectDescription.ToString();
            projectForm.cboProjectStatus.SelectedIndex = projectForm.cboProjectStatus.FindStringExact(projectModel.ProjectStatus);
            projectForm.tboxMunicipality.Text = projectModel.Municipality.ToString();
            projectForm.tboxCustomer.Text = projectModel.Customer.ToString();

            projectForm.UpdateBtn.Show();

            return projectForm;
        }

        public static void AskToDeleteEntry(DevExpress.XtraGrid.Views.Grid.GridView DataGridView)
        {
            var result = MessageDialog.ShowBox("Är du säker på att du vill ta bort projekt " + DataGridView.GetFocusedDataRow()["Projektnamn"].ToString() + " med nummer " + DataGridView.GetFocusedDataRow()["Projektnummer"].ToString() + "?", "TA BORT PROJEKT");

            if (result.Equals("1"))
            {
                ProjectService.DeleteProjectById(Convert.ToInt32(DataGridView.GetFocusedDataRow()["ID"]));
            }
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            if (FieldValidationHelper.hasValidationErrors(this.Controls))
                return;

            ProjectModel projectModel = new ProjectModel
                {
                    ProjectNumber = tboxProjectNumber.Text,
                    ProjectName = tboxProjectName.Text,
                    ProjectStatus = cboProjectStatus.Text,
                    ProjectDescription = tboxDescription.Text,
                    Customer = tboxCustomer.Text,
                    Municipality = tboxMunicipality.Text
                };

            ProjectService.InsertProject(projectModel);
            
            Project.RefreshDataGridSource();
        }


        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            ProjectModel projectModel = new ProjectModel
            {
                ProjectNumber = tboxProjectNumber.Text,
                ProjectName = tboxProjectName.Text,
                ProjectStatus = cboProjectStatus.Text,
                ProjectDescription = tboxDescription.Text,
                Customer = tboxCustomer.Text,
                Municipality = tboxMunicipality.Text
            };

            ProjectService.UpdateProject(projectModel, Convert.ToInt32(projectModel.ProjectNumber));
            
            Project.RefreshDataGridSource();
        }

        private void cboProjectStatus_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (cboProjectStatus.Text.Trim() == string.Empty)
            {
                errorProviderApp.SetError(cboProjectStatus, "Du måste välja projektstatus!");
                e.Cancel = true;
            }
            else
                errorProviderApp.SetError(cboProjectStatus, "");
        }

        private void tboxProjectName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (tboxProjectName.Text.Trim() == string.Empty)
            {
                errorProviderApp.SetError(tboxProjectName, "Projektnamn krävs!");
                e.Cancel = true;
            }
            else
                errorProviderApp.SetError(tboxProjectName, "");
        }

        private void tboxCustomer_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (tboxCustomer.Text.Trim() == string.Empty)
            {
                errorProviderApp.SetError(tboxCustomer, "Kund krävs!");
                e.Cancel = true;
            }
            else
                errorProviderApp.SetError(tboxCustomer, "");
        }

        private void tboxMunicipality_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (tboxMunicipality.Text.Trim() == string.Empty)
            {
                errorProviderApp.SetError(tboxMunicipality, "Kommun krävs!");
                e.Cancel = true;
            }
            else
                errorProviderApp.SetError(tboxMunicipality, "");
        }

        private void ProjectForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'spaceM2Dataset.Projekt' table. You can move, or remove it, as needed.
            this.projektTableAdapter.Fill(this.spaceM2Dataset.Projekt);

        }
    }
}
