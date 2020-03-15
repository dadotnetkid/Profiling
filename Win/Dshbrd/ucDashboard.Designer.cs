namespace Win.Dshbrd
{
    partial class ucDashboard
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
            this.WorkOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OfficeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EmployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EquipmentProfileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EquipmentTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UnitTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ActionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnNewPO = new DevExpress.XtraEditors.SimpleButton();
            this.Grid = new DevExpress.XtraGrid.GridControl();
            this.WorkOrderGrid = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PPEId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.WorkOrderId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RequestedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RequestedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EmployeeLookUpRepo = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.Problem = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.WorkOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OfficeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentProfileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkOrderGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeLookUpRepo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnNewPO);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(682, 40);
            this.panelControl1.TabIndex = 3;
            // 
            // btnNewPO
            // 
            this.btnNewPO.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNewPO.Appearance.Options.UseFont = true;
            this.btnNewPO.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnNewPO.ImageOptions.Image = global::Win.Properties.Resources.refresh_16x16;
            this.btnNewPO.Location = new System.Drawing.Point(15, 5);
            this.btnNewPO.Name = "btnNewPO";
            this.btnNewPO.Size = new System.Drawing.Size(86, 26);
            this.btnNewPO.TabIndex = 1;
            this.btnNewPO.Text = "Refresh";
            this.btnNewPO.Click += new System.EventHandler(this.btnNewPO_Click);
            // 
            // Grid
            // 
            this.Grid.DataSource = this.WorkOrderBindingSource;
            this.Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid.Location = new System.Drawing.Point(0, 40);
            this.Grid.MainView = this.WorkOrderGrid;
            this.Grid.Name = "Grid";
            this.Grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.EmployeeLookUpRepo});
            this.Grid.Size = new System.Drawing.Size(682, 413);
            this.Grid.TabIndex = 4;
            this.Grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.WorkOrderGrid});
            // 
            // WorkOrderGrid
            // 
            this.WorkOrderGrid.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.PPEId,
            this.WorkOrderId,
            this.RequestedDate,
            this.RequestedBy,
            this.Problem});
            this.WorkOrderGrid.GridControl = this.Grid;
            this.WorkOrderGrid.Name = "WorkOrderGrid";
            this.WorkOrderGrid.NewItemRowText = "New PO";
            this.WorkOrderGrid.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplaceHideCurrentRow;
            this.WorkOrderGrid.OptionsBehavior.ReadOnly = true;
            this.WorkOrderGrid.OptionsEditForm.EditFormColumnCount = 1;
            this.WorkOrderGrid.OptionsNavigation.AutoFocusNewRow = true;
            this.WorkOrderGrid.OptionsView.ShowFooter = true;
            this.WorkOrderGrid.OptionsView.ShowGroupPanel = false;
            // 
            // Id
            // 
            this.Id.Caption = "Id";
            this.Id.FieldName = "Id";
            this.Id.Name = "Id";
            // 
            // PPEId
            // 
            this.PPEId.Caption = "PPEId";
            this.PPEId.FieldName = "PPEId";
            this.PPEId.Name = "PPEId";
            // 
            // WorkOrderId
            // 
            this.WorkOrderId.Caption = "WO ID";
            this.WorkOrderId.FieldName = "WorkOrderId";
            this.WorkOrderId.Name = "WorkOrderId";
            this.WorkOrderId.Visible = true;
            this.WorkOrderId.VisibleIndex = 0;
            // 
            // RequestedDate
            // 
            this.RequestedDate.Caption = "Date/Time";
            this.RequestedDate.FieldName = "RequestedDate";
            this.RequestedDate.Name = "RequestedDate";
            this.RequestedDate.Visible = true;
            this.RequestedDate.VisibleIndex = 1;
            // 
            // RequestedBy
            // 
            this.RequestedBy.Caption = "RequestedBy";
            this.RequestedBy.ColumnEdit = this.EmployeeLookUpRepo;
            this.RequestedBy.FieldName = "RequestedBy";
            this.RequestedBy.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.RequestedBy.Name = "RequestedBy";
            this.RequestedBy.Visible = true;
            this.RequestedBy.VisibleIndex = 2;
            this.RequestedBy.Width = 177;
            // 
            // EmployeeLookUpRepo
            // 
            this.EmployeeLookUpRepo.AutoHeight = false;
            this.EmployeeLookUpRepo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EmployeeLookUpRepo.DataSource = this.EmployeeBindingSource;
            this.EmployeeLookUpRepo.DisplayMember = "EmployeeName";
            this.EmployeeLookUpRepo.Name = "EmployeeLookUpRepo";
            this.EmployeeLookUpRepo.ValueMember = "Id";
            // 
            // Problem
            // 
            this.Problem.Caption = "Problem";
            this.Problem.FieldName = "Problem";
            this.Problem.Name = "Problem";
            this.Problem.Visible = true;
            this.Problem.VisibleIndex = 3;
            // 
            // ucDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.panelControl1);
            this.Name = "ucDashboard";
            this.Size = new System.Drawing.Size(682, 453);
            ((System.ComponentModel.ISupportInitialize)(this.WorkOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OfficeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentProfileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkOrderGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeLookUpRepo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource WorkOrderBindingSource;
        private System.Windows.Forms.BindingSource OfficeBindingSource;
        private System.Windows.Forms.BindingSource EmployeeBindingSource;
        private System.Windows.Forms.BindingSource EquipmentProfileBindingSource;
        private System.Windows.Forms.BindingSource EquipmentTypeBindingSource;
        private System.Windows.Forms.BindingSource UnitTypeBindingSource;
        private System.Windows.Forms.BindingSource ActionBindingSource;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl Grid;
        private DevExpress.XtraGrid.Views.Grid.GridView WorkOrderGrid;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn PPEId;
        private DevExpress.XtraGrid.Columns.GridColumn WorkOrderId;
        private DevExpress.XtraGrid.Columns.GridColumn RequestedDate;
        private DevExpress.XtraGrid.Columns.GridColumn RequestedBy;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit EmployeeLookUpRepo;
        private DevExpress.XtraGrid.Columns.GridColumn Problem;
        private DevExpress.XtraEditors.SimpleButton btnNewPO;
    }
}
