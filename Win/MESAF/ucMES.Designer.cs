namespace Win.MESAF
{
    partial class ucMES
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucMES));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtSearch = new DevExpress.XtraEditors.SearchControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.entityServerModeSource1 = new DevExpress.Data.Linq.EntityServerModeSource();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOfficeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBtnDel = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colItemSpec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReceivedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeliveredBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployees = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOffices = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMESId = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityServerModeSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colBtnDel)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtSearch);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Padding = new System.Windows.Forms.Padding(2);
            this.panelControl1.Size = new System.Drawing.Size(447, 37);
            this.panelControl1.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch.Location = new System.Drawing.Point(4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSearch.Properties.Appearance.Options.UseFont = true;
            this.txtSearch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.txtSearch.Properties.ShowDefaultButtonsMode = DevExpress.XtraEditors.Repository.ShowDefaultButtonsMode.AutoChangeSearchToClear;
            this.txtSearch.Size = new System.Drawing.Size(439, 28);
            this.txtSearch.TabIndex = 2;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.entityServerModeSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 37);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.colBtnDel});
            this.gridControl1.Size = new System.Drawing.Size(447, 265);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // entityServerModeSource1
            // 
            this.entityServerModeSource1.DefaultSorting = "Id ASC";
            this.entityServerModeSource1.ElementType = typeof(Models.MES);
            this.entityServerModeSource1.KeyExpression = "Id";
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colOfficeId,
            this.colEmployeeId,
            this.colDel,
            this.colItemSpec,
            this.colDateCreated,
            this.colReceivedBy,
            this.colDeliveredBy,
            this.colEmployees,
            this.colOffices,
            this.colMESId});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Width = 64;
            // 
            // colOfficeId
            // 
            this.colOfficeId.FieldName = "OfficeId";
            this.colOfficeId.Name = "colOfficeId";
            // 
            // colEmployeeId
            // 
            this.colEmployeeId.FieldName = "EmployeeId";
            this.colEmployeeId.Name = "colEmployeeId";
            // 
            // colDel
            // 
            this.colDel.ColumnEdit = this.colBtnDel;
            this.colDel.Name = "colDel";
            this.colDel.Visible = true;
            this.colDel.VisibleIndex = 0;
            this.colDel.Width = 20;
            // 
            // colBtnDel
            // 
            this.colBtnDel.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.colBtnDel.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.colBtnDel.Name = "colBtnDel";
            this.colBtnDel.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.colBtnDel.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.colBtnDel_ButtonClick);
            // 
            // colItemSpec
            // 
            this.colItemSpec.FieldName = "ItemSpec";
            this.colItemSpec.Name = "colItemSpec";
            this.colItemSpec.Visible = true;
            this.colItemSpec.VisibleIndex = 1;
            this.colItemSpec.Width = 168;
            // 
            // colDateCreated
            // 
            this.colDateCreated.FieldName = "DateCreated";
            this.colDateCreated.Name = "colDateCreated";
            this.colDateCreated.Visible = true;
            this.colDateCreated.VisibleIndex = 2;
            this.colDateCreated.Width = 174;
            // 
            // colReceivedBy
            // 
            this.colReceivedBy.FieldName = "ReceivedBy";
            this.colReceivedBy.Name = "colReceivedBy";
            // 
            // colDeliveredBy
            // 
            this.colDeliveredBy.FieldName = "DeliveredBy";
            this.colDeliveredBy.Name = "colDeliveredBy";
            // 
            // colEmployees
            // 
            this.colEmployees.FieldName = "Employees";
            this.colEmployees.Name = "colEmployees";
            // 
            // colOffices
            // 
            this.colOffices.FieldName = "Offices";
            this.colOffices.Name = "colOffices";
            // 
            // colMESId
            // 
            this.colMESId.Caption = "MES Id";
            this.colMESId.FieldName = "MESId";
            this.colMESId.Name = "colMESId";
            this.colMESId.Visible = true;
            this.colMESId.VisibleIndex = 3;
            // 
            // ucMES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "ucMES";
            this.Size = new System.Drawing.Size(447, 302);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityServerModeSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colBtnDel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.Data.Linq.EntityServerModeSource entityServerModeSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colOfficeId;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeId;
        private DevExpress.XtraGrid.Columns.GridColumn colItemSpec;
        private DevExpress.XtraGrid.Columns.GridColumn colDateCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colReceivedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colDeliveredBy;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployees;
        private DevExpress.XtraGrid.Columns.GridColumn colOffices;
        private DevExpress.XtraEditors.SearchControl txtSearch;
        private DevExpress.XtraGrid.Columns.GridColumn colDel;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit colBtnDel;
        private DevExpress.XtraGrid.Columns.GridColumn colMESId;
    }
}
