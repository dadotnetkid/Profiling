namespace Win.Sup
{
    partial class frmSuppliers
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
            this.Grid = new DevExpress.XtraGrid.GridControl();
            this.SupplierGrid = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SupplierLookUpRepo = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.SupplierName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Address = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierLookUpRepo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid
            // 
            this.Grid.DataSource = this.SupplierBindingSource;
            this.Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid.Location = new System.Drawing.Point(0, 0);
            this.Grid.MainView = this.SupplierGrid;
            this.Grid.Name = "Grid";
            this.Grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.SupplierLookUpRepo});
            this.Grid.Size = new System.Drawing.Size(809, 397);
            this.Grid.TabIndex = 2;
            this.Grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.SupplierGrid});
            // 
            // SupplierGrid
            // 
            this.SupplierGrid.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.SupplierName,
            this.Address});
            this.SupplierGrid.GridControl = this.Grid;
            this.SupplierGrid.Name = "SupplierGrid";
            this.SupplierGrid.NewItemRowText = "NEW SUPPLIER";
            this.SupplierGrid.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplaceHideCurrentRow;
            this.SupplierGrid.OptionsEditForm.EditFormColumnCount = 1;
            this.SupplierGrid.OptionsNavigation.AutoFocusNewRow = true;
            this.SupplierGrid.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.SupplierGrid.OptionsView.ShowFooter = true;
            this.SupplierGrid.AfterPrintRow += new DevExpress.XtraGrid.Views.Base.AfterPrintRowEventHandler(this.b);
            this.SupplierGrid.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.SupplierGrid_RowUpdated);
            // 
            // Id
            // 
            this.Id.Caption = "Id";
            this.Id.FieldName = "Id";
            this.Id.Name = "Id";
            // 
            // SupplierLookUpRepo
            // 
            this.SupplierLookUpRepo.AutoHeight = false;
            this.SupplierLookUpRepo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SupplierLookUpRepo.DisplayMember = "SupplierName";
            this.SupplierLookUpRepo.Name = "SupplierLookUpRepo";
            this.SupplierLookUpRepo.ValueMember = "Id";
            // 
            // SupplierName
            // 
            this.SupplierName.Caption = "Supplier Name";
            this.SupplierName.FieldName = "SupplierName";
            this.SupplierName.Name = "SupplierName";
            this.SupplierName.Visible = true;
            this.SupplierName.VisibleIndex = 0;
            // 
            // Address
            // 
            this.Address.Caption = "Address";
            this.Address.FieldName = "Address";
            this.Address.Name = "Address";
            this.Address.Visible = true;
            this.Address.VisibleIndex = 1;
            // 
            // frmSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 397);
            this.Controls.Add(this.Grid);
            this.Name = "frmSuppliers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Suppliers";
            this.Load += new System.EventHandler(this.frmSuppliers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierLookUpRepo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl Grid;
        private DevExpress.XtraGrid.Views.Grid.GridView SupplierGrid;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit SupplierLookUpRepo;
        private DevExpress.XtraGrid.Columns.GridColumn SupplierName;
        private DevExpress.XtraGrid.Columns.GridColumn Address;
        private System.Windows.Forms.BindingSource SupplierBindingSource;
    }
}