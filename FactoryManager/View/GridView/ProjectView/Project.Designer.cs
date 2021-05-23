
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
            this.FooterPanel = new System.Windows.Forms.Panel();
            this.DeleteRow = new FontAwesome.Sharp.IconButton();
            this.EditRow = new FontAwesome.Sharp.IconButton();
            this.AddRow = new FontAwesome.Sharp.IconButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProjektnummer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProjektnamn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProjektstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBeskrivning = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKundnamn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKommun = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.FooterPanel.Location = new System.Drawing.Point(0, 492);
            this.FooterPanel.Name = "FooterPanel";
            this.FooterPanel.Padding = new System.Windows.Forms.Padding(10);
            this.FooterPanel.Size = new System.Drawing.Size(986, 60);
            this.FooterPanel.TabIndex = 71;
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
            this.DeleteRow.Location = new System.Drawing.Point(861, 10);
            this.DeleteRow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteRow.Name = "DeleteRow";
            this.DeleteRow.Size = new System.Drawing.Size(115, 40);
            this.DeleteRow.TabIndex = 23;
            this.DeleteRow.Text = "REDIGERA";
            this.DeleteRow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeleteRow.UseVisualStyleBackColor = false;
            this.DeleteRow.Click += new System.EventHandler(this.DeleteRow_Click);
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
            this.EditRow.Location = new System.Drawing.Point(436, 12);
            this.EditRow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditRow.Name = "EditRow";
            this.EditRow.Size = new System.Drawing.Size(115, 40);
            this.EditRow.TabIndex = 22;
            this.EditRow.Text = "REDIGERA";
            this.EditRow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EditRow.UseVisualStyleBackColor = false;
            this.EditRow.Click += new System.EventHandler(this.EditRow_Click);
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
            this.AddRow.Click += new System.EventHandler(this.AddRow_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(986, 492);
            this.gridControl1.TabIndex = 75;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            this.gridView1.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
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
            // Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 552);
            this.ControlBox = false;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.FooterPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Project";
            this.Opacity = 0D;
            this.Load += new System.EventHandler(this.Project_Load);
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
        private DevExpress.XtraGrid.Columns.GridColumn colProjektnummer;
        private DevExpress.XtraGrid.Columns.GridColumn colProjektnamn;
        private DevExpress.XtraGrid.Columns.GridColumn colProjektstatus;
        private DevExpress.XtraGrid.Columns.GridColumn colBeskrivning;
        private DevExpress.XtraGrid.Columns.GridColumn colKundnamn;
        private DevExpress.XtraGrid.Columns.GridColumn colKommun;
    }
}