using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using FactoryManager.AppData;
using FactoryManager.BLL;
using FactoryManager.View.AppDialog;

namespace FactoryManager.View.GridView
{
    public partial class User : XtraForm
    {
        public static DevExpress.XtraGrid.Views.Grid.GridView DataGridView;

        public User()
        {
            InitializeComponent();

            DataGridView = gridView1;
        }

        private void User_Load(object sender, EventArgs e)
        {
            gridControl1.Height = MainForm.DockingPanel.Height / 2;
            gridView1.OptionsView.ColumnAutoWidth = false;
            gridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            gridView1.BestFitColumns();
        }
        public static void RefreshDataGridSource()
        {
            DataGridView.MoveLast();
        }


        private void gridControl1_Load(object sender, EventArgs e)
        {
            gridView1.MoveLast();
        }

        private void gridControl1_VisibleChanged(object sender, EventArgs e)
        {
            gridView1.MoveLast();
        }

        private void AddRow_Click(object sender, EventArgs e)
        {

        }

        private void EditRow_Click(object sender, EventArgs e)
        {
           
        }

        private void DeleteRow_Click(object sender, EventArgs e)
        {
           
        }

        private void CloseForm_Click(object sender, EventArgs e)
        {
           
        }
    }
}
