namespace FactoryManager.View.AppDialog
{
    partial class NotificationDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotificationDialog));
            this.GridPanel = new System.Windows.Forms.Panel();
            this.CenterPanel = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.OKBoutton = new FontAwesome.Sharp.IconButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.GridPanel.SuspendLayout();
            this.CenterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.BottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridPanel
            // 
            this.GridPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GridPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.GridPanel.Controls.Add(this.CenterPanel);
            this.GridPanel.Controls.Add(this.pictureBox1);
            this.GridPanel.Controls.Add(this.lblTitle);
            this.GridPanel.Controls.Add(this.BottomPanel);
            this.GridPanel.Location = new System.Drawing.Point(325, 115);
            this.GridPanel.Name = "GridPanel";
            this.GridPanel.Size = new System.Drawing.Size(500, 450);
            this.GridPanel.TabIndex = 103;
            // 
            // CenterPanel
            // 
            this.CenterPanel.Controls.Add(this.lblMessage);
            this.CenterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CenterPanel.Location = new System.Drawing.Point(0, 128);
            this.CenterPanel.Name = "CenterPanel";
            this.CenterPanel.Padding = new System.Windows.Forms.Padding(20);
            this.CenterPanel.Size = new System.Drawing.Size(500, 270);
            this.CenterPanel.TabIndex = 117;
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.lblMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMessage.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMessage.ForeColor = System.Drawing.Color.White;
            this.lblMessage.Location = new System.Drawing.Point(20, 20);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Padding = new System.Windows.Forms.Padding(10);
            this.lblMessage.Size = new System.Drawing.Size(460, 230);
            this.lblMessage.TabIndex = 113;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.pictureBox1.BackgroundImage = global::FactoryManager.Properties.Resources.app_cover_transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 93);
            this.pictureBox1.TabIndex = 116;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(500, 35);
            this.lblTitle.TabIndex = 115;
            this.lblTitle.Text = "NOTIFICATION";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BottomPanel
            // 
            this.BottomPanel.Controls.Add(this.OKBoutton);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 398);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(500, 52);
            this.BottomPanel.TabIndex = 105;
            // 
            // OKBoutton
            // 
            this.OKBoutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.OKBoutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OKBoutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OKBoutton.FlatAppearance.BorderSize = 0;
            this.OKBoutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.OKBoutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.OKBoutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OKBoutton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OKBoutton.ForeColor = System.Drawing.Color.White;
            this.OKBoutton.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.OKBoutton.IconColor = System.Drawing.Color.White;
            this.OKBoutton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.OKBoutton.IconSize = 25;
            this.OKBoutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.OKBoutton.Location = new System.Drawing.Point(0, 0);
            this.OKBoutton.Name = "OKBoutton";
            this.OKBoutton.Padding = new System.Windows.Forms.Padding(10);
            this.OKBoutton.Size = new System.Drawing.Size(500, 52);
            this.OKBoutton.TabIndex = 110;
            this.OKBoutton.TabStop = false;
            this.OKBoutton.Text = "OK";
            this.OKBoutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OKBoutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.OKBoutton.UseVisualStyleBackColor = false;
            this.OKBoutton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // NotificationDialog
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(170)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(1150, 680);
            this.ControlBox = false;
            this.Controls.Add(this.GridPanel);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NotificationDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.GridPanel.ResumeLayout(false);
            this.CenterPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.BottomPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel GridPanel;
        private System.Windows.Forms.Panel BottomPanel;
        private FontAwesome.Sharp.IconButton OKBoutton;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel CenterPanel;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
    }
}