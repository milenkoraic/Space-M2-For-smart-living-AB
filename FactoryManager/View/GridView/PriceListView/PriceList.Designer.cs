
namespace FactoryManager.View.GridView.ActivityView
{
    partial class PriceList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PriceList));
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
            this.prislistaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prislistaTableAdapter = new FactoryManager.SpaceM2DatasetTableAdapters.PrislistaTableAdapter();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colArtikelnummer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colArtikelnamn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEnhet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVikt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBestenhet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colArtinköp_RSK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKontonummer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colByggdelnummer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colByggdelnamn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProduktgruppINKÖP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaterial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBatch = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLeverantörsnamn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVolym = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEnhetvolym = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLedig = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAktivitetsnummer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBeskrvakt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStation1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAvropsenhet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEnhetslast = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKoll = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLedig1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInlevererat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFörbrukat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInventerat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaldo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEnhet1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLedig2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMiljömärke_Kemikalie = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.flpEditButtons.SuspendLayout();
            this.EditButtonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spaceM2Dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prislistaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.prislistaBindingSource;
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
            this.colArtikelnummer,
            this.colArtikelnamn,
            this.colEnhet,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.colVikt,
            this.gridColumn4,
            this.colBestenhet,
            this.gridColumn5,
            this.gridColumn6,
            this.colArtinköp_RSK,
            this.colKontonummer,
            this.colStation,
            this.colByggdelnummer,
            this.colByggdelnamn,
            this.colProduktgruppINKÖP,
            this.colMaterial,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.colBatch,
            this.colLeverantörsnamn,
            this.colVolym,
            this.colEnhetvolym,
            this.colLedig,
            this.gridColumn11,
            this.colAktivitetsnummer,
            this.colBeskrvakt,
            this.colStation1,
            this.gridColumn12,
            this.colAvropsenhet,
            this.colEnhetslast,
            this.gridColumn13,
            this.gridColumn14,
            this.gridColumn15,
            this.gridColumn16,
            this.gridColumn17,
            this.colKoll,
            this.colLedig1,
            this.colInlevererat,
            this.colFörbrukat,
            this.colInventerat,
            this.colSaldo,
            this.colEnhet1,
            this.colLedig2,
            this.colDU,
            this.colMiljömärke_Kemikalie});
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
            // prislistaBindingSource
            // 
            this.prislistaBindingSource.DataMember = "Prislista";
            this.prislistaBindingSource.DataSource = this.spaceM2Dataset;
            // 
            // prislistaTableAdapter
            // 
            this.prislistaTableAdapter.ClearBeforeFill = true;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colArtikelnummer
            // 
            this.colArtikelnummer.FieldName = "Artikelnummer";
            this.colArtikelnummer.Name = "colArtikelnummer";
            this.colArtikelnummer.Visible = true;
            this.colArtikelnummer.VisibleIndex = 1;
            // 
            // colArtikelnamn
            // 
            this.colArtikelnamn.FieldName = "Artikelnamn";
            this.colArtikelnamn.Name = "colArtikelnamn";
            this.colArtikelnamn.Visible = true;
            this.colArtikelnamn.VisibleIndex = 2;
            // 
            // colEnhet
            // 
            this.colEnhet.FieldName = "Enhet";
            this.colEnhet.Name = "colEnhet";
            this.colEnhet.Visible = true;
            this.colEnhet.VisibleIndex = 3;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "Längd (1=Längd ska anges)";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 4;
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "Bredd (1=Bredd ska anges)";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 5;
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "Mängd-enhet (och prisenhet)";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 6;
            // 
            // colVikt
            // 
            this.colVikt.FieldName = "Vikt";
            this.colVikt.Name = "colVikt";
            this.colVikt.Visible = true;
            this.colVikt.VisibleIndex = 7;
            // 
            // gridColumn4
            // 
            this.gridColumn4.FieldName = "Viktenhet_(kg/x)";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 8;
            // 
            // colBestenhet
            // 
            this.colBestenhet.FieldName = "Best enhet";
            this.colBestenhet.Name = "colBestenhet";
            this.colBestenhet.Visible = true;
            this.colBestenhet.VisibleIndex = 9;
            // 
            // gridColumn5
            // 
            this.gridColumn5.FieldName = "Omräkning Enhet - Prisenhet_Hur mycket enligt enhet behövs för 1";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 10;
            // 
            // gridColumn6
            // 
            this.gridColumn6.FieldName = "Inköpspris inkl uppsk# frakt in";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 11;
            // 
            // colArtinköp_RSK
            // 
            this.colArtinköp_RSK.FieldName = "Art inköp_RSK";
            this.colArtinköp_RSK.Name = "colArtinköp_RSK";
            this.colArtinköp_RSK.Visible = true;
            this.colArtinköp_RSK.VisibleIndex = 12;
            // 
            // colKontonummer
            // 
            this.colKontonummer.FieldName = "Kontonummer";
            this.colKontonummer.Name = "colKontonummer";
            this.colKontonummer.Visible = true;
            this.colKontonummer.VisibleIndex = 13;
            // 
            // colStation
            // 
            this.colStation.FieldName = "Station";
            this.colStation.Name = "colStation";
            this.colStation.Visible = true;
            this.colStation.VisibleIndex = 14;
            // 
            // colByggdelnummer
            // 
            this.colByggdelnummer.FieldName = "Byggdelnummer";
            this.colByggdelnummer.Name = "colByggdelnummer";
            this.colByggdelnummer.Visible = true;
            this.colByggdelnummer.VisibleIndex = 15;
            // 
            // colByggdelnamn
            // 
            this.colByggdelnamn.FieldName = "Byggdelnamn";
            this.colByggdelnamn.Name = "colByggdelnamn";
            this.colByggdelnamn.Visible = true;
            this.colByggdelnamn.VisibleIndex = 16;
            // 
            // colProduktgruppINKÖP
            // 
            this.colProduktgruppINKÖP.FieldName = "Produkt grupp INKÖP";
            this.colProduktgruppINKÖP.Name = "colProduktgruppINKÖP";
            this.colProduktgruppINKÖP.Visible = true;
            this.colProduktgruppINKÖP.VisibleIndex = 17;
            // 
            // colMaterial
            // 
            this.colMaterial.FieldName = "Material";
            this.colMaterial.Name = "colMaterial";
            this.colMaterial.Visible = true;
            this.colMaterial.VisibleIndex = 18;
            // 
            // gridColumn7
            // 
            this.gridColumn7.FieldName = "Spill%";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 19;
            // 
            // gridColumn8
            // 
            this.gridColumn8.FieldName = "LAGER-PLATS";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 20;
            // 
            // gridColumn9
            // 
            this.gridColumn9.FieldName = "Huvud-leverantör";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 21;
            // 
            // gridColumn10
            // 
            this.gridColumn10.FieldName = "Bilaga (1=Bilaga ska anges)";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 22;
            // 
            // colBatch
            // 
            this.colBatch.FieldName = "Batch";
            this.colBatch.Name = "colBatch";
            this.colBatch.Visible = true;
            this.colBatch.VisibleIndex = 23;
            // 
            // colLeverantörsnamn
            // 
            this.colLeverantörsnamn.FieldName = "Leverantörsnamn";
            this.colLeverantörsnamn.Name = "colLeverantörsnamn";
            this.colLeverantörsnamn.Visible = true;
            this.colLeverantörsnamn.VisibleIndex = 24;
            // 
            // colVolym
            // 
            this.colVolym.FieldName = "Volym";
            this.colVolym.Name = "colVolym";
            this.colVolym.Visible = true;
            this.colVolym.VisibleIndex = 25;
            // 
            // colEnhetvolym
            // 
            this.colEnhetvolym.FieldName = "Enhet volym";
            this.colEnhetvolym.Name = "colEnhetvolym";
            this.colEnhetvolym.Visible = true;
            this.colEnhetvolym.VisibleIndex = 26;
            // 
            // colLedig
            // 
            this.colLedig.FieldName = "Ledig";
            this.colLedig.Name = "colLedig";
            this.colLedig.Visible = true;
            this.colLedig.VisibleIndex = 27;
            // 
            // gridColumn11
            // 
            this.gridColumn11.FieldName = "För-arbete";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 28;
            // 
            // colAktivitetsnummer
            // 
            this.colAktivitetsnummer.FieldName = "Aktivitetsnummer";
            this.colAktivitetsnummer.Name = "colAktivitetsnummer";
            this.colAktivitetsnummer.Visible = true;
            this.colAktivitetsnummer.VisibleIndex = 29;
            // 
            // colBeskrvakt
            // 
            this.colBeskrvakt.FieldName = "Beskrv akt";
            this.colBeskrvakt.Name = "colBeskrvakt";
            this.colBeskrvakt.Visible = true;
            this.colBeskrvakt.VisibleIndex = 30;
            // 
            // colStation1
            // 
            this.colStation1.FieldName = "Station1";
            this.colStation1.Name = "colStation1";
            this.colStation1.Visible = true;
            this.colStation1.VisibleIndex = 31;
            // 
            // gridColumn12
            // 
            this.gridColumn12.FieldName = "BVB ID för huvud-leverantör_Total bedömning";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 32;
            // 
            // colAvropsenhet
            // 
            this.colAvropsenhet.FieldName = "Avropsenhet";
            this.colAvropsenhet.Name = "colAvropsenhet";
            this.colAvropsenhet.Visible = true;
            this.colAvropsenhet.VisibleIndex = 33;
            // 
            // colEnhetslast
            // 
            this.colEnhetslast.FieldName = "Enhetslast";
            this.colEnhetslast.Name = "colEnhetslast";
            this.colEnhetslast.Visible = true;
            this.colEnhetslast.VisibleIndex = 34;
            // 
            // gridColumn13
            // 
            this.gridColumn13.FieldName = "Enh#last Storhet";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 35;
            // 
            // gridColumn14
            // 
            this.gridColumn14.FieldName = "Lev# Enhet_L (m)";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 36;
            // 
            // gridColumn15
            // 
            this.gridColumn15.FieldName = "Lev# Enhet_B (m)";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 37;
            // 
            // gridColumn16
            // 
            this.gridColumn16.FieldName = "Lev# Enhet_H (m)";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.Visible = true;
            this.gridColumn16.VisibleIndex = 38;
            // 
            // gridColumn17
            // 
            this.gridColumn17.FieldName = "Lev# Enhet_Vikt (kg)";
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.Visible = true;
            this.gridColumn17.VisibleIndex = 39;
            // 
            // colKoll
            // 
            this.colKoll.FieldName = "Koll";
            this.colKoll.Name = "colKoll";
            this.colKoll.Visible = true;
            this.colKoll.VisibleIndex = 40;
            // 
            // colLedig1
            // 
            this.colLedig1.FieldName = "Ledig1";
            this.colLedig1.Name = "colLedig1";
            this.colLedig1.Visible = true;
            this.colLedig1.VisibleIndex = 41;
            // 
            // colInlevererat
            // 
            this.colInlevererat.FieldName = "Inlevererat";
            this.colInlevererat.Name = "colInlevererat";
            this.colInlevererat.Visible = true;
            this.colInlevererat.VisibleIndex = 42;
            // 
            // colFörbrukat
            // 
            this.colFörbrukat.FieldName = "Förbrukat";
            this.colFörbrukat.Name = "colFörbrukat";
            this.colFörbrukat.Visible = true;
            this.colFörbrukat.VisibleIndex = 43;
            // 
            // colInventerat
            // 
            this.colInventerat.FieldName = "Inventerat";
            this.colInventerat.Name = "colInventerat";
            this.colInventerat.Visible = true;
            this.colInventerat.VisibleIndex = 44;
            // 
            // colSaldo
            // 
            this.colSaldo.FieldName = "Saldo";
            this.colSaldo.Name = "colSaldo";
            this.colSaldo.Visible = true;
            this.colSaldo.VisibleIndex = 45;
            // 
            // colEnhet1
            // 
            this.colEnhet1.FieldName = "Enhet1";
            this.colEnhet1.Name = "colEnhet1";
            this.colEnhet1.Visible = true;
            this.colEnhet1.VisibleIndex = 46;
            // 
            // colLedig2
            // 
            this.colLedig2.FieldName = "Ledig2";
            this.colLedig2.Name = "colLedig2";
            this.colLedig2.Visible = true;
            this.colLedig2.VisibleIndex = 47;
            // 
            // colDU
            // 
            this.colDU.FieldName = "DU";
            this.colDU.Name = "colDU";
            this.colDU.Visible = true;
            this.colDU.VisibleIndex = 48;
            // 
            // colMiljömärke_Kemikalie
            // 
            this.colMiljömärke_Kemikalie.FieldName = "Miljömärke_Kemikalie";
            this.colMiljömärke_Kemikalie.Name = "colMiljömärke_Kemikalie";
            this.colMiljömärke_Kemikalie.Visible = true;
            this.colMiljömärke_Kemikalie.VisibleIndex = 49;
            // 
            // PriceList
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
            this.Name = "PriceList";
            this.Text = "PriceList";
            this.Load += new System.EventHandler(this.PriceList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.flpEditButtons.ResumeLayout(false);
            this.EditButtonsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spaceM2Dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prislistaBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource prislistaBindingSource;
        private SpaceM2DatasetTableAdapters.PrislistaTableAdapter prislistaTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colArtikelnummer;
        private DevExpress.XtraGrid.Columns.GridColumn colArtikelnamn;
        private DevExpress.XtraGrid.Columns.GridColumn colEnhet;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn colVikt;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn colBestenhet;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn colArtinköp_RSK;
        private DevExpress.XtraGrid.Columns.GridColumn colKontonummer;
        private DevExpress.XtraGrid.Columns.GridColumn colStation;
        private DevExpress.XtraGrid.Columns.GridColumn colByggdelnummer;
        private DevExpress.XtraGrid.Columns.GridColumn colByggdelnamn;
        private DevExpress.XtraGrid.Columns.GridColumn colProduktgruppINKÖP;
        private DevExpress.XtraGrid.Columns.GridColumn colMaterial;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn colBatch;
        private DevExpress.XtraGrid.Columns.GridColumn colLeverantörsnamn;
        private DevExpress.XtraGrid.Columns.GridColumn colVolym;
        private DevExpress.XtraGrid.Columns.GridColumn colEnhetvolym;
        private DevExpress.XtraGrid.Columns.GridColumn colLedig;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn colAktivitetsnummer;
        private DevExpress.XtraGrid.Columns.GridColumn colBeskrvakt;
        private DevExpress.XtraGrid.Columns.GridColumn colStation1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn colAvropsenhet;
        private DevExpress.XtraGrid.Columns.GridColumn colEnhetslast;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraGrid.Columns.GridColumn colKoll;
        private DevExpress.XtraGrid.Columns.GridColumn colLedig1;
        private DevExpress.XtraGrid.Columns.GridColumn colInlevererat;
        private DevExpress.XtraGrid.Columns.GridColumn colFörbrukat;
        private DevExpress.XtraGrid.Columns.GridColumn colInventerat;
        private DevExpress.XtraGrid.Columns.GridColumn colSaldo;
        private DevExpress.XtraGrid.Columns.GridColumn colEnhet1;
        private DevExpress.XtraGrid.Columns.GridColumn colLedig2;
        private DevExpress.XtraGrid.Columns.GridColumn colDU;
        private DevExpress.XtraGrid.Columns.GridColumn colMiljömärke_Kemikalie;
    }
}