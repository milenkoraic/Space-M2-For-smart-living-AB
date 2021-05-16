namespace FactoryManager.View
{
    partial class LoginForm
    {
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.FooterPanel = new System.Windows.Forms.Panel();
            this.CopyrightLabel = new System.Windows.Forms.Label();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.AppVersionLabel = new System.Windows.Forms.Label();
            this.ButtoneExit = new FontAwesome.Sharp.IconButton();
            this.MainLoginPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ButtonLogIn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.LoginTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.FormFadeTimer = new System.Windows.Forms.Timer(this.components);
            this.MainPanel.SuspendLayout();
            this.FooterPanel.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            this.MainLoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(170)))), ((int)(((byte)(72)))));
            this.MainPanel.Controls.Add(this.FooterPanel);
            this.MainPanel.Controls.Add(this.HeaderPanel);
            this.MainPanel.Controls.Add(this.MainLoginPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1150, 680);
            this.MainPanel.TabIndex = 85;
            // 
            // FooterPanel
            // 
            this.FooterPanel.Controls.Add(this.CopyrightLabel);
            this.FooterPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FooterPanel.Location = new System.Drawing.Point(0, 631);
            this.FooterPanel.Name = "FooterPanel";
            this.FooterPanel.Size = new System.Drawing.Size(1150, 49);
            this.FooterPanel.TabIndex = 104;
            // 
            // CopyrightLabel
            // 
            this.CopyrightLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(72)))));
            this.CopyrightLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CopyrightLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CopyrightLabel.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CopyrightLabel.ForeColor = System.Drawing.Color.White;
            this.CopyrightLabel.Location = new System.Drawing.Point(0, 0);
            this.CopyrightLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CopyrightLabel.Name = "CopyrightLabel";
            this.CopyrightLabel.Padding = new System.Windows.Forms.Padding(10, 12, 0, 10);
            this.CopyrightLabel.Size = new System.Drawing.Size(1150, 49);
            this.CopyrightLabel.TabIndex = 81;
            this.CopyrightLabel.Text = "Copyright ©  Milenko Raic | Software Development";
            this.CopyrightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.HeaderPanel.Controls.Add(this.AppVersionLabel);
            this.HeaderPanel.Controls.Add(this.ButtoneExit);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(1150, 50);
            this.HeaderPanel.TabIndex = 103;
            // 
            // AppVersionLabel
            // 
            this.AppVersionLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.AppVersionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AppVersionLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AppVersionLabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AppVersionLabel.ForeColor = System.Drawing.Color.White;
            this.AppVersionLabel.Location = new System.Drawing.Point(0, 0);
            this.AppVersionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AppVersionLabel.Name = "AppVersionLabel";
            this.AppVersionLabel.Padding = new System.Windows.Forms.Padding(10, 12, 0, 10);
            this.AppVersionLabel.Size = new System.Drawing.Size(1100, 50);
            this.AppVersionLabel.TabIndex = 99;
            this.AppVersionLabel.Text = "Factory Manager";
            this.AppVersionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ButtoneExit
            // 
            this.ButtoneExit.AutoSize = true;
            this.ButtoneExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ButtoneExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtoneExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtoneExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtoneExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ButtoneExit.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.ButtoneExit.IconColor = System.Drawing.Color.White;
            this.ButtoneExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtoneExit.IconSize = 20;
            this.ButtoneExit.Location = new System.Drawing.Point(1100, 0);
            this.ButtoneExit.Margin = new System.Windows.Forms.Padding(0);
            this.ButtoneExit.Name = "ButtoneExit";
            this.ButtoneExit.Padding = new System.Windows.Forms.Padding(2);
            this.ButtoneExit.Size = new System.Drawing.Size(50, 50);
            this.ButtoneExit.TabIndex = 96;
            this.ButtoneExit.TabStop = false;
            this.ButtoneExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtoneExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ButtoneExit.UseVisualStyleBackColor = false;
            this.ButtoneExit.Click += new System.EventHandler(this.ButtoneExit_Click);
            // 
            // MainLoginPanel
            // 
            this.MainLoginPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MainLoginPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(170)))), ((int)(((byte)(72)))));
            this.MainLoginPanel.Controls.Add(this.pictureBox1);
            this.MainLoginPanel.Controls.Add(this.ButtonLogIn);
            this.MainLoginPanel.Controls.Add(this.LoginTextBox);
            this.MainLoginPanel.Location = new System.Drawing.Point(353, 128);
            this.MainLoginPanel.Name = "MainLoginPanel";
            this.MainLoginPanel.Size = new System.Drawing.Size(445, 442);
            this.MainLoginPanel.TabIndex = 102;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(170)))), ((int)(((byte)(72)))));
            this.pictureBox1.BackgroundImage = global::FactoryManager.Properties.Resources.app_cover_green;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(78, 28);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(10);
            this.pictureBox1.Size = new System.Drawing.Size(271, 188);
            this.pictureBox1.TabIndex = 85;
            this.pictureBox1.TabStop = false;
            // 
            // ButtonLogIn
            // 
            this.ButtonLogIn.ActiveBorderThickness = 3;
            this.ButtonLogIn.ActiveCornerRadius = 20;
            this.ButtonLogIn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ButtonLogIn.ActiveForecolor = System.Drawing.Color.GreenYellow;
            this.ButtonLogIn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(170)))), ((int)(((byte)(72)))));
            this.ButtonLogIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(170)))), ((int)(((byte)(72)))));
            this.ButtonLogIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonLogIn.BackgroundImage")));
            this.ButtonLogIn.ButtonText = "LOGGA IN";
            this.ButtonLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonLogIn.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonLogIn.ForeColor = System.Drawing.Color.GreenYellow;
            this.ButtonLogIn.IdleBorderThickness = 2;
            this.ButtonLogIn.IdleCornerRadius = 20;
            this.ButtonLogIn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ButtonLogIn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(72)))));
            this.ButtonLogIn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(72)))));
            this.ButtonLogIn.Location = new System.Drawing.Point(151, 314);
            this.ButtonLogIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonLogIn.Name = "ButtonLogIn";
            this.ButtonLogIn.Size = new System.Drawing.Size(120, 65);
            this.ButtonLogIn.TabIndex = 94;
            this.ButtonLogIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonLogIn.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(72)))));
            this.LoginTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LoginTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LoginTextBox.ForeColor = System.Drawing.Color.White;
            this.LoginTextBox.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(170)))), ((int)(((byte)(72)))));
            this.LoginTextBox.HintText = "Enter password";
            this.LoginTextBox.isPassword = false;
            this.LoginTextBox.LineFocusedColor = System.Drawing.Color.GreenYellow;
            this.LoginTextBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(170)))), ((int)(((byte)(72)))));
            this.LoginTextBox.LineMouseHoverColor = System.Drawing.Color.GreenYellow;
            this.LoginTextBox.LineThickness = 3;
            this.LoginTextBox.Location = new System.Drawing.Point(34, 239);
            this.LoginTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(354, 44);
            this.LoginTextBox.TabIndex = 93;
            this.LoginTextBox.TabStop = false;
            this.LoginTextBox.Text = "Ange ditt lösenord här...";
            this.LoginTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LoginTextBox.Enter += new System.EventHandler(this.LoginTextBox_Enter);
            this.LoginTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LoginTextBox_KeyPress);
            // 
            // FormFadeTimer
            // 
            this.FormFadeTimer.Enabled = true;
            this.FormFadeTimer.Interval = 20;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1150, 680);
            this.ControlBox = false;
            this.Controls.Add(this.MainPanel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.MainPanel.ResumeLayout(false);
            this.FooterPanel.ResumeLayout(false);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.MainLoginPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Timer FormFadeTimer;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.Panel FooterPanel;
        private System.Windows.Forms.Label CopyrightLabel;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Label AppVersionLabel;
        private FontAwesome.Sharp.IconButton ButtoneExit;
        private System.Windows.Forms.Panel MainLoginPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 ButtonLogIn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox LoginTextBox;
    }
}

