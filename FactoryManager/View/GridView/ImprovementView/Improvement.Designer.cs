
namespace FactoryManager.View.GridView.ActivityView
{
    partial class Improvement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Improvement));
            this.FooterPanel = new System.Windows.Forms.Panel();
            this.DeleteRow = new FontAwesome.Sharp.IconButton();
            this.EditRow = new FontAwesome.Sharp.IconButton();
            this.AddRow = new FontAwesome.Sharp.IconButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProjekt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKategori = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDatum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUtfärdadav = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAvvikelse = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrsak = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colÅtgärdiprojektet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAnsvarig1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAvhjälpandedatum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAvvikelseslösning = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAnsvarig2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colÅtgärdatlångsiktigtdatum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVeckastart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVeckaslut = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.colProjekt,
            this.colKategori,
            this.colStatus,
            this.colDatum,
            this.colUtfärdadav,
            this.colAvvikelse,
            this.colOrsak,
            this.colÅtgärdiprojektet,
            this.colAnsvarig1,
            this.colAvhjälpandedatum,
            this.colAvvikelseslösning,
            this.colAnsvarig2,
            this.colÅtgärdatlångsiktigtdatum,
            this.colVeckastart,
            this.colVeckaslut});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colProjekt
            // 
            this.colProjekt.FieldName = "Projekt";
            this.colProjekt.Name = "colProjekt";
            this.colProjekt.Visible = true;
            this.colProjekt.VisibleIndex = 1;
            // 
            // colKategori
            // 
            this.colKategori.FieldName = "Kategori";
            this.colKategori.Name = "colKategori";
            this.colKategori.Visible = true;
            this.colKategori.VisibleIndex = 2;
            // 
            // colStatus
            // 
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 3;
            // 
            // colDatum
            // 
            this.colDatum.FieldName = "Datum";
            this.colDatum.Name = "colDatum";
            this.colDatum.Visible = true;
            this.colDatum.VisibleIndex = 4;
            // 
            // colUtfärdadav
            // 
            this.colUtfärdadav.FieldName = "Utfärdad av";
            this.colUtfärdadav.Name = "colUtfärdadav";
            this.colUtfärdadav.Visible = true;
            this.colUtfärdadav.VisibleIndex = 5;
            // 
            // colAvvikelse
            // 
            this.colAvvikelse.FieldName = "Avvikelse";
            this.colAvvikelse.Name = "colAvvikelse";
            this.colAvvikelse.Visible = true;
            this.colAvvikelse.VisibleIndex = 6;
            // 
            // colOrsak
            // 
            this.colOrsak.FieldName = "Orsak";
            this.colOrsak.Name = "colOrsak";
            this.colOrsak.Visible = true;
            this.colOrsak.VisibleIndex = 7;
            // 
            // colÅtgärdiprojektet
            // 
            this.colÅtgärdiprojektet.FieldName = "Åtgärd i projektet";
            this.colÅtgärdiprojektet.Name = "colÅtgärdiprojektet";
            this.colÅtgärdiprojektet.Visible = true;
            this.colÅtgärdiprojektet.VisibleIndex = 8;
            // 
            // colAnsvarig1
            // 
            this.colAnsvarig1.FieldName = "Ansvarig1";
            this.colAnsvarig1.Name = "colAnsvarig1";
            this.colAnsvarig1.Visible = true;
            this.colAnsvarig1.VisibleIndex = 9;
            // 
            // colAvhjälpandedatum
            // 
            this.colAvhjälpandedatum.FieldName = "Avhjälpande datum";
            this.colAvhjälpandedatum.Name = "colAvhjälpandedatum";
            this.colAvhjälpandedatum.Visible = true;
            this.colAvhjälpandedatum.VisibleIndex = 10;
            // 
            // colAvvikelseslösning
            // 
            this.colAvvikelseslösning.FieldName = "Avvikelseslösning";
            this.colAvvikelseslösning.Name = "colAvvikelseslösning";
            this.colAvvikelseslösning.Visible = true;
            this.colAvvikelseslösning.VisibleIndex = 11;
            // 
            // colAnsvarig2
            // 
            this.colAnsvarig2.FieldName = "Ansvarig2";
            this.colAnsvarig2.Name = "colAnsvarig2";
            this.colAnsvarig2.Visible = true;
            this.colAnsvarig2.VisibleIndex = 12;
            // 
            // colÅtgärdatlångsiktigtdatum
            // 
            this.colÅtgärdatlångsiktigtdatum.FieldName = "Åtgärdat långsiktigt datum";
            this.colÅtgärdatlångsiktigtdatum.Name = "colÅtgärdatlångsiktigtdatum";
            this.colÅtgärdatlångsiktigtdatum.Visible = true;
            this.colÅtgärdatlångsiktigtdatum.VisibleIndex = 13;
            // 
            // colVeckastart
            // 
            this.colVeckastart.FieldName = "Vecka start";
            this.colVeckastart.Name = "colVeckastart";
            this.colVeckastart.Visible = true;
            this.colVeckastart.VisibleIndex = 14;
            // 
            // colVeckaslut
            // 
            this.colVeckaslut.FieldName = "Vecka slut";
            this.colVeckaslut.Name = "colVeckaslut";
            this.colVeckaslut.Visible = true;
            this.colVeckaslut.VisibleIndex = 15;
            // 
            // Improvement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1150, 680);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.FooterPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Improvement";
            this.Text = "Improvement";
            this.Load += new System.EventHandler(this.Improvement_Load);
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
        private DevExpress.XtraGrid.Columns.GridColumn colProjekt;
        private DevExpress.XtraGrid.Columns.GridColumn colKategori;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colDatum;
        private DevExpress.XtraGrid.Columns.GridColumn colUtfärdadav;
        private DevExpress.XtraGrid.Columns.GridColumn colAvvikelse;
        private DevExpress.XtraGrid.Columns.GridColumn colOrsak;
        private DevExpress.XtraGrid.Columns.GridColumn colÅtgärdiprojektet;
        private DevExpress.XtraGrid.Columns.GridColumn colAnsvarig1;
        private DevExpress.XtraGrid.Columns.GridColumn colAvhjälpandedatum;
        private DevExpress.XtraGrid.Columns.GridColumn colAvvikelseslösning;
        private DevExpress.XtraGrid.Columns.GridColumn colAnsvarig2;
        private DevExpress.XtraGrid.Columns.GridColumn colÅtgärdatlångsiktigtdatum;
        private DevExpress.XtraGrid.Columns.GridColumn colVeckastart;
        private DevExpress.XtraGrid.Columns.GridColumn colVeckaslut;
    }
}