namespace Win.Ofc
{
    partial class frmOffices
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
            this.OfficeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OfficeGrid = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.delCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.OffcAcr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OfficeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Chief = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TelNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BoxNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPosition = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnEditPo = new DevExpress.XtraEditors.SimpleButton();
            this.btnNewPO = new DevExpress.XtraEditors.SimpleButton();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OfficeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OfficeGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.OfficeBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.gridControl1.Location = new System.Drawing.Point(0, 37);
            this.gridControl1.MainView = this.OfficeGrid;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1});
            this.gridControl1.Size = new System.Drawing.Size(1129, 598);
            this.gridControl1.TabIndex = 15;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.OfficeGrid});
            // 
            // OfficeGrid
            // 
            this.OfficeGrid.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.OfficeGrid.Appearance.Row.Options.UseFont = true;
            this.OfficeGrid.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.delCol,
            this.OffcAcr,
            this.OfficeName,
            this.Chief,
            this.TelNo,
            this.BoxNo,
            this.colPosition});
            this.OfficeGrid.GridControl = this.gridControl1;
            this.OfficeGrid.Name = "OfficeGrid";
            this.OfficeGrid.NewItemRowText = "New Equipment";
            this.OfficeGrid.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.OfficeGrid.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.OfficeGrid.OptionsEditForm.EditFormColumnCount = 2;
            this.OfficeGrid.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.False;
            this.OfficeGrid.OptionsNavigation.AutoFocusNewRow = true;
            this.OfficeGrid.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full;
            this.OfficeGrid.OptionsView.BestFitUseErrorInfo = DevExpress.Utils.DefaultBoolean.True;
            this.OfficeGrid.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.OfficeGrid.OptionsView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.OfficeGrid.OptionsView.ShowGroupPanel = false;
            this.OfficeGrid.RowDeleting += new DevExpress.Data.RowDeletingEventHandler(this.OfficeGrid_RowDeleting);
            this.OfficeGrid.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.OfficeGrid_RowUpdated);
            this.OfficeGrid.DoubleClick += new System.EventHandler(this.OfficeGrid_DoubleClick);
            // 
            // Id
            // 
            this.Id.Caption = "Id";
            this.Id.FieldName = "Id";
            this.Id.Name = "Id";
            // 
            // delCol
            // 
            this.delCol.ColumnEdit = this.repositoryItemButtonEdit1;
            this.delCol.Name = "delCol";
            this.delCol.Visible = true;
            this.delCol.VisibleIndex = 0;
            this.delCol.Width = 23;
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
            this.repositoryItemButtonEdit1.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEdit1_ButtonClick_1);
            // 
            // OffcAcr
            // 
            this.OffcAcr.Caption = "OffcAcr";
            this.OffcAcr.FieldName = "OffcAcr";
            this.OffcAcr.Name = "OffcAcr";
            this.OffcAcr.Visible = true;
            this.OffcAcr.VisibleIndex = 1;
            this.OffcAcr.Width = 214;
            // 
            // OfficeName
            // 
            this.OfficeName.Caption = "Office Name";
            this.OfficeName.FieldName = "OfficeName";
            this.OfficeName.Name = "OfficeName";
            this.OfficeName.Visible = true;
            this.OfficeName.VisibleIndex = 2;
            this.OfficeName.Width = 214;
            // 
            // Chief
            // 
            this.Chief.Caption = "Chief";
            this.Chief.FieldName = "Chief";
            this.Chief.Name = "Chief";
            this.Chief.Visible = true;
            this.Chief.VisibleIndex = 3;
            this.Chief.Width = 214;
            // 
            // TelNo
            // 
            this.TelNo.Caption = "Tel No";
            this.TelNo.FieldName = "TelNo";
            this.TelNo.Name = "TelNo";
            this.TelNo.Visible = true;
            this.TelNo.VisibleIndex = 5;
            this.TelNo.Width = 214;
            // 
            // BoxNo
            // 
            this.BoxNo.Caption = "Box No";
            this.BoxNo.FieldName = "BoxNo";
            this.BoxNo.Name = "BoxNo";
            this.BoxNo.Visible = true;
            this.BoxNo.VisibleIndex = 6;
            this.BoxNo.Width = 227;
            // 
            // colPosition
            // 
            this.colPosition.Caption = "Position";
            this.colPosition.FieldName = "Position";
            this.colPosition.Name = "colPosition";
            this.colPosition.Visible = true;
            this.colPosition.VisibleIndex = 4;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnEditPo);
            this.panelControl1.Controls.Add(this.btnNewPO);
            this.panelControl1.Controls.Add(this.searchControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1129, 37);
            this.panelControl1.TabIndex = 16;
            // 
            // btnEditPo
            // 
            this.btnEditPo.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnEditPo.Appearance.Options.UseFont = true;
            this.btnEditPo.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnEditPo.ImageOptions.Image = global::Win.Properties.Resources.edit_16;
            this.btnEditPo.Location = new System.Drawing.Point(492, 6);
            this.btnEditPo.Name = "btnEditPo";
            this.btnEditPo.Size = new System.Drawing.Size(99, 26);
            this.btnEditPo.TabIndex = 5;
            this.btnEditPo.Text = "Edit Office";
            this.btnEditPo.Click += new System.EventHandler(this.btnEditPo_Click);
            // 
            // btnNewPO
            // 
            this.btnNewPO.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNewPO.Appearance.Options.UseFont = true;
            this.btnNewPO.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnNewPO.ImageOptions.Image = global::Win.Properties.Resources.add_16;
            this.btnNewPO.Location = new System.Drawing.Point(387, 6);
            this.btnNewPO.Name = "btnNewPO";
            this.btnNewPO.Size = new System.Drawing.Size(99, 26);
            this.btnNewPO.TabIndex = 4;
            this.btnNewPO.Text = "New Office";
            this.btnNewPO.Click += new System.EventHandler(this.btnNewPO_Click);
            // 
            // searchControl1
            // 
            this.searchControl1.Location = new System.Drawing.Point(12, 4);
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.searchControl1.Properties.Appearance.Options.UseFont = true;
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Properties.EditValueChanged += new System.EventHandler(this.searchControl1_Properties_EditValueChanged);
            this.searchControl1.Size = new System.Drawing.Size(369, 28);
            this.searchControl1.TabIndex = 1;
            this.searchControl1.SelectedIndexChanged += new System.EventHandler(this.searchControl1_SelectedIndexChanged);
            this.searchControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchControl1_KeyDown);
            // 
            // frmOffices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 635);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmOffices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Offices";
            this.Load += new System.EventHandler(this.frmOffices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OfficeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OfficeGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView OfficeGrid;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn OffcAcr;
        private DevExpress.XtraGrid.Columns.GridColumn OfficeName;
        private DevExpress.XtraGrid.Columns.GridColumn Chief;
        private DevExpress.XtraGrid.Columns.GridColumn TelNo;
        private DevExpress.XtraGrid.Columns.GridColumn BoxNo;
        private System.Windows.Forms.BindingSource OfficeBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn delCol;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colPosition;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SearchControl searchControl1;
        private DevExpress.XtraEditors.SimpleButton btnEditPo;
        private DevExpress.XtraEditors.SimpleButton btnNewPO;
    }
}