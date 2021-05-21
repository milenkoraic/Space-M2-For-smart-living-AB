
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Project));
            this.projektBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spaceM2Dataset = new FactoryManager.SpaceM2Dataset();
            this.projektTableAdapter = new FactoryManager.SpaceM2DatasetTableAdapters.ProjektTableAdapter();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProjektnummer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProjektnamn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProjektstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBeskrivning = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKundnamn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKommun = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.bunifuVScrollBar1 = new Bunifu.UI.WinForms.BunifuVScrollBar();
            this.flpEditButtons = new System.Windows.Forms.Panel();
            this.EditButtonsPanel = new System.Windows.Forms.Panel();
            this.DeleteRow = new FontAwesome.Sharp.IconButton();
            this.EditRow = new FontAwesome.Sharp.IconButton();
            this.AddRow = new FontAwesome.Sharp.IconButton();
            this.CloseForm = new FontAwesome.Sharp.IconButton();
            this.FooterPanel = new System.Windows.Forms.Panel();
            this.GridPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.projektBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spaceM2Dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.flpEditButtons.SuspendLayout();
            this.EditButtonsPanel.SuspendLayout();
            this.FooterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // projektBindingSource
            // 
            this.projektBindingSource.DataMember = "Projekt";
            this.projektBindingSource.DataSource = this.spaceM2Dataset;
            // 
            // spaceM2Dataset
            // 
            this.spaceM2Dataset.DataSetName = "SpaceM2Dataset";
            this.spaceM2Dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projektTableAdapter
            // 
            this.projektTableAdapter.ClearBeforeFill = true;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.projektBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(986, 258);
            this.gridControl1.TabIndex = 52;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Load += new System.EventHandler(this.gridControl1_Load);
            this.gridControl1.VisibleChanged += new System.EventHandler(this.gridControl1_VisibleChanged);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colProjektnummer,
            this.colProjektnamn,
            this.colProjektstatus,
            this.colBeskrivning,
            this.colKundnamn,
            this.colKommun});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colProjektnummer
            // 
            this.colProjektnummer.FieldName = "Projektnummer";
            this.colProjektnummer.Name = "colProjektnummer";
            this.colProjektnummer.Visible = true;
            this.colProjektnummer.VisibleIndex = 1;
            // 
            // colProjektnamn
            // 
            this.colProjektnamn.FieldName = "Projektnamn";
            this.colProjektnamn.Name = "colProjektnamn";
            this.colProjektnamn.Visible = true;
            this.colProjektnamn.VisibleIndex = 2;
            // 
            // colProjektstatus
            // 
            this.colProjektstatus.FieldName = "Projektstatus";
            this.colProjektstatus.Name = "colProjektstatus";
            this.colProjektstatus.Visible = true;
            this.colProjektstatus.VisibleIndex = 3;
            // 
            // colBeskrivning
            // 
            this.colBeskrivning.FieldName = "Beskrivning";
            this.colBeskrivning.Name = "colBeskrivning";
            this.colBeskrivning.Visible = true;
            this.colBeskrivning.VisibleIndex = 4;
            // 
            // colKundnamn
            // 
            this.colKundnamn.FieldName = "Kundnamn";
            this.colKundnamn.Name = "colKundnamn";
            this.colKundnamn.Visible = true;
            this.colKundnamn.VisibleIndex = 5;
            // 
            // colKommun
            // 
            this.colKommun.FieldName = "Kommun";
            this.colKommun.Name = "colKommun";
            this.colKommun.Visible = true;
            this.colKommun.VisibleIndex = 6;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(170)))), ((int)(((byte)(72)))));
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 258);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(986, 10);
            this.bunifuSeparator1.TabIndex = 61;
            // 
            // bunifuVScrollBar1
            // 
            this.bunifuVScrollBar1.AllowCursorChanges = true;
            this.bunifuVScrollBar1.AllowHomeEndKeysDetection = false;
            this.bunifuVScrollBar1.AllowIncrementalClickMoves = true;
            this.bunifuVScrollBar1.AllowMouseDownEffects = true;
            this.bunifuVScrollBar1.AllowMouseHoverEffects = true;
            this.bunifuVScrollBar1.AllowScrollingAnimations = true;
            this.bunifuVScrollBar1.AllowScrollKeysDetection = true;
            this.bunifuVScrollBar1.AllowScrollOptionsMenu = true;
            this.bunifuVScrollBar1.AllowShrinkingOnFocusLost = false;
            this.bunifuVScrollBar1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bunifuVScrollBar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuVScrollBar1.BackgroundImage")));
            this.bunifuVScrollBar1.BindingContainer = null;
            this.bunifuVScrollBar1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bunifuVScrollBar1.BorderRadius = 10;
            this.bunifuVScrollBar1.BorderThickness = 1;
            this.bunifuVScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuVScrollBar1.DurationBeforeShrink = 2000;
            this.bunifuVScrollBar1.LargeChange = 30;
            this.bunifuVScrollBar1.Location = new System.Drawing.Point(969, 268);
            this.bunifuVScrollBar1.Maximum = 100;
            this.bunifuVScrollBar1.Minimum = 0;
            this.bunifuVScrollBar1.MinimumThumbLength = 18;
            this.bunifuVScrollBar1.Name = "bunifuVScrollBar1";
            this.bunifuVScrollBar1.OnDisable.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bunifuVScrollBar1.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.bunifuVScrollBar1.OnDisable.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bunifuVScrollBar1.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bunifuVScrollBar1.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bunifuVScrollBar1.ShrinkSizeLimit = 3;
            this.bunifuVScrollBar1.Size = new System.Drawing.Size(17, 284);
            this.bunifuVScrollBar1.SmallChange = 1;
            this.bunifuVScrollBar1.TabIndex = 64;
            this.bunifuVScrollBar1.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(72)))));
            this.bunifuVScrollBar1.ThumbLength = 83;
            this.bunifuVScrollBar1.ThumbMargin = 1;
            this.bunifuVScrollBar1.ThumbStyle = Bunifu.UI.WinForms.BunifuVScrollBar.ThumbStyles.Inset;
            this.bunifuVScrollBar1.Value = 0;
            this.bunifuVScrollBar1.Visible = false;
            // 
            // flpEditButtons
            // 
            this.flpEditButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.flpEditButtons.Controls.Add(this.EditButtonsPanel);
            this.flpEditButtons.Controls.Add(this.CloseForm);
            this.flpEditButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpEditButtons.Location = new System.Drawing.Point(0, 0);
            this.flpEditButtons.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpEditButtons.Name = "flpEditButtons";
            this.flpEditButtons.Padding = new System.Windows.Forms.Padding(4);
            this.flpEditButtons.Size = new System.Drawing.Size(969, 50);
            this.flpEditButtons.TabIndex = 69;
            // 
            // EditButtonsPanel
            // 
            this.EditButtonsPanel.Controls.Add(this.DeleteRow);
            this.EditButtonsPanel.Controls.Add(this.EditRow);
            this.EditButtonsPanel.Controls.Add(this.AddRow);
            this.EditButtonsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.EditButtonsPanel.Location = new System.Drawing.Point(4, 4);
            this.EditButtonsPanel.Name = "EditButtonsPanel";
            this.EditButtonsPanel.Size = new System.Drawing.Size(348, 42);
            this.EditButtonsPanel.TabIndex = 10;
            // 
            // DeleteRow
            // 
            this.DeleteRow.BackColor = System.Drawing.Color.Brown;
            this.DeleteRow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteRow.Dock = System.Windows.Forms.DockStyle.Left;
            this.DeleteRow.FlatAppearance.BorderSize = 0;
            this.DeleteRow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.DeleteRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteRow.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DeleteRow.ForeColor = System.Drawing.Color.White;
            this.DeleteRow.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.DeleteRow.IconColor = System.Drawing.Color.White;
            this.DeleteRow.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DeleteRow.IconSize = 23;
            this.DeleteRow.Location = new System.Drawing.Point(230, 0);
            this.DeleteRow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteRow.Name = "DeleteRow";
            this.DeleteRow.Size = new System.Drawing.Size(115, 42);
            this.DeleteRow.TabIndex = 20;
            this.DeleteRow.Text = "REDIGERA";
            this.DeleteRow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeleteRow.UseVisualStyleBackColor = false;
            this.DeleteRow.Click += new System.EventHandler(this.DeleteRow_Click);
            // 
            // EditRow
            // 
            this.EditRow.BackColor = System.Drawing.Color.Goldenrod;
            this.EditRow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditRow.Dock = System.Windows.Forms.DockStyle.Left;
            this.EditRow.FlatAppearance.BorderSize = 0;
            this.EditRow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.EditRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditRow.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EditRow.ForeColor = System.Drawing.Color.White;
            this.EditRow.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.EditRow.IconColor = System.Drawing.Color.White;
            this.EditRow.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EditRow.IconSize = 23;
            this.EditRow.Location = new System.Drawing.Point(115, 0);
            this.EditRow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditRow.Name = "EditRow";
            this.EditRow.Size = new System.Drawing.Size(115, 42);
            this.EditRow.TabIndex = 19;
            this.EditRow.Text = "REDIGERA";
            this.EditRow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EditRow.UseVisualStyleBackColor = false;
            this.EditRow.Click += new System.EventHandler(this.EditRow_Click);
            // 
            // AddRow
            // 
            this.AddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(72)))));
            this.AddRow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddRow.Dock = System.Windows.Forms.DockStyle.Left;
            this.AddRow.FlatAppearance.BorderSize = 0;
            this.AddRow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(190)))), ((int)(((byte)(72)))));
            this.AddRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRow.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddRow.ForeColor = System.Drawing.Color.White;
            this.AddRow.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.AddRow.IconColor = System.Drawing.Color.White;
            this.AddRow.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddRow.IconSize = 23;
            this.AddRow.Location = new System.Drawing.Point(0, 0);
            this.AddRow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddRow.Name = "AddRow";
            this.AddRow.Size = new System.Drawing.Size(115, 42);
            this.AddRow.TabIndex = 16;
            this.AddRow.Text = "LÄGG TILL NY";
            this.AddRow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddRow.UseVisualStyleBackColor = false;
            this.AddRow.Click += new System.EventHandler(this.AddRow_Click);
            // 
            // CloseForm
            // 
            this.CloseForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.CloseForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseForm.FlatAppearance.BorderSize = 0;
            this.CloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseForm.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CloseForm.ForeColor = System.Drawing.Color.White;
            this.CloseForm.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.CloseForm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(170)))), ((int)(((byte)(72)))));
            this.CloseForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CloseForm.IconSize = 25;
            this.CloseForm.Location = new System.Drawing.Point(915, 4);
            this.CloseForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CloseForm.Name = "CloseForm";
            this.CloseForm.Size = new System.Drawing.Size(50, 42);
            this.CloseForm.TabIndex = 71;
            this.CloseForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CloseForm.UseVisualStyleBackColor = false;
            this.CloseForm.Visible = false;
            this.CloseForm.Click += new System.EventHandler(this.CloseForm_Click);
            this.CloseForm.MouseEnter += new System.EventHandler(this.CloseForm_MouseEnter);
            this.CloseForm.MouseLeave += new System.EventHandler(this.CloseForm_MouseLeave);
            // 
            // FooterPanel
            // 
            this.FooterPanel.Controls.Add(this.flpEditButtons);
            this.FooterPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FooterPanel.Location = new System.Drawing.Point(0, 502);
            this.FooterPanel.Name = "FooterPanel";
            this.FooterPanel.Size = new System.Drawing.Size(969, 50);
            this.FooterPanel.TabIndex = 71;
            // 
            // GridPanel
            // 
            this.GridPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GridPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.GridPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridPanel.Location = new System.Drawing.Point(0, 268);
            this.GridPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GridPanel.Name = "GridPanel";
            this.GridPanel.Padding = new System.Windows.Forms.Padding(5);
            this.GridPanel.Size = new System.Drawing.Size(969, 234);
            this.GridPanel.TabIndex = 72;
            // 
            // Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 552);
            this.ControlBox = false;
            this.Controls.Add(this.GridPanel);
            this.Controls.Add(this.FooterPanel);
            this.Controls.Add(this.bunifuVScrollBar1);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.gridControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Project";
            this.Opacity = 0D;
            this.Load += new System.EventHandler(this.Project_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projektBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spaceM2Dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.flpEditButtons.ResumeLayout(false);
            this.EditButtonsPanel.ResumeLayout(false);
            this.FooterPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private SpaceM2Dataset spaceM2Dataset;
        private SpaceM2DatasetTableAdapters.ProjektTableAdapter projektTableAdapter;
        private System.Windows.Forms.BindingSource projektBindingSource;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colProjektnummer;
        private DevExpress.XtraGrid.Columns.GridColumn colProjektnamn;
        private DevExpress.XtraGrid.Columns.GridColumn colProjektstatus;
        private DevExpress.XtraGrid.Columns.GridColumn colBeskrivning;
        private DevExpress.XtraGrid.Columns.GridColumn colKundnamn;
        private DevExpress.XtraGrid.Columns.GridColumn colKommun;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private Bunifu.UI.WinForms.BunifuVScrollBar bunifuVScrollBar1;
        private System.Windows.Forms.Panel flpEditButtons;
        private System.Windows.Forms.Panel EditButtonsPanel;
        private FontAwesome.Sharp.IconButton DeleteRow;
        private FontAwesome.Sharp.IconButton EditRow;
        private FontAwesome.Sharp.IconButton AddRow;
        private System.Windows.Forms.Panel FooterPanel;
        private System.Windows.Forms.Panel GridPanel;
        private FontAwesome.Sharp.IconButton CloseForm;
    }
}