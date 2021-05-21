using System;
using System.Drawing;
using System.Windows.Forms;

namespace FactoryManager.View.GridView
{
    public partial class Project : Form
    {
        static SpaceM2Dataset SM2Dataset;
        static SpaceM2DatasetTableAdapters.ProjektTableAdapter TableAdapter;
        static DevExpress.XtraGrid.Views.Grid.GridView DataGridView;
        static Button CloseFormButton;

        public Project()
        {
            InitializeComponent();

            SM2Dataset = spaceM2Dataset;
            TableAdapter = projektTableAdapter;
            DataGridView = gridView1;
            CloseFormButton = CloseForm;
        }

        private void Project_Load(object sender, EventArgs e)
        {
            projektTableAdapter.Fill(spaceM2Dataset.Projekt);
            gridControl1.Height = MainForm.DockingPanel.Height / 2;
            gridView1.OptionsView.ColumnAutoWidth = false;
            gridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            gridView1.BestFitColumns();
        }

        public static void RefreshDataGridSource()
        {
            TableAdapter.Fill(SM2Dataset.Projekt);
            DataGridView.MoveLast();
            CloseFormButton.PerformClick();
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
            EditButtonsPanel.Hide();
            CloseForm.Show();

            var form = ProjectForm.ReturnNewForm(gridView1);
            GridPanel.Controls.Clear();
            GridPanel.Controls.Add(form);
            form.Show();

            if (form.Height > GridPanel.Height)
            {
                GridPanel.VerticalScroll.Value = 1;
                bunifuVScrollBar1.BindTo(GridPanel);
                bunifuVScrollBar1.Show();
            }
            gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            gridView1.FocusedRowHandle = DevExpress.XtraGrid.GridControl.NewItemRowHandle;
        }

        private void EditRow_Click(object sender, EventArgs e)
        {
            EditButtonsPanel.Hide();
            CloseForm.Show();

            var form = ProjectForm.ReturnEditForm(ProjectForm.GetViewByButtonName((sender as Button).Name, gridView1));
            GridPanel.Controls.Clear();
            GridPanel.Controls.Add(form);
            form.Show();

            if (form.Height > GridPanel.Height)
            {
                GridPanel.VerticalScroll.Value = 1;
                bunifuVScrollBar1.BindTo(GridPanel);    
                bunifuVScrollBar1.Show();
            }
        }

        private void DeleteRow_Click(object sender, EventArgs e)
        {
            ProjectForm.AskToDeleteEntry(gridView1);
            RefreshDataGridSource();
        }

        private void CloseForm_Click(object sender, EventArgs e)
        {
            CloseForm.Hide();
            EditButtonsPanel.Show();
            GridPanel.Controls.Clear();
            bunifuVScrollBar1.Value = 0;
            bunifuVScrollBar1.Hide();
            gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
            gridView1.MoveLast();
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
