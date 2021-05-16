using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using FactoryManager.AppData.DataModel;
using FactoryManager.AppData.DataService;
using FactoryManager.View.AppDialog;
using FactoryManager.View.GridForm;
using FactoryManager.ViewModel.GridForm;

namespace FactoryManager.View.GridView
{
    public partial class Project : XtraForm
    {
        public static Panel FormViewPanel;
        public Project()
        {
            InitializeComponent();
            FormViewPanel = GridPanel;
        }

        private void Projects_Load(object sender, EventArgs e)
        {
            this.projektTableAdapter.Fill(this.spaceM2DataSet.Projekt);
            this.gridControl1.Height = MainForm.DockingPanel.Height / 2;

            bunifuElipse1.ApplyElipse(AddRow, 7);
            bunifuElipse1.ApplyElipse(EditRow, 7); 
        }

        public ProjectViewModel GetViewByButtonName(string buttonName)
        {
            ProjectViewModel projectViewModel = new ProjectViewModel();

            switch (buttonName)
            {
                case "AddRow":
                    var autoincrementViewModel = AutoincrementService.GetAutoincrementProjectNumber();
                    projectViewModel = new ProjectViewModel
                    {
                        ProjectId = autoincrementViewModel.Id,
                        ProjectNumber = autoincrementViewModel.Number.ToString()
                    };

                    break;
                case "EditRow":
                    projectViewModel.ProjectId = Convert.ToInt32(gridView1.GetFocusedDataRow()["Projekt_Id"]);
                    projectViewModel.ProjectNumber = gridView1.GetFocusedDataRow()["Proj nr"].ToString();
                    projectViewModel.ProjectName = gridView1.GetFocusedDataRow()["Projekt"].ToString();
                    projectViewModel.ProjectDescription = gridView1.GetFocusedDataRow()["Beskrivning"].ToString();
                    projectViewModel.ProjectStatus = gridView1.GetFocusedDataRow()["Status"].ToString();
                    projectViewModel.Customer = gridView1.GetFocusedDataRow()["Kund"].ToString();
                    projectViewModel.Municipality = gridView1.GetFocusedDataRow()["Kommun"].ToString();
                    break;
                case "DeleteRow":                   
                    string result = MessageDialog.ShowBox("Är du säker på att du vill ta bort projekt " + gridView1.GetFocusedDataRow()["Projekt"].ToString() + " med nummer " + gridView1.GetFocusedDataRow()["Proj nr"].ToString() + "?", "TA BORT PROJEKT");
                    
                    if (result.Equals("1"))
                    {
                        //Yes
                    }
                    else
                    {
                        //No
                    }
                    break;
            }
            return projectViewModel;
        }

        private void ToggleEditingButtons()
        {
            if (AddRow.Visible == true && EditRow.Visible == true && DeleteRow.Visible == true)
            {
                AddRow.Visible = false;
                EditRow.Visible = false;
                DeleteRow.Visible = false;
            }
            else
            {
                AddRow.Visible = true;
                EditRow.Visible = true;
                DeleteRow.Visible = true;
            }
        }

        private void AddRow_Click(object sender, EventArgs e)
        {
            ToggleEditingButtons();
            CloseForm.Show();
            var insertModel = GetViewByButtonName((sender as Button).Name);
            var form = ProjectForm.ReturnForm(insertModel);
            FormViewPanel.Controls.Clear();
            FormViewPanel.Controls.Add(form);
            form.Show();
        }

        private void EditRow_Click(object sender, EventArgs e)
        {
            ToggleEditingButtons();
            CloseForm.Show();
            var editModel = GetViewByButtonName((sender as Button).Name);
            var form = ProjectForm.ReturnForm(editModel);
            FormViewPanel.Controls.Clear();
            FormViewPanel.Controls.Add(form);
            form.Show();
        }

        private void DeleteRow_Click(object sender, EventArgs e)
        {
            GetViewByButtonName((sender as Button).Name);
        }

        private void CloseForm_Click(object sender, EventArgs e)
        {
            CloseForm.Hide();
            FormViewPanel.Controls.Clear();
            ToggleEditingButtons();
        }


        private void gridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                //IF "D" CLICK
                case (char)68:
                    DeleteRow.PerformClick();
                    break;
                //IF "E" CLICK
                case (char)69:
                    EditRow.PerformClick();
                    break;
                //IF "I" CLICK
                case (char)73:
                    AddRow.PerformClick();
                    break;
            }
        }
    }
}
