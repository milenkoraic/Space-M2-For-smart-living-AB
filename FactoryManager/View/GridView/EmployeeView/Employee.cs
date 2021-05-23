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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void Activity_Load(object sender, EventArgs e)
        {
            gridControl1.Height = MainForm.DockingPanel.Height / 2;
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
