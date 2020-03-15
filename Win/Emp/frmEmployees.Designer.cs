namespace Win.Emp
{
    partial class frmEmployees
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.EmployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EmployeeGrid = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.delCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonDEL = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.FirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MiddleName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Position = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OfficeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OfficeLookUpRepo = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.OfficeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonDEL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OfficeLookUpRepo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OfficeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.EmployeeBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.EmployeeGrid;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonDEL,
            this.OfficeLookUpRepo});
            this.gridControl1.Size = new System.Drawing.Size(921, 571);
            this.gridControl1.TabIndex = 16;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.EmployeeGrid});
            // 
            // EmployeeGrid
            // 
            this.EmployeeGrid.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.EmployeeGrid.Appearance.Row.Options.UseFont = true;
            this.EmployeeGrid.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.delCol,
            this.FirstName,
            this.MiddleName,
            this.LastName,
            this.Position,
            this.OfficeId});
            this.EmployeeGrid.GridControl = this.gridControl1;
            this.EmployeeGrid.Name = "EmployeeGrid";
            this.EmployeeGrid.NewItemRowText = "New Employee";
            this.EmployeeGrid.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.EmployeeGrid.OptionsEditForm.EditFormColumnCount = 2;
            this.EmployeeGrid.OptionsNavigation.AutoFocusNewRow = true;
            this.EmployeeGrid.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full;
            this.EmployeeGrid.OptionsView.BestFitUseErrorInfo = DevExpress.Utils.DefaultBoolean.True;
            this.EmployeeGrid.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.EmployeeGrid.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.EmployeeGrid.OptionsView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.EmployeeGrid.OptionsView.ShowGroupPanel = false;
            this.EmployeeGrid.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.EmployeeGrid_RowUpdated);
            // 
            // Id
            // 
            this.Id.Caption = "Id";
            this.Id.FieldName = "Id";
            this.Id.Name = "Id";
            // 
            // delCol
            // 
            this.delCol.ColumnEdit = this.repositoryItemButtonDEL;
            this.delCol.Name = "delCol";
            this.delCol.Visible = true;
            this.delCol.VisibleIndex = 0;
            this.delCol.Width = 20;
            // 
            // repositoryItemButtonDEL
            // 
            this.repositoryItemButtonDEL.AutoHeight = false;
            editorButtonImageOptions1.Image = global::Win.Properties.Resources.cancel_16;
            serializableAppearanceObject1.Image = global::Win.Properties.Resources.cancel_16;
            serializableAppearanceObject1.Options.UseImage = true;
            this.repositoryItemButtonDEL.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonDEL.Name = "repositoryItemButtonDEL";
            this.repositoryItemButtonDEL.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonDEL.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonDEL_ButtonClick);
            // 
            // FirstName
            // 
            this.FirstName.Caption = "First Name";
            this.FirstName.FieldName = "FirstName";
            this.FirstName.Name = "FirstName";
            this.FirstName.Visible = true;
            this.FirstName.VisibleIndex = 1;
            // 
            // MiddleName
            // 
            this.MiddleName.Caption = "Middle Name";
            this.MiddleName.FieldName = "MiddleName";
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.Visible = true;
            this.MiddleName.VisibleIndex = 2;
            // 
            // LastName
            // 
            this.LastName.Caption = "Last Name";
            this.LastName.FieldName = "LastName";
            this.LastName.Name = "LastName";
            this.LastName.Visible = true;
            this.LastName.VisibleIndex = 3;
            // 
            // Position
            // 
            this.Position.Caption = "Position";
            this.Position.FieldName = "Position";
            this.Position.Name = "Position";
            this.Position.Visible = true;
            this.Position.VisibleIndex = 4;
            // 
            // OfficeId
            // 
            this.OfficeId.Caption = "Office";
            this.OfficeId.ColumnEdit = this.OfficeLookUpRepo;
            this.OfficeId.FieldName = "OfficeId";
            this.OfficeId.Name = "OfficeId";
            this.OfficeId.Visible = true;
            this.OfficeId.VisibleIndex = 5;
            this.OfficeId.Width = 229;
            // 
            // OfficeLookUpRepo
            // 
            this.OfficeLookUpRepo.AutoHeight = false;
            this.OfficeLookUpRepo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.OfficeLookUpRepo.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 33, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("OfficeName", "Office Name", 73, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.OfficeLookUpRepo.DataSource = this.OfficeBindingSource;
            this.OfficeLookUpRepo.DisplayMember = "OfficeName";
            this.OfficeLookUpRepo.Name = "OfficeLookUpRepo";
            this.OfficeLookUpRepo.NullText = "";
            this.OfficeLookUpRepo.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.OfficeLookUpRepo.ValueMember = "Id";
            // 
            // frmEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 571);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmEmployees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.frmEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonDEL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OfficeLookUpRepo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OfficeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView EmployeeGrid;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn delCol;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonDEL;
        private System.Windows.Forms.BindingSource EmployeeBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn FirstName;
        private DevExpress.XtraGrid.Columns.GridColumn MiddleName;
        private DevExpress.XtraGrid.Columns.GridColumn LastName;
        private DevExpress.XtraGrid.Columns.GridColumn OfficeId;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit OfficeLookUpRepo;
        private System.Windows.Forms.BindingSource OfficeBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn Position;
    }
}