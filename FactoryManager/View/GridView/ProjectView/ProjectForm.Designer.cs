
using System.Windows.Forms;

namespace FactoryManager.View.GridView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectForm));
            this.errorProviderApp = new System.Windows.Forms.ErrorProvider(this.components);
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.FormPanel = new System.Windows.Forms.Panel();
            this.dataLayoutControl2 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.IDTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ProjektnummerTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ProjektnamnTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.KundnamnTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ProjektstatusComboBox = new DevExpress.XtraEditors.ComboBoxEdit();
            this.KommunTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.BeskrivningTextEdit = new DevExpress.XtraEditors.MemoEdit();
            this.ProjectLayoutControl = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.Header = new System.Windows.Forms.Panel();
            this.UpdateBtn = new FontAwesome.Sharp.IconButton();
            this.InsertBtn = new FontAwesome.Sharp.IconButton();
            this.Footer = new System.Windows.Forms.FlowLayoutPanel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.CloseForm = new FontAwesome.Sharp.IconButton();
            this.FormTitle = new System.Windows.Forms.Label();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.FormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl2)).BeginInit();
            this.dataLayoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IDTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjektnummerTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjektnamnTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KundnamnTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjektstatusComboBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KommunTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BeskrivningTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectLayoutControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.Header.SuspendLayout();
            this.Footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProviderApp
            // 
            this.errorProviderApp.ContainerControl = this;
            // 
            // FormPanel
            // 
            this.FormPanel.AutoScroll = true;
            this.FormPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.FormPanel.Controls.Add(this.bunifuSeparator2);
            this.FormPanel.Controls.Add(this.dataLayoutControl2);
            this.FormPanel.Controls.Add(this.Header);
            this.FormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormPanel.Location = new System.Drawing.Point(0, 0);
            this.FormPanel.Margin = new System.Windows.Forms.Padding(2);
            this.FormPanel.Name = "FormPanel";
            this.FormPanel.Size = new System.Drawing.Size(696, 345);
            this.FormPanel.TabIndex = 127;
            // 
            // dataLayoutControl2
            // 
            this.dataLayoutControl2.Controls.Add(this.IDTextEdit);
            this.dataLayoutControl2.Controls.Add(this.ProjektnummerTextEdit);
            this.dataLayoutControl2.Controls.Add(this.ProjektnamnTextEdit);
            this.dataLayoutControl2.Controls.Add(this.KundnamnTextEdit);
            this.dataLayoutControl2.Controls.Add(this.ProjektstatusComboBox);
            this.dataLayoutControl2.Controls.Add(this.KommunTextEdit);
            this.dataLayoutControl2.Controls.Add(this.BeskrivningTextEdit);
            this.dataLayoutControl2.Location = new System.Drawing.Point(12, 45);
            this.dataLayoutControl2.Name = "dataLayoutControl2";
            this.dataLayoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(738, 46, 650, 400);
            this.dataLayoutControl2.Root = this.ProjectLayoutControl;
            this.dataLayoutControl2.Size = new System.Drawing.Size(679, 293);
            this.dataLayoutControl2.TabIndex = 127;
            this.dataLayoutControl2.Text = "dataLayoutControl2";
            // 
            // IDTextEdit
            // 
            this.IDTextEdit.Location = new System.Drawing.Point(22, 40);
            this.IDTextEdit.Name = "IDTextEdit";
            this.IDTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.IDTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDTextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.IDTextEdit.Properties.Appearance.Options.UseBackColor = true;
            this.IDTextEdit.Properties.Appearance.Options.UseFont = true;
            this.IDTextEdit.Properties.Appearance.Options.UseForeColor = true;
            this.IDTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.IDTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.IDTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.IDTextEdit.Properties.Mask.EditMask = "N0";
            this.IDTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.IDTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.IDTextEdit.Properties.ReadOnly = true;
            this.IDTextEdit.Size = new System.Drawing.Size(197, 24);
            this.IDTextEdit.StyleController = this.dataLayoutControl2;
            this.IDTextEdit.TabIndex = 1;
            this.IDTextEdit.TabStop = false;
            // 
            // ProjektnummerTextEdit
            // 
            this.ProjektnummerTextEdit.Location = new System.Drawing.Point(223, 40);
            this.ProjektnummerTextEdit.Name = "ProjektnummerTextEdit";
            this.ProjektnummerTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ProjektnummerTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjektnummerTextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.ProjektnummerTextEdit.Properties.Appearance.Options.UseBackColor = true;
            this.ProjektnummerTextEdit.Properties.Appearance.Options.UseFont = true;
            this.ProjektnummerTextEdit.Properties.Appearance.Options.UseForeColor = true;
            this.ProjektnummerTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.ProjektnummerTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.ProjektnummerTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ProjektnummerTextEdit.Properties.ReadOnly = true;
            this.ProjektnummerTextEdit.Size = new System.Drawing.Size(250, 24);
            this.ProjektnummerTextEdit.StyleController = this.dataLayoutControl2;
            this.ProjektnummerTextEdit.TabIndex = 2;
            this.ProjektnummerTextEdit.TabStop = false;
            // 
            // ProjektnamnTextEdit
            // 
            this.ProjektnamnTextEdit.Location = new System.Drawing.Point(22, 86);
            this.ProjektnamnTextEdit.Name = "ProjektnamnTextEdit";
            this.ProjektnamnTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ProjektnamnTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjektnamnTextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.ProjektnamnTextEdit.Properties.Appearance.Options.UseBackColor = true;
            this.ProjektnamnTextEdit.Properties.Appearance.Options.UseFont = true;
            this.ProjektnamnTextEdit.Properties.Appearance.Options.UseForeColor = true;
            this.ProjektnamnTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ProjektnamnTextEdit.Size = new System.Drawing.Size(635, 24);
            this.ProjektnamnTextEdit.StyleController = this.dataLayoutControl2;
            this.ProjektnamnTextEdit.TabIndex = 4;
            this.ProjektnamnTextEdit.Validating += new System.ComponentModel.CancelEventHandler(this.tboxProjectName_Validating);
            // 
            // KundnamnTextEdit
            // 
            this.KundnamnTextEdit.Location = new System.Drawing.Point(22, 132);
            this.KundnamnTextEdit.Name = "KundnamnTextEdit";
            this.KundnamnTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.KundnamnTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KundnamnTextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.KundnamnTextEdit.Properties.Appearance.Options.UseBackColor = true;
            this.KundnamnTextEdit.Properties.Appearance.Options.UseFont = true;
            this.KundnamnTextEdit.Properties.Appearance.Options.UseForeColor = true;
            this.KundnamnTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.KundnamnTextEdit.Size = new System.Drawing.Size(635, 24);
            this.KundnamnTextEdit.StyleController = this.dataLayoutControl2;
            this.KundnamnTextEdit.TabIndex = 6;
            this.KundnamnTextEdit.Validating += new System.ComponentModel.CancelEventHandler(this.tboxCustomer_Validating);
            // 
            // ProjektstatusComboBox
            // 
            this.ProjektstatusComboBox.Location = new System.Drawing.Point(477, 40);
            this.ProjektstatusComboBox.Name = "ProjektstatusComboBox";
            this.ProjektstatusComboBox.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ProjektstatusComboBox.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjektstatusComboBox.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.ProjektstatusComboBox.Properties.Appearance.Options.UseBackColor = true;
            this.ProjektstatusComboBox.Properties.Appearance.Options.UseFont = true;
            this.ProjektstatusComboBox.Properties.Appearance.Options.UseForeColor = true;
            this.ProjektstatusComboBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ProjektstatusComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ProjektstatusComboBox.Properties.Items.AddRange(new object[] {
            "Pågående",
            "Avslutat"});
            this.ProjektstatusComboBox.Size = new System.Drawing.Size(180, 24);
            this.ProjektstatusComboBox.StyleController = this.dataLayoutControl2;
            this.ProjektstatusComboBox.TabIndex = 3;
            this.ProjektstatusComboBox.TabStop = false;
            this.ProjektstatusComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.cboProjectStatus_Validating);
            // 
            // KommunTextEdit
            // 
            this.KommunTextEdit.Location = new System.Drawing.Point(22, 178);
            this.KommunTextEdit.Name = "KommunTextEdit";
            this.KommunTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.KommunTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KommunTextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.KommunTextEdit.Properties.Appearance.Options.UseBackColor = true;
            this.KommunTextEdit.Properties.Appearance.Options.UseFont = true;
            this.KommunTextEdit.Properties.Appearance.Options.UseForeColor = true;
            this.KommunTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.KommunTextEdit.Size = new System.Drawing.Size(635, 24);
            this.KommunTextEdit.StyleController = this.dataLayoutControl2;
            this.KommunTextEdit.TabIndex = 7;
            this.KommunTextEdit.Validating += new System.ComponentModel.CancelEventHandler(this.tboxMunicipality_Validating);
            // 
            // BeskrivningTextEdit
            // 
            this.BeskrivningTextEdit.Location = new System.Drawing.Point(22, 224);
            this.BeskrivningTextEdit.Name = "BeskrivningTextEdit";
            this.BeskrivningTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.BeskrivningTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BeskrivningTextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.BeskrivningTextEdit.Properties.Appearance.Options.UseBackColor = true;
            this.BeskrivningTextEdit.Properties.Appearance.Options.UseFont = true;
            this.BeskrivningTextEdit.Properties.Appearance.Options.UseForeColor = true;
            this.BeskrivningTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.BeskrivningTextEdit.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.BeskrivningTextEdit.Size = new System.Drawing.Size(635, 47);
            this.BeskrivningTextEdit.StyleController = this.dataLayoutControl2;
            this.BeskrivningTextEdit.TabIndex = 5;
            // 
            // ProjectLayoutControl
            // 
            this.ProjectLayoutControl.AppearanceItemCaption.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectLayoutControl.AppearanceItemCaption.ForeColor = System.Drawing.Color.White;
            this.ProjectLayoutControl.AppearanceItemCaption.Options.UseFont = true;
            this.ProjectLayoutControl.AppearanceItemCaption.Options.UseForeColor = true;
            this.ProjectLayoutControl.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.ProjectLayoutControl.GroupBordersVisible = false;
            this.ProjectLayoutControl.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup4});
            this.ProjectLayoutControl.Name = "Root";
            this.ProjectLayoutControl.Padding = new DevExpress.XtraLayout.Utils.Padding(20, 20, 20, 20);
            this.ProjectLayoutControl.Size = new System.Drawing.Size(679, 293);
            this.ProjectLayoutControl.TextVisible = false;
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.AllowDrawBackground = false;
            this.layoutControlGroup4.GroupBordersVisible = false;
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.layoutControlGroup4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup4.Name = "autoGeneratedGroup0";
            this.layoutControlGroup4.Size = new System.Drawing.Size(639, 253);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem1.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.layoutControlItem1.Control = this.IDTextEdit;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "ItemForID";
            this.layoutControlItem1.Size = new System.Drawing.Size(201, 46);
            this.layoutControlItem1.Text = "ProjektID";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(84, 15);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.ProjektnamnTextEdit;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 46);
            this.layoutControlItem3.Name = "ItemForProjektnamn";
            this.layoutControlItem3.Size = new System.Drawing.Size(639, 46);
            this.layoutControlItem3.Text = "Projektnamn";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(84, 15);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.KundnamnTextEdit;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 92);
            this.layoutControlItem6.Name = "ItemForKundnamn";
            this.layoutControlItem6.Size = new System.Drawing.Size(639, 46);
            this.layoutControlItem6.Text = "Kundnamn";
            this.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(84, 15);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.KommunTextEdit;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 138);
            this.layoutControlItem7.Name = "ItemForKommun";
            this.layoutControlItem7.Size = new System.Drawing.Size(639, 46);
            this.layoutControlItem7.Text = "Kommun";
            this.layoutControlItem7.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(84, 15);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.ProjektnummerTextEdit;
            this.layoutControlItem2.Location = new System.Drawing.Point(201, 0);
            this.layoutControlItem2.Name = "ItemForProjektnummer";
            this.layoutControlItem2.Size = new System.Drawing.Size(254, 46);
            this.layoutControlItem2.Text = "Projektnummer";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(84, 15);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.ProjektstatusComboBox;
            this.layoutControlItem4.Location = new System.Drawing.Point(455, 0);
            this.layoutControlItem4.Name = "ItemForProjektstatus";
            this.layoutControlItem4.Size = new System.Drawing.Size(184, 46);
            this.layoutControlItem4.Text = "Projektstatus";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(84, 15);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.BeskrivningTextEdit;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 184);
            this.layoutControlItem5.Name = "ItemForBeskrivning";
            this.layoutControlItem5.Size = new System.Drawing.Size(639, 69);
            this.layoutControlItem5.Text = "Beskrivning";
            this.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(84, 15);
            // 
            // Header
            // 
            this.Header.Controls.Add(this.FormTitle);
            this.Header.Controls.Add(this.CloseForm);
            this.Header.Controls.Add(this.bunifuSeparator1);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(696, 50);
            this.Header.TabIndex = 129;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.UpdateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateBtn.FlatAppearance.BorderSize = 0;
            this.UpdateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBtn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UpdateBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateBtn.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.UpdateBtn.IconColor = System.Drawing.Color.White;
            this.UpdateBtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.UpdateBtn.IconSize = 25;
            this.UpdateBtn.Location = new System.Drawing.Point(188, 12);
            this.UpdateBtn.Margin = new System.Windows.Forms.Padding(2, 2, 8, 2);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(144, 42);
            this.UpdateBtn.TabIndex = 11;
            this.UpdateBtn.TabStop = false;
            this.UpdateBtn.Text = "UPPDATERA";
            this.UpdateBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Visible = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // InsertBtn
            // 
            this.InsertBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.InsertBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InsertBtn.FlatAppearance.BorderSize = 0;
            this.InsertBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(170)))), ((int)(((byte)(72)))));
            this.InsertBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsertBtn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.InsertBtn.ForeColor = System.Drawing.Color.White;
            this.InsertBtn.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.InsertBtn.IconColor = System.Drawing.Color.White;
            this.InsertBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.InsertBtn.IconSize = 25;
            this.InsertBtn.Location = new System.Drawing.Point(34, 12);
            this.InsertBtn.Margin = new System.Windows.Forms.Padding(2, 2, 8, 2);
            this.InsertBtn.Name = "InsertBtn";
            this.InsertBtn.Size = new System.Drawing.Size(144, 42);
            this.InsertBtn.TabIndex = 10;
            this.InsertBtn.TabStop = false;
            this.InsertBtn.Text = "SPARA";
            this.InsertBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.InsertBtn.UseVisualStyleBackColor = false;
            this.InsertBtn.Visible = false;
            this.InsertBtn.Click += new System.EventHandler(this.InsertBtn_Click);
            // 
            // Footer
            // 
            this.Footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Footer.Controls.Add(this.InsertBtn);
            this.Footer.Controls.Add(this.UpdateBtn);
            this.Footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Footer.Location = new System.Drawing.Point(0, 345);
            this.Footer.Margin = new System.Windows.Forms.Padding(2);
            this.Footer.Name = "Footer";
            this.Footer.Padding = new System.Windows.Forms.Padding(32, 10, 10, 10);
            this.Footer.Size = new System.Drawing.Size(696, 68);
            this.Footer.TabIndex = 125;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(170)))), ((int)(((byte)(72)))));
            this.bunifuSeparator1.LineThickness = 5;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 0);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(696, 5);
            this.bunifuSeparator1.TabIndex = 131;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // CloseForm
            // 
            this.CloseForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseForm.FlatAppearance.BorderSize = 0;
            this.CloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseForm.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseForm.ForeColor = System.Drawing.Color.White;
            this.CloseForm.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.CloseForm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(170)))), ((int)(((byte)(72)))));
            this.CloseForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CloseForm.IconSize = 30;
            this.CloseForm.Location = new System.Drawing.Point(651, 5);
            this.CloseForm.Name = "CloseForm";
            this.CloseForm.Size = new System.Drawing.Size(45, 45);
            this.CloseForm.TabIndex = 132;
            this.CloseForm.UseVisualStyleBackColor = true;
            this.CloseForm.Click += new System.EventHandler(this.CloseForm_Click);
            // 
            // FormTitle
            // 
            this.FormTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.FormTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(170)))), ((int)(((byte)(72)))));
            this.FormTitle.Location = new System.Drawing.Point(0, 5);
            this.FormTitle.Name = "FormTitle";
            this.FormTitle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.FormTitle.Size = new System.Drawing.Size(651, 45);
            this.FormTitle.TabIndex = 133;
            this.FormTitle.Text = "Space M2 For smart living AB";
            this.FormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(170)))), ((int)(((byte)(72)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(0, 340);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(696, 5);
            this.bunifuSeparator2.TabIndex = 132;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // ProjectForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(696, 413);
            this.Controls.Add(this.FormPanel);
            this.Controls.Add(this.Footer);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("ProjectForm.IconOptions.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projekt";
            this.Load += new System.EventHandler(this.ProjectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.FormPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl2)).EndInit();
            this.dataLayoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IDTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjektnummerTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjektnamnTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KundnamnTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjektstatusComboBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KommunTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BeskrivningTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectLayoutControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.Header.ResumeLayout(false);
            this.Footer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProviderApp;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private Panel FormPanel;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl2;
        private DevExpress.XtraEditors.TextEdit IDTextEdit;
        private DevExpress.XtraEditors.TextEdit ProjektnummerTextEdit;
        private DevExpress.XtraEditors.TextEdit ProjektnamnTextEdit;
        private DevExpress.XtraEditors.TextEdit KundnamnTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup ProjectLayoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.ComboBoxEdit ProjektstatusComboBox;
        private Panel Header;
        private FlowLayoutPanel Footer;
        private FontAwesome.Sharp.IconButton InsertBtn;
        private FontAwesome.Sharp.IconButton UpdateBtn;
        private DevExpress.XtraEditors.TextEdit KommunTextEdit;
        private DevExpress.XtraEditors.MemoEdit BeskrivningTextEdit;
        private Label FormTitle;
        private FontAwesome.Sharp.IconButton CloseForm;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
    }
}