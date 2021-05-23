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
    public partial class ApartmentType : Form
    {
        public ApartmentType()
        {
            InitializeComponent();
        }

        private void Activity_Load(object sender, EventArgs e)
        {
            gridControl1.Height = MainForm.DockingPanel.Height / 2;
            gridView1.OptionsView.ColumnAutoWidth = false;
            gridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            gridView1.BestFitColumns();

        }

        private void gridControl1_Load(object sender, EventArgs e)
        {

        }

        private void gridControl1_VisibleChanged(object sender, EventArgs e)
        {

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
