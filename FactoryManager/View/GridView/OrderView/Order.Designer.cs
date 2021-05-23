
namespace FactoryManager.View.GridView.ActivityView
{
    partial class Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
            this.FooterPanel = new System.Windows.Forms.Panel();
            this.DeleteRow = new FontAwesome.Sharp.IconButton();
            this.EditRow = new FontAwesome.Sharp.IconButton();
            this.AddRow = new FontAwesome.Sharp.IconButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrdernummer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProjektnummer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAnställdnummer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLeverantörsnummer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLeveransadressnummer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKommentar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderdatum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colÖnskatdatpåplats = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBekrdagpåplats = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBehoverdag = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFakturadatum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFakturanummer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAnkomstdatum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFörtydligantillbeställning = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGarantikontrolleradenligtavtal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAvtal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colANSVAR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFaktureratbelopp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKALKYL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FooterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // FooterPanel
            // 
            this.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.FooterPanel.Controls.Add(this.DeleteRow);
            this.FooterPanel.Controls.Add(this.EditRow);
            this.FooterPanel.Controls.Add(this.AddRow);
            this.FooterPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FooterPanel.Location = new System.Drawing.Point(0, 620);
            this.FooterPanel.Name = "FooterPanel";
            this.FooterPanel.Padding = new System.Windows.Forms.Padding(10);
            this.FooterPanel.Size = new System.Drawing.Size(1150, 60);
            this.FooterPanel.TabIndex = 72;
            // 
            // DeleteRow
            // 
            this.DeleteRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.DeleteRow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteRow.Dock = System.Windows.Forms.DockStyle.Right;
            this.DeleteRow.FlatAppearance.BorderSize = 0;
            this.DeleteRow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.DeleteRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteRow.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DeleteRow.ForeColor = System.Drawing.Color.White;
            this.DeleteRow.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.DeleteRow.IconColor = System.Drawing.Color.White;
            this.DeleteRow.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DeleteRow.IconSize = 23;
            this.DeleteRow.Location = new System.Drawing.Point(1025, 10);
            this.DeleteRow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteRow.Name = "DeleteRow";
            this.DeleteRow.Size = new System.Drawing.Size(115, 40);
            this.DeleteRow.TabIndex = 23;
            this.DeleteRow.Text = "REDIGERA";
            this.DeleteRow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeleteRow.UseVisualStyleBackColor = false;
            // 
            // EditRow
            // 
            this.EditRow.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.EditRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
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
            this.EditRow.Location = new System.Drawing.Point(518, 12);
            this.EditRow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditRow.Name = "EditRow";
            this.EditRow.Size = new System.Drawing.Size(115, 40);
            this.EditRow.TabIndex = 22;
            this.EditRow.Text = "REDIGERA";
            this.EditRow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EditRow.UseVisualStyleBackColor = false;
            // 
            // AddRow
            // 
            this.AddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
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
            this.AddRow.Location = new System.Drawing.Point(10, 10);
            this.AddRow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddRow.Name = "AddRow";
            this.AddRow.Size = new System.Drawing.Size(115, 40);
            this.AddRow.TabIndex = 21;
            this.AddRow.Text = "LÄGG TILL NY";
            this.AddRow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddRow.UseVisualStyleBackColor = false;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1150, 620);
            this.gridControl1.TabIndex = 73;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colOrdernummer,
            this.colProjektnummer,
            this.colAnställdnummer,
            this.colLeverantörsnummer,
            this.colLeveransadressnummer,
            this.colStatus,
            this.colKommentar,
            this.colOrderdatum,
            this.colÖnskatdatpåplats,
            this.colBekrdagpåplats,
            this.colBehoverdag,
            this.colFakturadatum,
            this.colFakturanummer,
            this.colAnkomstdatum,
            this.colFörtydligantillbeställning,
            this.colGarantikontrolleradenligtavtal,
            this.colAvtal,
            this.colANSVAR,
            this.colFaktureratbelopp,
            this.colKALKYL});
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
            // colProjektnummer
            // 
            this.colProjektnummer.FieldName = "Projektnummer";
            this.colProjektnummer.Name = "colProjektnummer";
            this.colProjektnummer.Visible = true;
            this.colProjektnummer.VisibleIndex = 2;
            // 
            // colAnställdnummer
            // 
            this.colAnställdnummer.FieldName = "Anställdnummer";
            this.colAnställdnummer.Name = "colAnställdnummer";
            this.colAnställdnummer.Visible = true;
            this.colAnställdnummer.VisibleIndex = 3;
            // 
            // colLeverantörsnummer
            // 
            this.colLeverantörsnummer.FieldName = "Leverantörsnummer";
            this.colLeverantörsnummer.Name = "colLeverantörsnummer";
            this.colLeverantörsnummer.Visible = true;
            this.colLeverantörsnummer.VisibleIndex = 4;
            // 
            // colLeveransadressnummer
            // 
            this.colLeveransadressnummer.FieldName = "Leveransadressnummer";
            this.colLeveransadressnummer.Name = "colLeveransadressnummer";
            this.colLeveransadressnummer.Visible = true;
            this.colLeveransadressnummer.VisibleIndex = 5;
            // 
            // colStatus
            // 
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 6;
            // 
            // colKommentar
            // 
            this.colKommentar.FieldName = "Kommentar";
            this.colKommentar.Name = "colKommentar";
            this.colKommentar.Visible = true;
            this.colKommentar.VisibleIndex = 7;
            // 
            // colOrderdatum
            // 
            this.colOrderdatum.FieldName = "Order datum";
            this.colOrderdatum.Name = "colOrderdatum";
            this.colOrderdatum.Visible = true;
            this.colOrderdatum.VisibleIndex = 8;
            // 
            // colÖnskatdatpåplats
            // 
            this.colÖnskatdatpåplats.FieldName = "Önskat dat på plats";
            this.colÖnskatdatpåplats.Name = "colÖnskatdatpåplats";
            this.colÖnskatdatpåplats.Visible = true;
            this.colÖnskatdatpåplats.VisibleIndex = 9;
            // 
            // colBekrdagpåplats
            // 
            this.colBekrdagpåplats.FieldName = "Bekr dag på plats";
            this.colBekrdagpåplats.Name = "colBekrdagpåplats";
            this.colBekrdagpåplats.Visible = true;
            this.colBekrdagpåplats.VisibleIndex = 10;
            // 
            // colBehoverdag
            // 
            this.colBehoverdag.FieldName = "Behover dag";
            this.colBehoverdag.Name = "colBehoverdag";
            this.colBehoverdag.Visible = true;
            this.colBehoverdag.VisibleIndex = 11;
            // 
            // colFakturadatum
            // 
            this.colFakturadatum.FieldName = "Fakturadatum";
            this.colFakturadatum.Name = "colFakturadatum";
            this.colFakturadatum.Visible = true;
            this.colFakturadatum.VisibleIndex = 12;
            // 
            // colFakturanummer
            // 
            this.colFakturanummer.FieldName = "Fakturanummer";
            this.colFakturanummer.Name = "colFakturanummer";
            this.colFakturanummer.Visible = true;
            this.colFakturanummer.VisibleIndex = 13;
            // 
            // colAnkomstdatum
            // 
            this.colAnkomstdatum.FieldName = "Ankomst datum";
            this.colAnkomstdatum.Name = "colAnkomstdatum";
            this.colAnkomstdatum.Visible = true;
            this.colAnkomstdatum.VisibleIndex = 14;
            // 
            // colFörtydligantillbeställning
            // 
            this.colFörtydligantillbeställning.FieldName = "Förtydligan till beställning";
            this.colFörtydligantillbeställning.Name = "colFörtydligantillbeställning";
            this.colFörtydligantillbeställning.Visible = true;
            this.colFörtydligantillbeställning.VisibleIndex = 15;
            // 
            // colGarantikontrolleradenligtavtal
            // 
            this.colGarantikontrolleradenligtavtal.FieldName = "Garanti kontrollerad enligt avtal";
            this.colGarantikontrolleradenligtavtal.Name = "colGarantikontrolleradenligtavtal";
            this.colGarantikontrolleradenligtavtal.Visible = true;
            this.colGarantikontrolleradenligtavtal.VisibleIndex = 16;
            // 
            // colAvtal
            // 
            this.colAvtal.FieldName = "Avtal";
            this.colAvtal.Name = "colAvtal";
            this.colAvtal.Visible = true;
            this.colAvtal.VisibleIndex = 17;
            // 
            // colANSVAR
            // 
            this.colANSVAR.FieldName = "ANSVAR";
            this.colANSVAR.Name = "colANSVAR";
            this.colANSVAR.Visible = true;
            this.colANSVAR.VisibleIndex = 18;
            // 
            // colFaktureratbelopp
            // 
            this.colFaktureratbelopp.FieldName = "Fakturerat belopp";
            this.colFaktureratbelopp.Name = "colFaktureratbelopp";
            this.colFaktureratbelopp.Visible = true;
            this.colFaktureratbelopp.VisibleIndex = 19;
            // 
            // colKALKYL
            // 
            this.colKALKYL.FieldName = "KALKYL";
            this.colKALKYL.Name = "colKALKYL";
            this.colKALKYL.Visible = true;
            this.colKALKYL.VisibleIndex = 20;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1150, 680);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.FooterPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Order";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            this.FooterPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel FooterPanel;
        private FontAwesome.Sharp.IconButton DeleteRow;
        private FontAwesome.Sharp.IconButton EditRow;
        private FontAwesome.Sharp.IconButton AddRow;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colOrdernummer;
        private DevExpress.XtraGrid.Columns.GridColumn colProjektnummer;
        private DevExpress.XtraGrid.Columns.GridColumn colAnställdnummer;
        private DevExpress.XtraGrid.Columns.GridColumn colLeverantörsnummer;
        private DevExpress.XtraGrid.Columns.GridColumn colLeveransadressnummer;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colKommentar;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderdatum;
        private DevExpress.XtraGrid.Columns.GridColumn colÖnskatdatpåplats;
        private DevExpress.XtraGrid.Columns.GridColumn colBekrdagpåplats;
        private DevExpress.XtraGrid.Columns.GridColumn colBehoverdag;
        private DevExpress.XtraGrid.Columns.GridColumn colFakturadatum;
        private DevExpress.XtraGrid.Columns.GridColumn colFakturanummer;
        private DevExpress.XtraGrid.Columns.GridColumn colAnkomstdatum;
        private DevExpress.XtraGrid.Columns.GridColumn colFörtydligantillbeställning;
        private DevExpress.XtraGrid.Columns.GridColumn colGarantikontrolleradenligtavtal;
        private DevExpress.XtraGrid.Columns.GridColumn colAvtal;
        private DevExpress.XtraGrid.Columns.GridColumn colANSVAR;
        private DevExpress.XtraGrid.Columns.GridColumn colFaktureratbelopp;
        private DevExpress.XtraGrid.Columns.GridColumn colKALKYL;
    }
}