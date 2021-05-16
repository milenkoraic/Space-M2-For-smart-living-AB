
namespace FactoryManager.View.GridView
{
    partial class Project
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        ///
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.spaceM2DataSet = new FactoryManager.SpaceM2DataSet();
            this.projektBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projektTableAdapter = new FactoryManager.SpaceM2DataSetTableAdapters.ProjektTableAdapter();
            this.tableAdapterManager = new FactoryManager.SpaceM2DataSetTableAdapters.TableAdapterManager();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProjekt_Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProjnr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProjekt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKund = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKommun = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBeskrivning = new DevExpress.XtraGrid.Columns.GridColumn();
            this.flpEditButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.AddRow = new FontAwesome.Sharp.IconButton();
            this.EditRow = new FontAwesome.Sharp.IconButton();
            this.DeleteRow = new FontAwesome.Sharp.IconButton();
            this.CloseForm = new FontAwesome.Sharp.IconButton();
            this.GridPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.spaceM2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.flpEditButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // spaceM2DataSet
            // 
            this.spaceM2DataSet.DataSetName = "SpaceM2DataSet";
            this.spaceM2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projektBindingSource
            // 
            this.projektBindingSource.DataMember = "Projekt";
            this.projektBindingSource.DataSource = this.spaceM2DataSet;
            // 
            // projektTableAdapter
            // 
            this.projektTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AktiviteterTableAdapter = null;
            this.tableAdapterManager.Användare_RollerTableAdapter = null;
            this.tableAdapterManager.AnvändareTableAdapter = null;
            this.tableAdapterManager.ArtiklarTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ByggdelarTableAdapter = null;
            this.tableAdapterManager.FabriksplaneringTableAdapter = null;
            this.tableAdapterManager.InköpsordrarTableAdapter = null;
            this.tableAdapterManager.Konstruktion_per_väggtypTableAdapter = null;
            this.tableAdapterManager.Kontakter_Space_M2TableAdapter = null;
            this.tableAdapterManager.KontonTableAdapter = null;
            this.tableAdapterManager.LägenhetstyperTableAdapter = null;
            this.tableAdapterManager.LeveransadresserTableAdapter = null;
            this.tableAdapterManager.LeverantörerTableAdapter = null;
            this.tableAdapterManager.MängderTableAdapter = null;
            this.tableAdapterManager.Moduler_ExcelTableAdapter = null;
            this.tableAdapterManager.ModultyperTableAdapter = null;
            this.tableAdapterManager.ProjektTableAdapter = this.projektTableAdapter;
            this.tableAdapterManager.Stationer___Akt_och_E_kontrollTableAdapter = null;
            this.tableAdapterManager.StationerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = FactoryManager.SpaceM2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Väggar_per_modultypTableAdapter = null;
            this.tableAdapterManager.VäggtyperTableAdapter = null;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.projektBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1150, 340);
            this.gridControl1.TabIndex = 46;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProjekt_Id,
            this.colProjnr,
            this.colProjekt,
            this.colStatus,
            this.colKund,
            this.colKommun,
            this.colBeskrivning});
            this.gridView1.DetailHeight = 1065;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsClipboard.AllowCopy = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsClipboard.AllowExcelFormat = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsNavigation.AutoFocusNewRow = true;
            this.gridView1.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            // 
            // colProjekt_Id
            // 
            this.colProjekt_Id.FieldName = "Projekt_Id";
            this.colProjekt_Id.MinWidth = 61;
            this.colProjekt_Id.Name = "colProjekt_Id";
            this.colProjekt_Id.Visible = true;
            this.colProjekt_Id.VisibleIndex = 0;
            this.colProjekt_Id.Width = 227;
            // 
            // colProjnr
            // 
            this.colProjnr.FieldName = "Proj nr";
            this.colProjnr.MinWidth = 61;
            this.colProjnr.Name = "colProjnr";
            this.colProjnr.Visible = true;
            this.colProjnr.VisibleIndex = 1;
            this.colProjnr.Width = 227;
            // 
            // colProjekt
            // 
            this.colProjekt.FieldName = "Projekt";
            this.colProjekt.MinWidth = 61;
            this.colProjekt.Name = "colProjekt";
            this.colProjekt.Visible = true;
            this.colProjekt.VisibleIndex = 2;
            this.colProjekt.Width = 227;
            // 
            // colStatus
            // 
            this.colStatus.FieldName = "Status";
            this.colStatus.MinWidth = 61;
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 3;
            this.colStatus.Width = 227;
            // 
            // colKund
            // 
            this.colKund.FieldName = "Kund";
            this.colKund.MinWidth = 61;
            this.colKund.Name = "colKund";
            this.colKund.Visible = true;
            this.colKund.VisibleIndex = 4;
            this.colKund.Width = 227;
            // 
            // colKommun
            // 
            this.colKommun.FieldName = "Kommun";
            this.colKommun.MinWidth = 61;
            this.colKommun.Name = "colKommun";
            this.colKommun.Visible = true;
            this.colKommun.VisibleIndex = 5;
            this.colKommun.Width = 227;
            // 
            // colBeskrivning
            // 
            this.colBeskrivning.FieldName = "Beskrivning";
            this.colBeskrivning.MinWidth = 61;
            this.colBeskrivning.Name = "colBeskrivning";
            this.colBeskrivning.Visible = true;
            this.colBeskrivning.VisibleIndex = 6;
            this.colBeskrivning.Width = 227;
            // 
            // flpEditButtons
            // 
            this.flpEditButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.flpEditButtons.Controls.Add(this.AddRow);
            this.flpEditButtons.Controls.Add(this.EditRow);
            this.flpEditButtons.Controls.Add(this.DeleteRow);
            this.flpEditButtons.Controls.Add(this.CloseForm);
            this.flpEditButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpEditButtons.Location = new System.Drawing.Point(0, 340);
            this.flpEditButtons.Name = "flpEditButtons";
            this.flpEditButtons.Padding = new System.Windows.Forms.Padding(5);
            this.flpEditButtons.Size = new System.Drawing.Size(1150, 60);
            this.flpEditButtons.TabIndex = 47;
            // 
            // AddRow
            // 
            this.AddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.AddRow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddRow.FlatAppearance.BorderSize = 0;
            this.AddRow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(170)))), ((int)(((byte)(72)))));
            this.AddRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRow.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddRow.ForeColor = System.Drawing.Color.White;
            this.AddRow.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.AddRow.IconColor = System.Drawing.Color.White;
            this.AddRow.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddRow.IconSize = 23;
            this.AddRow.Location = new System.Drawing.Point(8, 8);
            this.AddRow.Name = "AddRow";
            this.AddRow.Size = new System.Drawing.Size(121, 45);
            this.AddRow.TabIndex = 0;
            this.AddRow.Text = "LÄGG TILL NY";
            this.AddRow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddRow.UseVisualStyleBackColor = false;
            this.AddRow.Click += new System.EventHandler(this.AddRow_Click);
            // 
            // EditRow
            // 
            this.EditRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.EditRow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditRow.FlatAppearance.BorderSize = 0;
            this.EditRow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.EditRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditRow.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EditRow.ForeColor = System.Drawing.Color.White;
            this.EditRow.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.EditRow.IconColor = System.Drawing.Color.White;
            this.EditRow.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EditRow.IconSize = 23;
            this.EditRow.Location = new System.Drawing.Point(135, 8);
            this.EditRow.Name = "EditRow";
            this.EditRow.Size = new System.Drawing.Size(121, 45);
            this.EditRow.TabIndex = 1;
            this.EditRow.Text = "REDIGERA";
            this.EditRow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EditRow.UseVisualStyleBackColor = false;
            this.EditRow.Click += new System.EventHandler(this.EditRow_Click);
            // 
            // DeleteRow
            // 
            this.DeleteRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.DeleteRow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteRow.FlatAppearance.BorderSize = 0;
            this.DeleteRow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.DeleteRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteRow.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DeleteRow.ForeColor = System.Drawing.Color.White;
            this.DeleteRow.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.DeleteRow.IconColor = System.Drawing.Color.White;
            this.DeleteRow.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DeleteRow.IconSize = 23;
            this.DeleteRow.Location = new System.Drawing.Point(262, 8);
            this.DeleteRow.Name = "DeleteRow";
            this.DeleteRow.Size = new System.Drawing.Size(121, 45);
            this.DeleteRow.TabIndex = 2;
            this.DeleteRow.Text = "RADERA";
            this.DeleteRow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeleteRow.UseVisualStyleBackColor = false;
            this.DeleteRow.Click += new System.EventHandler(this.DeleteRow_Click);
            // 
            // CloseForm
            // 
            this.CloseForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.CloseForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseForm.FlatAppearance.BorderSize = 0;
            this.CloseForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.CloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseForm.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CloseForm.ForeColor = System.Drawing.Color.White;
            this.CloseForm.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.CloseForm.IconColor = System.Drawing.Color.White;
            this.CloseForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CloseForm.IconSize = 23;
            this.CloseForm.Location = new System.Drawing.Point(389, 8);
            this.CloseForm.Name = "CloseForm";
            this.CloseForm.Size = new System.Drawing.Size(121, 45);
            this.CloseForm.TabIndex = 3;
            this.CloseForm.Text = "STÄNG";
            this.CloseForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CloseForm.UseVisualStyleBackColor = false;
            this.CloseForm.Visible = false;
            this.CloseForm.Click += new System.EventHandler(this.CloseForm_Click);
            // 
            // GridPanel
            // 
            this.GridPanel.AutoScroll = true;
            this.GridPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GridPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.GridPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridPanel.Location = new System.Drawing.Point(0, 400);
            this.GridPanel.Name = "GridPanel";
            this.GridPanel.Size = new System.Drawing.Size(1150, 280);
            this.GridPanel.TabIndex = 48;
            // 
            // Project
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 680);
            this.ControlBox = false;
            this.Controls.Add(this.GridPanel);
            this.Controls.Add(this.flpEditButtons);
            this.Controls.Add(this.gridControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Project";
            this.Opacity = 0D;
            this.Load += new System.EventHandler(this.Projects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spaceM2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.flpEditButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private SpaceM2DataSet spaceM2DataSet;
        private System.Windows.Forms.BindingSource projektBindingSource;
        private SpaceM2DataSetTableAdapters.ProjektTableAdapter projektTableAdapter;
        private SpaceM2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel GridPanel;
        private System.Windows.Forms.FlowLayoutPanel flpEditButtons;
        private FontAwesome.Sharp.IconButton AddRow;
        private FontAwesome.Sharp.IconButton EditRow;
        private FontAwesome.Sharp.IconButton DeleteRow;
        private FontAwesome.Sharp.IconButton CloseForm;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colProjekt_Id;
        private DevExpress.XtraGrid.Columns.GridColumn colProjnr;
        private DevExpress.XtraGrid.Columns.GridColumn colProjekt;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colKund;
        private DevExpress.XtraGrid.Columns.GridColumn colKommun;
        private DevExpress.XtraGrid.Columns.GridColumn colBeskrivning;
    }
}