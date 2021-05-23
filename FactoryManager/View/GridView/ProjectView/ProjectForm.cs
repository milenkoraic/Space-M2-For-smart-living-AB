using System;
using System.Drawing;
using System.Windows.Forms;
using FactoryManager.BLL;
using FactoryManager.View.AppDialog;
using FactoryManager.ViewModel.GridForm;
using FactoryManager.ViewService;
using FactoryManager.ViewService.FormValidation;

namespace FactoryManager.View.GridView
{
    public partial class ProjectForm : DevExpress.XtraEditors.XtraForm
    {
        static ProjectForm projectForm;
        public ProjectForm()
        {
            InitializeComponent();
        }

        public static void ReturnNewForm(DevExpress.XtraGrid.Views.Grid.GridView DataGridView)
        {
            projectForm = new ProjectForm();

            var autoincrementModel = AutoincrementService.GetAutoincrementNumber(DataGridView.Columns[0].FieldName, DataGridView.Columns[1].FieldName, MainForm.SectionIndicator.Text.ToUpperInvariant());
            projectForm.IDTextEdit.Text = autoincrementModel.Id.ToString();
            projectForm.ProjektnummerTextEdit.Text = autoincrementModel.Number.ToString();
            projectForm.ProjektnamnTextEdit.ResetText();
            projectForm.BeskrivningTextEdit.ResetText();
            projectForm.ProjektstatusComboBox.SelectedIndex = -1;
            projectForm.KommunTextEdit.ResetText();
            projectForm.KundnamnTextEdit.ResetText();

            projectForm.InsertBtn.Show();

            projectForm.ShowDialog();
        }

        public static void ReturnEditForm(DevExpress.XtraGrid.Views.Grid.GridView DataGridView)
        {
            projectForm = new ProjectForm();

            projectForm.IDTextEdit.Text = DataGridView.GetFocusedDataRow()["ID"].ToString();
            projectForm.ProjektnummerTextEdit.Text = DataGridView.GetFocusedDataRow()["Projektnummer"].ToString();
            projectForm.ProjektnamnTextEdit.Text = DataGridView.GetFocusedDataRow()["Projektnamn"].ToString();
            projectForm.BeskrivningTextEdit.Text = DataGridView.GetFocusedDataRow()["Beskrivning"].ToString();
            projectForm.ProjektstatusComboBox.SelectedItem = DataGridView.GetFocusedDataRow()["Projektstatus"].ToString();
            projectForm.KommunTextEdit.Text = DataGridView.GetFocusedDataRow()["Kommun"].ToString();
            projectForm.KundnamnTextEdit.Text = DataGridView.GetFocusedDataRow()["Kundnamn"].ToString();

            projectForm.UpdateBtn.Show();

            projectForm.ShowDialog();
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            if (FieldValidationHelper.hasValidationErrors(this.Controls))
                return;

            ProjectModel project = new ProjectModel
                {
                    Number = ProjektnummerTextEdit.Text,
                    Name = ProjektnamnTextEdit.Text,
                    Status = ProjektstatusComboBox.Text,
                    Description = BeskrivningTextEdit.Text,
                    Customer = KundnamnTextEdit.Text,
                    Municipality = KommunTextEdit.Text
                };

            ProjectService.InsertProject(project);
            
            Project.RefreshDataGrid();

            Close();
        }


        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (FieldValidationHelper.hasValidationErrors(this.Controls))
                return;

            ProjectModel project = new ProjectModel
            {
                Number = ProjektnummerTextEdit.Text,
                Name = ProjektnamnTextEdit.Text,
                Status = ProjektstatusComboBox.Text,
                Description = BeskrivningTextEdit.Text,
                Customer = KundnamnTextEdit.Text,
                Municipality = KommunTextEdit.Text
            };

            ProjectService.UpdateProject(project, Convert.ToInt32(project.Number));
            
            Project.RefreshDataGrid();

            Close();
        }

        private void cboProjectStatus_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (ProjektstatusComboBox.Text.Trim() == string.Empty)
            {
                errorProviderApp.SetError(ProjektstatusComboBox, "Du måste välja projektstatus!");
                e.Cancel = true;
            }
            else
                errorProviderApp.SetError(ProjektstatusComboBox, "");
        }

        private void tboxProjectName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (ProjektnamnTextEdit.Text.Trim() == string.Empty)
            {
                errorProviderApp.SetError(ProjektnamnTextEdit, "Projektnamn krävs!");
                e.Cancel = true;
            }
            else
                errorProviderApp.SetError(ProjektnamnTextEdit, "");
        }

        private void tboxCustomer_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (KundnamnTextEdit.Text.Trim() == string.Empty)
            {
                errorProviderApp.SetError(KundnamnTextEdit, "Kund krävs!");
                e.Cancel = true;
            }
            else
                errorProviderApp.SetError(KundnamnTextEdit, "");
        }

        private void tboxMunicipality_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (KommunTextEdit.Text.Trim() == string.Empty)
            {
                errorProviderApp.SetError(KommunTextEdit, "Kommun krävs!");
                e.Cancel = true;
            }
            else
                errorProviderApp.SetError(KommunTextEdit, "");
        }

        private void ProjectForm_Load(object sender, EventArgs e)
        {

        }

        private void CloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
