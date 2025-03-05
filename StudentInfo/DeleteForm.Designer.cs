namespace StudentInfo
{
    partial class DeleteForm
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
            this.lcLastName = new DevExpress.XtraEditors.LabelControl();
            this.lcMiddleName = new DevExpress.XtraEditors.LabelControl();
            this.lcFirstName = new DevExpress.XtraEditors.LabelControl();
            this.teLastName = new DevExpress.XtraEditors.TextEdit();
            this.teMiddleName = new DevExpress.XtraEditors.TextEdit();
            this.teFirstName = new DevExpress.XtraEditors.TextEdit();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.teLastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMiddleName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teFirstName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lcLastName
            // 
            this.lcLastName.Location = new System.Drawing.Point(95, 244);
            this.lcLastName.Name = "lcLastName";
            this.lcLastName.Size = new System.Drawing.Size(55, 16);
            this.lcLastName.TabIndex = 19;
            this.lcLastName.Text = "Lastname";
            // 
            // lcMiddleName
            // 
            this.lcMiddleName.Location = new System.Drawing.Point(95, 171);
            this.lcMiddleName.Name = "lcMiddleName";
            this.lcMiddleName.Size = new System.Drawing.Size(69, 16);
            this.lcMiddleName.TabIndex = 18;
            this.lcMiddleName.Text = "Middlename";
            // 
            // lcFirstName
            // 
            this.lcFirstName.Location = new System.Drawing.Point(95, 98);
            this.lcFirstName.Name = "lcFirstName";
            this.lcFirstName.Size = new System.Drawing.Size(57, 16);
            this.lcFirstName.TabIndex = 17;
            this.lcFirstName.Text = "Firstname";
            // 
            // teLastName
            // 
            this.teLastName.Location = new System.Drawing.Point(95, 266);
            this.teLastName.Name = "teLastName";
            this.teLastName.Properties.AutoHeight = false;
            this.teLastName.Size = new System.Drawing.Size(201, 31);
            this.teLastName.TabIndex = 16;
            // 
            // teMiddleName
            // 
            this.teMiddleName.Location = new System.Drawing.Point(95, 193);
            this.teMiddleName.Name = "teMiddleName";
            this.teMiddleName.Properties.AutoHeight = false;
            this.teMiddleName.Size = new System.Drawing.Size(201, 31);
            this.teMiddleName.TabIndex = 15;
            // 
            // teFirstName
            // 
            this.teFirstName.Location = new System.Drawing.Point(95, 120);
            this.teFirstName.Name = "teFirstName";
            this.teFirstName.Properties.AutoHeight = false;
            this.teFirstName.Size = new System.Drawing.Size(201, 31);
            this.teFirstName.TabIndex = 14;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(148, 347);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 436);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lcLastName);
            this.Controls.Add(this.lcMiddleName);
            this.Controls.Add(this.lcFirstName);
            this.Controls.Add(this.teLastName);
            this.Controls.Add(this.teMiddleName);
            this.Controls.Add(this.teFirstName);
            this.Name = "Delete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete";
            ((System.ComponentModel.ISupportInitialize)(this.teLastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMiddleName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teFirstName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lcLastName;
        private DevExpress.XtraEditors.LabelControl lcMiddleName;
        private DevExpress.XtraEditors.LabelControl lcFirstName;
        private DevExpress.XtraEditors.TextEdit teLastName;
        private DevExpress.XtraEditors.TextEdit teMiddleName;
        private DevExpress.XtraEditors.TextEdit teFirstName;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
    }
}