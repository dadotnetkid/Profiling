namespace Win.Xcanner
{
    partial class UcScanners
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
            this.gridControl3 = new DevExpress.XtraGrid.GridControl();
            this.DocumentGrid = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFileId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFileView = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnFileView = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colFileDownload = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnFileDownload = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colFileDateCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFileCreatedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFilesize = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DocumentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DocumentGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFileView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFileDownload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DocumentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl3
            // 
            this.gridControl3.DataSource = this.DocumentBindingSource;
            this.gridControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl3.Location = new System.Drawing.Point(0, 0);
            this.gridControl3.MainView = this.DocumentGrid;
            this.gridControl3.Name = "gridControl3";
            this.gridControl3.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnFileDownload,
            this.btnFileView});
            this.gridControl3.Size = new System.Drawing.Size(591, 181);
            this.gridControl3.TabIndex = 3;
            this.gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.DocumentGrid});
            // 
            // DocumentGrid
            // 
            this.DocumentGrid.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFileId,
            this.colFileView,
            this.colFileDownload,
            this.colFileDateCreated,
            this.colFileCreatedBy,
            this.colFilesize});
            this.DocumentGrid.GridControl = this.gridControl3;
            this.DocumentGrid.Name = "DocumentGrid";
            this.DocumentGrid.NewItemRowText = "New PO";
            this.DocumentGrid.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplaceHideCurrentRow;
            this.DocumentGrid.OptionsBehavior.ReadOnly = true;
            this.DocumentGrid.OptionsEditForm.EditFormColumnCount = 1;
            this.DocumentGrid.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.False;
            this.DocumentGrid.OptionsNavigation.AutoFocusNewRow = true;
            this.DocumentGrid.OptionsView.ShowFooter = true;
            this.DocumentGrid.OptionsView.ShowGroupPanel = false;
            // 
            // colFileId
            // 
            this.colFileId.Caption = "Id";
            this.colFileId.FieldName = "Id";
            this.colFileId.Name = "colFileId";
            this.colFileId.OptionsColumn.ReadOnly = true;
            // 
            // colFileView
            // 
            this.colFileView.ColumnEdit = this.btnFileView;
            this.colFileView.Name = "colFileView";
            this.colFileView.Visible = true;
            this.colFileView.VisibleIndex = 1;
            this.colFileView.Width = 20;
            // 
            // btnFileView
            // 
            this.btnFileView.AutoHeight = false;
            this.btnFileView.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.btnFileView.Name = "btnFileView";
            this.btnFileView.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // colFileDownload
            // 
            this.colFileDownload.ColumnEdit = this.btnFileDownload;
            this.colFileDownload.Name = "colFileDownload";
            this.colFileDownload.Visible = true;
            this.colFileDownload.VisibleIndex = 0;
            this.colFileDownload.Width = 20;
            // 
            // btnFileDownload
            // 
            this.btnFileDownload.AutoHeight = false;
            this.btnFileDownload.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.btnFileDownload.Name = "btnFileDownload";
            this.btnFileDownload.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // colFileDateCreated
            // 
            this.colFileDateCreated.Caption = "Date Created";
            this.colFileDateCreated.DisplayFormat.FormatString = "MM/dd/yy hh:mm:ss tt";
            this.colFileDateCreated.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colFileDateCreated.FieldName = "DateCreated";
            this.colFileDateCreated.Name = "colFileDateCreated";
            this.colFileDateCreated.Visible = true;
            this.colFileDateCreated.VisibleIndex = 2;
            this.colFileDateCreated.Width = 249;
            // 
            // colFileCreatedBy
            // 
            this.colFileCreatedBy.Caption = "Created By";
            this.colFileCreatedBy.FieldName = "CreatedBy";
            this.colFileCreatedBy.Name = "colFileCreatedBy";
            this.colFileCreatedBy.Visible = true;
            this.colFileCreatedBy.VisibleIndex = 3;
            this.colFileCreatedBy.Width = 249;
            // 
            // colFilesize
            // 
            this.colFilesize.Caption = "File Size";
            this.colFilesize.FieldName = "File Size";
            this.colFilesize.Name = "colFilesize";
            this.colFilesize.Visible = true;
            this.colFilesize.VisibleIndex = 4;
            this.colFilesize.Width = 255;
            // 
            // UcScanners
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl3);
            this.Name = "UcScanners";
            this.Size = new System.Drawing.Size(591, 181);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DocumentGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFileView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFileDownload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DocumentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl3;
        private DevExpress.XtraGrid.Views.Grid.GridView DocumentGrid;
        private DevExpress.XtraGrid.Columns.GridColumn colFileId;
        private DevExpress.XtraGrid.Columns.GridColumn colFileView;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnFileView;
        private DevExpress.XtraGrid.Columns.GridColumn colFileDownload;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnFileDownload;
        private DevExpress.XtraGrid.Columns.GridColumn colFileDateCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colFileCreatedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colFilesize;
        private System.Windows.Forms.BindingSource DocumentBindingSource;
    }
}
