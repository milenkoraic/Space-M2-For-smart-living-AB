
namespace FactoryManager.View
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.DateTimeTimer = new System.Windows.Forms.Timer(this.components);
            this.cboAppForms = new System.Windows.Forms.ComboBox();
            this.LeftSidePanel = new System.Windows.Forms.Panel();
            this.ButtonLogout = new FontAwesome.Sharp.IconButton();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.ProductionPanel = new System.Windows.Forms.Panel();
            this.Project = new FontAwesome.Sharp.IconButton();
            this.Production = new FontAwesome.Sharp.IconButton();
            this.Dashboard = new FontAwesome.Sharp.IconButton();
            this.Home = new FontAwesome.Sharp.IconButton();
            this.UserInfoPanel = new System.Windows.Forms.Panel();
            this.LabelUserInfo = new System.Windows.Forms.Label();
            this.UserRoleLabel = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.TopLeftHeaderPanel = new System.Windows.Forms.Panel();
            this.LogoImage = new System.Windows.Forms.PictureBox();
            this.TopHeaderPanel = new System.Windows.Forms.Panel();
            this.ButtoneExit = new FontAwesome.Sharp.IconButton();
            this.TopHeaderSubpanel = new System.Windows.Forms.Panel();
            this.GridSelection = new FontAwesome.Sharp.IconButton();
            this.CurrentWeekLabel = new System.Windows.Forms.Label();
            this.CurrentDateTimeLabel = new System.Windows.Forms.Label();
            this.LabelIndicator = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.LeftSidePanel.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            this.ProductionPanel.SuspendLayout();
            this.UserInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.TopLeftHeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoImage)).BeginInit();
            this.TopHeaderPanel.SuspendLayout();
            this.TopHeaderSubpanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DateTimeTimer
            // 
            this.DateTimeTimer.Enabled = true;
            this.DateTimeTimer.Interval = 10;
            this.DateTimeTimer.Tick += new System.EventHandler(this.DateTimeTimer_Tick);
            // 
            // cboAppForms
            // 
            this.cboAppForms.FormattingEnabled = true;
            this.cboAppForms.Location = new System.Drawing.Point(118, 31);
            this.cboAppForms.Name = "cboAppForms";
            this.cboAppForms.Size = new System.Drawing.Size(121, 24);
            this.cboAppForms.TabIndex = 102;
            // 
            // LeftSidePanel
            // 
            this.LeftSidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.LeftSidePanel.Controls.Add(this.ButtonLogout);
            this.LeftSidePanel.Controls.Add(this.MenuPanel);
            this.LeftSidePanel.Controls.Add(this.UserInfoPanel);
            this.LeftSidePanel.Controls.Add(this.TopLeftHeaderPanel);
            this.LeftSidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftSidePanel.Location = new System.Drawing.Point(0, 0);
            this.LeftSidePanel.Name = "LeftSidePanel";
            this.LeftSidePanel.Size = new System.Drawing.Size(270, 680);
            this.LeftSidePanel.TabIndex = 51;
            // 
            // ButtonLogout
            // 
            this.ButtonLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ButtonLogout.Cursor = System.Windows.Forms.Cursors.Default;
            this.ButtonLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonLogout.FlatAppearance.BorderSize = 0;
            this.ButtonLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.ButtonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLogout.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonLogout.ForeColor = System.Drawing.Color.White;
            this.ButtonLogout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.ButtonLogout.IconColor = System.Drawing.Color.White;
            this.ButtonLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonLogout.IconSize = 25;
            this.ButtonLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonLogout.Location = new System.Drawing.Point(0, 630);
            this.ButtonLogout.Name = "ButtonLogout";
            this.ButtonLogout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ButtonLogout.Rotation = 180D;
            this.ButtonLogout.Size = new System.Drawing.Size(270, 50);
            this.ButtonLogout.TabIndex = 112;
            this.ButtonLogout.TabStop = false;
            this.ButtonLogout.Text = "  LOGGA UT";
            this.ButtonLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonLogout.UseVisualStyleBackColor = false;
            this.ButtonLogout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuPanel.Controls.Add(this.ProductionPanel);
            this.MenuPanel.Controls.Add(this.Production);
            this.MenuPanel.Controls.Add(this.Dashboard);
            this.MenuPanel.Controls.Add(this.Home);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuPanel.Location = new System.Drawing.Point(0, 294);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Padding = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.MenuPanel.Size = new System.Drawing.Size(270, 228);
            this.MenuPanel.TabIndex = 111;
            // 
            // ProductionPanel
            // 
            this.ProductionPanel.Controls.Add(this.Project);
            this.ProductionPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProductionPanel.Location = new System.Drawing.Point(5, 125);
            this.ProductionPanel.Name = "ProductionPanel";
            this.ProductionPanel.Size = new System.Drawing.Size(260, 175);
            this.ProductionPanel.TabIndex = 2;
            this.ProductionPanel.Visible = false;
            // 
            // Project
            // 
            this.Project.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(170)))), ((int)(((byte)(72)))));
            this.Project.Dock = System.Windows.Forms.DockStyle.Top;
            this.Project.FlatAppearance.BorderSize = 0;
            this.Project.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Project.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Project.ForeColor = System.Drawing.Color.White;
            this.Project.IconChar = FontAwesome.Sharp.IconChar.Building;
            this.Project.IconColor = System.Drawing.Color.White;
            this.Project.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Project.IconSize = 25;
            this.Project.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Project.Location = new System.Drawing.Point(0, 0);
            this.Project.Name = "Project";
            this.Project.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.Project.Size = new System.Drawing.Size(260, 35);
            this.Project.TabIndex = 2;
            this.Project.Text = "  Projekt";
            this.Project.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Project.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Project.UseVisualStyleBackColor = false;
            this.Project.Click += new System.EventHandler(this.Project_Click);
            // 
            // Production
            // 
            this.Production.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Production.Dock = System.Windows.Forms.DockStyle.Top;
            this.Production.FlatAppearance.BorderSize = 0;
            this.Production.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.Production.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Production.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Production.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(170)))), ((int)(((byte)(72)))));
            this.Production.IconChar = FontAwesome.Sharp.IconChar.Industry;
            this.Production.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(170)))), ((int)(((byte)(72)))));
            this.Production.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Production.IconSize = 25;
            this.Production.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Production.Location = new System.Drawing.Point(5, 85);
            this.Production.Name = "Production";
            this.Production.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Production.Size = new System.Drawing.Size(260, 40);
            this.Production.TabIndex = 1;
            this.Production.Text = "  PRODUKTION";
            this.Production.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Production.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Production.UseVisualStyleBackColor = false;
            this.Production.Click += new System.EventHandler(this.Production_Click);
            // 
            // Dashboard
            // 
            this.Dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Dashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.Dashboard.FlatAppearance.BorderSize = 0;
            this.Dashboard.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dashboard.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Dashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(170)))), ((int)(((byte)(72)))));
            this.Dashboard.IconChar = FontAwesome.Sharp.IconChar.TachometerAlt;
            this.Dashboard.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(170)))), ((int)(((byte)(72)))));
            this.Dashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Dashboard.IconSize = 25;
            this.Dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Dashboard.Location = new System.Drawing.Point(5, 45);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Dashboard.Size = new System.Drawing.Size(260, 40);
            this.Dashboard.TabIndex = 0;
            this.Dashboard.Text = "  INSTRUMENTBRÄDA";
            this.Dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Dashboard.UseVisualStyleBackColor = false;
            this.Dashboard.Click += new System.EventHandler(this.Dashboard_Click);
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Home.Dock = System.Windows.Forms.DockStyle.Top;
            this.Home.FlatAppearance.BorderSize = 0;
            this.Home.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Home.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(170)))), ((int)(((byte)(72)))));
            this.Home.IconChar = FontAwesome.Sharp.IconChar.HouseUser;
            this.Home.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(170)))), ((int)(((byte)(72)))));
            this.Home.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Home.IconSize = 25;
            this.Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Home.Location = new System.Drawing.Point(5, 5);
            this.Home.Name = "Home";
            this.Home.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Home.Size = new System.Drawing.Size(260, 40);
            this.Home.TabIndex = 54;
            this.Home.Text = "  HEMSIDA";
            this.Home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // UserInfoPanel
            // 
            this.UserInfoPanel.Controls.Add(this.LabelUserInfo);
            this.UserInfoPanel.Controls.Add(this.UserRoleLabel);
            this.UserInfoPanel.Controls.Add(this.bunifuSeparator1);
            this.UserInfoPanel.Controls.Add(this.bunifuPictureBox1);
            this.UserInfoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UserInfoPanel.Location = new System.Drawing.Point(0, 104);
            this.UserInfoPanel.Name = "UserInfoPanel";
            this.UserInfoPanel.Padding = new System.Windows.Forms.Padding(5);
            this.UserInfoPanel.Size = new System.Drawing.Size(270, 190);
            this.UserInfoPanel.TabIndex = 110;
            // 
            // LabelUserInfo
            // 
            this.LabelUserInfo.BackColor = System.Drawing.Color.Transparent;
            this.LabelUserInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LabelUserInfo.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelUserInfo.ForeColor = System.Drawing.Color.White;
            this.LabelUserInfo.Location = new System.Drawing.Point(5, 105);
            this.LabelUserInfo.Name = "LabelUserInfo";
            this.LabelUserInfo.Size = new System.Drawing.Size(260, 39);
            this.LabelUserInfo.TabIndex = 123;
            this.LabelUserInfo.Text = "Peter Lindberg";
            this.LabelUserInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserRoleLabel
            // 
            this.UserRoleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(170)))), ((int)(((byte)(72)))));
            this.UserRoleLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.UserRoleLabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UserRoleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.UserRoleLabel.Location = new System.Drawing.Point(5, 144);
            this.UserRoleLabel.Name = "UserRoleLabel";
            this.UserRoleLabel.Size = new System.Drawing.Size(260, 41);
            this.UserRoleLabel.TabIndex = 122;
            this.UserRoleLabel.Text = "Administrator";
            this.UserRoleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(72)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(5, 5);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(260, 20);
            this.bunifuSeparator1.TabIndex = 108;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 30;
            this.bunifuPictureBox1.Image = global::FactoryManager.Properties.Resources.UserImageDefault;
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(105, 37);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(60, 60);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 107;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // TopLeftHeaderPanel
            // 
            this.TopLeftHeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.TopLeftHeaderPanel.Controls.Add(this.LogoImage);
            this.TopLeftHeaderPanel.Controls.Add(this.cboAppForms);
            this.TopLeftHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopLeftHeaderPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.TopLeftHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.TopLeftHeaderPanel.Name = "TopLeftHeaderPanel";
            this.TopLeftHeaderPanel.Padding = new System.Windows.Forms.Padding(10);
            this.TopLeftHeaderPanel.Size = new System.Drawing.Size(270, 104);
            this.TopLeftHeaderPanel.TabIndex = 27;
            // 
            // LogoImage
            // 
            this.LogoImage.BackColor = System.Drawing.Color.Transparent;
            this.LogoImage.BackgroundImage = global::FactoryManager.Properties.Resources.app_cover_transparent;
            this.LogoImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LogoImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogoImage.Location = new System.Drawing.Point(10, 10);
            this.LogoImage.Name = "LogoImage";
            this.LogoImage.Size = new System.Drawing.Size(250, 84);
            this.LogoImage.TabIndex = 103;
            this.LogoImage.TabStop = false;
            // 
            // TopHeaderPanel
            // 
            this.TopHeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.TopHeaderPanel.Controls.Add(this.ButtoneExit);
            this.TopHeaderPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.TopHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopHeaderPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(72)))));
            this.TopHeaderPanel.Location = new System.Drawing.Point(270, 0);
            this.TopHeaderPanel.Margin = new System.Windows.Forms.Padding(4);
            this.TopHeaderPanel.Name = "TopHeaderPanel";
            this.TopHeaderPanel.Size = new System.Drawing.Size(880, 40);
            this.TopHeaderPanel.TabIndex = 125;
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
            this.ButtoneExit.Location = new System.Drawing.Point(840, 0);
            this.ButtoneExit.Margin = new System.Windows.Forms.Padding(0);
            this.ButtoneExit.Name = "ButtoneExit";
            this.ButtoneExit.Padding = new System.Windows.Forms.Padding(2);
            this.ButtoneExit.Size = new System.Drawing.Size(40, 40);
            this.ButtoneExit.TabIndex = 97;
            this.ButtoneExit.TabStop = false;
            this.ButtoneExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtoneExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ButtoneExit.UseVisualStyleBackColor = false;
            this.ButtoneExit.Click += new System.EventHandler(this.ButtoneExit_Click);
            // 
            // TopHeaderSubpanel
            // 
            this.TopHeaderSubpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.TopHeaderSubpanel.Controls.Add(this.GridSelection);
            this.TopHeaderSubpanel.Controls.Add(this.CurrentWeekLabel);
            this.TopHeaderSubpanel.Controls.Add(this.CurrentDateTimeLabel);
            this.TopHeaderSubpanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.TopHeaderSubpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopHeaderSubpanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(72)))));
            this.TopHeaderSubpanel.Location = new System.Drawing.Point(270, 40);
            this.TopHeaderSubpanel.Margin = new System.Windows.Forms.Padding(4);
            this.TopHeaderSubpanel.Name = "TopHeaderSubpanel";
            this.TopHeaderSubpanel.Size = new System.Drawing.Size(880, 40);
            this.TopHeaderSubpanel.TabIndex = 126;
            // 
            // GridSelection
            // 
            this.GridSelection.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GridSelection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GridSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GridSelection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.GridSelection.IconChar = FontAwesome.Sharp.IconChar.Server;
            this.GridSelection.IconColor = System.Drawing.Color.DarkOrange;
            this.GridSelection.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.GridSelection.IconSize = 25;
            this.GridSelection.Location = new System.Drawing.Point(423, 3);
            this.GridSelection.Name = "GridSelection";
            this.GridSelection.Size = new System.Drawing.Size(35, 35);
            this.GridSelection.TabIndex = 124;
            this.GridSelection.UseVisualStyleBackColor = true;
            this.GridSelection.Click += new System.EventHandler(this.BackOffice_Click);
            // 
            // CurrentWeekLabel
            // 
            this.CurrentWeekLabel.AutoSize = true;
            this.CurrentWeekLabel.BackColor = System.Drawing.Color.Transparent;
            this.CurrentWeekLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.CurrentWeekLabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CurrentWeekLabel.ForeColor = System.Drawing.Color.White;
            this.CurrentWeekLabel.Location = new System.Drawing.Point(0, 0);
            this.CurrentWeekLabel.Name = "CurrentWeekLabel";
            this.CurrentWeekLabel.Padding = new System.Windows.Forms.Padding(8);
            this.CurrentWeekLabel.Size = new System.Drawing.Size(94, 37);
            this.CurrentWeekLabel.TabIndex = 119;
            this.CurrentWeekLabel.Text = "VECKA 18";
            this.CurrentWeekLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CurrentDateTimeLabel
            // 
            this.CurrentDateTimeLabel.AutoSize = true;
            this.CurrentDateTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.CurrentDateTimeLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.CurrentDateTimeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CurrentDateTimeLabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CurrentDateTimeLabel.ForeColor = System.Drawing.Color.White;
            this.CurrentDateTimeLabel.Location = new System.Drawing.Point(719, 0);
            this.CurrentDateTimeLabel.Margin = new System.Windows.Forms.Padding(4, 15, 4, 0);
            this.CurrentDateTimeLabel.Name = "CurrentDateTimeLabel";
            this.CurrentDateTimeLabel.Padding = new System.Windows.Forms.Padding(8);
            this.CurrentDateTimeLabel.Size = new System.Drawing.Size(161, 37);
            this.CurrentDateTimeLabel.TabIndex = 118;
            this.CurrentDateTimeLabel.Text = "TISDAG 2021.05.11";
            this.CurrentDateTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelIndicator
            // 
            this.LabelIndicator.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LabelIndicator.BackColor = System.Drawing.Color.Transparent;
            this.LabelIndicator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelIndicator.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelIndicator.ForeColor = System.Drawing.Color.Gold;
            this.LabelIndicator.Location = new System.Drawing.Point(308, 0);
            this.LabelIndicator.Name = "LabelIndicator";
            this.LabelIndicator.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.LabelIndicator.Size = new System.Drawing.Size(265, 40);
            this.LabelIndicator.TabIndex = 117;
            this.LabelIndicator.Text = "INSTRUMENTBRÄDA";
            this.LabelIndicator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.LabelIndicator);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(72)))));
            this.panel1.Location = new System.Drawing.Point(270, 80);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(880, 40);
            this.panel1.TabIndex = 129;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(170)))), ((int)(((byte)(72)))));
            this.MainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(270, 120);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.MainPanel.Size = new System.Drawing.Size(880, 560);
            this.MainPanel.TabIndex = 130;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1150, 680);
            this.ControlBox = false;
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TopHeaderSubpanel);
            this.Controls.Add(this.TopHeaderPanel);
            this.Controls.Add(this.LeftSidePanel);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.LeftSidePanel.ResumeLayout(false);
            this.MenuPanel.ResumeLayout(false);
            this.ProductionPanel.ResumeLayout(false);
            this.UserInfoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.TopLeftHeaderPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoImage)).EndInit();
            this.TopHeaderPanel.ResumeLayout(false);
            this.TopHeaderPanel.PerformLayout();
            this.TopHeaderSubpanel.ResumeLayout(false);
            this.TopHeaderSubpanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer DateTimeTimer;
        private System.Windows.Forms.Panel LeftSidePanel;
        private System.Windows.Forms.ComboBox cboAppForms;
        private System.Windows.Forms.Panel TopLeftHeaderPanel;
        private System.Windows.Forms.PictureBox LogoImage;
        private System.Windows.Forms.Panel TopHeaderPanel;
        private FontAwesome.Sharp.IconButton ButtoneExit;
        private System.Windows.Forms.Panel TopHeaderSubpanel;
        private System.Windows.Forms.Label LabelIndicator;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Panel ProductionPanel;
        private FontAwesome.Sharp.IconButton Project;
        private FontAwesome.Sharp.IconButton Production;
        private FontAwesome.Sharp.IconButton Dashboard;
        private FontAwesome.Sharp.IconButton Home;
        private System.Windows.Forms.Panel UserInfoPanel;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private System.Windows.Forms.Label LabelUserInfo;
        private System.Windows.Forms.Label UserRoleLabel;
        private FontAwesome.Sharp.IconButton ButtonLogout;
        private System.Windows.Forms.Label CurrentWeekLabel;
        private System.Windows.Forms.Label CurrentDateTimeLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel MainPanel;
        private FontAwesome.Sharp.IconButton GridSelection;
    }
}

