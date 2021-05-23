
namespace FactoryManager.View.GridView.ActivityView
{
    partial class ModuleTypeWall
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModuleTypeWall));
            this.FooterPanel = new System.Windows.Forms.Panel();
            this.DeleteRow = new FontAwesome.Sharp.IconButton();
            this.EditRow = new FontAwesome.Sharp.IconButton();
            this.AddRow = new FontAwesome.Sharp.IconButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colVägg_Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVäggsnummer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModultypsnummer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModultypsbeskrivning = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVäggtypsnummer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVäggtypsbeskrivning = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLängd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRitningsdatum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRitningsnummer = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.colVägg_Id,
            this.colVäggsnummer,
            this.colModultypsnummer,
            this.colModultypsbeskrivning,
            this.colVäggtypsnummer,
            this.colVäggtypsbeskrivning,
            this.colLängd,
            this.colRitningsdatum,
            this.colRitningsnummer});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colVägg_Id
            // 
            this.colVägg_Id.FieldName = "Vägg_Id";
            this.colVägg_Id.Name = "colVägg_Id";
            this.colVägg_Id.Visible = true;
            this.colVägg_Id.VisibleIndex = 0;
            // 
            // colVäggsnummer
            // 
            this.colVäggsnummer.FieldName = "Väggsnummer";
            this.colVäggsnummer.Name = "colVäggsnummer";
            this.colVäggsnummer.Visible = true;
            this.colVäggsnummer.VisibleIndex = 1;
            // 
            // colModultypsnummer
            // 
            this.colModultypsnummer.FieldName = "Modultypsnummer";
            this.colModultypsnummer.Name = "colModultypsnummer";
            this.colModultypsnummer.Visible = true;
            this.colModultypsnummer.VisibleIndex = 2;
            // 
            // colModultypsbeskrivning
            // 
            this.colModultypsbeskrivning.FieldName = "Modultypsbeskrivning";
            this.colModultypsbeskrivning.Name = "colModultypsbeskrivning";
            this.colModultypsbeskrivning.Visible = true;
            this.colModultypsbeskrivning.VisibleIndex = 3;
            // 
            // colVäggtypsnummer
            // 
            this.colVäggtypsnummer.FieldName = "Väggtypsnummer";
            this.colVäggtypsnummer.Name = "colVäggtypsnummer";
            this.colVäggtypsnummer.Visible = true;
            this.colVäggtypsnummer.VisibleIndex = 4;
            // 
            // colVäggtypsbeskrivning
            // 
            this.colVäggtypsbeskrivning.FieldName = "Väggtypsbeskrivning";
            this.colVäggtypsbeskrivning.Name = "colVäggtypsbeskrivning";
            this.colVäggtypsbeskrivning.Visible = true;
            this.colVäggtypsbeskrivning.VisibleIndex = 5;
            // 
            // colLängd
            // 
            this.colLängd.FieldName = "Längd";
            this.colLängd.Name = "colLängd";
            this.colLängd.Visible = true;
            this.colLängd.VisibleIndex = 6;
            // 
            // colRitningsdatum
            // 
            this.colRitningsdatum.FieldName = "Ritningsdatum";
            this.colRitningsdatum.Name = "colRitningsdatum";
            this.colRitningsdatum.Visible = true;
            this.colRitningsdatum.VisibleIndex = 7;
            // 
            // colRitningsnummer
            // 
            this.colRitningsnummer.FieldName = "Ritningsnummer";
            this.colRitningsnummer.Name = "colRitningsnummer";
            this.colRitningsnummer.Visible = true;
            this.colRitningsnummer.VisibleIndex = 8;
            // 
            // ModuleTypeWall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1150, 680);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.FooterPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModuleTypeWall";
            this.Text = "ModuleTypeWall";
            this.Load += new System.EventHandler(this.ModuleTypeWall_Load);
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
        private DevExpress.XtraGrid.Columns.GridColumn colVägg_Id;
        private DevExpress.XtraGrid.Columns.GridColumn colVäggsnummer;
        private DevExpress.XtraGrid.Columns.GridColumn colModultypsnummer;
        private DevExpress.XtraGrid.Columns.GridColumn colModultypsbeskrivning;
        private DevExpress.XtraGrid.Columns.GridColumn colVäggtypsnummer;
        private DevExpress.XtraGrid.Columns.GridColumn colVäggtypsbeskrivning;
        private DevExpress.XtraGrid.Columns.GridColumn colLängd;
        private DevExpress.XtraGrid.Columns.GridColumn colRitningsdatum;
        private DevExpress.XtraGrid.Columns.GridColumn colRitningsnummer;
    }
}