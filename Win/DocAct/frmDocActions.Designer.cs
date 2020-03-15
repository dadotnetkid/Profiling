namespace Win.DocAct
{
    partial class frmDocActions
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dtDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cboStatus = new DevExpress.XtraEditors.LookUpEdit();
            this.StatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lblWorkOrder = new DevExpress.XtraEditors.LabelControl();
            this.cboUsers = new DevExpress.XtraEditors.LookUpEdit();
            this.UserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cboPrograms = new DevExpress.XtraEditors.LookUpEdit();
            this.DropdownBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.cboMain = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.cboSub = new DevExpress.XtraEditors.LookUpEdit();
            this.btnEditPo = new DevExpress.XtraEditors.SimpleButton();
            this.btnNewPO = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.cboActivity = new DevExpress.XtraEditors.LookUpEdit();
            this.txtActionTaken = new DevExpress.XtraEditors.LookUpEdit();
            this.ActionTakenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtRemarks = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboUsers.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPrograms.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DropdownBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMain.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSub.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboActivity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtActionTaken.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActionTakenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemarks.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(21, 63);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Date/Time";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(7, 182);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(74, 17);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Action Taken";
            // 
            // dtDate
            // 
            this.dtDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtDate.EditValue = new System.DateTime(2020, 2, 25, 18, 50, 55, 0);
            this.dtDate.Location = new System.Drawing.Point(87, 60);
            this.dtDate.Name = "dtDate";
            this.dtDate.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtDate.Properties.Appearance.Options.UseFont = true;
            this.dtDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDate.Properties.NullDate = new System.DateTime(2020, 2, 25, 18, 51, 15, 217);
            this.dtDate.Properties.NullDateCalendarValue = new System.DateTime(2020, 2, 25, 18, 51, 4, 0);
            this.dtDate.Properties.TodayDate = new System.DateTime(2020, 2, 25, 18, 51, 50, 0);
            this.dtDate.Size = new System.Drawing.Size(231, 24);
            this.dtDate.TabIndex = 0;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(46, 295);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(35, 17);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Status";
            // 
            // cboStatus
            // 
            this.cboStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboStatus.Location = new System.Drawing.Point(87, 292);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboStatus.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboStatus.Properties.Appearance.Options.UseFont = true;
            this.cboStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboStatus.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Value", 42, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cboStatus.Properties.DataSource = this.StatusBindingSource;
            this.cboStatus.Properties.DisplayMember = "Value";
            this.cboStatus.Properties.NullText = "";
            this.cboStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboStatus.Properties.ValueMember = "Value";
            this.cboStatus.Size = new System.Drawing.Size(504, 24);
            this.cboStatus.TabIndex = 5;
            this.cboStatus.EditValueChanged += new System.EventHandler(this.cboStatus_EditValueChanged);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lblWorkOrder);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(603, 52);
            this.panelControl1.TabIndex = 4;
            // 
            // lblWorkOrder
            // 
            this.lblWorkOrder.Appearance.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lblWorkOrder.Appearance.Options.UseFont = true;
            this.lblWorkOrder.Location = new System.Drawing.Point(12, 12);
            this.lblWorkOrder.Name = "lblWorkOrder";
            this.lblWorkOrder.Size = new System.Drawing.Size(287, 30);
            this.lblWorkOrder.TabIndex = 0;
            this.lblWorkOrder.Text = "Mark christopher - System Unit";
            // 
            // cboUsers
            // 
            this.cboUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboUsers.Enabled = false;
            this.cboUsers.Location = new System.Drawing.Point(87, 316);
            this.cboUsers.Name = "cboUsers";
            this.cboUsers.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboUsers.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboUsers.Properties.Appearance.Options.UseFont = true;
            this.cboUsers.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboUsers.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 34, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FullName", "Full Name", 68, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cboUsers.Properties.DataSource = this.UserBindingSource;
            this.cboUsers.Properties.DisplayMember = "FullName";
            this.cboUsers.Properties.NullText = "";
            this.cboUsers.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboUsers.Properties.ValueMember = "Id";
            this.cboUsers.Size = new System.Drawing.Size(504, 24);
            this.cboUsers.TabIndex = 6;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(3, 318);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(78, 17);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Endorsed To:";
            // 
            // cboPrograms
            // 
            this.cboPrograms.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboPrograms.Location = new System.Drawing.Point(87, 84);
            this.cboPrograms.MinimumSize = new System.Drawing.Size(353, 24);
            this.cboPrograms.Name = "cboPrograms";
            this.cboPrograms.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboPrograms.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.cboPrograms.Properties.Appearance.Options.UseFont = true;
            this.cboPrograms.Properties.AutoHeight = false;
            this.cboPrograms.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboPrograms.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 34, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DropdownValue", "", 108, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Order", "Order", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.True)});
            this.cboPrograms.Properties.DataSource = this.DropdownBindingSource;
            this.cboPrograms.Properties.DisplayMember = "DropdownValue";
            this.cboPrograms.Properties.NullText = "";
            this.cboPrograms.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboPrograms.Properties.ValueMember = "Id";
            this.cboPrograms.Size = new System.Drawing.Size(504, 24);
            this.cboPrograms.TabIndex = 1;
            this.cboPrograms.EditValueChanged += new System.EventHandler(this.cboPrograms_EditValueChanged);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(27, 87);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(54, 17);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Program:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(27, 111);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(54, 17);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Main Act:";
            // 
            // cboMain
            // 
            this.cboMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboMain.Location = new System.Drawing.Point(87, 108);
            this.cboMain.MinimumSize = new System.Drawing.Size(353, 24);
            this.cboMain.Name = "cboMain";
            this.cboMain.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboMain.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.cboMain.Properties.Appearance.Options.UseFont = true;
            this.cboMain.Properties.AutoHeight = false;
            this.cboMain.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboMain.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 34, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DropdownValue", "", 108, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Order", "Order", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.True)});
            this.cboMain.Properties.DataSource = this.DropdownBindingSource;
            this.cboMain.Properties.DisplayMember = "DropdownValue";
            this.cboMain.Properties.NullText = "";
            this.cboMain.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.StartsWith;
            this.cboMain.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboMain.Properties.ValueMember = "Id";
            this.cboMain.Size = new System.Drawing.Size(504, 24);
            this.cboMain.TabIndex = 2;
            this.cboMain.EditValueChanged += new System.EventHandler(this.cboMain_EditValueChanged);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(34, 159);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(47, 17);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "Sub Act:";
            // 
            // cboSub
            // 
            this.cboSub.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSub.Location = new System.Drawing.Point(87, 156);
            this.cboSub.MinimumSize = new System.Drawing.Size(353, 24);
            this.cboSub.Name = "cboSub";
            this.cboSub.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboSub.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.cboSub.Properties.Appearance.Options.UseFont = true;
            this.cboSub.Properties.AutoHeight = false;
            this.cboSub.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboSub.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 34, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DropdownValue", "", 108, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Order", "Order", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.True)});
            this.cboSub.Properties.DataSource = this.DropdownBindingSource;
            this.cboSub.Properties.DisplayMember = "DropdownValue";
            this.cboSub.Properties.NullText = "";
            this.cboSub.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboSub.Properties.ValueMember = "Id";
            this.cboSub.Size = new System.Drawing.Size(504, 24);
            this.cboSub.TabIndex = 3;
            // 
            // btnEditPo
            // 
            this.btnEditPo.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnEditPo.Appearance.Options.UseFont = true;
            this.btnEditPo.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnEditPo.ImageOptions.Image = global::Win.Properties.Resources.cancel_16;
            this.btnEditPo.Location = new System.Drawing.Point(516, 346);
            this.btnEditPo.Name = "btnEditPo";
            this.btnEditPo.Size = new System.Drawing.Size(75, 26);
            this.btnEditPo.TabIndex = 8;
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
            this.btnNewPO.Location = new System.Drawing.Point(435, 346);
            this.btnNewPO.Name = "btnNewPO";
            this.btnNewPO.Size = new System.Drawing.Size(75, 26);
            this.btnNewPO.TabIndex = 7;
            this.btnNewPO.TabStop = false;
            this.btnNewPO.Text = "Submit";
            this.btnNewPO.Click += new System.EventHandler(this.btnNewPO_Click);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(41, 135);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(40, 17);
            this.labelControl8.TabIndex = 0;
            this.labelControl8.Text = "Activity";
            // 
            // cboActivity
            // 
            this.cboActivity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboActivity.Location = new System.Drawing.Point(87, 132);
            this.cboActivity.MinimumSize = new System.Drawing.Size(353, 24);
            this.cboActivity.Name = "cboActivity";
            this.cboActivity.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboActivity.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.cboActivity.Properties.Appearance.Options.UseFont = true;
            this.cboActivity.Properties.AutoHeight = false;
            this.cboActivity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboActivity.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 34, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DropdownValue", "", 108, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Order", "Order", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.True)});
            this.cboActivity.Properties.DisplayMember = "DropdownValue";
            this.cboActivity.Properties.NullText = "";
            this.cboActivity.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboActivity.Properties.ValueMember = "Id";
            this.cboActivity.Size = new System.Drawing.Size(504, 24);
            this.cboActivity.TabIndex = 3;
            this.cboActivity.EditValueChanged += new System.EventHandler(this.cboActivity_EditValueChanged);
            // 
            // txtActionTaken
            // 
            this.txtActionTaken.AllowDrop = true;
            this.txtActionTaken.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtActionTaken.Location = new System.Drawing.Point(87, 180);
            this.txtActionTaken.Name = "txtActionTaken";
            this.txtActionTaken.Properties.AcceptEditorTextAsNewValue = DevExpress.Utils.DefaultBoolean.True;
            this.txtActionTaken.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.txtActionTaken.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.txtActionTaken.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtActionTaken.Properties.Appearance.Options.UseFont = true;
            this.txtActionTaken.Properties.AutoHeight = false;
            this.txtActionTaken.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtActionTaken.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ActionTaken", "Action Taken", 97, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.txtActionTaken.Properties.DataSource = this.ActionTakenBindingSource;
            this.txtActionTaken.Properties.DisplayMember = "ActionTaken";
            this.txtActionTaken.Properties.NullText = "";
            this.txtActionTaken.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.txtActionTaken.Properties.ValueMember = "ActionTaken";
            this.txtActionTaken.Size = new System.Drawing.Size(504, 73);
            this.txtActionTaken.TabIndex = 4;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(31, 256);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(50, 17);
            this.labelControl9.TabIndex = 0;
            this.labelControl9.Text = "Remarks";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRemarks.Location = new System.Drawing.Point(87, 253);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.txtRemarks.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtRemarks.Properties.Appearance.Options.UseFont = true;
            this.txtRemarks.Size = new System.Drawing.Size(504, 39);
            this.txtRemarks.TabIndex = 5;
            this.txtRemarks.EditValueChanged += new System.EventHandler(this.cboStatus_EditValueChanged);
            // 
            // frmDocActions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 384);
            this.Controls.Add(this.cboActivity);
            this.Controls.Add(this.cboSub);
            this.Controls.Add(this.cboMain);
            this.Controls.Add(this.cboPrograms);
            this.Controls.Add(this.cboUsers);
            this.Controls.Add(this.btnEditPo);
            this.Controls.Add(this.btnNewPO);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtActionTaken);
            this.Controls.Add(this.txtRemarks);
            this.Name = "frmDocActions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmWOActions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboUsers.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPrograms.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DropdownBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMain.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSub.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboActivity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtActionTaken.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActionTakenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemarks.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit dtDate;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LookUpEdit cboStatus;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnEditPo;
        private DevExpress.XtraEditors.SimpleButton btnNewPO;
        private DevExpress.XtraEditors.LabelControl lblWorkOrder;
        private System.Windows.Forms.BindingSource StatusBindingSource;
        private DevExpress.XtraEditors.LookUpEdit cboUsers;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.BindingSource UserBindingSource;
        private DevExpress.XtraEditors.LookUpEdit cboPrograms;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LookUpEdit cboMain;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LookUpEdit cboSub;
        private System.Windows.Forms.BindingSource DropdownBindingSource;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LookUpEdit cboActivity;
        private DevExpress.XtraEditors.LookUpEdit txtActionTaken;
        private System.Windows.Forms.BindingSource ActionTakenBindingSource;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.MemoEdit txtRemarks;
    }
}