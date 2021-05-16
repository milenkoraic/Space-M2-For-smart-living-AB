namespace FactoryManager.View.AppDialog
{
    partial class LoadingScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingScreen));
            this.FormDisplayTimer = new System.Windows.Forms.Timer(this.components);
            this.GridPanel = new System.Windows.Forms.Panel();
            this.CenterPanel = new System.Windows.Forms.Panel();
            this.LogoSpinner = new System.Windows.Forms.PictureBox();
            this.lmPanel = new System.Windows.Forms.Panel();
            this.rmPanel = new System.Windows.Forms.Panel();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.GridPanel.SuspendLayout();
            this.CenterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoSpinner)).BeginInit();
            this.BottomPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FormDisplayTimer
            // 
            this.FormDisplayTimer.Enabled = true;
            this.FormDisplayTimer.Interval = 10;
            // 
            // GridPanel
            // 
            this.GridPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GridPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(49)))));
            this.GridPanel.Controls.Add(this.CenterPanel);
            this.GridPanel.Controls.Add(this.BottomPanel);
            this.GridPanel.Controls.Add(this.TopPanel);
            this.GridPanel.Location = new System.Drawing.Point(317, 99);
            this.GridPanel.Name = "GridPanel";
            this.GridPanel.Padding = new System.Windows.Forms.Padding(10, 25, 10, 10);
            this.GridPanel.Size = new System.Drawing.Size(500, 450);
            this.GridPanel.TabIndex = 104;
            // 
            // CenterPanel
            // 
            this.CenterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(49)))));
            this.CenterPanel.Controls.Add(this.LogoSpinner);
            this.CenterPanel.Controls.Add(this.lmPanel);
            this.CenterPanel.Controls.Add(this.rmPanel);
            this.CenterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CenterPanel.Location = new System.Drawing.Point(10, 118);
            this.CenterPanel.Name = "CenterPanel";
            this.CenterPanel.Size = new System.Drawing.Size(480, 229);
            this.CenterPanel.TabIndex = 106;
            // 
            // LogoSpinner
            // 
            this.LogoSpinner.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LogoSpinner.Image = global::FactoryManager.Properties.Resources.loading_screen_spinner;
            this.LogoSpinner.Location = new System.Drawing.Point(140, 14);
            this.LogoSpinner.Name = "LogoSpinner";
            this.LogoSpinner.Size = new System.Drawing.Size(200, 200);
            this.LogoSpinner.TabIndex = 111;
            this.LogoSpinner.TabStop = false;
            // 
            // lmPanel
            // 
            this.lmPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(49)))));
            this.lmPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.lmPanel.Location = new System.Drawing.Point(0, 0);
            this.lmPanel.Name = "lmPanel";
            this.lmPanel.Size = new System.Drawing.Size(112, 229);
            this.lmPanel.TabIndex = 110;
            // 
            // rmPanel
            // 
            this.rmPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(49)))));
            this.rmPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rmPanel.Location = new System.Drawing.Point(368, 0);
            this.rmPanel.Name = "rmPanel";
            this.rmPanel.Size = new System.Drawing.Size(112, 229);
            this.rmPanel.TabIndex = 109;
            // 
            // BottomPanel
            // 
            this.BottomPanel.Controls.Add(this.MessageLabel);
            this.BottomPanel.Controls.Add(this.TitleLabel);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(10, 347);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(480, 93);
            this.BottomPanel.TabIndex = 105;
            // 
            // MessageLabel
            // 
            this.MessageLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(49)))));
            this.MessageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessageLabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MessageLabel.ForeColor = System.Drawing.Color.GreenYellow;
            this.MessageLabel.Location = new System.Drawing.Point(0, 32);
            this.MessageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(480, 61);
            this.MessageLabel.TabIndex = 111;
            this.MessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TitleLabel
            // 
            this.TitleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(49)))));
            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TitleLabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(170)))), ((int)(((byte)(72)))));
            this.TitleLabel.Location = new System.Drawing.Point(0, 0);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(480, 32);
            this.TitleLabel.TabIndex = 110;
            this.TitleLabel.Text = "LOADING";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.pictureBox1);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(10, 25);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(480, 93);
            this.TopPanel.TabIndex = 103;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(49)))));
            this.pictureBox1.BackgroundImage = global::FactoryManager.Properties.Resources.app_cover_transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(480, 93);
            this.pictureBox1.TabIndex = 109;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // LoadingScreen
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
            this.Name = "LoadingScreen";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SplashLoader_Load);
            this.GridPanel.ResumeLayout(false);
            this.CenterPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoSpinner)).EndInit();
            this.BottomPanel.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer FormDisplayTimer;
        private System.Windows.Forms.Panel GridPanel;
        private System.Windows.Forms.Panel CenterPanel;
        private System.Windows.Forms.PictureBox LogoSpinner;
        private System.Windows.Forms.Panel lmPanel;
        private System.Windows.Forms.Panel rmPanel;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}