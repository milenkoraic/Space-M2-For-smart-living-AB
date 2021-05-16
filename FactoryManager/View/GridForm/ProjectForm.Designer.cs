
namespace FactoryManager.View.GridForm
{
    partial class ProjectForm
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label kundLabel;
            System.Windows.Forms.Label projektLabel;
            System.Windows.Forms.Label proj_nrLabel;
            System.Windows.Forms.Label beskrivningLabel;
            System.Windows.Forms.Label kommunLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectForm));
            this.flpButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.InsertContinue = new FontAwesome.Sharp.IconButton();
            this.InsertClose = new FontAwesome.Sharp.IconButton();
            this.SaveChanges = new FontAwesome.Sharp.IconButton();
            this.InsertationPanel = new System.Windows.Forms.Panel();
            this.cboProjectStatus = new System.Windows.Forms.ComboBox();
            this.tboxProjectId = new System.Windows.Forms.TextBox();
            this.tboxProjectNumber = new System.Windows.Forms.TextBox();
            this.tboxProjectName = new System.Windows.Forms.TextBox();
            this.tboxCustomer = new System.Windows.Forms.TextBox();
            this.tboxMunicipality = new System.Windows.Forms.TextBox();
            this.tboxDescription = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            kundLabel = new System.Windows.Forms.Label();
            projektLabel = new System.Windows.Forms.Label();
            proj_nrLabel = new System.Windows.Forms.Label();
            beskrivningLabel = new System.Windows.Forms.Label();
            kommunLabel = new System.Windows.Forms.Label();
            this.flpButtons.SuspendLayout();
            this.InsertationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(26, 16);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(25, 18);
            label1.TabIndex = 124;
            label1.Text = "ID:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.BackColor = System.Drawing.Color.Transparent;
            statusLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            statusLabel.ForeColor = System.Drawing.Color.White;
            statusLabel.Location = new System.Drawing.Point(232, 16);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(50, 18);
            statusLabel.TabIndex = 114;
            statusLabel.Text = "Status:";
            statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // kundLabel
            // 
            kundLabel.AutoSize = true;
            kundLabel.BackColor = System.Drawing.Color.Transparent;
            kundLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            kundLabel.ForeColor = System.Drawing.Color.White;
            kundLabel.Location = new System.Drawing.Point(468, 16);
            kundLabel.Name = "kundLabel";
            kundLabel.Size = new System.Drawing.Size(44, 18);
            kundLabel.TabIndex = 107;
            kundLabel.Text = "Kund:";
            kundLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // projektLabel
            // 
            projektLabel.AutoSize = true;
            projektLabel.BackColor = System.Drawing.Color.Transparent;
            projektLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            projektLabel.ForeColor = System.Drawing.Color.White;
            projektLabel.Location = new System.Drawing.Point(23, 82);
            projektLabel.Name = "projektLabel";
            projektLabel.Size = new System.Drawing.Size(95, 18);
            projektLabel.TabIndex = 106;
            projektLabel.Text = "Projekt namn:";
            projektLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // proj_nrLabel
            // 
            proj_nrLabel.AutoSize = true;
            proj_nrLabel.BackColor = System.Drawing.Color.Transparent;
            proj_nrLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            proj_nrLabel.ForeColor = System.Drawing.Color.White;
            proj_nrLabel.Location = new System.Drawing.Point(125, 16);
            proj_nrLabel.Name = "proj_nrLabel";
            proj_nrLabel.Size = new System.Drawing.Size(53, 18);
            proj_nrLabel.TabIndex = 111;
            proj_nrLabel.Text = "Proj nr:";
            proj_nrLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // beskrivningLabel
            // 
            beskrivningLabel.AutoSize = true;
            beskrivningLabel.BackColor = System.Drawing.Color.Transparent;
            beskrivningLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            beskrivningLabel.ForeColor = System.Drawing.Color.White;
            beskrivningLabel.Location = new System.Drawing.Point(26, 148);
            beskrivningLabel.Name = "beskrivningLabel";
            beskrivningLabel.Size = new System.Drawing.Size(84, 18);
            beskrivningLabel.TabIndex = 109;
            beskrivningLabel.Text = "Beskrivning:";
            beskrivningLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // kommunLabel
            // 
            kommunLabel.AutoSize = true;
            kommunLabel.BackColor = System.Drawing.Color.Transparent;
            kommunLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            kommunLabel.ForeColor = System.Drawing.Color.White;
            kommunLabel.Location = new System.Drawing.Point(468, 82);
            kommunLabel.Name = "kommunLabel";
            kommunLabel.Size = new System.Drawing.Size(68, 18);
            kommunLabel.TabIndex = 108;
            kommunLabel.Text = "Kommun:";
            kommunLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flpButtons
            // 
            this.flpButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.flpButtons.Controls.Add(this.InsertContinue);
            this.flpButtons.Controls.Add(this.InsertClose);
            this.flpButtons.Controls.Add(this.SaveChanges);
            this.flpButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpButtons.Location = new System.Drawing.Point(0, 295);
            this.flpButtons.Name = "flpButtons";
            this.flpButtons.Padding = new System.Windows.Forms.Padding(25, 17, 17, 17);
            this.flpButtons.Size = new System.Drawing.Size(1150, 90);
            this.flpButtons.TabIndex = 125;
            // 
            // InsertContinue
            // 
            this.InsertContinue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.InsertContinue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(170)))), ((int)(((byte)(72)))));
            this.InsertContinue.FlatAppearance.BorderSize = 0;
            this.InsertContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsertContinue.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.InsertContinue.ForeColor = System.Drawing.Color.White;
            this.InsertContinue.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.InsertContinue.IconColor = System.Drawing.Color.White;
            this.InsertContinue.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.InsertContinue.IconSize = 25;
            this.InsertContinue.Location = new System.Drawing.Point(28, 20);
            this.InsertContinue.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.InsertContinue.Name = "InsertContinue";
            this.InsertContinue.Size = new System.Drawing.Size(191, 50);
            this.InsertContinue.TabIndex = 6;
            this.InsertContinue.TabStop = false;
            this.InsertContinue.Text = "SPARA | FORTSÄTTA";
            this.InsertContinue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.InsertContinue.UseVisualStyleBackColor = false;
            // 
            // InsertClose
            // 
            this.InsertClose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.InsertClose.BackColor = System.Drawing.Color.Goldenrod;
            this.InsertClose.FlatAppearance.BorderSize = 0;
            this.InsertClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsertClose.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.InsertClose.ForeColor = System.Drawing.Color.White;
            this.InsertClose.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.InsertClose.IconColor = System.Drawing.Color.White;
            this.InsertClose.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.InsertClose.IconSize = 25;
            this.InsertClose.Location = new System.Drawing.Point(232, 20);
            this.InsertClose.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.InsertClose.Name = "InsertClose";
            this.InsertClose.Size = new System.Drawing.Size(191, 50);
            this.InsertClose.TabIndex = 7;
            this.InsertClose.TabStop = false;
            this.InsertClose.Text = "SPARA | STÄNG";
            this.InsertClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.InsertClose.UseVisualStyleBackColor = false;
            // 
            // SaveChanges
            // 
            this.SaveChanges.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SaveChanges.BackColor = System.Drawing.Color.DarkOrange;
            this.SaveChanges.FlatAppearance.BorderSize = 0;
            this.SaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveChanges.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SaveChanges.ForeColor = System.Drawing.Color.White;
            this.SaveChanges.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.SaveChanges.IconColor = System.Drawing.Color.White;
            this.SaveChanges.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.SaveChanges.IconSize = 25;
            this.SaveChanges.Location = new System.Drawing.Point(436, 20);
            this.SaveChanges.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.SaveChanges.Name = "SaveChanges";
            this.SaveChanges.Size = new System.Drawing.Size(191, 50);
            this.SaveChanges.TabIndex = 9;
            this.SaveChanges.TabStop = false;
            this.SaveChanges.Text = "SPARA | STÄNG";
            this.SaveChanges.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SaveChanges.UseVisualStyleBackColor = false;
            // 
            // InsertationPanel
            // 
            this.InsertationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.InsertationPanel.Controls.Add(label1);
            this.InsertationPanel.Controls.Add(statusLabel);
            this.InsertationPanel.Controls.Add(this.cboProjectStatus);
            this.InsertationPanel.Controls.Add(this.tboxProjectId);
            this.InsertationPanel.Controls.Add(this.tboxProjectNumber);
            this.InsertationPanel.Controls.Add(this.tboxProjectName);
            this.InsertationPanel.Controls.Add(kundLabel);
            this.InsertationPanel.Controls.Add(projektLabel);
            this.InsertationPanel.Controls.Add(this.tboxCustomer);
            this.InsertationPanel.Controls.Add(proj_nrLabel);
            this.InsertationPanel.Controls.Add(this.tboxMunicipality);
            this.InsertationPanel.Controls.Add(beskrivningLabel);
            this.InsertationPanel.Controls.Add(kommunLabel);
            this.InsertationPanel.Controls.Add(this.tboxDescription);
            this.InsertationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InsertationPanel.Location = new System.Drawing.Point(0, 0);
            this.InsertationPanel.Name = "InsertationPanel";
            this.InsertationPanel.Size = new System.Drawing.Size(1150, 295);
            this.InsertationPanel.TabIndex = 127;
            // 
            // cboProjectStatus
            // 
            this.cboProjectStatus.BackColor = System.Drawing.Color.White;
            this.cboProjectStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboProjectStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProjectStatus.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cboProjectStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cboProjectStatus.FormattingEnabled = true;
            this.cboProjectStatus.Items.AddRange(new object[] {
            "Pågående",
            "Avslutat"});
            this.cboProjectStatus.Location = new System.Drawing.Point(235, 43);
            this.cboProjectStatus.Name = "cboProjectStatus";
            this.cboProjectStatus.Size = new System.Drawing.Size(207, 36);
            this.cboProjectStatus.TabIndex = 115;
            // 
            // tboxProjectId
            // 
            this.tboxProjectId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tboxProjectId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboxProjectId.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tboxProjectId.ForeColor = System.Drawing.Color.White;
            this.tboxProjectId.Location = new System.Drawing.Point(23, 43);
            this.tboxProjectId.Margin = new System.Windows.Forms.Padding(5);
            this.tboxProjectId.Multiline = true;
            this.tboxProjectId.Name = "tboxProjectId";
            this.tboxProjectId.ReadOnly = true;
            this.tboxProjectId.Size = new System.Drawing.Size(84, 30);
            this.tboxProjectId.TabIndex = 123;
            this.tboxProjectId.TabStop = false;
            // 
            // tboxProjectNumber
            // 
            this.tboxProjectNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tboxProjectNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboxProjectNumber.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tboxProjectNumber.ForeColor = System.Drawing.Color.White;
            this.tboxProjectNumber.Location = new System.Drawing.Point(128, 43);
            this.tboxProjectNumber.Margin = new System.Windows.Forms.Padding(5);
            this.tboxProjectNumber.Multiline = true;
            this.tboxProjectNumber.Name = "tboxProjectNumber";
            this.tboxProjectNumber.ReadOnly = true;
            this.tboxProjectNumber.Size = new System.Drawing.Size(84, 30);
            this.tboxProjectNumber.TabIndex = 110;
            this.tboxProjectNumber.TabStop = false;
            // 
            // tboxProjectName
            // 
            this.tboxProjectName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tboxProjectName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboxProjectName.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tboxProjectName.ForeColor = System.Drawing.Color.White;
            this.tboxProjectName.Location = new System.Drawing.Point(23, 109);
            this.tboxProjectName.Margin = new System.Windows.Forms.Padding(5);
            this.tboxProjectName.Multiline = true;
            this.tboxProjectName.Name = "tboxProjectName";
            this.tboxProjectName.Size = new System.Drawing.Size(419, 30);
            this.tboxProjectName.TabIndex = 102;
            this.tboxProjectName.TabStop = false;
            // 
            // tboxCustomer
            // 
            this.tboxCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tboxCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboxCustomer.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tboxCustomer.ForeColor = System.Drawing.Color.White;
            this.tboxCustomer.Location = new System.Drawing.Point(468, 43);
            this.tboxCustomer.Margin = new System.Windows.Forms.Padding(5);
            this.tboxCustomer.Multiline = true;
            this.tboxCustomer.Name = "tboxCustomer";
            this.tboxCustomer.Size = new System.Drawing.Size(419, 30);
            this.tboxCustomer.TabIndex = 103;
            this.tboxCustomer.TabStop = false;
            // 
            // tboxMunicipality
            // 
            this.tboxMunicipality.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tboxMunicipality.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboxMunicipality.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tboxMunicipality.ForeColor = System.Drawing.Color.White;
            this.tboxMunicipality.Location = new System.Drawing.Point(468, 109);
            this.tboxMunicipality.Margin = new System.Windows.Forms.Padding(5);
            this.tboxMunicipality.Multiline = true;
            this.tboxMunicipality.Name = "tboxMunicipality";
            this.tboxMunicipality.Size = new System.Drawing.Size(419, 30);
            this.tboxMunicipality.TabIndex = 104;
            this.tboxMunicipality.TabStop = false;
            // 
            // tboxDescription
            // 
            this.tboxDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tboxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboxDescription.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tboxDescription.ForeColor = System.Drawing.Color.White;
            this.tboxDescription.Location = new System.Drawing.Point(26, 175);
            this.tboxDescription.Margin = new System.Windows.Forms.Padding(5);
            this.tboxDescription.Multiline = true;
            this.tboxDescription.Name = "tboxDescription";
            this.tboxDescription.Size = new System.Drawing.Size(861, 84);
            this.tboxDescription.TabIndex = 105;
            this.tboxDescription.TabStop = false;
            // 
            // ProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1150, 385);
            this.ControlBox = false;
            this.Controls.Add(this.InsertationPanel);
            this.Controls.Add(this.flpButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.flpButtons.ResumeLayout(false);
            this.InsertationPanel.ResumeLayout(false);
            this.InsertationPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flpButtons;
        private FontAwesome.Sharp.IconButton InsertContinue;
        private FontAwesome.Sharp.IconButton InsertClose;
        private FontAwesome.Sharp.IconButton SaveChanges;
        private System.Windows.Forms.Panel InsertationPanel;
        private System.Windows.Forms.ComboBox cboProjectStatus;
        private System.Windows.Forms.TextBox tboxProjectId;
        private System.Windows.Forms.TextBox tboxProjectNumber;
        private System.Windows.Forms.TextBox tboxProjectName;
        private System.Windows.Forms.TextBox tboxCustomer;
        private System.Windows.Forms.TextBox tboxMunicipality;
        private System.Windows.Forms.TextBox tboxDescription;
    }
}