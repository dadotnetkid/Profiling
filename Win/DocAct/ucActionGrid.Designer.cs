namespace Win.DocAct
{
    partial class ucActionGrid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucActionGrid));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.EmployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EquipmentProfileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UnitTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EquipmentTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OfficeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DropdownBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ActionGridControl = new DevExpress.XtraGrid.GridControl();
            this.ActionGrid = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ActionId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEditAction = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEditRepo = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.ActionTaken = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Program = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProgramLookUpRepo = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.MainActivity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MainActLookUpRepo = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.Activity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ActivityLookUpRepo = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.SubActivity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SubActLookUpRepo = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.DateCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDelRepo = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentProfileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OfficeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DropdownBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActionGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActionGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditRepo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProgramLookUpRepo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainActLookUpRepo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityLookUpRepo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubActLookUpRepo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelRepo)).BeginInit();
            this.SuspendLayout();
            // 
            // ActionGridControl
            // 
            this.ActionGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActionGridControl.Location = new System.Drawing.Point(0, 0);
            this.ActionGridControl.MainView = this.ActionGrid;
            this.ActionGridControl.Name = "ActionGridControl";
            this.ActionGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.MainActLookUpRepo,
            this.ActivityLookUpRepo,
            this.SubActLookUpRepo,
            this.ProgramLookUpRepo,
            this.btnEditRepo,
            this.btnDelRepo});
            this.ActionGridControl.Size = new System.Drawing.Size(956, 310);
            this.ActionGridControl.TabIndex = 5;
            this.ActionGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ActionGrid});
            // 
            // ActionGrid
            // 
            this.ActionGrid.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ActionId,
            this.btnEditAction,
            this.ActionTaken,
            this.Program,
            this.MainActivity,
            this.Activity,
            this.SubActivity,
            this.DateCreated,
            this.Status,
            this.colDel});
            this.ActionGrid.GridControl = this.ActionGridControl;
            this.ActionGrid.Name = "ActionGrid";
            this.ActionGrid.NewItemRowText = "New PO";
            this.ActionGrid.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplaceHideCurrentRow;
            this.ActionGrid.OptionsBehavior.ReadOnly = true;
            this.ActionGrid.OptionsEditForm.EditFormColumnCount = 1;
            this.ActionGrid.OptionsNavigation.AutoFocusNewRow = true;
            this.ActionGrid.OptionsView.ShowFooter = true;
            this.ActionGrid.OptionsView.ShowGroupPanel = false;
            // 
            // ActionId
            // 
            this.ActionId.Caption = "Id";
            this.ActionId.FieldName = "Id";
            this.ActionId.Name = "ActionId";
            // 
            // btnEditAction
            // 
            this.btnEditAction.ColumnEdit = this.btnEditRepo;
            this.btnEditAction.Name = "btnEditAction";
            this.btnEditAction.Visible = true;
            this.btnEditAction.VisibleIndex = 0;
            this.btnEditAction.Width = 20;
            // 
            // btnEditRepo
            // 
            this.btnEditRepo.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("btnEditRepo.Appearance.Image")));
            this.btnEditRepo.Appearance.Options.UseImage = true;
            this.btnEditRepo.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            serializableAppearanceObject1.Image = ((System.Drawing.Image)(resources.GetObject("serializableAppearanceObject1.Image")));
            serializableAppearanceObject1.Options.UseImage = true;
            this.btnEditRepo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnEditRepo.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEditRepo.ContextImageOptions.Image")));
            this.btnEditRepo.Name = "btnEditRepo";
            this.btnEditRepo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnEditRepo.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnEditRepo_ButtonClick);
            // 
            // ActionTaken
            // 
            this.ActionTaken.Caption = "Action Taken";
            this.ActionTaken.FieldName = "ActionTaken";
            this.ActionTaken.Name = "ActionTaken";
            this.ActionTaken.Visible = true;
            this.ActionTaken.VisibleIndex = 6;
            this.ActionTaken.Width = 108;
            // 
            // Program
            // 
            this.Program.Caption = "Program";
            this.Program.ColumnEdit = this.ProgramLookUpRepo;
            this.Program.FieldName = "ProgramId";
            this.Program.Name = "Program";
            this.Program.Visible = true;
            this.Program.VisibleIndex = 2;
            this.Program.Width = 108;
            // 
            // ProgramLookUpRepo
            // 
            this.ProgramLookUpRepo.AutoHeight = false;
            this.ProgramLookUpRepo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ProgramLookUpRepo.DisplayMember = "Value";
            this.ProgramLookUpRepo.Name = "ProgramLookUpRepo";
            this.ProgramLookUpRepo.NullText = "";
            this.ProgramLookUpRepo.ValueMember = "Id";
            // 
            // MainActivity
            // 
            this.MainActivity.Caption = "Main Activity";
            this.MainActivity.ColumnEdit = this.MainActLookUpRepo;
            this.MainActivity.FieldName = "MainActivityId";
            this.MainActivity.Name = "MainActivity";
            this.MainActivity.Visible = true;
            this.MainActivity.VisibleIndex = 4;
            this.MainActivity.Width = 108;
            // 
            // MainActLookUpRepo
            // 
            this.MainActLookUpRepo.AutoHeight = false;
            this.MainActLookUpRepo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.MainActLookUpRepo.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 33, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Value", 39, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.MainActLookUpRepo.DataSource = this.EmployeeBindingSource;
            this.MainActLookUpRepo.DisplayMember = "Value";
            this.MainActLookUpRepo.Name = "MainActLookUpRepo";
            this.MainActLookUpRepo.NullText = "";
            this.MainActLookUpRepo.ValueMember = "Id";
            // 
            // Activity
            // 
            this.Activity.Caption = "Activity";
            this.Activity.ColumnEdit = this.ActivityLookUpRepo;
            this.Activity.FieldName = "ActivityId";
            this.Activity.Name = "Activity";
            this.Activity.Visible = true;
            this.Activity.VisibleIndex = 3;
            this.Activity.Width = 108;
            // 
            // ActivityLookUpRepo
            // 
            this.ActivityLookUpRepo.AutoHeight = false;
            this.ActivityLookUpRepo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ActivityLookUpRepo.DisplayMember = "Value";
            this.ActivityLookUpRepo.Name = "ActivityLookUpRepo";
            this.ActivityLookUpRepo.NullText = "";
            this.ActivityLookUpRepo.ValueMember = "Id";
            // 
            // SubActivity
            // 
            this.SubActivity.Caption = "Sub Activity";
            this.SubActivity.ColumnEdit = this.SubActLookUpRepo;
            this.SubActivity.FieldName = "SubActivityId";
            this.SubActivity.Name = "SubActivity";
            this.SubActivity.Visible = true;
            this.SubActivity.VisibleIndex = 5;
            this.SubActivity.Width = 108;
            // 
            // SubActLookUpRepo
            // 
            this.SubActLookUpRepo.AutoHeight = false;
            this.SubActLookUpRepo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SubActLookUpRepo.DisplayMember = "Value";
            this.SubActLookUpRepo.Name = "SubActLookUpRepo";
            this.SubActLookUpRepo.NullText = "";
            this.SubActLookUpRepo.ValueMember = "Id";
            // 
            // DateCreated
            // 
            this.DateCreated.Caption = "DateCreated";
            this.DateCreated.FieldName = "DateCreated";
            this.DateCreated.Name = "DateCreated";
            this.DateCreated.Visible = true;
            this.DateCreated.VisibleIndex = 8;
            this.DateCreated.Width = 128;
            // 
            // Status
            // 
            this.Status.Caption = "Status";
            this.Status.FieldName = "Status";
            this.Status.Name = "Status";
            this.Status.Visible = true;
            this.Status.VisibleIndex = 7;
            this.Status.Width = 108;
            // 
            // colDel
            // 
            this.colDel.ColumnEdit = this.btnDelRepo;
            this.colDel.Name = "colDel";
            this.colDel.Visible = true;
            this.colDel.VisibleIndex = 1;
            this.colDel.Width = 20;
            // 
            // btnDelRepo
            // 
            this.btnDelRepo.AutoHeight = false;
            editorButtonImageOptions2.Image = global::Win.Properties.Resources.close_16x16;
            this.btnDelRepo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnDelRepo.Name = "btnDelRepo";
            this.btnDelRepo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnDelRepo.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnDelRepo_ButtonClick);
            // 
            // ucActionGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ActionGridControl);
            this.Name = "ucActionGrid";
            this.Size = new System.Drawing.Size(956, 310);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentProfileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OfficeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DropdownBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActionGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActionGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditRepo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProgramLookUpRepo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainActLookUpRepo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityLookUpRepo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubActLookUpRepo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelRepo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource EmployeeBindingSource;
        private System.Windows.Forms.BindingSource EquipmentProfileBindingSource;
        private System.Windows.Forms.BindingSource UnitTypeBindingSource;
        private System.Windows.Forms.BindingSource EquipmentTypeBindingSource;
        private System.Windows.Forms.BindingSource OfficeBindingSource;
        private System.Windows.Forms.BindingSource SupplierBindingSource;
        private System.Windows.Forms.BindingSource DropdownBindingSource;
        private DevExpress.XtraGrid.GridControl ActionGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView ActionGrid;
        private DevExpress.XtraGrid.Columns.GridColumn ActionId;
        private DevExpress.XtraGrid.Columns.GridColumn btnEditAction;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEditRepo;
        private DevExpress.XtraGrid.Columns.GridColumn ActionTaken;
        private DevExpress.XtraGrid.Columns.GridColumn Program;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ProgramLookUpRepo;
        private DevExpress.XtraGrid.Columns.GridColumn MainActivity;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit MainActLookUpRepo;
        private DevExpress.XtraGrid.Columns.GridColumn Activity;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ActivityLookUpRepo;
        private DevExpress.XtraGrid.Columns.GridColumn SubActivity;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit SubActLookUpRepo;
        private DevExpress.XtraGrid.Columns.GridColumn DateCreated;
        private DevExpress.XtraGrid.Columns.GridColumn Status;
        private DevExpress.XtraGrid.Columns.GridColumn colDel;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDelRepo;
    }
}
