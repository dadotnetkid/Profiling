namespace Win.PO
{
    partial class frmPurchaseOrders
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
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tabPane2 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.btnAction = new DevExpress.XtraEditors.SimpleButton();
            this.lblPODescription = new DevExpress.XtraEditors.LabelControl();
            this.btnEditPo = new DevExpress.XtraEditors.SimpleButton();
            this.btnNewPO = new DevExpress.XtraEditors.SimpleButton();
            this.btnScan = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.ucPOEquipmentProfile1 = new Win.PO.ucPOEquipmentProfile();
            this.UcPODetails = new Win.PO.ucPODetails();
            this.UcPOGrid = new Win.PO.ucPOGrid();
            this.UcActionGrid = new Win.DocAct.ucActionGrid();
            this.tabNavigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane2)).BeginInit();
            this.tabPane2.SuspendLayout();
            this.tabNavigationPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "Details";
            this.tabNavigationPage1.Controls.Add(this.ucPOEquipmentProfile1);
            this.tabNavigationPage1.Controls.Add(this.UcPODetails);
            this.tabNavigationPage1.Controls.Add(this.tabPane2);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(852, 575);
            // 
            // tabPane2
            // 
            this.tabPane2.Controls.Add(this.tabNavigationPage2);
            this.tabPane2.Location = new System.Drawing.Point(8, 400);
            this.tabPane2.Name = "tabPane2";
            this.tabPane2.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage2});
            this.tabPane2.RegularSize = new System.Drawing.Size(835, 165);
            this.tabPane2.SelectedPage = this.tabNavigationPage2;
            this.tabPane2.Size = new System.Drawing.Size(835, 165);
            this.tabPane2.TabIndex = 17;
            this.tabPane2.Text = "tabPane2";
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Appearance.Options.UseFont = true;
            this.tabNavigationPage2.Appearance.Options.UseTextOptions = true;
            this.tabNavigationPage2.Caption = "tabNavigationPage2";
            this.tabNavigationPage2.Controls.Add(this.UcActionGrid);
            this.tabNavigationPage2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.PageText = "Action Taken";
            this.tabNavigationPage2.Size = new System.Drawing.Size(835, 138);
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tabPane1.Location = new System.Drawing.Point(2, 2);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1});
            this.tabPane1.RegularSize = new System.Drawing.Size(852, 602);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            this.tabPane1.Size = new System.Drawing.Size(852, 602);
            this.tabPane1.TabIndex = 0;
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.tabPane1);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl4.Location = new System.Drawing.Point(389, 78);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(856, 606);
            this.panelControl4.TabIndex = 6;
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
            this.lblPODescription.Location = new System.Drawing.Point(8, 2);
            this.lblPODescription.Name = "lblPODescription";
            this.lblPODescription.Size = new System.Drawing.Size(80, 30);
            this.lblPODescription.TabIndex = 2;
            this.lblPODescription.Text = "PO-0001";
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
            this.btnEditPo.Text = "Edit Profile";
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
            this.btnNewPO.Text = "New Profile";
            this.btnNewPO.Click += new System.EventHandler(this.btnNewPO_Click);
            // 
            // btnScan
            // 
            this.btnScan.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnScan.Appearance.Options.UseFont = true;
            this.btnScan.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnScan.ImageOptions.Image = global::Win.Properties.Resources.search_20;
            this.btnScan.Location = new System.Drawing.Point(299, 46);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(75, 26);
            this.btnScan.TabIndex = 3;
            this.btnScan.Text = "Scan";
            this.btnScan.Visible = false;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.btnScan);
            this.panelControl3.Controls.Add(this.btnAction);
            this.panelControl3.Controls.Add(this.lblPODescription);
            this.panelControl3.Controls.Add(this.btnEditPo);
            this.panelControl3.Controls.Add(this.btnNewPO);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(389, 0);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(856, 78);
            this.panelControl3.TabIndex = 5;
            // 
            // panelControl1
            // 
            this.panelControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelControl1.Controls.Add(this.UcPOGrid);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(389, 684);
            this.panelControl1.TabIndex = 4;
            // 
            // ucPOEquipmentProfile1
            // 
            this.ucPOEquipmentProfile1.Location = new System.Drawing.Point(8, 225);
            this.ucPOEquipmentProfile1.Name = "ucPOEquipmentProfile1";
            this.ucPOEquipmentProfile1.Size = new System.Drawing.Size(834, 161);
            this.ucPOEquipmentProfile1.TabIndex = 19;
            // 
            // UcPODetails
            // 
            this.UcPODetails.Location = new System.Drawing.Point(5, 3);
            this.UcPODetails.Name = "UcPODetails";
            this.UcPODetails.PoId = 0;
            this.UcPODetails.Size = new System.Drawing.Size(844, 216);
            this.UcPODetails.TabIndex = 18;
            // 
            // UcPOGrid
            // 
            this.UcPOGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UcPOGrid.Location = new System.Drawing.Point(2, 2);
            this.UcPOGrid.Name = "UcPOGrid";
            this.UcPOGrid.Size = new System.Drawing.Size(385, 680);
            this.UcPOGrid.TabIndex = 0;
            // 
            // UcActionGrid
            // 
            this.UcActionGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UcActionGrid.Location = new System.Drawing.Point(0, 0);
            this.UcActionGrid.Name = "UcActionGrid";
            this.UcActionGrid.Size = new System.Drawing.Size(835, 138);
            this.UcActionGrid.TabIndex = 0;
            // 
            // frmPurchaseOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 684);
            this.Controls.Add(this.panelControl4);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmPurchaseOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase Orders";
            this.Load += new System.EventHandler(this.frmPurchaseOrders_Load);
            this.tabNavigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane2)).EndInit();
            this.tabPane2.ResumeLayout(false);
            this.tabNavigationPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.SimpleButton btnAction;
        private DevExpress.XtraEditors.LabelControl lblPODescription;
        private DevExpress.XtraEditors.SimpleButton btnEditPo;
        private DevExpress.XtraEditors.SimpleButton btnNewPO;
        private DevExpress.XtraEditors.SimpleButton btnScan;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraBars.Navigation.TabPane tabPane2;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private ucPOGrid UcPOGrid;
        private ucPODetails UcPODetails;
        private ucPOEquipmentProfile ucPOEquipmentProfile1;
        private DocAct.ucActionGrid UcActionGrid;
    }
}