
namespace FactoryManager.View.GridView
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.flpButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.InsertContinue = new FontAwesome.Sharp.IconButton();
            this.InsertClose = new FontAwesome.Sharp.IconButton();
            this.SaveChanges = new FontAwesome.Sharp.IconButton();
            this.InsertationPanel = new System.Windows.Forms.Panel();
            this.användareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.spaceM2Dataset = new FactoryManager.SpaceM2Dataset();
            this.användareBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.användareTableAdapter = new FactoryManager.SpaceM2DatasetTableAdapters.AnvändareTableAdapter();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.IDTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.UsernummerTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.RollsnummerTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.FörnamnTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.EfternamnTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.LösenordTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.BildLänkTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForID = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForUsernummer = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForRollsnummer = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForFörnamn = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEfternamn = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForLösenord = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForBildLänk = new DevExpress.XtraLayout.LayoutControlItem();
            this.flpButtons.SuspendLayout();
            this.InsertationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.användareBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spaceM2Dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.användareBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsernummerTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RollsnummerTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FörnamnTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EfternamnTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LösenordTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BildLänkTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUsernummer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRollsnummer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFörnamn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEfternamn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLösenord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBildLänk)).BeginInit();
            this.SuspendLayout();
            // 
            // flpButtons
            // 
            this.flpButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.flpButtons.Controls.Add(this.InsertContinue);
            this.flpButtons.Controls.Add(this.InsertClose);
            this.flpButtons.Controls.Add(this.SaveChanges);
            this.flpButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpButtons.Location = new System.Drawing.Point(0, 228);
            this.flpButtons.Margin = new System.Windows.Forms.Padding(2);
            this.flpButtons.Name = "flpButtons";
            this.flpButtons.Padding = new System.Windows.Forms.Padding(15, 14, 13, 14);
            this.flpButtons.Size = new System.Drawing.Size(692, 73);
            this.flpButtons.TabIndex = 125;
            // 
            // InsertContinue
            // 
            this.InsertContinue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.InsertContinue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(170)))), ((int)(((byte)(72)))));
            this.InsertContinue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InsertContinue.FlatAppearance.BorderSize = 0;
            this.InsertContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsertContinue.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.InsertContinue.ForeColor = System.Drawing.Color.White;
            this.InsertContinue.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.InsertContinue.IconColor = System.Drawing.Color.White;
            this.InsertContinue.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.InsertContinue.IconSize = 25;
            this.InsertContinue.Location = new System.Drawing.Point(17, 16);
            this.InsertContinue.Margin = new System.Windows.Forms.Padding(2, 2, 8, 2);
            this.InsertContinue.Name = "InsertContinue";
            this.InsertContinue.Size = new System.Drawing.Size(143, 41);
            this.InsertContinue.TabIndex = 6;
            this.InsertContinue.TabStop = false;
            this.InsertContinue.Text = "SPARA | FORTSÄTTA";
            this.InsertContinue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.InsertContinue.UseVisualStyleBackColor = false;
            this.InsertContinue.Visible = false;
            this.InsertContinue.Click += new System.EventHandler(this.Insert_Click);
            // 
            // InsertClose
            // 
            this.InsertClose.BackColor = System.Drawing.Color.Goldenrod;
            this.InsertClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InsertClose.FlatAppearance.BorderSize = 0;
            this.InsertClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsertClose.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.InsertClose.ForeColor = System.Drawing.Color.White;
            this.InsertClose.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.InsertClose.IconColor = System.Drawing.Color.White;
            this.InsertClose.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.InsertClose.IconSize = 25;
            this.InsertClose.Location = new System.Drawing.Point(170, 16);
            this.InsertClose.Margin = new System.Windows.Forms.Padding(2, 2, 8, 2);
            this.InsertClose.Name = "InsertClose";
            this.InsertClose.Size = new System.Drawing.Size(143, 41);
            this.InsertClose.TabIndex = 7;
            this.InsertClose.TabStop = false;
            this.InsertClose.Text = "SPARA | STÄNG";
            this.InsertClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.InsertClose.UseVisualStyleBackColor = false;
            this.InsertClose.Visible = false;
            // 
            // SaveChanges
            // 
            this.SaveChanges.BackColor = System.Drawing.Color.MediumPurple;
            this.SaveChanges.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveChanges.FlatAppearance.BorderSize = 0;
            this.SaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveChanges.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SaveChanges.ForeColor = System.Drawing.Color.White;
            this.SaveChanges.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.SaveChanges.IconColor = System.Drawing.Color.White;
            this.SaveChanges.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.SaveChanges.IconSize = 25;
            this.SaveChanges.Location = new System.Drawing.Point(323, 16);
            this.SaveChanges.Margin = new System.Windows.Forms.Padding(2, 2, 8, 2);
            this.SaveChanges.Name = "SaveChanges";
            this.SaveChanges.Size = new System.Drawing.Size(116, 41);
            this.SaveChanges.TabIndex = 9;
            this.SaveChanges.TabStop = false;
            this.SaveChanges.Text = "UPPDATERA";
            this.SaveChanges.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SaveChanges.UseVisualStyleBackColor = false;
            this.SaveChanges.Visible = false;
            this.SaveChanges.Click += new System.EventHandler(this.SaveChanges_Click);
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
            this.InsertationPanel.Size = new System.Drawing.Size(692, 228);
            this.InsertationPanel.TabIndex = 127;
            // 
            // användareBindingSource
            // 
            this.användareBindingSource.DataMember = "Användare";
            this.användareBindingSource.DataSource = typeof(FactoryManager.SpaceM2Dataset);
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.IDTextEdit);
            this.dataLayoutControl1.Controls.Add(this.UsernummerTextEdit);
            this.dataLayoutControl1.Controls.Add(this.RollsnummerTextEdit);
            this.dataLayoutControl1.Controls.Add(this.FörnamnTextEdit);
            this.dataLayoutControl1.Controls.Add(this.EfternamnTextEdit);
            this.dataLayoutControl1.Controls.Add(this.LösenordTextEdit);
            this.dataLayoutControl1.Controls.Add(this.BildLänkTextEdit);
            this.dataLayoutControl1.DataSource = this.användareBindingSource1;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(532, 0, 650, 400);
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(216, 228);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(216, 228);
            this.Root.TextVisible = false;
            // 
            // spaceM2Dataset
            // 
            this.spaceM2Dataset.DataSetName = "SpaceM2Dataset";
            this.spaceM2Dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // användareBindingSource1
            // 
            this.användareBindingSource1.DataMember = "Användare";
            this.användareBindingSource1.DataSource = this.spaceM2Dataset;
            // 
            // användareTableAdapter
            // 
            this.användareTableAdapter.ClearBeforeFill = true;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForID,
            this.ItemForUsernummer,
            this.ItemForRollsnummer,
            this.ItemForFörnamn,
            this.ItemForEfternamn,
            this.ItemForLösenord,
            this.ItemForBildLänk});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(196, 208);
            // 
            // IDTextEdit
            // 
            this.IDTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.användareBindingSource1, "ID", true));
            this.IDTextEdit.Location = new System.Drawing.Point(76, 12);
            this.IDTextEdit.Name = "IDTextEdit";
            this.IDTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.IDTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.IDTextEdit.Properties.Mask.EditMask = "N0";
            this.IDTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.IDTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.IDTextEdit.Size = new System.Drawing.Size(128, 20);
            this.IDTextEdit.StyleController = this.dataLayoutControl1;
            this.IDTextEdit.TabIndex = 4;
            // 
            // UsernummerTextEdit
            // 
            this.UsernummerTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.användareBindingSource1, "Usernummer", true));
            this.UsernummerTextEdit.Location = new System.Drawing.Point(76, 36);
            this.UsernummerTextEdit.Name = "UsernummerTextEdit";
            this.UsernummerTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.UsernummerTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.UsernummerTextEdit.Properties.Mask.EditMask = "N0";
            this.UsernummerTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.UsernummerTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.UsernummerTextEdit.Size = new System.Drawing.Size(128, 20);
            this.UsernummerTextEdit.StyleController = this.dataLayoutControl1;
            this.UsernummerTextEdit.TabIndex = 5;
            // 
            // RollsnummerTextEdit
            // 
            this.RollsnummerTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.användareBindingSource1, "Rollsnummer", true));
            this.RollsnummerTextEdit.Location = new System.Drawing.Point(76, 60);
            this.RollsnummerTextEdit.Name = "RollsnummerTextEdit";
            this.RollsnummerTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.RollsnummerTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.RollsnummerTextEdit.Properties.Mask.EditMask = "N0";
            this.RollsnummerTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.RollsnummerTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.RollsnummerTextEdit.Size = new System.Drawing.Size(128, 20);
            this.RollsnummerTextEdit.StyleController = this.dataLayoutControl1;
            this.RollsnummerTextEdit.TabIndex = 6;
            // 
            // FörnamnTextEdit
            // 
            this.FörnamnTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.användareBindingSource1, "Förnamn", true));
            this.FörnamnTextEdit.Location = new System.Drawing.Point(76, 84);
            this.FörnamnTextEdit.Name = "FörnamnTextEdit";
            this.FörnamnTextEdit.Size = new System.Drawing.Size(128, 20);
            this.FörnamnTextEdit.StyleController = this.dataLayoutControl1;
            this.FörnamnTextEdit.TabIndex = 7;
            // 
            // EfternamnTextEdit
            // 
            this.EfternamnTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.användareBindingSource1, "Efternamn", true));
            this.EfternamnTextEdit.Location = new System.Drawing.Point(76, 108);
            this.EfternamnTextEdit.Name = "EfternamnTextEdit";
            this.EfternamnTextEdit.Size = new System.Drawing.Size(128, 20);
            this.EfternamnTextEdit.StyleController = this.dataLayoutControl1;
            this.EfternamnTextEdit.TabIndex = 8;
            // 
            // LösenordTextEdit
            // 
            this.LösenordTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.användareBindingSource1, "Lösenord", true));
            this.LösenordTextEdit.Location = new System.Drawing.Point(76, 132);
            this.LösenordTextEdit.Name = "LösenordTextEdit";
            this.LösenordTextEdit.Size = new System.Drawing.Size(128, 20);
            this.LösenordTextEdit.StyleController = this.dataLayoutControl1;
            this.LösenordTextEdit.TabIndex = 9;
            // 
            // BildLänkTextEdit
            // 
            this.BildLänkTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.användareBindingSource1, "BildLänk", true));
            this.BildLänkTextEdit.Location = new System.Drawing.Point(76, 156);
            this.BildLänkTextEdit.Name = "BildLänkTextEdit";
            this.BildLänkTextEdit.Size = new System.Drawing.Size(128, 20);
            this.BildLänkTextEdit.StyleController = this.dataLayoutControl1;
            this.BildLänkTextEdit.TabIndex = 10;
            // 
            // ItemForID
            // 
            this.ItemForID.Control = this.IDTextEdit;
            this.ItemForID.Location = new System.Drawing.Point(0, 0);
            this.ItemForID.Name = "ItemForID";
            this.ItemForID.Size = new System.Drawing.Size(196, 24);
            this.ItemForID.Text = "ID";
            this.ItemForID.TextSize = new System.Drawing.Size(60, 13);
            // 
            // ItemForUsernummer
            // 
            this.ItemForUsernummer.Control = this.UsernummerTextEdit;
            this.ItemForUsernummer.Location = new System.Drawing.Point(0, 24);
            this.ItemForUsernummer.Name = "ItemForUsernummer";
            this.ItemForUsernummer.Size = new System.Drawing.Size(196, 24);
            this.ItemForUsernummer.Text = "Usernummer";
            this.ItemForUsernummer.TextSize = new System.Drawing.Size(60, 13);
            // 
            // ItemForRollsnummer
            // 
            this.ItemForRollsnummer.Control = this.RollsnummerTextEdit;
            this.ItemForRollsnummer.Location = new System.Drawing.Point(0, 48);
            this.ItemForRollsnummer.Name = "ItemForRollsnummer";
            this.ItemForRollsnummer.Size = new System.Drawing.Size(196, 24);
            this.ItemForRollsnummer.Text = "Rollsnummer";
            this.ItemForRollsnummer.TextSize = new System.Drawing.Size(60, 13);
            // 
            // ItemForFörnamn
            // 
            this.ItemForFörnamn.Control = this.FörnamnTextEdit;
            this.ItemForFörnamn.Location = new System.Drawing.Point(0, 72);
            this.ItemForFörnamn.Name = "ItemForFörnamn";
            this.ItemForFörnamn.Size = new System.Drawing.Size(196, 24);
            this.ItemForFörnamn.Text = "Förnamn";
            this.ItemForFörnamn.TextSize = new System.Drawing.Size(60, 13);
            // 
            // ItemForEfternamn
            // 
            this.ItemForEfternamn.Control = this.EfternamnTextEdit;
            this.ItemForEfternamn.Location = new System.Drawing.Point(0, 96);
            this.ItemForEfternamn.Name = "ItemForEfternamn";
            this.ItemForEfternamn.Size = new System.Drawing.Size(196, 24);
            this.ItemForEfternamn.Text = "Efternamn";
            this.ItemForEfternamn.TextSize = new System.Drawing.Size(60, 13);
            // 
            // ItemForLösenord
            // 
            this.ItemForLösenord.Control = this.LösenordTextEdit;
            this.ItemForLösenord.Location = new System.Drawing.Point(0, 120);
            this.ItemForLösenord.Name = "ItemForLösenord";
            this.ItemForLösenord.Size = new System.Drawing.Size(196, 24);
            this.ItemForLösenord.Text = "Lösenord";
            this.ItemForLösenord.TextSize = new System.Drawing.Size(60, 13);
            // 
            // ItemForBildLänk
            // 
            this.ItemForBildLänk.Control = this.BildLänkTextEdit;
            this.ItemForBildLänk.Location = new System.Drawing.Point(0, 144);
            this.ItemForBildLänk.Name = "ItemForBildLänk";
            this.ItemForBildLänk.Size = new System.Drawing.Size(196, 64);
            this.ItemForBildLänk.Text = "Bild Länk";
            this.ItemForBildLänk.TextSize = new System.Drawing.Size(60, 13);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(170)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(692, 301);
            this.ControlBox = false;
            this.Controls.Add(this.InsertationPanel);
            this.Controls.Add(this.flpButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.flpButtons.ResumeLayout(false);
            this.InsertationPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.användareBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spaceM2Dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.användareBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsernummerTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RollsnummerTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FörnamnTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EfternamnTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LösenordTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BildLänkTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUsernummer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRollsnummer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFörnamn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEfternamn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLösenord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBildLänk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flpButtons;
        private FontAwesome.Sharp.IconButton InsertContinue;
        private FontAwesome.Sharp.IconButton InsertClose;
        private FontAwesome.Sharp.IconButton SaveChanges;
        private System.Windows.Forms.Panel InsertationPanel;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private System.Windows.Forms.BindingSource användareBindingSource;
        private SpaceM2Dataset spaceM2Dataset;
        private System.Windows.Forms.BindingSource användareBindingSource1;
        private SpaceM2DatasetTableAdapters.AnvändareTableAdapter användareTableAdapter;
        private DevExpress.XtraEditors.TextEdit IDTextEdit;
        private DevExpress.XtraEditors.TextEdit UsernummerTextEdit;
        private DevExpress.XtraEditors.TextEdit RollsnummerTextEdit;
        private DevExpress.XtraEditors.TextEdit FörnamnTextEdit;
        private DevExpress.XtraEditors.TextEdit EfternamnTextEdit;
        private DevExpress.XtraEditors.TextEdit LösenordTextEdit;
        private DevExpress.XtraEditors.TextEdit BildLänkTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForID;
        private DevExpress.XtraLayout.LayoutControlItem ItemForUsernummer;
        private DevExpress.XtraLayout.LayoutControlItem ItemForRollsnummer;
        private DevExpress.XtraLayout.LayoutControlItem ItemForFörnamn;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEfternamn;
        private DevExpress.XtraLayout.LayoutControlItem ItemForLösenord;
        private DevExpress.XtraLayout.LayoutControlItem ItemForBildLänk;
    }
}