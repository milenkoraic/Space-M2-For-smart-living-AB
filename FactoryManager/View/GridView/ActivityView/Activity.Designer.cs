
namespace FactoryManager.View.GridView.ActivityView
{
    partial class Activity
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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Activity));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.bunifuVScrollBar1 = new Bunifu.UI.WinForms.BunifuVScrollBar();
            this.flpEditButtons = new System.Windows.Forms.Panel();
            this.EditButtonsPanel = new System.Windows.Forms.Panel();
            this.DeleteRow = new FontAwesome.Sharp.IconButton();
            this.EditRow = new FontAwesome.Sharp.IconButton();
            this.AddRow = new FontAwesome.Sharp.IconButton();
            this.CloseForm = new FontAwesome.Sharp.IconButton();
            this.GridPanel = new System.Windows.Forms.Panel();
            this.spaceM2Dataset = new FactoryManager.SpaceM2Dataset();
            this.aktivitetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aktivitetTableAdapter = new FactoryManager.SpaceM2DatasetTableAdapters.AktivitetTableAdapter();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAktivitetsnummer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAktivitetsbeskrivning = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEgenkontroll = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInstruktion = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.flpEditButtons.SuspendLayout();
            this.EditButtonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spaceM2Dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aktivitetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.aktivitetBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1150, 362);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Load += new System.EventHandler(this.gridControl1_Load);
            this.gridControl1.VisibleChanged += new System.EventHandler(this.gridControl1_VisibleChanged);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colAktivitetsnummer,
            this.colAktivitetsbeskrivning,
            this.colEgenkontroll,
            this.colInstruktion});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
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
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 362);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(1150, 10);
            this.bunifuSeparator1.TabIndex = 62;
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
            this.bunifuVScrollBar1.Location = new System.Drawing.Point(1133, 372);
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
            this.bunifuVScrollBar1.Size = new System.Drawing.Size(17, 308);
            this.bunifuVScrollBar1.SmallChange = 1;
            this.bunifuVScrollBar1.TabIndex = 65;
            this.bunifuVScrollBar1.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(72)))));
            this.bunifuVScrollBar1.ThumbLength = 90;
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
            this.flpEditButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpEditButtons.Location = new System.Drawing.Point(0, 630);
            this.flpEditButtons.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpEditButtons.Name = "flpEditButtons";
            this.flpEditButtons.Padding = new System.Windows.Forms.Padding(4);
            this.flpEditButtons.Size = new System.Drawing.Size(1133, 50);
            this.flpEditButtons.TabIndex = 82;
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
            this.CloseForm.Location = new System.Drawing.Point(1079, 4);
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
            // GridPanel
            // 
            this.GridPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GridPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.GridPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridPanel.Location = new System.Drawing.Point(0, 372);
            this.GridPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GridPanel.Name = "GridPanel";
            this.GridPanel.Padding = new System.Windows.Forms.Padding(5);
            this.GridPanel.Size = new System.Drawing.Size(1133, 258);
            this.GridPanel.TabIndex = 83;
            // 
            // spaceM2Dataset
            // 
            this.spaceM2Dataset.DataSetName = "SpaceM2Dataset";
            this.spaceM2Dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aktivitetBindingSource
            // 
            this.aktivitetBindingSource.DataMember = "Aktivitet";
            this.aktivitetBindingSource.DataSource = this.spaceM2Dataset;
            // 
            // aktivitetTableAdapter
            // 
            this.aktivitetTableAdapter.ClearBeforeFill = true;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colAktivitetsnummer
            // 
            this.colAktivitetsnummer.FieldName = "Aktivitetsnummer";
            this.colAktivitetsnummer.Name = "colAktivitetsnummer";
            this.colAktivitetsnummer.Visible = true;
            this.colAktivitetsnummer.VisibleIndex = 1;
            // 
            // colAktivitetsbeskrivning
            // 
            this.colAktivitetsbeskrivning.FieldName = "Aktivitetsbeskrivning";
            this.colAktivitetsbeskrivning.Name = "colAktivitetsbeskrivning";
            this.colAktivitetsbeskrivning.Visible = true;
            this.colAktivitetsbeskrivning.VisibleIndex = 2;
            // 
            // colEgenkontroll
            // 
            this.colEgenkontroll.FieldName = "Egenkontroll";
            this.colEgenkontroll.Name = "colEgenkontroll";
            this.colEgenkontroll.Visible = true;
            this.colEgenkontroll.VisibleIndex = 3;
            // 
            // colInstruktion
            // 
            this.colInstruktion.FieldName = "Instruktion";
            this.colInstruktion.Name = "colInstruktion";
            this.colInstruktion.Visible = true;
            this.colInstruktion.VisibleIndex = 4;
            // 
            // Activity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1150, 680);
            this.Controls.Add(this.GridPanel);
            this.Controls.Add(this.flpEditButtons);
            this.Controls.Add(this.bunifuVScrollBar1);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.gridControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Activity";
            this.Text = "Activity";
            this.Load += new System.EventHandler(this.Activity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.flpEditButtons.ResumeLayout(false);
            this.EditButtonsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spaceM2Dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aktivitetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private Bunifu.UI.WinForms.BunifuVScrollBar bunifuVScrollBar1;
        private System.Windows.Forms.Panel flpEditButtons;
        private System.Windows.Forms.Panel EditButtonsPanel;
        private FontAwesome.Sharp.IconButton DeleteRow;
        private FontAwesome.Sharp.IconButton EditRow;
        private FontAwesome.Sharp.IconButton AddRow;
        private FontAwesome.Sharp.IconButton CloseForm;
        private System.Windows.Forms.Panel GridPanel;
        private SpaceM2Dataset spaceM2Dataset;
        private System.Windows.Forms.BindingSource aktivitetBindingSource;
        private SpaceM2DatasetTableAdapters.AktivitetTableAdapter aktivitetTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colAktivitetsnummer;
        private DevExpress.XtraGrid.Columns.GridColumn colAktivitetsbeskrivning;
        private DevExpress.XtraGrid.Columns.GridColumn colEgenkontroll;
        private DevExpress.XtraGrid.Columns.GridColumn colInstruktion;
    }
}