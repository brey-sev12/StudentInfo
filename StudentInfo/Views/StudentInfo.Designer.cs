namespace StudentInfo
{
    partial class StudentInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentInfo));
            this.gcStudentInfo = new DevExpress.XtraGrid.GridControl();
            this.gvStudentInfo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.FirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MiddleName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Sex = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CivilStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Address = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Contact = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.teFirstName = new DevExpress.XtraEditors.TextEdit();
            this.teMiddleName = new DevExpress.XtraEditors.TextEdit();
            this.teLastName = new DevExpress.XtraEditors.TextEdit();
            this.teContact = new DevExpress.XtraEditors.TextEdit();
            this.teAddress = new DevExpress.XtraEditors.TextEdit();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.lcFirstName = new DevExpress.XtraEditors.LabelControl();
            this.lcMiddleName = new DevExpress.XtraEditors.LabelControl();
            this.lcLastName = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lcAddress = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cbeSex = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbeCivilStatus = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gcStudentInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudentInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teFirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMiddleName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teContact.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeSex.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeCivilStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gcStudentInfo
            // 
            this.gcStudentInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gcStudentInfo.Location = new System.Drawing.Point(0, 324);
            this.gcStudentInfo.MainView = this.gvStudentInfo;
            this.gcStudentInfo.Name = "gcStudentInfo";
            this.gcStudentInfo.Size = new System.Drawing.Size(1046, 370);
            this.gcStudentInfo.TabIndex = 1;
            this.gcStudentInfo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvStudentInfo});
            // 
            // gvStudentInfo
            // 
            this.gvStudentInfo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.FirstName,
            this.MiddleName,
            this.LastName,
            this.Sex,
            this.CivilStatus,
            this.Address,
            this.Contact});
            this.gvStudentInfo.GridControl = this.gcStudentInfo;
            this.gvStudentInfo.Name = "gvStudentInfo";
            this.gvStudentInfo.OptionsCustomization.CustomizationFormSearchBoxVisible = true;
            this.gvStudentInfo.OptionsFind.AlwaysVisible = true;
            this.gvStudentInfo.OptionsFind.FindNullPrompt = "Search keywords";
            this.gvStudentInfo.OptionsFind.FindPanelLocation = DevExpress.XtraGrid.Views.Grid.GridFindPanelLocation.Panel;
            this.gvStudentInfo.OptionsView.ShowGroupPanel = false;
            // 
            // FirstName
            // 
            this.FirstName.Caption = "Firstname";
            this.FirstName.FieldName = "FirstName";
            this.FirstName.MinWidth = 25;
            this.FirstName.Name = "FirstName";
            this.FirstName.OptionsColumn.AllowEdit = false;
            this.FirstName.Visible = true;
            this.FirstName.VisibleIndex = 0;
            this.FirstName.Width = 94;
            // 
            // MiddleName
            // 
            this.MiddleName.Caption = "Middlename";
            this.MiddleName.FieldName = "MiddleName";
            this.MiddleName.MinWidth = 25;
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.OptionsColumn.AllowEdit = false;
            this.MiddleName.Visible = true;
            this.MiddleName.VisibleIndex = 1;
            this.MiddleName.Width = 94;
            // 
            // LastName
            // 
            this.LastName.Caption = "Lastname";
            this.LastName.FieldName = "LastName";
            this.LastName.MinWidth = 25;
            this.LastName.Name = "LastName";
            this.LastName.OptionsColumn.AllowEdit = false;
            this.LastName.Visible = true;
            this.LastName.VisibleIndex = 2;
            this.LastName.Width = 94;
            // 
            // Sex
            // 
            this.Sex.Caption = "Sex";
            this.Sex.FieldName = "Sex";
            this.Sex.MinWidth = 25;
            this.Sex.Name = "Sex";
            this.Sex.OptionsColumn.AllowEdit = false;
            this.Sex.Visible = true;
            this.Sex.VisibleIndex = 5;
            this.Sex.Width = 94;
            // 
            // CivilStatus
            // 
            this.CivilStatus.Caption = "Civil Status";
            this.CivilStatus.FieldName = "CivilStatus";
            this.CivilStatus.MinWidth = 25;
            this.CivilStatus.Name = "CivilStatus";
            this.CivilStatus.OptionsColumn.AllowEdit = false;
            this.CivilStatus.Visible = true;
            this.CivilStatus.VisibleIndex = 6;
            this.CivilStatus.Width = 94;
            // 
            // Address
            // 
            this.Address.Caption = "Address";
            this.Address.FieldName = "Address";
            this.Address.MinWidth = 25;
            this.Address.Name = "Address";
            this.Address.OptionsColumn.AllowEdit = false;
            this.Address.Visible = true;
            this.Address.VisibleIndex = 4;
            this.Address.Width = 94;
            // 
            // Contact
            // 
            this.Contact.Caption = "Contact Number";
            this.Contact.FieldName = "Contact";
            this.Contact.MinWidth = 25;
            this.Contact.Name = "Contact";
            this.Contact.OptionsColumn.AllowEdit = false;
            this.Contact.Visible = true;
            this.Contact.VisibleIndex = 3;
            this.Contact.Width = 94;
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAdd.Appearance.Options.UseBackColor = true;
            this.btnAdd.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAdd.ImageOptions.SvgImage")));
            this.btnAdd.Location = new System.Drawing.Point(564, 181);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 43);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.ToolTip = "Add button\r\n";
            this.btnAdd.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Cursor;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            this.btnDelete.Appearance.Options.UseBackColor = true;
            this.btnDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDelete.ImageOptions.SvgImage")));
            this.btnDelete.Location = new System.Drawing.Point(788, 181);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 43);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.ToolTip = "Delete button\r\n\r\nSelect a specific row before deleting.";
            this.btnDelete.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Cursor;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // teFirstName
            // 
            this.teFirstName.Location = new System.Drawing.Point(20, 105);
            this.teFirstName.Name = "teFirstName";
            this.teFirstName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teFirstName.Properties.Appearance.Options.UseFont = true;
            this.teFirstName.Properties.AutoHeight = false;
            this.teFirstName.Size = new System.Drawing.Size(201, 31);
            this.teFirstName.TabIndex = 1;
            // 
            // teMiddleName
            // 
            this.teMiddleName.Location = new System.Drawing.Point(238, 105);
            this.teMiddleName.Name = "teMiddleName";
            this.teMiddleName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teMiddleName.Properties.Appearance.Options.UseFont = true;
            this.teMiddleName.Properties.AutoHeight = false;
            this.teMiddleName.Size = new System.Drawing.Size(201, 31);
            this.teMiddleName.TabIndex = 2;
            // 
            // teLastName
            // 
            this.teLastName.Location = new System.Drawing.Point(457, 105);
            this.teLastName.Name = "teLastName";
            this.teLastName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teLastName.Properties.Appearance.Options.UseFont = true;
            this.teLastName.Properties.AutoHeight = false;
            this.teLastName.Size = new System.Drawing.Size(201, 31);
            this.teLastName.TabIndex = 3;
            // 
            // teContact
            // 
            this.teContact.Location = new System.Drawing.Point(20, 193);
            this.teContact.Name = "teContact";
            this.teContact.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teContact.Properties.Appearance.Options.UseFont = true;
            this.teContact.Properties.AutoHeight = false;
            this.teContact.Size = new System.Drawing.Size(161, 31);
            this.teContact.TabIndex = 6;
            // 
            // teAddress
            // 
            this.teAddress.Location = new System.Drawing.Point(205, 193);
            this.teAddress.Name = "teAddress";
            this.teAddress.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teAddress.Properties.Appearance.Options.UseFont = true;
            this.teAddress.Properties.AutoHeight = false;
            this.teAddress.Size = new System.Drawing.Size(254, 31);
            this.teAddress.TabIndex = 7;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUpdate.Appearance.Options.UseBackColor = true;
            this.btnUpdate.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUpdate.ImageOptions.SvgImage")));
            this.btnUpdate.Location = new System.Drawing.Point(679, 181);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 43);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.ToolTip = "Update button\r\n\r\nSelect a specific row before inputting details in the text field" +
    "s\r\nAfterwards, click the Update button.";
            this.btnUpdate.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Cursor;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lcFirstName
            // 
            this.lcFirstName.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcFirstName.Appearance.Options.UseFont = true;
            this.lcFirstName.Location = new System.Drawing.Point(20, 83);
            this.lcFirstName.Name = "lcFirstName";
            this.lcFirstName.Size = new System.Drawing.Size(64, 20);
            this.lcFirstName.TabIndex = 11;
            this.lcFirstName.Text = "Firstname";
            // 
            // lcMiddleName
            // 
            this.lcMiddleName.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcMiddleName.Appearance.Options.UseFont = true;
            this.lcMiddleName.Location = new System.Drawing.Point(238, 83);
            this.lcMiddleName.Name = "lcMiddleName";
            this.lcMiddleName.Size = new System.Drawing.Size(84, 20);
            this.lcMiddleName.TabIndex = 12;
            this.lcMiddleName.Text = "Middlename";
            // 
            // lcLastName
            // 
            this.lcLastName.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcLastName.Appearance.Options.UseFont = true;
            this.lcLastName.Location = new System.Drawing.Point(457, 83);
            this.lcLastName.Name = "lcLastName";
            this.lcLastName.Size = new System.Drawing.Size(63, 20);
            this.lcLastName.TabIndex = 13;
            this.lcLastName.Text = "Lastname";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(20, 171);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(109, 20);
            this.labelControl1.TabIndex = 16;
            this.labelControl1.Text = "Contact Number";
            // 
            // lcAddress
            // 
            this.lcAddress.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcAddress.Appearance.Options.UseFont = true;
            this.lcAddress.Location = new System.Drawing.Point(205, 171);
            this.lcAddress.Name = "lcAddress";
            this.lcAddress.Size = new System.Drawing.Size(53, 20);
            this.lcAddress.TabIndex = 17;
            this.lcAddress.Text = "Address";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(679, 83);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(23, 20);
            this.labelControl2.TabIndex = 14;
            this.labelControl2.Text = "Sex";
            // 
            // cbeSex
            // 
            this.cbeSex.Location = new System.Drawing.Point(679, 105);
            this.cbeSex.Name = "cbeSex";
            this.cbeSex.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbeSex.Properties.Appearance.Options.UseFont = true;
            this.cbeSex.Properties.AutoHeight = false;
            this.cbeSex.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeSex.Properties.DropDownRows = 2;
            this.cbeSex.Properties.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbeSex.Size = new System.Drawing.Size(131, 31);
            this.cbeSex.TabIndex = 4;
            // 
            // cbeCivilStatus
            // 
            this.cbeCivilStatus.Location = new System.Drawing.Point(829, 105);
            this.cbeCivilStatus.Name = "cbeCivilStatus";
            this.cbeCivilStatus.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbeCivilStatus.Properties.Appearance.Options.UseFont = true;
            this.cbeCivilStatus.Properties.AutoHeight = false;
            this.cbeCivilStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeCivilStatus.Properties.Items.AddRange(new object[] {
            "Single",
            "Married",
            "Separated",
            "Divorced",
            "Widowed"});
            this.cbeCivilStatus.Size = new System.Drawing.Size(150, 31);
            this.cbeCivilStatus.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(829, 83);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(72, 20);
            this.labelControl3.TabIndex = 15;
            this.labelControl3.Text = "Civil Status";
            // 
            // groupControl1
            // 
            this.groupControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupControl1.CaptionImageOptions.Padding = new System.Windows.Forms.Padding(-10, 10, 0, 10);
            this.groupControl1.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("groupControl1.CaptionImageOptions.SvgImage")));
            this.groupControl1.CaptionImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.groupControl1.Controls.Add(this.lcAddress);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.teAddress);
            this.groupControl1.Controls.Add(this.btnUpdate);
            this.groupControl1.Controls.Add(this.btnAdd);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.cbeCivilStatus);
            this.groupControl1.Controls.Add(this.btnDelete);
            this.groupControl1.Controls.Add(this.teContact);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.cbeSex);
            this.groupControl1.Controls.Add(this.lcFirstName);
            this.groupControl1.Controls.Add(this.teFirstName);
            this.groupControl1.Controls.Add(this.lcMiddleName);
            this.groupControl1.Controls.Add(this.teMiddleName);
            this.groupControl1.Controls.Add(this.lcLastName);
            this.groupControl1.Controls.Add(this.teLastName);
            this.groupControl1.Location = new System.Drawing.Point(21, 25);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1005, 272);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Form";
            // 
            // StudentInfo
            // 
            this.Appearance.BackColor = System.Drawing.Color.Black;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 694);
            this.Controls.Add(this.gcStudentInfo);
            this.Controls.Add(this.groupControl1);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("StudentInfo.IconOptions.SvgImage")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StudentInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Info";
            ((System.ComponentModel.ISupportInitialize)(this.gcStudentInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudentInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teFirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMiddleName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teContact.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeSex.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeCivilStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcStudentInfo;
        private DevExpress.XtraGrid.Views.Grid.GridView gvStudentInfo;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.TextEdit teFirstName;
        private DevExpress.XtraEditors.TextEdit teMiddleName;
        private DevExpress.XtraEditors.TextEdit teLastName;
        private DevExpress.XtraEditors.TextEdit teContact;
        private DevExpress.XtraEditors.TextEdit teAddress;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.LabelControl lcFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn FirstName;
        private DevExpress.XtraGrid.Columns.GridColumn MiddleName;
        private DevExpress.XtraGrid.Columns.GridColumn LastName;
        private DevExpress.XtraGrid.Columns.GridColumn Contact;
        private DevExpress.XtraGrid.Columns.GridColumn Address;
        private DevExpress.XtraEditors.LabelControl lcMiddleName;
        private DevExpress.XtraEditors.LabelControl lcLastName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lcAddress;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit cbeSex;
        private DevExpress.XtraEditors.ComboBoxEdit cbeCivilStatus;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.Columns.GridColumn Sex;
        private DevExpress.XtraGrid.Columns.GridColumn CivilStatus;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}

