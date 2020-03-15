namespace Win.Emp
{
    partial class frmAddEditEmployees
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
            this.btnEditPo = new DevExpress.XtraEditors.SimpleButton();
            this.btnNewPO = new DevExpress.XtraEditors.SimpleButton();
            this.txtFirstname = new DevExpress.XtraEditors.TextEdit();
            this.txtMiddleName = new DevExpress.XtraEditors.TextEdit();
            this.txtLastName = new DevExpress.XtraEditors.TextEdit();
            this.txtPosition = new DevExpress.XtraEditors.TextEdit();
            this.cboOffice = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMiddleName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPosition.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboOffice.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditPo
            // 
            this.btnEditPo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditPo.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnEditPo.Appearance.Options.UseFont = true;
            this.btnEditPo.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnEditPo.ImageOptions.Image = global::Win.Properties.Resources.cancel_16;
            this.btnEditPo.Location = new System.Drawing.Point(375, 140);
            this.btnEditPo.Name = "btnEditPo";
            this.btnEditPo.Size = new System.Drawing.Size(87, 30);
            this.btnEditPo.TabIndex = 10;
            this.btnEditPo.TabStop = false;
            this.btnEditPo.Text = "Cancel";
            this.btnEditPo.Click += new System.EventHandler(this.btnEditPo_Click);
            // 
            // btnNewPO
            // 
            this.btnNewPO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewPO.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNewPO.Appearance.Options.UseFont = true;
            this.btnNewPO.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnNewPO.ImageOptions.Image = global::Win.Properties.Resources.save_16;
            this.btnNewPO.Location = new System.Drawing.Point(280, 140);
            this.btnNewPO.Name = "btnNewPO";
            this.btnNewPO.Size = new System.Drawing.Size(87, 30);
            this.btnNewPO.TabIndex = 9;
            this.btnNewPO.TabStop = false;
            this.btnNewPO.Text = "Submit";
            this.btnNewPO.Click += new System.EventHandler(this.btnNewPO_Click);
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(105, 15);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFirstname.Properties.Appearance.Options.UseFont = true;
            this.txtFirstname.Size = new System.Drawing.Size(357, 24);
            this.txtFirstname.TabIndex = 11;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(105, 39);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMiddleName.Properties.Appearance.Options.UseFont = true;
            this.txtMiddleName.Size = new System.Drawing.Size(357, 24);
            this.txtMiddleName.TabIndex = 12;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(105, 63);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtLastName.Properties.Appearance.Options.UseFont = true;
            this.txtLastName.Size = new System.Drawing.Size(357, 24);
            this.txtLastName.TabIndex = 13;
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(105, 87);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPosition.Properties.Appearance.Options.UseFont = true;
            this.txtPosition.Size = new System.Drawing.Size(357, 24);
            this.txtPosition.TabIndex = 14;
            // 
            // cboOffice
            // 
            this.cboOffice.Location = new System.Drawing.Point(105, 111);
            this.cboOffice.Name = "cboOffice";
            this.cboOffice.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboOffice.Properties.Appearance.Options.UseFont = true;
            this.cboOffice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboOffice.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("OfficeName", "Office Name"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("OffcAcr", "OffcAcr")});
            this.cboOffice.Properties.DisplayMember = "OfficeName";
            this.cboOffice.Properties.NullText = "";
            this.cboOffice.Properties.ValueMember = "Id";
            this.cboOffice.Size = new System.Drawing.Size(357, 24);
            this.cboOffice.TabIndex = 15;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(23, 18);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(63, 17);
            this.labelControl1.TabIndex = 16;
            this.labelControl1.Text = "First Name";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(23, 42);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(80, 17);
            this.labelControl2.TabIndex = 16;
            this.labelControl2.Text = "Middle Name";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(23, 67);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(62, 17);
            this.labelControl3.TabIndex = 16;
            this.labelControl3.Text = "Last Name";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(23, 91);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(46, 17);
            this.labelControl4.TabIndex = 16;
            this.labelControl4.Text = "Position";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(23, 115);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(34, 17);
            this.labelControl5.TabIndex = 16;
            this.labelControl5.Text = "Office";
            // 
            // frmAddEditEmployees
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 184);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cboOffice);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtMiddleName);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.btnEditPo);
            this.Controls.Add(this.btnNewPO);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "frmAddEditEmployees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Edit Employee";
            this.Load += new System.EventHandler(this.frmAddEditEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMiddleName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPosition.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboOffice.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnEditPo;
        private DevExpress.XtraEditors.SimpleButton btnNewPO;
        private DevExpress.XtraEditors.TextEdit txtFirstname;
        private DevExpress.XtraEditors.TextEdit txtMiddleName;
        private DevExpress.XtraEditors.TextEdit txtLastName;
        private DevExpress.XtraEditors.TextEdit txtPosition;
        private DevExpress.XtraEditors.LookUpEdit cboOffice;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}