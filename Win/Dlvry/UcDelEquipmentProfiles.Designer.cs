namespace Win.Dlvry
{
    partial class UcDelEquipmentProfiles
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject12 = new DevExpress.Utils.SerializableAppearanceObject();
            this.EquipmentProfileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.EquipmentGrid = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PPEId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.delCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.ItemNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UnitTypeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Serial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EquipmentTypeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EquipmentName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.UnitCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.decimalSpinEditRepo = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.Total = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentProfileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.decimalSpinEditRepo)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.EquipmentProfileBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.EquipmentGrid;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1,
            this.repositoryItemSpinEdit1,
            this.decimalSpinEditRepo,
            this.repositoryItemMemoEdit1});
            this.gridControl1.Size = new System.Drawing.Size(510, 174);
            this.gridControl1.TabIndex = 22;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.EquipmentGrid});
            // 
            // EquipmentGrid
            // 
            this.EquipmentGrid.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.EquipmentGrid.Appearance.Row.Options.UseFont = true;
            this.EquipmentGrid.ChildGridLevelName = "DetailView";
            this.EquipmentGrid.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.PPEId,
            this.delCol,
            this.ItemNo,
            this.UnitTypeId,
            this.Serial,
            this.EquipmentTypeId,
            this.EquipmentName,
            this.Description,
            this.QTY,
            this.UnitCost,
            this.Total});
            this.EquipmentGrid.GridControl = this.gridControl1;
            this.EquipmentGrid.Name = "EquipmentGrid";
            this.EquipmentGrid.NewItemRowText = "New Equipment";
            this.EquipmentGrid.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.EquipmentGrid.OptionsBehavior.ReadOnly = true;
            this.EquipmentGrid.OptionsEditForm.EditFormColumnCount = 2;
            this.EquipmentGrid.OptionsNavigation.AutoFocusNewRow = true;
            this.EquipmentGrid.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full;
            this.EquipmentGrid.OptionsView.BestFitUseErrorInfo = DevExpress.Utils.DefaultBoolean.True;
            this.EquipmentGrid.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.EquipmentGrid.OptionsView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.EquipmentGrid.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Id";
            this.gridColumn1.FieldName = "Id";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // PPEId
            // 
            this.PPEId.Caption = "PPEId";
            this.PPEId.FieldName = "PPEId";
            this.PPEId.Name = "PPEId";
            // 
            // delCol
            // 
            this.delCol.ColumnEdit = this.repositoryItemButtonEdit1;
            this.delCol.Name = "delCol";
            this.delCol.Width = 29;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            editorButtonImageOptions1.Image = global::Win.Properties.Resources.cancel_16;
            serializableAppearanceObject1.Image = global::Win.Properties.Resources.cancel_16;
            serializableAppearanceObject1.Options.UseImage = true;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // ItemNo
            // 
            this.ItemNo.Caption = "Item No";
            this.ItemNo.FieldName = "ItemNumber";
            this.ItemNo.Name = "ItemNo";
            this.ItemNo.Visible = true;
            this.ItemNo.VisibleIndex = 0;
            this.ItemNo.Width = 69;
            // 
            // UnitTypeId
            // 
            this.UnitTypeId.Caption = "UOM";
            this.UnitTypeId.FieldName = "UnitTypes.UnitType";
            this.UnitTypeId.Name = "UnitTypeId";
            this.UnitTypeId.Visible = true;
            this.UnitTypeId.VisibleIndex = 2;
            this.UnitTypeId.Width = 89;
            // 
            // Serial
            // 
            this.Serial.Caption = "Serial";
            this.Serial.FieldName = "Serial";
            this.Serial.Name = "Serial";
            this.Serial.Width = 94;
            // 
            // EquipmentTypeId
            // 
            this.EquipmentTypeId.Caption = "Equipment Type";
            this.EquipmentTypeId.FieldName = "EquipmentType";
            this.EquipmentTypeId.Name = "EquipmentTypeId";
            this.EquipmentTypeId.Visible = true;
            this.EquipmentTypeId.VisibleIndex = 3;
            this.EquipmentTypeId.Width = 125;
            // 
            // EquipmentName
            // 
            this.EquipmentName.Caption = "Equipment Name";
            this.EquipmentName.FieldName = "EquipmentName";
            this.EquipmentName.Name = "EquipmentName";
            this.EquipmentName.Width = 94;
            // 
            // Description
            // 
            this.Description.Caption = "Description";
            this.Description.ColumnEdit = this.repositoryItemMemoEdit1;
            this.Description.FieldName = "Description";
            this.Description.Name = "Description";
            this.Description.Visible = true;
            this.Description.VisibleIndex = 4;
            this.Description.Width = 217;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // QTY
            // 
            this.QTY.Caption = "QTY";
            this.QTY.ColumnEdit = this.repositoryItemSpinEdit1;
            this.QTY.FieldName = "QTY";
            this.QTY.Name = "QTY";
            this.QTY.Visible = true;
            this.QTY.VisibleIndex = 1;
            this.QTY.Width = 55;
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, false, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            // 
            // UnitCost
            // 
            this.UnitCost.Caption = "UnitCost";
            this.UnitCost.ColumnEdit = this.decimalSpinEditRepo;
            this.UnitCost.DisplayFormat.FormatString = "n2";
            this.UnitCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.UnitCost.FieldName = "UnitCost";
            this.UnitCost.Name = "UnitCost";
            this.UnitCost.Visible = true;
            this.UnitCost.VisibleIndex = 5;
            this.UnitCost.Width = 95;
            // 
            // decimalSpinEditRepo
            // 
            this.decimalSpinEditRepo.AutoHeight = false;
            this.decimalSpinEditRepo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, false, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.decimalSpinEditRepo.DisplayFormat.FormatString = "#,#.0#";
            this.decimalSpinEditRepo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.decimalSpinEditRepo.EditFormat.FormatString = "#,#.0#";
            this.decimalSpinEditRepo.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.decimalSpinEditRepo.Name = "decimalSpinEditRepo";
            // 
            // Total
            // 
            this.Total.Caption = "Total";
            this.Total.ColumnEdit = this.decimalSpinEditRepo;
            this.Total.DisplayFormat.FormatString = "n2";
            this.Total.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.Total.FieldName = "Total";
            this.Total.Name = "Total";
            this.Total.OptionsColumn.ReadOnly = true;
            this.Total.Visible = true;
            this.Total.VisibleIndex = 6;
            this.Total.Width = 143;
            // 
            // UcDelEquipmentProfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "UcDelEquipmentProfiles";
            this.Size = new System.Drawing.Size(510, 174);
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentProfileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.decimalSpinEditRepo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource EquipmentProfileBindingSource;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView EquipmentGrid;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn PPEId;
        private DevExpress.XtraGrid.Columns.GridColumn delCol;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn ItemNo;
        private DevExpress.XtraGrid.Columns.GridColumn UnitTypeId;
        private DevExpress.XtraGrid.Columns.GridColumn Serial;
        private DevExpress.XtraGrid.Columns.GridColumn EquipmentTypeId;
        private DevExpress.XtraGrid.Columns.GridColumn EquipmentName;
        private DevExpress.XtraGrid.Columns.GridColumn Description;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn QTY;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn UnitCost;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit decimalSpinEditRepo;
        private DevExpress.XtraGrid.Columns.GridColumn Total;
    }
}
