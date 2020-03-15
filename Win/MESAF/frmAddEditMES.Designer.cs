namespace Win.MESAF
{
    partial class frmAddEditMES
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
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtPosition = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dtDate = new DevExpress.XtraEditors.DateEdit();
            this.txtRequest = new DevExpress.XtraEditors.MemoEdit();
            this.txtItemSpec = new DevExpress.XtraEditors.LookUpEdit();
            this.txtOffice = new DevExpress.XtraEditors.LookUpEdit();
            this.txtEmployee = new DevExpress.XtraEditors.LookUpEdit();
            this.btnEditPo = new DevExpress.XtraEditors.SimpleButton();
            this.btnNewPO = new DevExpress.XtraEditors.SimpleButton();
            this.ItemSpecBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EmployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddEmployee = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lblMESNo = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.OfficeBindingSource = new DevExpress.Data.Linq.EntityServerModeSource();
            ((System.ComponentModel.ISupportInitialize)(this.txtPosition.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRequest.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemSpec.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOffice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmployee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemSpecBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OfficeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(368, 68);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(47, 17);
            this.labelControl6.TabIndex = 19;
            this.labelControl6.Text = "Request";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(368, 44);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(60, 17);
            this.labelControl5.TabIndex = 20;
            this.labelControl5.Text = "Item Spec:";
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(64, 116);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPosition.Properties.Appearance.Options.UseFont = true;
            this.txtPosition.Properties.UseReadOnlyAppearance = false;
            this.txtPosition.Size = new System.Drawing.Size(271, 24);
            this.txtPosition.TabIndex = 3;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(11, 119);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(46, 17);
            this.labelControl4.TabIndex = 21;
            this.labelControl4.Text = "Position";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(11, 95);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(35, 17);
            this.labelControl3.TabIndex = 22;
            this.labelControl3.Text = "Name";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(11, 71);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(34, 17);
            this.labelControl2.TabIndex = 23;
            this.labelControl2.Text = "Office";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(11, 47);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(30, 17);
            this.labelControl1.TabIndex = 24;
            this.labelControl1.Text = "Date:";
            // 
            // dtDate
            // 
            this.dtDate.EditValue = null;
            this.dtDate.Location = new System.Drawing.Point(64, 44);
            this.dtDate.Name = "dtDate";
            this.dtDate.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtDate.Properties.Appearance.Options.UseFont = true;
            this.dtDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDate.Properties.UseReadOnlyAppearance = false;
            this.dtDate.Size = new System.Drawing.Size(271, 24);
            this.dtDate.TabIndex = 0;
            // 
            // txtRequest
            // 
            this.txtRequest.Location = new System.Drawing.Point(434, 68);
            this.txtRequest.Name = "txtRequest";
            this.txtRequest.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtRequest.Properties.Appearance.Options.UseFont = true;
            this.txtRequest.Properties.UseReadOnlyAppearance = false;
            this.txtRequest.Size = new System.Drawing.Size(271, 84);
            this.txtRequest.TabIndex = 5;
            // 
            // txtItemSpec
            // 
            this.txtItemSpec.Location = new System.Drawing.Point(434, 44);
            this.txtItemSpec.Name = "txtItemSpec";
            this.txtItemSpec.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtItemSpec.Properties.Appearance.Options.UseFont = true;
            this.txtItemSpec.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtItemSpec.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemSpec", "Item Spec", 80, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.txtItemSpec.Properties.DataSource = this.ItemSpecBindingSource;
            this.txtItemSpec.Properties.DisplayMember = "ItemSpec";
            this.txtItemSpec.Properties.NullText = "";
            this.txtItemSpec.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.txtItemSpec.Properties.UseReadOnlyAppearance = false;
            this.txtItemSpec.Properties.ValueMember = "ItemSpec";
            this.txtItemSpec.Size = new System.Drawing.Size(271, 24);
            this.txtItemSpec.TabIndex = 4;
            // 
            // txtOffice
            // 
            this.txtOffice.Location = new System.Drawing.Point(64, 68);
            this.txtOffice.Name = "txtOffice";
            this.txtOffice.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtOffice.Properties.Appearance.Options.UseFont = true;
            this.txtOffice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtOffice.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("OfficeName", "Office Name", 83, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.txtOffice.Properties.DataSource = this.OfficeBindingSource;
            this.txtOffice.Properties.DisplayMember = "OfficeName";
            this.txtOffice.Properties.NullText = "";
            this.txtOffice.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.txtOffice.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.txtOffice.Properties.UseReadOnlyAppearance = false;
            this.txtOffice.Properties.ValueMember = "Id";
            this.txtOffice.Size = new System.Drawing.Size(271, 24);
            this.txtOffice.TabIndex = 1;
            // 
            // txtEmployee
            // 
            this.txtEmployee.Location = new System.Drawing.Point(64, 92);
            this.txtEmployee.Name = "txtEmployee";
            this.txtEmployee.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmployee.Properties.Appearance.Options.UseFont = true;
            this.txtEmployee.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtEmployee.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmployeeName", "Employee Name", 119, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.txtEmployee.Properties.DataSource = this.EmployeeBindingSource;
            this.txtEmployee.Properties.DisplayMember = "EmployeeName";
            this.txtEmployee.Properties.NullText = "";
            this.txtEmployee.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.txtEmployee.Properties.ValueMember = "Id";
            this.txtEmployee.Size = new System.Drawing.Size(251, 24);
            this.txtEmployee.TabIndex = 2;
            this.txtEmployee.EditValueChanged += new System.EventHandler(this.txtEmployee_EditValueChanged);
            // 
            // btnEditPo
            // 
            this.btnEditPo.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnEditPo.Appearance.Options.UseFont = true;
            this.btnEditPo.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnEditPo.ImageOptions.Image = global::Win.Properties.Resources.cancel_16;
            this.btnEditPo.Location = new System.Drawing.Point(630, 158);
            this.btnEditPo.Name = "btnEditPo";
            this.btnEditPo.Size = new System.Drawing.Size(75, 26);
            this.btnEditPo.TabIndex = 7;
            this.btnEditPo.TabStop = false;
            this.btnEditPo.Text = "Cancel";
            this.btnEditPo.Click += new System.EventHandler(this.btnEditPo_Click);
            // 
            // btnNewPO
            // 
            this.btnNewPO.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNewPO.Appearance.Options.UseFont = true;
            this.btnNewPO.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnNewPO.ImageOptions.Image = global::Win.Properties.Resources.save_16;
            this.btnNewPO.Location = new System.Drawing.Point(549, 158);
            this.btnNewPO.Name = "btnNewPO";
            this.btnNewPO.Size = new System.Drawing.Size(75, 26);
            this.btnNewPO.TabIndex = 6;
            this.btnNewPO.TabStop = false;
            this.btnNewPO.Text = "Submit";
            this.btnNewPO.Click += new System.EventHandler(this.btnNewPO_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.AutoSize = true;
            this.btnAddEmployee.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnAddEmployee.ImageOptions.Image = global::Win.Properties.Resources.addfile_16x16;
            this.btnAddEmployee.Location = new System.Drawing.Point(317, 95);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(18, 20);
            this.btnAddEmployee.TabIndex = 25;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lblMESNo);
            this.panelControl1.Controls.Add(this.labelControl7);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(708, 36);
            this.panelControl1.TabIndex = 26;
            // 
            // lblMESNo
            // 
            this.lblMESNo.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblMESNo.Appearance.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblMESNo.Appearance.Options.UseFont = true;
            this.lblMESNo.Appearance.Options.UseForeColor = true;
            this.lblMESNo.Location = new System.Drawing.Point(109, 0);
            this.lblMESNo.Name = "lblMESNo";
            this.lblMESNo.Size = new System.Drawing.Size(114, 32);
            this.lblMESNo.TabIndex = 11;
            this.lblMESNo.Text = "EPiS-0001";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(12, 0);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(91, 32);
            this.labelControl7.TabIndex = 11;
            this.labelControl7.Text = "MES No.";
            // 
            // OfficeBindingSource
            // 
            this.OfficeBindingSource.DefaultSorting = "Id ASC";
            this.OfficeBindingSource.ElementType = typeof(Models.MES);
            this.OfficeBindingSource.KeyExpression = "Id";
            // 
            // frmAddEditMES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 209);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.btnEditPo);
            this.Controls.Add(this.btnNewPO);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.txtRequest);
            this.Controls.Add(this.txtItemSpec);
            this.Controls.Add(this.txtOffice);
            this.Controls.Add(this.txtEmployee);
            this.Name = "frmAddEditMES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Edit MES";
            this.Load += new System.EventHandler(this.frmAddEditMES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtPosition.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRequest.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemSpec.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOffice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmployee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemSpecBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OfficeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtPosition;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dtDate;
        private DevExpress.XtraEditors.MemoEdit txtRequest;
        private DevExpress.Data.Linq.EntityServerModeSource OfficeBindingSource;
        private DevExpress.XtraEditors.SimpleButton btnEditPo;
        private DevExpress.XtraEditors.SimpleButton btnNewPO;
        private DevExpress.XtraEditors.LookUpEdit txtItemSpec;
        private DevExpress.XtraEditors.LookUpEdit txtOffice;
        private System.Windows.Forms.BindingSource ItemSpecBindingSource;
        private System.Windows.Forms.BindingSource EmployeeBindingSource;
        private DevExpress.XtraEditors.LookUpEdit txtEmployee;
        private DevExpress.XtraEditors.SimpleButton btnAddEmployee;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl lblMESNo;
        private DevExpress.XtraEditors.LabelControl labelControl7;
    }
}