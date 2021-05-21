
namespace FactoryManager.View.GridView.ActivityView
{
    partial class Module
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Module));
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
            this.modulmonteringBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modulmonteringTableAdapter = new FactoryManager.SpaceM2DatasetTableAdapters.ModulmonteringTableAdapter();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProjektnummer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLägenhetsnummer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModulnummer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModultypnummer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModultypnamn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlannummer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlanväggstart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlanresning = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlanutleverans = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrognosutlev = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiff = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDAGARFRÅNRESNING_BÖR15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSättanummerochtidssättamoduler = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGodkännaproduktionsritningar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProgrameraregelverkan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMängdamaterial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAvropamaterial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMottagninginkörningavmaterial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUtkörningavmaterialtillrespektivestation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVägg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLägenhetsskiljandeväggar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMålning = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGolvTak = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colResning = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStation7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStation8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStation9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStation10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStation11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStation12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStation13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStation14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStation15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStation16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStation17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStation18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmballeringMärkning = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUTGÅR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLevererad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF44 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF45 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMängdat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF48 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF49 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.flpEditButtons.SuspendLayout();
            this.EditButtonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spaceM2Dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modulmonteringBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.modulmonteringBindingSource;
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
            this.colProjektnummer,
            this.colLägenhetsnummer,
            this.colModulnummer,
            this.colModultypnummer,
            this.colModultypnamn,
            this.colPlannummer,
            this.colPlanväggstart,
            this.colPlanresning,
            this.colPlanutleverans,
            this.colPrognosutlev,
            this.colDiff,
            this.colDAGARFRÅNRESNING_BÖR15,
            this.colSättanummerochtidssättamoduler,
            this.gridColumn1,
            this.colGodkännaproduktionsritningar,
            this.colProgrameraregelverkan,
            this.colMängdamaterial,
            this.colAvropamaterial,
            this.colMottagninginkörningavmaterial,
            this.colUtkörningavmaterialtillrespektivestation,
            this.colVägg,
            this.colLägenhetsskiljandeväggar,
            this.colMålning,
            this.colGolvTak,
            this.gridColumn2,
            this.colResning,
            this.colStation7,
            this.colStation8,
            this.colStation9,
            this.colStation10,
            this.colStation11,
            this.colStation12,
            this.colStation13,
            this.colStation14,
            this.colStation15,
            this.colStation16,
            this.colStation17,
            this.colStation18,
            this.colEmballeringMärkning,
            this.colUTGÅR,
            this.colLevererad,
            this.colF44,
            this.colF45,
            this.colMängdat,
            this.colKr,
            this.colF48,
            this.colF49});
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
            // modulmonteringBindingSource
            // 
            this.modulmonteringBindingSource.DataMember = "Modulmontering";
            this.modulmonteringBindingSource.DataSource = this.spaceM2Dataset;
            // 
            // modulmonteringTableAdapter
            // 
            this.modulmonteringTableAdapter.ClearBeforeFill = true;
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
            // colLägenhetsnummer
            // 
            this.colLägenhetsnummer.FieldName = "Lägenhetsnummer";
            this.colLägenhetsnummer.Name = "colLägenhetsnummer";
            this.colLägenhetsnummer.Visible = true;
            this.colLägenhetsnummer.VisibleIndex = 2;
            // 
            // colModulnummer
            // 
            this.colModulnummer.FieldName = "Modulnummer";
            this.colModulnummer.Name = "colModulnummer";
            this.colModulnummer.Visible = true;
            this.colModulnummer.VisibleIndex = 3;
            // 
            // colModultypnummer
            // 
            this.colModultypnummer.FieldName = "Modultypnummer";
            this.colModultypnummer.Name = "colModultypnummer";
            this.colModultypnummer.Visible = true;
            this.colModultypnummer.VisibleIndex = 4;
            // 
            // colModultypnamn
            // 
            this.colModultypnamn.FieldName = "Modultyp namn";
            this.colModultypnamn.Name = "colModultypnamn";
            this.colModultypnamn.Visible = true;
            this.colModultypnamn.VisibleIndex = 5;
            // 
            // colPlannummer
            // 
            this.colPlannummer.FieldName = "Plannummer";
            this.colPlannummer.Name = "colPlannummer";
            this.colPlannummer.Visible = true;
            this.colPlannummer.VisibleIndex = 6;
            // 
            // colPlanväggstart
            // 
            this.colPlanväggstart.FieldName = "Plan väggstart";
            this.colPlanväggstart.Name = "colPlanväggstart";
            this.colPlanväggstart.Visible = true;
            this.colPlanväggstart.VisibleIndex = 7;
            // 
            // colPlanresning
            // 
            this.colPlanresning.FieldName = "Plan resning";
            this.colPlanresning.Name = "colPlanresning";
            this.colPlanresning.Visible = true;
            this.colPlanresning.VisibleIndex = 8;
            // 
            // colPlanutleverans
            // 
            this.colPlanutleverans.FieldName = "Plan utleverans";
            this.colPlanutleverans.Name = "colPlanutleverans";
            this.colPlanutleverans.Visible = true;
            this.colPlanutleverans.VisibleIndex = 9;
            // 
            // colPrognosutlev
            // 
            this.colPrognosutlev.FieldName = "Prognos utlev";
            this.colPrognosutlev.Name = "colPrognosutlev";
            this.colPrognosutlev.Visible = true;
            this.colPrognosutlev.VisibleIndex = 10;
            // 
            // colDiff
            // 
            this.colDiff.FieldName = "Diff";
            this.colDiff.Name = "colDiff";
            this.colDiff.Visible = true;
            this.colDiff.VisibleIndex = 11;
            // 
            // colDAGARFRÅNRESNING_BÖR15
            // 
            this.colDAGARFRÅNRESNING_BÖR15.FieldName = "DAGAR FRÅN RESNING_BÖR 15";
            this.colDAGARFRÅNRESNING_BÖR15.Name = "colDAGARFRÅNRESNING_BÖR15";
            this.colDAGARFRÅNRESNING_BÖR15.Visible = true;
            this.colDAGARFRÅNRESNING_BÖR15.VisibleIndex = 12;
            // 
            // colSättanummerochtidssättamoduler
            // 
            this.colSättanummerochtidssättamoduler.FieldName = "Sätta nummer och tidssätta moduler";
            this.colSättanummerochtidssättamoduler.Name = "colSättanummerochtidssättamoduler";
            this.colSättanummerochtidssättamoduler.Visible = true;
            this.colSättanummerochtidssättamoduler.VisibleIndex = 13;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "Rita upp moduler / produktionsritningar";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 14;
            // 
            // colGodkännaproduktionsritningar
            // 
            this.colGodkännaproduktionsritningar.FieldName = "Godkänna produktionsritningar";
            this.colGodkännaproduktionsritningar.Name = "colGodkännaproduktionsritningar";
            this.colGodkännaproduktionsritningar.Visible = true;
            this.colGodkännaproduktionsritningar.VisibleIndex = 15;
            // 
            // colProgrameraregelverkan
            // 
            this.colProgrameraregelverkan.FieldName = "Programera regelverkan";
            this.colProgrameraregelverkan.Name = "colProgrameraregelverkan";
            this.colProgrameraregelverkan.Visible = true;
            this.colProgrameraregelverkan.VisibleIndex = 16;
            // 
            // colMängdamaterial
            // 
            this.colMängdamaterial.FieldName = "Mängda material";
            this.colMängdamaterial.Name = "colMängdamaterial";
            this.colMängdamaterial.Visible = true;
            this.colMängdamaterial.VisibleIndex = 17;
            // 
            // colAvropamaterial
            // 
            this.colAvropamaterial.FieldName = "Avropa material";
            this.colAvropamaterial.Name = "colAvropamaterial";
            this.colAvropamaterial.Visible = true;
            this.colAvropamaterial.VisibleIndex = 18;
            // 
            // colMottagninginkörningavmaterial
            // 
            this.colMottagninginkörningavmaterial.FieldName = "Mottagning inkörning av material";
            this.colMottagninginkörningavmaterial.Name = "colMottagninginkörningavmaterial";
            this.colMottagninginkörningavmaterial.Visible = true;
            this.colMottagninginkörningavmaterial.VisibleIndex = 19;
            // 
            // colUtkörningavmaterialtillrespektivestation
            // 
            this.colUtkörningavmaterialtillrespektivestation.FieldName = "Utkörning av material till respektive station";
            this.colUtkörningavmaterialtillrespektivestation.Name = "colUtkörningavmaterialtillrespektivestation";
            this.colUtkörningavmaterialtillrespektivestation.Visible = true;
            this.colUtkörningavmaterialtillrespektivestation.VisibleIndex = 20;
            // 
            // colVägg
            // 
            this.colVägg.FieldName = "Vägg";
            this.colVägg.Name = "colVägg";
            this.colVägg.Visible = true;
            this.colVägg.VisibleIndex = 21;
            // 
            // colLägenhetsskiljandeväggar
            // 
            this.colLägenhetsskiljandeväggar.FieldName = "Lägenhetsskiljande väggar";
            this.colLägenhetsskiljandeväggar.Name = "colLägenhetsskiljandeväggar";
            this.colLägenhetsskiljandeväggar.Visible = true;
            this.colLägenhetsskiljandeväggar.VisibleIndex = 22;
            // 
            // colMålning
            // 
            this.colMålning.FieldName = "Målning";
            this.colMålning.Name = "colMålning";
            this.colMålning.Visible = true;
            this.colMålning.VisibleIndex = 23;
            // 
            // colGolvTak
            // 
            this.colGolvTak.FieldName = "Golv Tak";
            this.colGolvTak.Name = "colGolvTak";
            this.colGolvTak.Visible = true;
            this.colGolvTak.VisibleIndex = 24;
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "Golv Tak - komplettering";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 25;
            // 
            // colResning
            // 
            this.colResning.FieldName = "Resning";
            this.colResning.Name = "colResning";
            this.colResning.Visible = true;
            this.colResning.VisibleIndex = 26;
            // 
            // colStation7
            // 
            this.colStation7.FieldName = "Station 7";
            this.colStation7.Name = "colStation7";
            this.colStation7.Visible = true;
            this.colStation7.VisibleIndex = 27;
            // 
            // colStation8
            // 
            this.colStation8.FieldName = "Station 8";
            this.colStation8.Name = "colStation8";
            this.colStation8.Visible = true;
            this.colStation8.VisibleIndex = 28;
            // 
            // colStation9
            // 
            this.colStation9.FieldName = "Station 9";
            this.colStation9.Name = "colStation9";
            this.colStation9.Visible = true;
            this.colStation9.VisibleIndex = 29;
            // 
            // colStation10
            // 
            this.colStation10.FieldName = "Station 10";
            this.colStation10.Name = "colStation10";
            this.colStation10.Visible = true;
            this.colStation10.VisibleIndex = 30;
            // 
            // colStation11
            // 
            this.colStation11.FieldName = "Station 11";
            this.colStation11.Name = "colStation11";
            this.colStation11.Visible = true;
            this.colStation11.VisibleIndex = 31;
            // 
            // colStation12
            // 
            this.colStation12.FieldName = "Station 12";
            this.colStation12.Name = "colStation12";
            this.colStation12.Visible = true;
            this.colStation12.VisibleIndex = 32;
            // 
            // colStation13
            // 
            this.colStation13.FieldName = "Station 13";
            this.colStation13.Name = "colStation13";
            this.colStation13.Visible = true;
            this.colStation13.VisibleIndex = 33;
            // 
            // colStation14
            // 
            this.colStation14.FieldName = "Station 14";
            this.colStation14.Name = "colStation14";
            this.colStation14.Visible = true;
            this.colStation14.VisibleIndex = 34;
            // 
            // colStation15
            // 
            this.colStation15.FieldName = "Station 15";
            this.colStation15.Name = "colStation15";
            this.colStation15.Visible = true;
            this.colStation15.VisibleIndex = 35;
            // 
            // colStation16
            // 
            this.colStation16.FieldName = "Station 16";
            this.colStation16.Name = "colStation16";
            this.colStation16.Visible = true;
            this.colStation16.VisibleIndex = 36;
            // 
            // colStation17
            // 
            this.colStation17.FieldName = "Station 17";
            this.colStation17.Name = "colStation17";
            this.colStation17.Visible = true;
            this.colStation17.VisibleIndex = 37;
            // 
            // colStation18
            // 
            this.colStation18.FieldName = "Station 18";
            this.colStation18.Name = "colStation18";
            this.colStation18.Visible = true;
            this.colStation18.VisibleIndex = 38;
            // 
            // colEmballeringMärkning
            // 
            this.colEmballeringMärkning.FieldName = "Emballering Märkning";
            this.colEmballeringMärkning.Name = "colEmballeringMärkning";
            this.colEmballeringMärkning.Visible = true;
            this.colEmballeringMärkning.VisibleIndex = 39;
            // 
            // colUTGÅR
            // 
            this.colUTGÅR.FieldName = "UTGÅR";
            this.colUTGÅR.Name = "colUTGÅR";
            this.colUTGÅR.Visible = true;
            this.colUTGÅR.VisibleIndex = 40;
            // 
            // colLevererad
            // 
            this.colLevererad.FieldName = "Levererad";
            this.colLevererad.Name = "colLevererad";
            this.colLevererad.Visible = true;
            this.colLevererad.VisibleIndex = 41;
            // 
            // colF44
            // 
            this.colF44.FieldName = "F44";
            this.colF44.Name = "colF44";
            this.colF44.Visible = true;
            this.colF44.VisibleIndex = 42;
            // 
            // colF45
            // 
            this.colF45.FieldName = "F45";
            this.colF45.Name = "colF45";
            this.colF45.Visible = true;
            this.colF45.VisibleIndex = 43;
            // 
            // colMängdat
            // 
            this.colMängdat.FieldName = "Mängdat";
            this.colMängdat.Name = "colMängdat";
            this.colMängdat.Visible = true;
            this.colMängdat.VisibleIndex = 44;
            // 
            // colKr
            // 
            this.colKr.FieldName = "Kr";
            this.colKr.Name = "colKr";
            this.colKr.Visible = true;
            this.colKr.VisibleIndex = 45;
            // 
            // colF48
            // 
            this.colF48.FieldName = "F48";
            this.colF48.Name = "colF48";
            this.colF48.Visible = true;
            this.colF48.VisibleIndex = 46;
            // 
            // colF49
            // 
            this.colF49.FieldName = "F49";
            this.colF49.Name = "colF49";
            this.colF49.Visible = true;
            this.colF49.VisibleIndex = 47;
            // 
            // Module
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
            this.Name = "Module";
            this.Text = "Module";
            this.Load += new System.EventHandler(this.Module_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.flpEditButtons.ResumeLayout(false);
            this.EditButtonsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spaceM2Dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modulmonteringBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource modulmonteringBindingSource;
        private SpaceM2DatasetTableAdapters.ModulmonteringTableAdapter modulmonteringTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colProjektnummer;
        private DevExpress.XtraGrid.Columns.GridColumn colLägenhetsnummer;
        private DevExpress.XtraGrid.Columns.GridColumn colModulnummer;
        private DevExpress.XtraGrid.Columns.GridColumn colModultypnummer;
        private DevExpress.XtraGrid.Columns.GridColumn colModultypnamn;
        private DevExpress.XtraGrid.Columns.GridColumn colPlannummer;
        private DevExpress.XtraGrid.Columns.GridColumn colPlanväggstart;
        private DevExpress.XtraGrid.Columns.GridColumn colPlanresning;
        private DevExpress.XtraGrid.Columns.GridColumn colPlanutleverans;
        private DevExpress.XtraGrid.Columns.GridColumn colPrognosutlev;
        private DevExpress.XtraGrid.Columns.GridColumn colDiff;
        private DevExpress.XtraGrid.Columns.GridColumn colDAGARFRÅNRESNING_BÖR15;
        private DevExpress.XtraGrid.Columns.GridColumn colSättanummerochtidssättamoduler;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colGodkännaproduktionsritningar;
        private DevExpress.XtraGrid.Columns.GridColumn colProgrameraregelverkan;
        private DevExpress.XtraGrid.Columns.GridColumn colMängdamaterial;
        private DevExpress.XtraGrid.Columns.GridColumn colAvropamaterial;
        private DevExpress.XtraGrid.Columns.GridColumn colMottagninginkörningavmaterial;
        private DevExpress.XtraGrid.Columns.GridColumn colUtkörningavmaterialtillrespektivestation;
        private DevExpress.XtraGrid.Columns.GridColumn colVägg;
        private DevExpress.XtraGrid.Columns.GridColumn colLägenhetsskiljandeväggar;
        private DevExpress.XtraGrid.Columns.GridColumn colMålning;
        private DevExpress.XtraGrid.Columns.GridColumn colGolvTak;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colResning;
        private DevExpress.XtraGrid.Columns.GridColumn colStation7;
        private DevExpress.XtraGrid.Columns.GridColumn colStation8;
        private DevExpress.XtraGrid.Columns.GridColumn colStation9;
        private DevExpress.XtraGrid.Columns.GridColumn colStation10;
        private DevExpress.XtraGrid.Columns.GridColumn colStation11;
        private DevExpress.XtraGrid.Columns.GridColumn colStation12;
        private DevExpress.XtraGrid.Columns.GridColumn colStation13;
        private DevExpress.XtraGrid.Columns.GridColumn colStation14;
        private DevExpress.XtraGrid.Columns.GridColumn colStation15;
        private DevExpress.XtraGrid.Columns.GridColumn colStation16;
        private DevExpress.XtraGrid.Columns.GridColumn colStation17;
        private DevExpress.XtraGrid.Columns.GridColumn colStation18;
        private DevExpress.XtraGrid.Columns.GridColumn colEmballeringMärkning;
        private DevExpress.XtraGrid.Columns.GridColumn colUTGÅR;
        private DevExpress.XtraGrid.Columns.GridColumn colLevererad;
        private DevExpress.XtraGrid.Columns.GridColumn colF44;
        private DevExpress.XtraGrid.Columns.GridColumn colF45;
        private DevExpress.XtraGrid.Columns.GridColumn colMängdat;
        private DevExpress.XtraGrid.Columns.GridColumn colKr;
        private DevExpress.XtraGrid.Columns.GridColumn colF48;
        private DevExpress.XtraGrid.Columns.GridColumn colF49;
    }
}