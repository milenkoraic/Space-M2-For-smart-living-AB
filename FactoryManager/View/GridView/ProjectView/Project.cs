
using FactoryManager.BLL;
using FactoryManager.View.AppDialog;
using System;
using System.Windows.Forms;

namespace FactoryManager.View.GridView
{
    public partial class Project : Form
    {
        static DevExpress.XtraGrid.GridControl DataGridControl;
        static DevExpress.XtraGrid.Views.Grid.GridView DataGridView;

        public static void RefreshDataGrid()
        {
            ProjectService.Fill(DataGridControl);
            DataGridView.MoveLast();
        }

        public Project()
        {
            InitializeComponent();
            DataGridControl = gridControl1;
            DataGridView = gridView1;
        }

        private void Project_Load(object sender, EventArgs e)
        {
            ProjectService.Fill(gridControl1);
            RefreshDataGrid();
            gridView1.OptionsView.ColumnAutoWidth = false;
            gridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            gridView1.BestFitColumns();
        }

        private void AddRow_Click(object sender, EventArgs e)
        {
            ProjectForm.ReturnNewForm(gridView1);
        }

        private void EditRow_Click(object sender, EventArgs e)
        {
            ProjectForm.ReturnEditForm(gridView1);
        }

        private void DeleteRow_Click(object sender, EventArgs e)
        {
            var result = MessageDialog.ShowBox(
                "Är du säker på att du vill ta bort projekt " + 
                gridView1.GetFocusedDataRow()["Projektnamn"].ToString() + 
                " med nummer " + 
                gridView1.GetFocusedDataRow()["Projektnummer"].ToString() + 
                "?", 
                "TA BORT PROJEKT");

            if (result.Equals("1"))
            {
                ProjectService.DeleteProjectById(Convert.ToInt32(gridView1.GetFocusedDataRow()["ID"]));
                RefreshDataGrid();
            }
        }
    }
}
