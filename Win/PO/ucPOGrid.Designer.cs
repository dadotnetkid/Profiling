namespace Win.PO
{
    partial class ucPOGrid
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.POBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.Grid = new DevExpress.XtraGrid.GridControl();
            this.POGrid = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PPEDel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.PurchaseNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OfficeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OfficeLookUpRepo = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.EmployeeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.txtSearch = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.POBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.POGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OfficeLookUpRepo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelControl1.Controls.Add(this.Grid);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(269, 584);
            this.panelControl1.TabIndex = 5;
            // 
            // Grid
            // 
            this.Grid.DataSource = this.POBindingSource;
            this.Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid.Location = new System.Drawing.Point(2, 46);
            this.Grid.MainView = this.POGrid;
            this.Grid.Name = "Grid";
            this.Grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.OfficeLookUpRepo,
            this.repositoryItemDateEdit1,
            this.repositoryItemButtonEdit2});
            this.Grid.Size = new System.Drawing.Size(265, 536);
            this.Grid.TabIndex = 2;
            this.Grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.POGrid});
            // 
            // POGrid
            // 
            this.POGrid.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.PPEDel,
            this.PurchaseNumber,
            this.OfficeId,
            this.EmployeeId});
            this.POGrid.GridControl = this.Grid;
            this.POGrid.Name = "POGrid";
            this.POGrid.NewItemRowText = "New PO";
            this.POGrid.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplaceHideCurrentRow;
            this.POGrid.OptionsBehavior.ReadOnly = true;
            this.POGrid.OptionsEditForm.EditFormColumnCount = 1;
            this.POGrid.OptionsNavigation.AutoFocusNewRow = true;
            this.POGrid.OptionsView.ShowFooter = true;
            this.POGrid.OptionsView.ShowGroupPanel = false;
            this.POGrid.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.POGrid_CustomDrawCell);
            // 
            // Id
            // 
            this.Id.Caption = "Id";
            this.Id.FieldName = "Id";
            this.Id.Name = "Id";
            // 
            // PPEDel
            // 
            this.PPEDel.AppearanceCell.Image = global::Win.Properties.Resources.cancel_16;
            this.PPEDel.AppearanceCell.Options.UseImage = true;
            this.PPEDel.ColumnEdit = this.repositoryItemButtonEdit2;
            this.PPEDel.Name = "PPEDel";
            this.PPEDel.Visible = true;
            this.PPEDel.VisibleIndex = 0;
            this.PPEDel.Width = 37;
            // 
            // repositoryItemButtonEdit2
            // 
            this.repositoryItemButtonEdit2.Appearance.Image = global::Win.Properties.Resources.cancel_16;
            this.repositoryItemButtonEdit2.Appearance.Options.UseImage = true;
            this.repositoryItemButtonEdit2.AutoHeight = false;
            editorButtonImageOptions1.Image = global::Win.Properties.Resources.cancel_16;
            serializableAppearanceObject1.Image = global::Win.Properties.Resources.cancel_16;
            serializableAppearanceObject1.Options.UseImage = true;
            this.repositoryItemButtonEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonEdit2.ContextImageOptions.Image = global::Win.Properties.Resources.cancel_16;
            this.repositoryItemButtonEdit2.Name = "repositoryItemButtonEdit2";
            this.repositoryItemButtonEdit2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEdit2.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEdit2_ButtonClick);
            // 
            // PurchaseNumber
            // 
            this.PurchaseNumber.Caption = "PO No";
            this.PurchaseNumber.DisplayFormat.FormatString = "PO-0000";
            this.PurchaseNumber.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.PurchaseNumber.FieldName = "Id";
            this.PurchaseNumber.Name = "PurchaseNumber";
            this.PurchaseNumber.Visible = true;
            this.PurchaseNumber.VisibleIndex = 1;
            this.PurchaseNumber.Width = 109;
            // 
            // OfficeId
            // 
            this.OfficeId.Caption = "Office";
            this.OfficeId.FieldName = "Offices.OfficeName";
            this.OfficeId.Name = "OfficeId";
            this.OfficeId.Visible = true;
            this.OfficeId.VisibleIndex = 2;
            this.OfficeId.Width = 109;
            // 
            // OfficeLookUpRepo
            // 
            this.OfficeLookUpRepo.AutoHeight = false;
            this.OfficeLookUpRepo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.OfficeLookUpRepo.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 33, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("OffcAcr", "OffcAcr"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("OfficeName", "Office Name", 73, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.OfficeLookUpRepo.DisplayMember = "OfficeName";
            this.OfficeLookUpRepo.Name = "OfficeLookUpRepo";
            this.OfficeLookUpRepo.NullText = "";
            this.OfficeLookUpRepo.ValueMember = "Id";
            // 
            // EmployeeId
            // 
            this.EmployeeId.Caption = "Employee";
            this.EmployeeId.FieldName = "Employees.EmployeeName";
            this.EmployeeId.Name = "EmployeeId";
            this.EmployeeId.Visible = true;
            this.EmployeeId.VisibleIndex = 3;
            this.EmployeeId.Width = 109;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnSearch);
            this.panelControl2.Controls.Add(this.txtSearch);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(2, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(265, 44);
            this.panelControl2.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.AutoSize = true;
            this.btnSearch.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnSearch.ImageOptions.Image = global::Win.Properties.Resources.search_20;
            this.btnSearch.Location = new System.Drawing.Point(232, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(28, 26);
            this.btnSearch.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(11, 11);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSearch.Properties.Appearance.Options.UseFont = true;
            this.txtSearch.Size = new System.Drawing.Size(215, 28);
            this.txtSearch.TabIndex = 0;
            // 
            // ucPOGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Name = "ucPOGrid";
            this.Size = new System.Drawing.Size(269, 584);
            this.Load += new System.EventHandler(this.ucPOGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.POBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.POGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OfficeLookUpRepo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource POBindingSource;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn PPEDel;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn PurchaseNumber;
        private DevExpress.XtraGrid.Columns.GridColumn OfficeId;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit OfficeLookUpRepo;
        private DevExpress.XtraGrid.Columns.GridColumn EmployeeId;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.TextEdit txtSearch;
        public DevExpress.XtraGrid.GridControl Grid;
        public DevExpress.XtraGrid.Views.Grid.GridView POGrid;
    }
}
