namespace Win.PO
{
    partial class _frmAddEditActions
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
            this.dtActionDate = new DevExpress.XtraEditors.DateEdit();
            this.txtAction = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtRemarks = new DevExpress.XtraEditors.MemoEdit();
            this.btnEditPo = new DevExpress.XtraEditors.SimpleButton();
            this.btnNewPO = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtActionDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtActionDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAction.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemarks.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dtActionDate
            // 
            this.dtActionDate.EditValue = new System.DateTime(2020, 2, 18, 16, 19, 30, 0);
            this.dtActionDate.Location = new System.Drawing.Point(173, 8);
            this.dtActionDate.Name = "dtActionDate";
            this.dtActionDate.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtActionDate.Properties.Appearance.Options.UseFont = true;
            this.dtActionDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtActionDate.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.dtActionDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtActionDate.Properties.CalendarTimeProperties.DisplayFormat.FormatString = "h:mm:ss tt";
            this.dtActionDate.Properties.CalendarTimeProperties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dtActionDate.Properties.CalendarTimeProperties.EditFormat.FormatString = "h:mm:ss tt";
            this.dtActionDate.Properties.CalendarTimeProperties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dtActionDate.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista;
            this.dtActionDate.Properties.DisplayFormat.FormatString = "MM/dd/yyyy h:mm:ss tt";
            this.dtActionDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtActionDate.Properties.EditFormat.FormatString = "MM/dd/yyyy h:mm:ss tt";
            this.dtActionDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtActionDate.Properties.Mask.EditMask = "MM/dd/yyyy h:mm:ss tt";
            this.dtActionDate.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
            this.dtActionDate.Size = new System.Drawing.Size(340, 24);
            this.dtActionDate.TabIndex = 0;
            // 
            // txtAction
            // 
            this.txtAction.Location = new System.Drawing.Point(173, 32);
            this.txtAction.Name = "txtAction";
            this.txtAction.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAction.Properties.Appearance.Options.UseFont = true;
            this.txtAction.Size = new System.Drawing.Size(340, 96);
            this.txtAction.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 11);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 17);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Date/Time*";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 34);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(74, 17);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Action Taken";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(12, 135);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(50, 17);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Remarks";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(173, 128);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtRemarks.Properties.Appearance.Options.UseFont = true;
            this.txtRemarks.Size = new System.Drawing.Size(340, 44);
            this.txtRemarks.TabIndex = 2;
            // 
            // btnEditPo
            // 
            this.btnEditPo.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnEditPo.Appearance.Options.UseFont = true;
            this.btnEditPo.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnEditPo.ImageOptions.Image = global::Win.Properties.Resources.cancel_16;
            this.btnEditPo.Location = new System.Drawing.Point(438, 178);
            this.btnEditPo.Name = "btnEditPo";
            this.btnEditPo.Size = new System.Drawing.Size(75, 26);
            this.btnEditPo.TabIndex = 4;
            this.btnEditPo.Text = "Cancel";
            this.btnEditPo.Click += new System.EventHandler(this.btnEditPo_Click);
            // 
            // btnNewPO
            // 
            this.btnNewPO.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNewPO.Appearance.Options.UseFont = true;
            this.btnNewPO.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnNewPO.ImageOptions.Image = global::Win.Properties.Resources.save_16;
            this.btnNewPO.Location = new System.Drawing.Point(358, 178);
            this.btnNewPO.Name = "btnNewPO";
            this.btnNewPO.Size = new System.Drawing.Size(75, 26);
            this.btnNewPO.TabIndex = 3;
            this.btnNewPO.Text = "Submit";
            this.btnNewPO.Click += new System.EventHandler(this.btnNewPO_Click);
            // 
            // frmAddEditActions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 211);
            this.Controls.Add(this.btnEditPo);
            this.Controls.Add(this.btnNewPO);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.txtAction);
            this.Controls.Add(this.dtActionDate);
            this.Name = "frmAddEditActions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Action";
            this.Load += new System.EventHandler(this.frmAddEditActions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtActionDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtActionDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAction.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemarks.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit dtActionDate;
        private DevExpress.XtraEditors.MemoEdit txtAction;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.MemoEdit txtRemarks;
        private DevExpress.XtraEditors.SimpleButton btnEditPo;
        private DevExpress.XtraEditors.SimpleButton btnNewPO;
    }
}