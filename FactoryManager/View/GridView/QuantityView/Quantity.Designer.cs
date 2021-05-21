
namespace FactoryManager.View.GridView.ActivityView
{
    partial class Quantity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quantity));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.mängderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spaceM2Dataset = new FactoryManager.SpaceM2Dataset();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrdernummer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModulnummer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colArtikelnummer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKommentar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLängd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBredd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEnhet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAntal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOmräkning = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInköpradkr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBehovimodul = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTyp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFyllning = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBredd1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHöjd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDörrblad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGlas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGångjärn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLåskista = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSlutbleck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKulördörrblad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKulörkarm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKarmdjup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTröskel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHängning = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLjud = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBrand = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVärme = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSäkerhet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDörrkik = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInbrott = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBröstningfönster = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSpecialpris = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.bunifuVScrollBar1 = new Bunifu.UI.WinForms.BunifuVScrollBar();
            this.flpEditButtons = new System.Windows.Forms.Panel();
            this.EditButtonsPanel = new System.Windows.Forms.Panel();
            this.DeleteRow = new FontAwesome.Sharp.IconButton();
            this.EditRow = new FontAwesome.Sharp.IconButton();
            this.AddRow = new FontAwesome.Sharp.IconButton();
            this.CloseForm = new FontAwesome.Sharp.IconButton();
            this.GridPanel = new System.Windows.Forms.Panel();
            this.mängderTableAdapter = new FactoryManager.SpaceM2DatasetTableAdapters.MängderTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mängderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spaceM2Dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.flpEditButtons.SuspendLayout();
            this.EditButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.mängderBindingSource;
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
            // mängderBindingSource
            // 
            this.mängderBindingSource.DataMember = "Mängder";
            this.mängderBindingSource.DataSource = this.spaceM2Dataset;
            // 
            // spaceM2Dataset
            // 
            this.spaceM2Dataset.DataSetName = "SpaceM2Dataset";
            this.spaceM2Dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colOrdernummer,
            this.colModulnummer,
            this.colArtikelnummer,
            this.colKommentar,
            this.colLängd,
            this.colBredd,
            this.colEnhet,
            this.colAntal,
            this.colOmräkning,
            this.colInköpradkr,
            this.colBehovimodul,
            this.gridColumn1,
            this.colTyp,
            this.colFyllning,
            this.colBredd1,
            this.colHöjd,
            this.colDörrblad,
            this.colGlas,
            this.colGångjärn,
            this.colLåskista,
            this.colSlutbleck,
            this.colKulördörrblad,
            this.colKulörkarm,
            this.colKarmdjup,
            this.colTröskel,
            this.colHängning,
            this.colLjud,
            this.colBrand,
            this.colVärme,
            this.colBad,
            this.colSäkerhet,
            this.colDörrkik,
            this.colInbrott,
            this.colEl,
            this.colBröstningfönster,
            this.colSpecialpris});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colOrdernummer
            // 
            this.colOrdernummer.FieldName = "Ordernummer";
            this.colOrdernummer.Name = "colOrdernummer";
            this.colOrdernummer.Visible = true;
            this.colOrdernummer.VisibleIndex = 1;
            // 
            // colModulnummer
            // 
            this.colModulnummer.FieldName = "Modulnummer";
            this.colModulnummer.Name = "colModulnummer";
            this.colModulnummer.Visible = true;
            this.colModulnummer.VisibleIndex = 2;
            // 
            // colArtikelnummer
            // 
            this.colArtikelnummer.FieldName = "Artikelnummer";
            this.colArtikelnummer.Name = "colArtikelnummer";
            this.colArtikelnummer.Visible = true;
            this.colArtikelnummer.VisibleIndex = 3;
            // 
            // colKommentar
            // 
            this.colKommentar.FieldName = "Kommentar";
            this.colKommentar.Name = "colKommentar";
            this.colKommentar.Visible = true;
            this.colKommentar.VisibleIndex = 4;
            // 
            // colLängd
            // 
            this.colLängd.FieldName = "Längd";
            this.colLängd.Name = "colLängd";
            this.colLängd.Visible = true;
            this.colLängd.VisibleIndex = 5;
            // 
            // colBredd
            // 
            this.colBredd.FieldName = "Bredd";
            this.colBredd.Name = "colBredd";
            this.colBredd.Visible = true;
            this.colBredd.VisibleIndex = 6;
            // 
            // colEnhet
            // 
            this.colEnhet.FieldName = "Enhet";
            this.colEnhet.Name = "colEnhet";
            this.colEnhet.Visible = true;
            this.colEnhet.VisibleIndex = 7;
            // 
            // colAntal
            // 
            this.colAntal.FieldName = "Antal";
            this.colAntal.Name = "colAntal";
            this.colAntal.Visible = true;
            this.colAntal.VisibleIndex = 8;
            // 
            // colOmräkning
            // 
            this.colOmräkning.FieldName = "Omräkning";
            this.colOmräkning.Name = "colOmräkning";
            this.colOmräkning.Visible = true;
            this.colOmräkning.VisibleIndex = 9;
            // 
            // colInköpradkr
            // 
            this.colInköpradkr.FieldName = "Inköp rad kr";
            this.colInköpradkr.Name = "colInköpradkr";
            this.colInköpradkr.Visible = true;
            this.colInköpradkr.VisibleIndex = 10;
            // 
            // colBehovimodul
            // 
            this.colBehovimodul.FieldName = "Behov i modul";
            this.colBehovimodul.Name = "colBehovimodul";
            this.colBehovimodul.Visible = true;
            this.colBehovimodul.VisibleIndex = 11;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "Vecka - dag";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 12;
            // 
            // colTyp
            // 
            this.colTyp.FieldName = "Typ";
            this.colTyp.Name = "colTyp";
            this.colTyp.Visible = true;
            this.colTyp.VisibleIndex = 13;
            // 
            // colFyllning
            // 
            this.colFyllning.FieldName = "Fyllning";
            this.colFyllning.Name = "colFyllning";
            this.colFyllning.Visible = true;
            this.colFyllning.VisibleIndex = 14;
            // 
            // colBredd1
            // 
            this.colBredd1.FieldName = "Bredd1";
            this.colBredd1.Name = "colBredd1";
            this.colBredd1.Visible = true;
            this.colBredd1.VisibleIndex = 15;
            // 
            // colHöjd
            // 
            this.colHöjd.FieldName = "Höjd";
            this.colHöjd.Name = "colHöjd";
            this.colHöjd.Visible = true;
            this.colHöjd.VisibleIndex = 16;
            // 
            // colDörrblad
            // 
            this.colDörrblad.FieldName = "Dörrblad";
            this.colDörrblad.Name = "colDörrblad";
            this.colDörrblad.Visible = true;
            this.colDörrblad.VisibleIndex = 17;
            // 
            // colGlas
            // 
            this.colGlas.FieldName = "Glas";
            this.colGlas.Name = "colGlas";
            this.colGlas.Visible = true;
            this.colGlas.VisibleIndex = 18;
            // 
            // colGångjärn
            // 
            this.colGångjärn.FieldName = "Gångjärn";
            this.colGångjärn.Name = "colGångjärn";
            this.colGångjärn.Visible = true;
            this.colGångjärn.VisibleIndex = 19;
            // 
            // colLåskista
            // 
            this.colLåskista.FieldName = "Låskista";
            this.colLåskista.Name = "colLåskista";
            this.colLåskista.Visible = true;
            this.colLåskista.VisibleIndex = 20;
            // 
            // colSlutbleck
            // 
            this.colSlutbleck.FieldName = "Slutbleck";
            this.colSlutbleck.Name = "colSlutbleck";
            this.colSlutbleck.Visible = true;
            this.colSlutbleck.VisibleIndex = 21;
            // 
            // colKulördörrblad
            // 
            this.colKulördörrblad.FieldName = "Kulör dörrblad";
            this.colKulördörrblad.Name = "colKulördörrblad";
            this.colKulördörrblad.Visible = true;
            this.colKulördörrblad.VisibleIndex = 22;
            // 
            // colKulörkarm
            // 
            this.colKulörkarm.FieldName = "Kulör karm";
            this.colKulörkarm.Name = "colKulörkarm";
            this.colKulörkarm.Visible = true;
            this.colKulörkarm.VisibleIndex = 23;
            // 
            // colKarmdjup
            // 
            this.colKarmdjup.FieldName = "Karmdjup";
            this.colKarmdjup.Name = "colKarmdjup";
            this.colKarmdjup.Visible = true;
            this.colKarmdjup.VisibleIndex = 24;
            // 
            // colTröskel
            // 
            this.colTröskel.FieldName = "Tröskel";
            this.colTröskel.Name = "colTröskel";
            this.colTröskel.Visible = true;
            this.colTröskel.VisibleIndex = 25;
            // 
            // colHängning
            // 
            this.colHängning.FieldName = "Hängning";
            this.colHängning.Name = "colHängning";
            this.colHängning.Visible = true;
            this.colHängning.VisibleIndex = 26;
            // 
            // colLjud
            // 
            this.colLjud.FieldName = "Ljud";
            this.colLjud.Name = "colLjud";
            this.colLjud.Visible = true;
            this.colLjud.VisibleIndex = 27;
            // 
            // colBrand
            // 
            this.colBrand.FieldName = "Brand";
            this.colBrand.Name = "colBrand";
            this.colBrand.Visible = true;
            this.colBrand.VisibleIndex = 28;
            // 
            // colVärme
            // 
            this.colVärme.FieldName = "Värme";
            this.colVärme.Name = "colVärme";
            this.colVärme.Visible = true;
            this.colVärme.VisibleIndex = 29;
            // 
            // colBad
            // 
            this.colBad.FieldName = "Bad";
            this.colBad.Name = "colBad";
            this.colBad.Visible = true;
            this.colBad.VisibleIndex = 30;
            // 
            // colSäkerhet
            // 
            this.colSäkerhet.FieldName = "Säkerhet";
            this.colSäkerhet.Name = "colSäkerhet";
            this.colSäkerhet.Visible = true;
            this.colSäkerhet.VisibleIndex = 31;
            // 
            // colDörrkik
            // 
            this.colDörrkik.FieldName = "Dörrkik";
            this.colDörrkik.Name = "colDörrkik";
            this.colDörrkik.Visible = true;
            this.colDörrkik.VisibleIndex = 32;
            // 
            // colInbrott
            // 
            this.colInbrott.FieldName = "Inbrott";
            this.colInbrott.Name = "colInbrott";
            this.colInbrott.Visible = true;
            this.colInbrott.VisibleIndex = 33;
            // 
            // colEl
            // 
            this.colEl.FieldName = "El";
            this.colEl.Name = "colEl";
            this.colEl.Visible = true;
            this.colEl.VisibleIndex = 34;
            // 
            // colBröstningfönster
            // 
            this.colBröstningfönster.FieldName = "Bröstning fönster";
            this.colBröstningfönster.Name = "colBröstningfönster";
            this.colBröstningfönster.Visible = true;
            this.colBröstningfönster.VisibleIndex = 35;
            // 
            // colSpecialpris
            // 
            this.colSpecialpris.FieldName = "Specialpris";
            this.colSpecialpris.Name = "colSpecialpris";
            this.colSpecialpris.Visible = true;
            this.colSpecialpris.VisibleIndex = 36;
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
            // mängderTableAdapter
            // 
            this.mängderTableAdapter.ClearBeforeFill = true;
            // 
            // Quantity
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
            this.Name = "Quantity";
            this.Text = "Quantity";
            this.Load += new System.EventHandler(this.Quantity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mängderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spaceM2Dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.flpEditButtons.ResumeLayout(false);
            this.EditButtonsPanel.ResumeLayout(false);
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
        private System.Windows.Forms.BindingSource mängderBindingSource;
        private SpaceM2DatasetTableAdapters.MängderTableAdapter mängderTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colOrdernummer;
        private DevExpress.XtraGrid.Columns.GridColumn colModulnummer;
        private DevExpress.XtraGrid.Columns.GridColumn colArtikelnummer;
        private DevExpress.XtraGrid.Columns.GridColumn colKommentar;
        private DevExpress.XtraGrid.Columns.GridColumn colLängd;
        private DevExpress.XtraGrid.Columns.GridColumn colBredd;
        private DevExpress.XtraGrid.Columns.GridColumn colEnhet;
        private DevExpress.XtraGrid.Columns.GridColumn colAntal;
        private DevExpress.XtraGrid.Columns.GridColumn colOmräkning;
        private DevExpress.XtraGrid.Columns.GridColumn colInköpradkr;
        private DevExpress.XtraGrid.Columns.GridColumn colBehovimodul;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colTyp;
        private DevExpress.XtraGrid.Columns.GridColumn colFyllning;
        private DevExpress.XtraGrid.Columns.GridColumn colBredd1;
        private DevExpress.XtraGrid.Columns.GridColumn colHöjd;
        private DevExpress.XtraGrid.Columns.GridColumn colDörrblad;
        private DevExpress.XtraGrid.Columns.GridColumn colGlas;
        private DevExpress.XtraGrid.Columns.GridColumn colGångjärn;
        private DevExpress.XtraGrid.Columns.GridColumn colLåskista;
        private DevExpress.XtraGrid.Columns.GridColumn colSlutbleck;
        private DevExpress.XtraGrid.Columns.GridColumn colKulördörrblad;
        private DevExpress.XtraGrid.Columns.GridColumn colKulörkarm;
        private DevExpress.XtraGrid.Columns.GridColumn colKarmdjup;
        private DevExpress.XtraGrid.Columns.GridColumn colTröskel;
        private DevExpress.XtraGrid.Columns.GridColumn colHängning;
        private DevExpress.XtraGrid.Columns.GridColumn colLjud;
        private DevExpress.XtraGrid.Columns.GridColumn colBrand;
        private DevExpress.XtraGrid.Columns.GridColumn colVärme;
        private DevExpress.XtraGrid.Columns.GridColumn colBad;
        private DevExpress.XtraGrid.Columns.GridColumn colSäkerhet;
        private DevExpress.XtraGrid.Columns.GridColumn colDörrkik;
        private DevExpress.XtraGrid.Columns.GridColumn colInbrott;
        private DevExpress.XtraGrid.Columns.GridColumn colEl;
        private DevExpress.XtraGrid.Columns.GridColumn colBröstningfönster;
        private DevExpress.XtraGrid.Columns.GridColumn colSpecialpris;
    }
}