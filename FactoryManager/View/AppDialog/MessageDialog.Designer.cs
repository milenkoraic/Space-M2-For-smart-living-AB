namespace FactoryManager.View.AppDialog
{
    partial class MessageDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageDialog));
            this.FormDisplayPanel = new System.Windows.Forms.Timer(this.components);
            this.GridPanel = new System.Windows.Forms.Panel();
            this.CenterPanel = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lmPanel = new System.Windows.Forms.Panel();
            this.YES = new FontAwesome.Sharp.IconButton();
            this.rmPanel = new System.Windows.Forms.Panel();
            this.NO = new FontAwesome.Sharp.IconButton();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.rbcPanel = new System.Windows.Forms.Panel();
            this.lbcPanel = new System.Windows.Forms.Panel();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rtcPanel = new System.Windows.Forms.Panel();
            this.ltcPanel = new System.Windows.Forms.Panel();
            this.GridPanel.SuspendLayout();
            this.CenterPanel.SuspendLayout();
            this.lmPanel.SuspendLayout();
            this.rmPanel.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FormDisplayPanel
            // 
            this.FormDisplayPanel.Enabled = true;
            this.FormDisplayPanel.Interval = 20;
            this.FormDisplayPanel.Tick += new System.EventHandler(this.FormDisplayPanel_Tick);
            // 
            // GridPanel
            // 
            this.GridPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GridPanel.Controls.Add(this.CenterPanel);
            this.GridPanel.Controls.Add(this.BottomPanel);
            this.GridPanel.Controls.Add(this.TopPanel);
            this.GridPanel.Location = new System.Drawing.Point(250, 90);
            this.GridPanel.Name = "GridPanel";
            this.GridPanel.Size = new System.Drawing.Size(650, 500);
            this.GridPanel.TabIndex = 102;
            // 
            // CenterPanel
            // 
            this.CenterPanel.Controls.Add(this.lblMessage);
            this.CenterPanel.Controls.Add(this.lmPanel);
            this.CenterPanel.Controls.Add(this.rmPanel);
            this.CenterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CenterPanel.Location = new System.Drawing.Point(0, 93);
            this.CenterPanel.Name = "CenterPanel";
            this.CenterPanel.Size = new System.Drawing.Size(650, 314);
            this.CenterPanel.TabIndex = 106;
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMessage.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMessage.ForeColor = System.Drawing.Color.White;
            this.lblMessage.Location = new System.Drawing.Point(112, 0);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Padding = new System.Windows.Forms.Padding(20);
            this.lblMessage.Size = new System.Drawing.Size(426, 314);
            this.lblMessage.TabIndex = 112;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lmPanel
            // 
            this.lmPanel.Controls.Add(this.YES);
            this.lmPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.lmPanel.Location = new System.Drawing.Point(0, 0);
            this.lmPanel.Name = "lmPanel";
            this.lmPanel.Size = new System.Drawing.Size(112, 314);
            this.lmPanel.TabIndex = 110;
            // 
            // YES
            // 
            this.YES.AutoSize = true;
            this.YES.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.YES.Cursor = System.Windows.Forms.Cursors.Hand;
            this.YES.Dock = System.Windows.Forms.DockStyle.Left;
            this.YES.FlatAppearance.BorderSize = 0;
            this.YES.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.YES.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.YES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YES.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.YES.ForeColor = System.Drawing.Color.White;
            this.YES.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.YES.IconColor = System.Drawing.Color.White;
            this.YES.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.YES.IconSize = 25;
            this.YES.Location = new System.Drawing.Point(0, 0);
            this.YES.Name = "YES";
            this.YES.Padding = new System.Windows.Forms.Padding(10);
            this.YES.Size = new System.Drawing.Size(112, 314);
            this.YES.TabIndex = 8;
            this.YES.TabStop = false;
            this.YES.Text = "YES";
            this.YES.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.YES.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.YES.UseVisualStyleBackColor = false;
            this.YES.Click += new System.EventHandler(this.YES_Click);
            // 
            // rmPanel
            // 
            this.rmPanel.Controls.Add(this.NO);
            this.rmPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rmPanel.Location = new System.Drawing.Point(538, 0);
            this.rmPanel.Name = "rmPanel";
            this.rmPanel.Size = new System.Drawing.Size(112, 314);
            this.rmPanel.TabIndex = 109;
            // 
            // NO
            // 
            this.NO.AutoSize = true;
            this.NO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.NO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NO.Dock = System.Windows.Forms.DockStyle.Right;
            this.NO.FlatAppearance.BorderSize = 0;
            this.NO.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.NO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.NO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NO.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NO.ForeColor = System.Drawing.Color.White;
            this.NO.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.NO.IconColor = System.Drawing.Color.White;
            this.NO.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.NO.IconSize = 25;
            this.NO.Location = new System.Drawing.Point(0, 0);
            this.NO.Name = "NO";
            this.NO.Padding = new System.Windows.Forms.Padding(10);
            this.NO.Size = new System.Drawing.Size(112, 314);
            this.NO.TabIndex = 9;
            this.NO.TabStop = false;
            this.NO.Text = "NO";
            this.NO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NO.UseVisualStyleBackColor = false;
            this.NO.Click += new System.EventHandler(this.NO_Click);
            // 
            // BottomPanel
            // 
            this.BottomPanel.Controls.Add(this.lblTitle);
            this.BottomPanel.Controls.Add(this.rbcPanel);
            this.BottomPanel.Controls.Add(this.lbcPanel);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 407);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(650, 93);
            this.BottomPanel.TabIndex = 105;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(112, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(426, 93);
            this.lblTitle.TabIndex = 110;
            this.lblTitle.Text = "USER QUESTION TITLE?";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbcPanel
            // 
            this.rbcPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rbcPanel.Location = new System.Drawing.Point(538, 0);
            this.rbcPanel.Name = "rbcPanel";
            this.rbcPanel.Size = new System.Drawing.Size(112, 93);
            this.rbcPanel.TabIndex = 109;
            // 
            // lbcPanel
            // 
            this.lbcPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbcPanel.Location = new System.Drawing.Point(0, 0);
            this.lbcPanel.Name = "lbcPanel";
            this.lbcPanel.Size = new System.Drawing.Size(112, 93);
            this.lbcPanel.TabIndex = 106;
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.pictureBox1);
            this.TopPanel.Controls.Add(this.rtcPanel);
            this.TopPanel.Controls.Add(this.ltcPanel);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(650, 93);
            this.TopPanel.TabIndex = 103;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.pictureBox1.BackgroundImage = global::FactoryManager.Properties.Resources.app_cover_transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(112, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(426, 93);
            this.pictureBox1.TabIndex = 109;
            this.pictureBox1.TabStop = false;
            // 
            // rtcPanel
            // 
            this.rtcPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rtcPanel.Location = new System.Drawing.Point(538, 0);
            this.rtcPanel.Name = "rtcPanel";
            this.rtcPanel.Size = new System.Drawing.Size(112, 93);
            this.rtcPanel.TabIndex = 108;
            // 
            // ltcPanel
            // 
            this.ltcPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ltcPanel.Location = new System.Drawing.Point(0, 0);
            this.ltcPanel.Name = "ltcPanel";
            this.ltcPanel.Size = new System.Drawing.Size(112, 93);
            this.ltcPanel.TabIndex = 107;
            // 
            // MessageDialog
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(170)))), ((int)(((byte)(72)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
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
            this.Name = "MessageDialog";
            this.Opacity = 0D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.GridPanel.ResumeLayout(false);
            this.CenterPanel.ResumeLayout(false);
            this.lmPanel.ResumeLayout(false);
            this.lmPanel.PerformLayout();
            this.rmPanel.ResumeLayout(false);
            this.rmPanel.PerformLayout();
            this.BottomPanel.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer FormDisplayPanel;
        private System.Windows.Forms.Panel GridPanel;
        private System.Windows.Forms.Panel CenterPanel;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Panel lmPanel;
        private FontAwesome.Sharp.IconButton YES;
        private System.Windows.Forms.Panel rmPanel;
        private FontAwesome.Sharp.IconButton NO;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel rbcPanel;
        private System.Windows.Forms.Panel lbcPanel;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel rtcPanel;
        private System.Windows.Forms.Panel ltcPanel;
    }
}