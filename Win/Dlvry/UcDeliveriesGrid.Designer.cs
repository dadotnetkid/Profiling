namespace Win.Dlvry
{
    partial class UcDeliveryGrid
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.Grid = new DevExpress.XtraGrid.GridControl();
            this.TechSpecGrid = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PPEDel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colOfficeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateRequested = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TechSpecId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.txtSearch = new DevExpress.XtraEditors.SearchControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TechSpecGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit2)).BeginInit();
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
            this.panelControl1.Size = new System.Drawing.Size(482, 431);
            this.panelControl1.TabIndex = 3;
            // 
            // Grid
            // 
            this.Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid.Location = new System.Drawing.Point(2, 46);
            this.Grid.MainView = this.TechSpecGrid;
            this.Grid.Name = "Grid";
            this.Grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit2});
            this.Grid.Size = new System.Drawing.Size(478, 383);
            this.Grid.TabIndex = 1;
            this.Grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.TechSpecGrid});
            // 
            // TechSpecGrid
            // 
            this.TechSpecGrid.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.PPEDel,
            this.colOfficeId,
            this.colEmployeeId,
            this.colDateRequested,
            this.TechSpecId});
            this.TechSpecGrid.GridControl = this.Grid;
            this.TechSpecGrid.Name = "TechSpecGrid";
            this.TechSpecGrid.NewItemRowText = "New PO";
            this.TechSpecGrid.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplaceHideCurrentRow;
            this.TechSpecGrid.OptionsBehavior.ReadOnly = true;
            this.TechSpecGrid.OptionsEditForm.EditFormColumnCount = 1;
            this.TechSpecGrid.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.False;
            this.TechSpecGrid.OptionsNavigation.AutoFocusNewRow = true;
            this.TechSpecGrid.OptionsView.ShowFooter = true;
            this.TechSpecGrid.OptionsView.ShowGroupPanel = false;
            this.TechSpecGrid.DoubleClick += new System.EventHandler(this.TechSpecGrid_DoubleClick);
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
            this.PPEDel.Width = 30;
            // 
            // repositoryItemButtonEdit2
            // 
            this.repositoryItemButtonEdit2.Appearance.Image = global::Win.Properties.Resources.cancel_16;
            this.repositoryItemButtonEdit2.Appearance.Options.UseImage = true;
            this.repositoryItemButtonEdit2.AutoHeight = false;
            editorButtonImageOptions2.Image = global::Win.Properties.Resources.cancel_16;
            serializableAppearanceObject5.Image = global::Win.Properties.Resources.cancel_16;
            serializableAppearanceObject5.Options.UseImage = true;
            this.repositoryItemButtonEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonEdit2.ContextImageOptions.Image = global::Win.Properties.Resources.cancel_16;
            this.repositoryItemButtonEdit2.Name = "repositoryItemButtonEdit2";
            this.repositoryItemButtonEdit2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEdit2.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEdit2_ButtonClick);
            // 
            // colOfficeId
            // 
            this.colOfficeId.Caption = "Office";
            this.colOfficeId.FieldName = "Employees.Offices.OfficeName";
            this.colOfficeId.Name = "colOfficeId";
            this.colOfficeId.Visible = true;
            this.colOfficeId.VisibleIndex = 3;
            this.colOfficeId.Width = 80;
            // 
            // colEmployeeId
            // 
            this.colEmployeeId.Caption = "Employee";
            this.colEmployeeId.FieldName = "Employees.EmployeeName";
            this.colEmployeeId.Name = "colEmployeeId";
            this.colEmployeeId.Visible = true;
            this.colEmployeeId.VisibleIndex = 4;
            this.colEmployeeId.Width = 88;
            // 
            // colDateRequested
            // 
            this.colDateRequested.Caption = "Date/Time";
            this.colDateRequested.FieldName = "DateRequested";
            this.colDateRequested.Name = "colDateRequested";
            this.colDateRequested.Visible = true;
            this.colDateRequested.VisibleIndex = 2;
            this.colDateRequested.Width = 67;
            // 
            // TechSpecId
            // 
            this.TechSpecId.Caption = "Id";
            this.TechSpecId.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.TechSpecId.FieldName = "TechSpecsId";
            this.TechSpecId.Name = "TechSpecId";
            this.TechSpecId.Visible = true;
            this.TechSpecId.VisibleIndex = 1;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.txtSearch);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(2, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(478, 44);
            this.panelControl2.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(13, 8);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSearch.Properties.Appearance.Options.UseFont = true;
            this.txtSearch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.txtSearch.Properties.ShowDefaultButtonsMode = DevExpress.XtraEditors.Repository.ShowDefaultButtonsMode.AutoChangeSearchToClear;
            this.txtSearch.Properties.EditValueChanged += new System.EventHandler(this.txtSearch_Properties_EditValueChanged);
            this.txtSearch.Size = new System.Drawing.Size(460, 28);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // UcDeliveryGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Name = "UcDeliveryGrid";
            this.Size = new System.Drawing.Size(482, 431);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TechSpecGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl Grid;
        private DevExpress.XtraGrid.Views.Grid.GridView TechSpecGrid;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn PPEDel;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn colOfficeId;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeId;
        private DevExpress.XtraGrid.Columns.GridColumn colDateRequested;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SearchControl txtSearch;
        private DevExpress.XtraGrid.Columns.GridColumn TechSpecId;
    }
}
