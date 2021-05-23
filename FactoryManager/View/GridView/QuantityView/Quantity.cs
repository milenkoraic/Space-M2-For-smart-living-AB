using FactoryManager.BLL.Quantity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactoryManager.View.GridView.ActivityView
{
    public partial class Quantity : Form
    {
        static DevExpress.XtraGrid.GridControl DataGridControl;
        static DevExpress.XtraGrid.Views.Grid.GridView DataGridView;
        public static void RefreshDataGrid()
        {
            QuantityService.Fill(DataGridControl);
            DataGridView.MoveLast();
        }

        public Quantity()
        {
            InitializeComponent();
            DataGridControl = gridControl1;
            DataGridView = gridView1;
        }

        private void Quantity_Load(object sender, EventArgs e)
        {
            QuantityService.Fill(gridControl1);
            gridView1.OptionsView.ColumnAutoWidth = false;
            gridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            gridView1.BestFitColumns();
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
    }
}
