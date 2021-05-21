
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
            this.flpButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.InsertBtn = new FontAwesome.Sharp.IconButton();
            this.UpdateBtn = new FontAwesome.Sharp.IconButton();
            this.InsertationPanel = new System.Windows.Forms.Panel();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.tboxProjectId = new DevExpress.XtraEditors.TextEdit();
            this.projektBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spaceM2Dataset = new FactoryManager.SpaceM2Dataset();
            this.tboxProjectNumber = new DevExpress.XtraEditors.TextEdit();
            this.tboxProjectName = new DevExpress.XtraEditors.TextEdit();
            this.tboxDescription = new DevExpress.XtraEditors.MemoEdit();
            this.tboxCustomer = new DevExpress.XtraEditors.TextEdit();
            this.tboxMunicipality = new DevExpress.XtraEditors.TextEdit();
            this.cboProjectStatus = new System.Windows.Forms.ComboBox();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForID = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForProjektnamn = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForProjektnummer = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForProjektstatus = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForKundnamn = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForKommun = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForBeskrivning = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            this.errorProviderApp = new System.Windows.Forms.ErrorProvider(this.components);
            this.projektTableAdapter = new FactoryManager.SpaceM2DatasetTableAdapters.ProjektTableAdapter();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.flpButtons.SuspendLayout();
            this.InsertationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tboxProjectId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spaceM2Dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tboxProjectNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tboxProjectName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tboxDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tboxCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tboxMunicipality.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForProjektnamn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForProjektnummer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForProjektstatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForKundnamn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForKommun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBeskrivning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // flpButtons
            // 
            this.flpButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.flpButtons.Controls.Add(this.InsertBtn);
            this.flpButtons.Controls.Add(this.UpdateBtn);
            this.flpButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpButtons.Location = new System.Drawing.Point(0, 295);
            this.flpButtons.Margin = new System.Windows.Forms.Padding(2);
            this.flpButtons.Name = "flpButtons";
            this.flpButtons.Padding = new System.Windows.Forms.Padding(0, 14, 13, 14);
            this.flpButtons.Size = new System.Drawing.Size(692, 73);
            this.flpButtons.TabIndex = 125;
            // 
            // InsertBtn
            // 
            this.InsertBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(170)))), ((int)(((byte)(72)))));
            this.InsertBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InsertBtn.FlatAppearance.BorderSize = 0;
            this.InsertBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsertBtn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.InsertBtn.ForeColor = System.Drawing.Color.White;
            this.InsertBtn.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.InsertBtn.IconColor = System.Drawing.Color.White;
            this.InsertBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.InsertBtn.IconSize = 25;
            this.InsertBtn.Location = new System.Drawing.Point(2, 16);
            this.InsertBtn.Margin = new System.Windows.Forms.Padding(2, 2, 8, 2);
            this.InsertBtn.Name = "InsertBtn";
            this.InsertBtn.Size = new System.Drawing.Size(116, 41);
            this.InsertBtn.TabIndex = 10;
            this.InsertBtn.TabStop = false;
            this.InsertBtn.Text = "SPARA";
            this.InsertBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.InsertBtn.UseVisualStyleBackColor = false;
            this.InsertBtn.Visible = false;
            this.InsertBtn.Click += new System.EventHandler(this.InsertBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.Chocolate;
            this.UpdateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateBtn.FlatAppearance.BorderSize = 0;
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBtn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UpdateBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateBtn.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.UpdateBtn.IconColor = System.Drawing.Color.White;
            this.UpdateBtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.UpdateBtn.IconSize = 25;
            this.UpdateBtn.Location = new System.Drawing.Point(128, 16);
            this.UpdateBtn.Margin = new System.Windows.Forms.Padding(2, 2, 8, 2);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(116, 41);
            this.UpdateBtn.TabIndex = 11;
            this.UpdateBtn.TabStop = false;
            this.UpdateBtn.Text = "UPPDATERA";
            this.UpdateBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Visible = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // InsertationPanel
            // 
            this.InsertationPanel.AutoScroll = true;
            this.InsertationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.InsertationPanel.Controls.Add(this.dataLayoutControl1);
            this.InsertationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InsertationPanel.Location = new System.Drawing.Point(0, 0);
            this.InsertationPanel.Margin = new System.Windows.Forms.Padding(2);
            this.InsertationPanel.Name = "InsertationPanel";
            this.InsertationPanel.Size = new System.Drawing.Size(692, 295);
            this.InsertationPanel.TabIndex = 127;
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.BackColor = System.Drawing.Color.White;
            this.dataLayoutControl1.Controls.Add(this.tboxProjectId);
            this.dataLayoutControl1.Controls.Add(this.tboxProjectNumber);
            this.dataLayoutControl1.Controls.Add(this.tboxProjectName);
            this.dataLayoutControl1.Controls.Add(this.tboxDescription);
            this.dataLayoutControl1.Controls.Add(this.tboxCustomer);
            this.dataLayoutControl1.Controls.Add(this.tboxMunicipality);
            this.dataLayoutControl1.Controls.Add(this.cboProjectStatus);
            this.dataLayoutControl1.DataSource = this.projektBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(692, 295);
            this.dataLayoutControl1.TabIndex = 126;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // tboxProjectId
            // 
            this.tboxProjectId.DataBindings.Add(new System.Windows.Forms.Binding("ReadOnly", this.projektBindingSource, "ID", true));
            this.tboxProjectId.Dock = System.Windows.Forms.DockStyle.Left;
            this.tboxProjectId.Location = new System.Drawing.Point(99, 43);
            this.tboxProjectId.MaximumSize = new System.Drawing.Size(154, 0);
            this.tboxProjectId.Name = "tboxProjectId";
            this.tboxProjectId.Properties.Appearance.Options.UseTextOptions = true;
            this.tboxProjectId.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.tboxProjectId.Properties.Mask.EditMask = "N0";
            this.tboxProjectId.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tboxProjectId.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.tboxProjectId.Size = new System.Drawing.Size(150, 20);
            this.tboxProjectId.StyleController = this.dataLayoutControl1;
            this.tboxProjectId.TabIndex = 5;
            // 
            // projektBindingSource
            // 
            this.projektBindingSource.DataMember = "Projekt";
            this.projektBindingSource.DataSource = this.spaceM2Dataset;
            // 
            // spaceM2Dataset
            // 
            this.spaceM2Dataset.DataSetName = "SpaceM2Dataset";
            this.spaceM2Dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tboxProjectNumber
            // 
            this.tboxProjectNumber.Location = new System.Drawing.Point(328, 43);
            this.tboxProjectNumber.MaximumSize = new System.Drawing.Size(154, 0);
            this.tboxProjectNumber.Name = "tboxProjectNumber";
            this.tboxProjectNumber.Size = new System.Drawing.Size(131, 20);
            this.tboxProjectNumber.StyleController = this.dataLayoutControl1;
            this.tboxProjectNumber.TabIndex = 6;
            // 
            // tboxProjectName
            // 
            this.tboxProjectName.Location = new System.Drawing.Point(99, 67);
            this.tboxProjectName.Name = "tboxProjectName";
            this.tboxProjectName.Size = new System.Drawing.Size(569, 20);
            this.tboxProjectName.StyleController = this.dataLayoutControl1;
            this.tboxProjectName.TabIndex = 7;
            this.tboxProjectName.Validating += new System.ComponentModel.CancelEventHandler(this.tboxProjectName_Validating);
            // 
            // tboxDescription
            // 
            this.tboxDescription.Location = new System.Drawing.Point(99, 139);
            this.tboxDescription.Name = "tboxDescription";
            this.tboxDescription.Size = new System.Drawing.Size(569, 131);
            this.tboxDescription.StyleController = this.dataLayoutControl1;
            this.tboxDescription.TabIndex = 9;
            // 
            // tboxCustomer
            // 
            this.tboxCustomer.Location = new System.Drawing.Point(99, 91);
            this.tboxCustomer.Name = "tboxCustomer";
            this.tboxCustomer.Size = new System.Drawing.Size(569, 20);
            this.tboxCustomer.StyleController = this.dataLayoutControl1;
            this.tboxCustomer.TabIndex = 10;
            this.tboxCustomer.Validating += new System.ComponentModel.CancelEventHandler(this.tboxCustomer_Validating);
            // 
            // tboxMunicipality
            // 
            this.tboxMunicipality.Location = new System.Drawing.Point(99, 115);
            this.tboxMunicipality.Name = "tboxMunicipality";
            this.tboxMunicipality.Size = new System.Drawing.Size(569, 20);
            this.tboxMunicipality.StyleController = this.dataLayoutControl1;
            this.tboxMunicipality.TabIndex = 11;
            this.tboxMunicipality.Validating += new System.ComponentModel.CancelEventHandler(this.tboxMunicipality_Validating);
            // 
            // cboProjectStatus
            // 
            this.cboProjectStatus.Items.AddRange(new object[] {
            "Avslutat",
            "Pågående"});
            this.cboProjectStatus.Location = new System.Drawing.Point(538, 43);
            this.cboProjectStatus.MaximumSize = new System.Drawing.Size(154, 0);
            this.cboProjectStatus.Name = "cboProjectStatus";
            this.cboProjectStatus.Size = new System.Drawing.Size(130, 21);
            this.cboProjectStatus.TabIndex = 8;
            this.cboProjectStatus.Validating += new System.ComponentModel.CancelEventHandler(this.cboProjectStatus_Validating);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.simpleSeparator1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(692, 295);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(672, 274);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForID,
            this.ItemForProjektnamn,
            this.ItemForProjektnummer,
            this.ItemForProjektstatus,
            this.ItemForKundnamn,
            this.ItemForKommun,
            this.ItemForBeskrivning});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(672, 274);
            this.layoutControlGroup1.Text = "Projektinfo";
            // 
            // ItemForID
            // 
            this.ItemForID.Control = this.tboxProjectId;
            this.ItemForID.Location = new System.Drawing.Point(0, 0);
            this.ItemForID.MaxSize = new System.Drawing.Size(229, 24);
            this.ItemForID.MinSize = new System.Drawing.Size(229, 24);
            this.ItemForID.Name = "ItemForID";
            this.ItemForID.Size = new System.Drawing.Size(229, 24);
            this.ItemForID.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.ItemForID.Text = "ID";
            this.ItemForID.TextLocation = DevExpress.Utils.Locations.Left;
            this.ItemForID.TextSize = new System.Drawing.Size(72, 13);
            // 
            // ItemForProjektnamn
            // 
            this.ItemForProjektnamn.Control = this.tboxProjectName;
            this.ItemForProjektnamn.Location = new System.Drawing.Point(0, 24);
            this.ItemForProjektnamn.Name = "ItemForProjektnamn";
            this.ItemForProjektnamn.Size = new System.Drawing.Size(648, 24);
            this.ItemForProjektnamn.Text = "Projektnamn";
            this.ItemForProjektnamn.TextSize = new System.Drawing.Size(72, 13);
            // 
            // ItemForProjektnummer
            // 
            this.ItemForProjektnummer.Control = this.tboxProjectNumber;
            this.ItemForProjektnummer.Location = new System.Drawing.Point(229, 0);
            this.ItemForProjektnummer.MaxSize = new System.Drawing.Size(210, 24);
            this.ItemForProjektnummer.MinSize = new System.Drawing.Size(210, 24);
            this.ItemForProjektnummer.Name = "ItemForProjektnummer";
            this.ItemForProjektnummer.Size = new System.Drawing.Size(210, 24);
            this.ItemForProjektnummer.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.ItemForProjektnummer.Text = "Projektnummer";
            this.ItemForProjektnummer.TextLocation = DevExpress.Utils.Locations.Left;
            this.ItemForProjektnummer.TextSize = new System.Drawing.Size(72, 13);
            // 
            // ItemForProjektstatus
            // 
            this.ItemForProjektstatus.Control = this.cboProjectStatus;
            this.ItemForProjektstatus.Location = new System.Drawing.Point(439, 0);
            this.ItemForProjektstatus.MaxSize = new System.Drawing.Size(209, 0);
            this.ItemForProjektstatus.MinSize = new System.Drawing.Size(209, 24);
            this.ItemForProjektstatus.Name = "ItemForProjektstatus";
            this.ItemForProjektstatus.Size = new System.Drawing.Size(209, 24);
            this.ItemForProjektstatus.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.ItemForProjektstatus.Text = "Projektstatus";
            this.ItemForProjektstatus.TextSize = new System.Drawing.Size(72, 13);
            // 
            // ItemForKundnamn
            // 
            this.ItemForKundnamn.Control = this.tboxCustomer;
            this.ItemForKundnamn.Location = new System.Drawing.Point(0, 48);
            this.ItemForKundnamn.Name = "ItemForKundnamn";
            this.ItemForKundnamn.Size = new System.Drawing.Size(648, 24);
            this.ItemForKundnamn.Text = "Kundnamn";
            this.ItemForKundnamn.TextSize = new System.Drawing.Size(72, 13);
            // 
            // ItemForKommun
            // 
            this.ItemForKommun.Control = this.tboxMunicipality;
            this.ItemForKommun.Location = new System.Drawing.Point(0, 72);
            this.ItemForKommun.Name = "ItemForKommun";
            this.ItemForKommun.Size = new System.Drawing.Size(648, 24);
            this.ItemForKommun.Text = "Kommun";
            this.ItemForKommun.TextSize = new System.Drawing.Size(72, 13);
            // 
            // ItemForBeskrivning
            // 
            this.ItemForBeskrivning.Control = this.tboxDescription;
            this.ItemForBeskrivning.Location = new System.Drawing.Point(0, 96);
            this.ItemForBeskrivning.Name = "ItemForBeskrivning";
            this.ItemForBeskrivning.Size = new System.Drawing.Size(648, 135);
            this.ItemForBeskrivning.StartNewLine = true;
            this.ItemForBeskrivning.Text = "Beskrivning";
            this.ItemForBeskrivning.TextSize = new System.Drawing.Size(72, 13);
            // 
            // simpleSeparator1
            // 
            this.simpleSeparator1.AllowHotTrack = false;
            this.simpleSeparator1.Location = new System.Drawing.Point(0, 274);
            this.simpleSeparator1.Name = "simpleSeparator1";
            this.simpleSeparator1.Size = new System.Drawing.Size(672, 1);
            // 
            // errorProviderApp
            // 
            this.errorProviderApp.ContainerControl = this;
            // 
            // projektTableAdapter
            // 
            this.projektTableAdapter.ClearBeforeFill = true;
            // 
            // ProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(692, 368);
            this.ControlBox = false;
            this.Controls.Add(this.InsertationPanel);
            this.Controls.Add(this.flpButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ProjectForm_Load);
            this.flpButtons.ResumeLayout(false);
            this.InsertationPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tboxProjectId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spaceM2Dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tboxProjectNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tboxProjectName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tboxDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tboxCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tboxMunicipality.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForProjektnamn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForProjektnummer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForProjektstatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForKundnamn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForKommun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBeskrivning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flpButtons;
        private System.Windows.Forms.Panel InsertationPanel;
        private System.Windows.Forms.ErrorProvider errorProviderApp;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private SpaceM2Dataset spaceM2Dataset;
        private System.Windows.Forms.BindingSource projektBindingSource;
        private SpaceM2DatasetTableAdapters.ProjektTableAdapter projektTableAdapter;
        private DevExpress.XtraEditors.TextEdit tboxProjectId;
        private DevExpress.XtraEditors.TextEdit tboxProjectNumber;
        private DevExpress.XtraEditors.TextEdit tboxProjectName;
        private DevExpress.XtraEditors.MemoEdit tboxDescription;
        private DevExpress.XtraEditors.TextEdit tboxCustomer;
        private DevExpress.XtraEditors.TextEdit tboxMunicipality;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForID;
        private DevExpress.XtraLayout.LayoutControlItem ItemForProjektnamn;
        private DevExpress.XtraLayout.LayoutControlItem ItemForProjektnummer;
        private DevExpress.XtraLayout.LayoutControlItem ItemForProjektstatus;
        private DevExpress.XtraLayout.LayoutControlItem ItemForKundnamn;
        private DevExpress.XtraLayout.LayoutControlItem ItemForKommun;
        private DevExpress.XtraLayout.LayoutControlItem ItemForBeskrivning;
        private ComboBox cboProjectStatus;
        private FontAwesome.Sharp.IconButton InsertBtn;
        private FontAwesome.Sharp.IconButton UpdateBtn;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}