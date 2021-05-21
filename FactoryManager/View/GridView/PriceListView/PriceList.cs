﻿using System;
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
    public partial class PriceList : Form
    {
        public PriceList()
        {
            InitializeComponent();
        }

        private void PriceList_Load(object sender, EventArgs e)
        {
            prislistaTableAdapter.Fill(spaceM2Dataset.Prislista);
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

        private void CloseForm_Click(object sender, EventArgs e)
        {

        }

        private void CloseForm_MouseEnter(object sender, EventArgs e)
        {
            CloseForm.BackColor = Color.FromArgb(50, 170, 72);
            CloseForm.IconColor = Color.White;
        }

        private void CloseForm_MouseLeave(object sender, EventArgs e)
        {
            CloseForm.BackColor = Color.FromArgb(35, 35, 35);
            CloseForm.IconColor = Color.FromArgb(50, 170, 72);
        }
    }
}