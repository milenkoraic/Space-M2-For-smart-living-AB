using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using FactoryManager.BLL;
using FactoryManager.View.AppDialog;

namespace FactoryManager.View.GridView
{
    public partial class User : XtraForm
    {
        public static SpaceM2Dataset SM2Dataset;
        public static SpaceM2DatasetTableAdapters.AnvändareTableAdapter TableAdapter;
        
        public static DevExpress.XtraGrid.Views.Grid.GridView DataGridView;
        public static Panel FormViewPanel;
        public static Button CloseFormButton;

        public User()
        {
            InitializeComponent();

            SM2Dataset = spaceM2Dataset;
            TableAdapter = användareTableAdapter;
            DataGridView = gridView1;
            FormViewPanel = GridPanel;
            CloseFormButton = CloseForm;
        }

        private void User_Load(object sender, EventArgs e)
        {
            användareTableAdapter.Fill(spaceM2Dataset.Användare);
            gridControl1.Height = MainForm.DockingPanel.Height / 2;
            gridView1.OptionsView.ColumnAutoWidth = false;
            gridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            gridView1.BestFitColumns();
        }
        public static void RefreshDataGridSource()
        {
            TableAdapter.Fill(SM2Dataset.Användare);
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

        private void ToggleButtons()
        {
            if (AddRow.Visible == true && EditRow.Visible == true && DeleteRow.Visible == true)
            {
                AddRow.Hide();
                EditRow.Hide();
                DeleteRow.Hide();
                CloseForm.Show();
            }
            else
            {
                AddRow.Show();
                EditRow.Show();
                DeleteRow.Show();
                CloseForm.Hide();
            }
        }

        private UserModel GetViewByButtonName(string buttonName)
        {
            UserModel model = new UserModel();

            switch (buttonName)
            {
                case "AddRow":
                    var autoincrementModel = AutoincrementService.GetAutoincrementNumber(User.DataGridView.Columns[0].FieldName, User.DataGridView.Columns[1].FieldName, MainForm.SectionIndicator.Text.ToUpperInvariant());
                    model = new UserModel
                    {
                        Id = autoincrementModel.Id,
                        Number = autoincrementModel.Number
                    };

                    break;
                case "EditRow":
                    //model.[PropertyID] = Convert.ToInt32(DataGrid.GetFocusedDataRow()["ID"]);
                    //model.[PropertyNumber] = Convert.ToInt32(DataGrid.GetFocusedDataRow()["Projektnummer"]);
                    //model.[PropertyName] = DataGrid.GetFocusedDataRow()["Projektnummer"].ToString();
                    //model.[PropertyETC] = DataGrid.GetFocusedDataRow()["Projektnummer"];
                    break;
                case "DeleteRow":
                    string result = MessageDialog.ShowBox("Är du säker på att du vill ta bort projekt " + User.DataGridView.GetFocusedDataRow()["Projektnamn"].ToString() + " med nummer " + User.DataGridView.GetFocusedDataRow()["Projektnummer"].ToString() + "?", "TA BORT PROJEKT");

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
            return model;
        }

        private void AddRow_Click(object sender, EventArgs e)
        {
            ToggleButtons();

            var formModel = GetViewByButtonName((sender as Button).Name);
            var form = UserForm.ReturnForm(formModel);
            FormViewPanel.Controls.Clear();
            FormViewPanel.Controls.Add(form);
            form.Show();

            if (form.Height > FormViewPanel.Height)
            {
                GridPanel.VerticalScroll.Value = 1;
                bunifuVScrollBar1.BindTo(FormViewPanel);
                bunifuVScrollBar1.Show();
            }
            gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            gridView1.FocusedRowHandle = DevExpress.XtraGrid.GridControl.NewItemRowHandle;
        }

        private void EditRow_Click(object sender, EventArgs e)
        {
            ToggleButtons();

            var formModel = GetViewByButtonName((sender as Button).Name);
            var form = UserForm.ReturnForm(formModel);
            FormViewPanel.Controls.Clear();
            FormViewPanel.Controls.Add(form);
            form.Show();

            if (form.Height > FormViewPanel.Height)
            {
                GridPanel.VerticalScroll.Value = 1;
                bunifuVScrollBar1.BindTo(FormViewPanel);    
                bunifuVScrollBar1.Show();
            }
        }

        private void DeleteRow_Click(object sender, EventArgs e)
        {
            var formModel = GetViewByButtonName((sender as Button).Name);
            var form = UserForm.ReturnForm(formModel);
            form.Show();
        }

        private void CloseForm_Click(object sender, EventArgs e)
        {
            ToggleButtons();
            FormViewPanel.Controls.Clear();
            bunifuVScrollBar1.Value = 0;
            bunifuVScrollBar1.Hide();
            gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
            gridView1.MoveLast();
        }
    }
}
