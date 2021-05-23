
namespace FactoryManager.View.GridView.ActivityView
{
    partial class Supplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Supplier));
            this.FooterPanel = new System.Windows.Forms.Panel();
            this.DeleteRow = new FontAwesome.Sharp.IconButton();
            this.EditRow = new FontAwesome.Sharp.IconButton();
            this.AddRow = new FontAwesome.Sharp.IconButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLeverantörsnummer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLeverantörsnamn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTyp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrgnummer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrdermail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPostnummer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBankgironummer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKonto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLedtid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKredittid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReferens = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.FooterPanel.TabIndex = 73;
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
            this.gridControl1.TabIndex = 74;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colLeverantörsnummer,
            this.colLeverantörsnamn,
            this.colTyp,
            this.colOrgnummer,
            this.colTelefon,
            this.colMail,
            this.colOrdermail,
            this.colAdress,
            this.colPostnummer,
            this.colOrt,
            this.colBankgironummer,
            this.colKonto,
            this.colLedtid,
            this.colKredittid,
            this.colReferens});
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
            // colLeverantörsnummer
            // 
            this.colLeverantörsnummer.FieldName = "Leverantörsnummer";
            this.colLeverantörsnummer.Name = "colLeverantörsnummer";
            this.colLeverantörsnummer.Visible = true;
            this.colLeverantörsnummer.VisibleIndex = 1;
            // 
            // colLeverantörsnamn
            // 
            this.colLeverantörsnamn.FieldName = "Leverantörsnamn";
            this.colLeverantörsnamn.Name = "colLeverantörsnamn";
            this.colLeverantörsnamn.Visible = true;
            this.colLeverantörsnamn.VisibleIndex = 2;
            // 
            // colTyp
            // 
            this.colTyp.FieldName = "Typ";
            this.colTyp.Name = "colTyp";
            this.colTyp.Visible = true;
            this.colTyp.VisibleIndex = 3;
            // 
            // colOrgnummer
            // 
            this.colOrgnummer.FieldName = "Org nummer";
            this.colOrgnummer.Name = "colOrgnummer";
            this.colOrgnummer.Visible = true;
            this.colOrgnummer.VisibleIndex = 4;
            // 
            // colTelefon
            // 
            this.colTelefon.FieldName = "Telefon";
            this.colTelefon.Name = "colTelefon";
            this.colTelefon.Visible = true;
            this.colTelefon.VisibleIndex = 5;
            // 
            // colMail
            // 
            this.colMail.FieldName = "Mail";
            this.colMail.Name = "colMail";
            this.colMail.Visible = true;
            this.colMail.VisibleIndex = 6;
            // 
            // colOrdermail
            // 
            this.colOrdermail.FieldName = "Ordermail";
            this.colOrdermail.Name = "colOrdermail";
            this.colOrdermail.Visible = true;
            this.colOrdermail.VisibleIndex = 7;
            // 
            // colAdress
            // 
            this.colAdress.FieldName = "Adress";
            this.colAdress.Name = "colAdress";
            this.colAdress.Visible = true;
            this.colAdress.VisibleIndex = 8;
            // 
            // colPostnummer
            // 
            this.colPostnummer.FieldName = "Postnummer";
            this.colPostnummer.Name = "colPostnummer";
            this.colPostnummer.Visible = true;
            this.colPostnummer.VisibleIndex = 9;
            // 
            // colOrt
            // 
            this.colOrt.FieldName = "Ort";
            this.colOrt.Name = "colOrt";
            this.colOrt.Visible = true;
            this.colOrt.VisibleIndex = 10;
            // 
            // colBankgironummer
            // 
            this.colBankgironummer.FieldName = "Bankgironummer";
            this.colBankgironummer.Name = "colBankgironummer";
            this.colBankgironummer.Visible = true;
            this.colBankgironummer.VisibleIndex = 11;
            // 
            // colKonto
            // 
            this.colKonto.FieldName = "Konto";
            this.colKonto.Name = "colKonto";
            this.colKonto.Visible = true;
            this.colKonto.VisibleIndex = 12;
            // 
            // colLedtid
            // 
            this.colLedtid.FieldName = "Ledtid";
            this.colLedtid.Name = "colLedtid";
            this.colLedtid.Visible = true;
            this.colLedtid.VisibleIndex = 13;
            // 
            // colKredittid
            // 
            this.colKredittid.FieldName = "Kredittid";
            this.colKredittid.Name = "colKredittid";
            this.colKredittid.Visible = true;
            this.colKredittid.VisibleIndex = 14;
            // 
            // colReferens
            // 
            this.colReferens.FieldName = "Referens";
            this.colReferens.Name = "colReferens";
            this.colReferens.Visible = true;
            this.colReferens.VisibleIndex = 15;
            // 
            // Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1150, 680);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.FooterPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Supplier";
            this.Text = "Supplier";
            this.Load += new System.EventHandler(this.Supplier_Load);
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
        private DevExpress.XtraGrid.Columns.GridColumn colLeverantörsnummer;
        private DevExpress.XtraGrid.Columns.GridColumn colLeverantörsnamn;
        private DevExpress.XtraGrid.Columns.GridColumn colTyp;
        private DevExpress.XtraGrid.Columns.GridColumn colOrgnummer;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefon;
        private DevExpress.XtraGrid.Columns.GridColumn colMail;
        private DevExpress.XtraGrid.Columns.GridColumn colOrdermail;
        private DevExpress.XtraGrid.Columns.GridColumn colAdress;
        private DevExpress.XtraGrid.Columns.GridColumn colPostnummer;
        private DevExpress.XtraGrid.Columns.GridColumn colOrt;
        private DevExpress.XtraGrid.Columns.GridColumn colBankgironummer;
        private DevExpress.XtraGrid.Columns.GridColumn colKonto;
        private DevExpress.XtraGrid.Columns.GridColumn colLedtid;
        private DevExpress.XtraGrid.Columns.GridColumn colKredittid;
        private DevExpress.XtraGrid.Columns.GridColumn colReferens;
    }
}