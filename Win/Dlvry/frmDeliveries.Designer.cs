namespace Win.Dlvry
{
    partial class frmDeliveries
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
            this.UnitTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EquipmentTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EquipmentProfileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TechSpecBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OfficeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EmployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DropdownBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchTimer = new System.Windows.Forms.Timer(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.UcTechSpecGrid = new Win.Dlvry.UcDeliveryGrid();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.TechSpecDetails = new Win.Dlvry.ucDeliveryDetails();
            this.tabPane2 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage3 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.ucTSEquipmentProfiles1 = new Win.Dlvry.UcDelEquipmentProfiles();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.UcActionGrid = new Win.DocAct.ucActionGrid();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.gridControl3 = new DevExpress.XtraGrid.GridControl();
            this.DocumentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DocumentGrid = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFileId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFileView = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnFileView = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colFileDownload = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnFileDownload = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colFileDateCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFileCreatedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFilesize = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AssignedToBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TechSpecsRequestDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ActionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnScan = new DevExpress.XtraEditors.SimpleButton();
            this.btnAction = new DevExpress.XtraEditors.SimpleButton();
            this.lblPODescription = new DevExpress.XtraEditors.LabelControl();
            this.btnEditPo = new DevExpress.XtraEditors.SimpleButton();
            this.btnNewPO = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.UnitTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentProfileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TechSpecBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OfficeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DropdownBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane2)).BeginInit();
            this.tabPane2.SuspendLayout();
            this.tabNavigationPage3.SuspendLayout();
            this.tabNavigationPage2.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DocumentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DocumentGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFileView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFileDownload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssignedToBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TechSpecsRequestDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchTimer
            // 
            this.searchTimer.Interval = 3000;
            // 
            // panelControl1
            // 
            this.panelControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelControl1.Controls.Add(this.UcTechSpecGrid);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(355, 582);
            this.panelControl1.TabIndex = 2;
            // 
            // UcTechSpecGrid
            // 
            this.UcTechSpecGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UcTechSpecGrid.Location = new System.Drawing.Point(2, 2);
            this.UcTechSpecGrid.Name = "UcTechSpecGrid";
            this.UcTechSpecGrid.Size = new System.Drawing.Size(351, 578);
            this.UcTechSpecGrid.TabIndex = 0;
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.TechSpecDetails);
            this.panelControl4.Controls.Add(this.tabPane2);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl4.Location = new System.Drawing.Point(355, 78);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(842, 504);
            this.panelControl4.TabIndex = 5;
            // 
            // TechSpecDetails
            // 
            this.TechSpecDetails.Location = new System.Drawing.Point(8, 6);
            this.TechSpecDetails.Name = "TechSpecDetails";
            this.TechSpecDetails.Size = new System.Drawing.Size(822, 206);
            this.TechSpecDetails.TabIndex = 22;
            // 
            // tabPane2
            // 
            this.tabPane2.Controls.Add(this.tabNavigationPage3);
            this.tabPane2.Controls.Add(this.tabNavigationPage2);
            this.tabPane2.Controls.Add(this.tabNavigationPage1);
            this.tabPane2.Location = new System.Drawing.Point(13, 218);
            this.tabPane2.Name = "tabPane2";
            this.tabPane2.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage3,
            this.tabNavigationPage2,
            this.tabNavigationPage1});
            this.tabPane2.RegularSize = new System.Drawing.Size(814, 270);
            this.tabPane2.SelectedPage = this.tabNavigationPage3;
            this.tabPane2.Size = new System.Drawing.Size(814, 270);
            this.tabPane2.TabIndex = 21;
            this.tabPane2.Text = "tabPane2";
            // 
            // tabNavigationPage3
            // 
            this.tabNavigationPage3.Caption = "tabNavigationPage3";
            this.tabNavigationPage3.Controls.Add(this.ucTSEquipmentProfiles1);
            this.tabNavigationPage3.Name = "tabNavigationPage3";
            this.tabNavigationPage3.PageText = "Details";
            this.tabNavigationPage3.Size = new System.Drawing.Size(814, 243);
            // 
            // ucTSEquipmentProfiles1
            // 
            this.ucTSEquipmentProfiles1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTSEquipmentProfiles1.Location = new System.Drawing.Point(0, 0);
            this.ucTSEquipmentProfiles1.Name = "ucTSEquipmentProfiles1";
            this.ucTSEquipmentProfiles1.Size = new System.Drawing.Size(814, 243);
            this.ucTSEquipmentProfiles1.TabIndex = 0;
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Caption = "Action";
            this.tabNavigationPage2.Controls.Add(this.UcActionGrid);
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Size = new System.Drawing.Size(814, 243);
            // 
            // UcActionGrid
            // 
            this.UcActionGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UcActionGrid.Location = new System.Drawing.Point(0, 0);
            this.UcActionGrid.Name = "UcActionGrid";
            this.UcActionGrid.Size = new System.Drawing.Size(814, 243);
            this.UcActionGrid.TabIndex = 0;
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "Scanned/Uploaded";
            this.tabNavigationPage1.Controls.Add(this.gridControl3);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(814, 243);
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
            this.gridControl3.Size = new System.Drawing.Size(814, 243);
            this.gridControl3.TabIndex = 2;
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
            this.btnFileView.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnFileView_ButtonClick);
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
            this.btnFileDownload.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnFileDownload_ButtonClick);
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
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.btnPrint);
            this.panelControl3.Controls.Add(this.btnScan);
            this.panelControl3.Controls.Add(this.btnAction);
            this.panelControl3.Controls.Add(this.lblPODescription);
            this.panelControl3.Controls.Add(this.btnEditPo);
            this.panelControl3.Controls.Add(this.btnNewPO);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(355, 0);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(842, 78);
            this.panelControl3.TabIndex = 4;
            // 
            // btnPrint
            // 
            this.btnPrint.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPrint.Appearance.Options.UseFont = true;
            this.btnPrint.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnPrint.ImageOptions.Image = global::Win.Properties.Resources.printer_16x16;
            this.btnPrint.Location = new System.Drawing.Point(299, 46);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 26);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnScan
            // 
            this.btnScan.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnScan.Appearance.Options.UseFont = true;
            this.btnScan.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnScan.ImageOptions.Image = global::Win.Properties.Resources.search_20;
            this.btnScan.Location = new System.Drawing.Point(380, 46);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(75, 26);
            this.btnScan.TabIndex = 3;
            this.btnScan.Text = "Scan";
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // btnAction
            // 
            this.btnAction.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAction.Appearance.Options.UseFont = true;
            this.btnAction.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnAction.ImageOptions.Image = global::Win.Properties.Resources.action_16;
            this.btnAction.Location = new System.Drawing.Point(218, 46);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(75, 26);
            this.btnAction.TabIndex = 3;
            this.btnAction.Text = "Action";
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // lblPODescription
            // 
            this.lblPODescription.Appearance.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lblPODescription.Appearance.Options.UseFont = true;
            this.lblPODescription.Location = new System.Drawing.Point(13, 6);
            this.lblPODescription.Name = "lblPODescription";
            this.lblPODescription.Size = new System.Drawing.Size(0, 30);
            this.lblPODescription.TabIndex = 2;
            // 
            // btnEditPo
            // 
            this.btnEditPo.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnEditPo.Appearance.Options.UseFont = true;
            this.btnEditPo.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnEditPo.ImageOptions.Image = global::Win.Properties.Resources.edit_16;
            this.btnEditPo.Location = new System.Drawing.Point(113, 46);
            this.btnEditPo.Name = "btnEditPo";
            this.btnEditPo.Size = new System.Drawing.Size(99, 26);
            this.btnEditPo.TabIndex = 1;
            this.btnEditPo.Text = "Edit TS";
            this.btnEditPo.Click += new System.EventHandler(this.btnEditPo_Click);
            // 
            // btnNewPO
            // 
            this.btnNewPO.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNewPO.Appearance.Options.UseFont = true;
            this.btnNewPO.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnNewPO.ImageOptions.Image = global::Win.Properties.Resources.add_16;
            this.btnNewPO.Location = new System.Drawing.Point(8, 46);
            this.btnNewPO.Name = "btnNewPO";
            this.btnNewPO.Size = new System.Drawing.Size(99, 26);
            this.btnNewPO.TabIndex = 0;
            this.btnNewPO.Text = "New TS";
            this.btnNewPO.Click += new System.EventHandler(this.btnNewPO_Click);
            // 
            // frmDeliveries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 582);
            this.Controls.Add(this.panelControl4);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl1);
            this.MaximumSize = new System.Drawing.Size(1199, 614);
            this.Name = "frmDeliveries";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deliveries";
            this.Load += new System.EventHandler(this.frmTechSpecs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UnitTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentProfileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TechSpecBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OfficeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DropdownBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane2)).EndInit();
            this.tabPane2.ResumeLayout(false);
            this.tabNavigationPage3.ResumeLayout(false);
            this.tabNavigationPage2.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DocumentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DocumentGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFileView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFileDownload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssignedToBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TechSpecsRequestDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource UnitTypeBindingSource;
        private System.Windows.Forms.BindingSource EquipmentTypeBindingSource;
        private System.Windows.Forms.BindingSource EquipmentProfileBindingSource;
        private System.Windows.Forms.BindingSource TechSpecBindingSource;
        private System.Windows.Forms.BindingSource OfficeBindingSource;
        private System.Windows.Forms.BindingSource EmployeeBindingSource;
        private System.Windows.Forms.BindingSource DropdownBindingSource;
        private System.Windows.Forms.Timer searchTimer;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraBars.Navigation.TabPane tabPane2;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage3;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton btnScan;
        private DevExpress.XtraEditors.SimpleButton btnAction;
        private DevExpress.XtraEditors.LabelControl lblPODescription;
        private DevExpress.XtraEditors.SimpleButton btnEditPo;
        private DevExpress.XtraEditors.SimpleButton btnNewPO;
        private System.Windows.Forms.BindingSource AssignedToBindingSource;
        private System.Windows.Forms.BindingSource ActionBindingSource;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private System.Windows.Forms.BindingSource TechSpecsRequestDetailBindingSource;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraGrid.GridControl gridControl3;
        private DevExpress.XtraGrid.Views.Grid.GridView DocumentGrid;
        private DevExpress.XtraGrid.Columns.GridColumn colFileId;
        private DevExpress.XtraGrid.Columns.GridColumn colFileDateCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colFileCreatedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colFilesize;
        private System.Windows.Forms.BindingSource DocumentBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colFileDownload;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnFileDownload;
        private DevExpress.XtraGrid.Columns.GridColumn colFileView;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnFileView;
        private UcDeliveryGrid UcTechSpecGrid;
        private DocAct.ucActionGrid UcActionGrid;
        private ucDeliveryDetails TechSpecDetails;
        private UcDelEquipmentProfiles ucTSEquipmentProfiles1;
    }
}