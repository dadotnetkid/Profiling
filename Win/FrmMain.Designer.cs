namespace Win
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.backstageViewControl1 = new DevExpress.XtraBars.Ribbon.BackstageViewControl();
            this.backstageViewClientControl1 = new DevExpress.XtraBars.Ribbon.BackstageViewClientControl();
            this.backstageViewTabItem1 = new DevExpress.XtraBars.Ribbon.BackstageViewTabItem();
            this.btnDashboard = new DevExpress.XtraBars.BarButtonItem();
            this.barOffices = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.btnDeliveries = new DevExpress.XtraBars.BarButtonItem();
            this.btnSupplier = new DevExpress.XtraBars.BarButtonItem();
            this.btnEmployees = new DevExpress.XtraBars.BarButtonItem();
            this.btnPPe = new DevExpress.XtraBars.BarButtonItem();
            this.btnWO = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.lblUser = new DevExpress.XtraBars.BarHeaderItem();
            this.btnTechSpec = new DevExpress.XtraBars.BarButtonItem();
            this.btnMes = new DevExpress.XtraBars.BarButtonItem();
            this.btnDocActionTreeList = new DevExpress.XtraBars.BarButtonItem();
            this.btnStatus = new DevExpress.XtraBars.BarButtonItem();
            this.btnActions = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbFilemanagements = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemHypertextLabel1 = new DevExpress.XtraEditors.Repository.RepositoryItemHypertextLabel();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.pnlDashoard = new DevExpress.XtraEditors.PanelControl();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblTime = new DevExpress.XtraBars.BarHeaderItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backstageViewControl1)).BeginInit();
            this.backstageViewControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHypertextLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDashoard)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ApplicationButtonDropDownControl = this.backstageViewControl1;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnDashboard,
            this.barOffices,
            this.barButtonItem5,
            this.barButtonItem6,
            this.btnDeliveries,
            this.btnSupplier,
            this.btnEmployees,
            this.btnPPe,
            this.btnWO,
            this.barButtonItem10,
            this.lblUser,
            this.btnTechSpec,
            this.btnMes,
            this.btnDocActionTreeList,
            this.btnStatus,
            this.btnActions,
            this.lblTime});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 25;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage3,
            this.ribbonPage2});
            this.ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemHypertextLabel1});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2019;
            this.ribbon.Size = new System.Drawing.Size(924, 146);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // backstageViewControl1
            // 
            this.backstageViewControl1.Controls.Add(this.backstageViewClientControl1);
            this.backstageViewControl1.Items.Add(this.backstageViewTabItem1);
            this.backstageViewControl1.Location = new System.Drawing.Point(71, 214);
            this.backstageViewControl1.Name = "backstageViewControl1";
            this.backstageViewControl1.OwnerControl = this.ribbon;
            this.backstageViewControl1.SelectedTab = this.backstageViewTabItem1;
            this.backstageViewControl1.SelectedTabIndex = 0;
            this.backstageViewControl1.Size = new System.Drawing.Size(480, 150);
            this.backstageViewControl1.TabIndex = 2;
            // 
            // backstageViewClientControl1
            // 
            this.backstageViewClientControl1.Location = new System.Drawing.Point(151, 62);
            this.backstageViewClientControl1.Name = "backstageViewClientControl1";
            this.backstageViewClientControl1.Size = new System.Drawing.Size(329, 88);
            this.backstageViewClientControl1.TabIndex = 1;
            // 
            // backstageViewTabItem1
            // 
            this.backstageViewTabItem1.Caption = "Logout";
            this.backstageViewTabItem1.ContentControl = this.backstageViewClientControl1;
            this.backstageViewTabItem1.ImageOptions.ItemNormal.Image = ((System.Drawing.Image)(resources.GetObject("backstageViewTabItem1.ImageOptions.ItemNormal.Image")));
            this.backstageViewTabItem1.Name = "backstageViewTabItem1";
            this.backstageViewTabItem1.Selected = true;
            this.backstageViewTabItem1.SelectedChanged += new DevExpress.XtraBars.Ribbon.BackstageViewItemEventHandler(this.backstageViewTabItem1_SelectedChanged);
            this.backstageViewTabItem1.ItemPressed += new DevExpress.XtraBars.Ribbon.BackstageViewItemEventHandler(this.backstageViewTabItem1_ItemPressed);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Caption = "View Dashboard";
            this.btnDashboard.Id = 1;
            this.btnDashboard.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.ImageOptions.Image")));
            this.btnDashboard.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDashboard.ImageOptions.LargeImage")));
            this.btnDashboard.ItemAppearance.Normal.Options.UseFont = true;
            this.btnDashboard.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // barOffices
            // 
            this.barOffices.Caption = "View Offices";
            this.barOffices.Id = 4;
            this.barOffices.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barOffices.ImageOptions.Image")));
            this.barOffices.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barOffices.ImageOptions.LargeImage")));
            this.barOffices.ItemAppearance.Normal.Options.UseFont = true;
            this.barOffices.Name = "barOffices";
            this.barOffices.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barOffices.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barOffices_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "View Users";
            this.barButtonItem5.Id = 6;
            this.barButtonItem5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.Image")));
            this.barButtonItem5.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.LargeImage")));
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barButtonItem5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "View User Levels";
            this.barButtonItem6.Id = 7;
            this.barButtonItem6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.Image")));
            this.barButtonItem6.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.LargeImage")));
            this.barButtonItem6.Name = "barButtonItem6";
            this.barButtonItem6.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barButtonItem6.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem6_ItemClick);
            // 
            // btnDeliveries
            // 
            this.btnDeliveries.Caption = "Deliveries";
            this.btnDeliveries.Id = 8;
            this.btnDeliveries.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDeliveries.ImageOptions.Image")));
            this.btnDeliveries.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDeliveries.ImageOptions.LargeImage")));
            this.btnDeliveries.Name = "btnDeliveries";
            this.btnDeliveries.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnDeliveries.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDeliveries_ItemClick);
            // 
            // btnSupplier
            // 
            this.btnSupplier.Caption = "Suppliers";
            this.btnSupplier.Id = 10;
            this.btnSupplier.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSupplier.ImageOptions.Image")));
            this.btnSupplier.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSupplier.ImageOptions.LargeImage")));
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnSupplier.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick_1);
            // 
            // btnEmployees
            // 
            this.btnEmployees.Caption = "Employees";
            this.btnEmployees.Id = 11;
            this.btnEmployees.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployees.ImageOptions.Image")));
            this.btnEmployees.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnEmployees.ImageOptions.LargeImage")));
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnEmployees.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick_1);
            // 
            // btnPPe
            // 
            this.btnPPe.Caption = "PPE Profiles";
            this.btnPPe.Id = 12;
            this.btnPPe.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPPe.ImageOptions.Image")));
            this.btnPPe.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPPe.ImageOptions.LargeImage")));
            this.btnPPe.Name = "btnPPe";
            this.btnPPe.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnPPe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem8_ItemClick_1);
            // 
            // btnWO
            // 
            this.btnWO.Caption = "Work Order";
            this.btnWO.Id = 13;
            this.btnWO.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnWO.ImageOptions.Image")));
            this.btnWO.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnWO.ImageOptions.LargeImage")));
            this.btnWO.Name = "btnWO";
            this.btnWO.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnWO.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnWO_ItemClick);
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.Caption = "Accomplishment Report";
            this.barButtonItem10.Id = 14;
            this.barButtonItem10.ImageOptions.Image = global::Win.Properties.Resources.report_64;
            this.barButtonItem10.Name = "barButtonItem10";
            this.barButtonItem10.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barButtonItem10.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem10_ItemClick);
            // 
            // lblUser
            // 
            this.lblUser.Caption = "User:";
            this.lblUser.Id = 18;
            this.lblUser.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("lblUser.ImageOptions.Image")));
            this.lblUser.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("lblUser.ImageOptions.LargeImage")));
            this.lblUser.Name = "lblUser";
            // 
            // btnTechSpec
            // 
            this.btnTechSpec.Caption = "Tech Specs";
            this.btnTechSpec.Id = 19;
            this.btnTechSpec.ImageOptions.Image = global::Win.Properties.Resources.technology_16x16;
            this.btnTechSpec.ImageOptions.LargeImage = global::Win.Properties.Resources.technology_32x32;
            this.btnTechSpec.Name = "btnTechSpec";
            this.btnTechSpec.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnTechSpec.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem11_ItemClick);
            // 
            // btnMes
            // 
            this.btnMes.Caption = "MES";
            this.btnMes.Id = 20;
            this.btnMes.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMes.ImageOptions.Image")));
            this.btnMes.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMes.ImageOptions.LargeImage")));
            this.btnMes.Name = "btnMes";
            this.btnMes.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem12_ItemClick);
            // 
            // btnDocActionTreeList
            // 
            this.btnDocActionTreeList.Caption = "Action Tree";
            this.btnDocActionTreeList.Id = 21;
            this.btnDocActionTreeList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDocActionTreeList.ImageOptions.Image")));
            this.btnDocActionTreeList.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDocActionTreeList.ImageOptions.LargeImage")));
            this.btnDocActionTreeList.Name = "btnDocActionTreeList";
            this.btnDocActionTreeList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDocActionTreeList_ItemClick);
            // 
            // btnStatus
            // 
            this.btnStatus.Caption = "Status";
            this.btnStatus.Id = 22;
            this.btnStatus.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnStatus.ImageOptions.Image")));
            this.btnStatus.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnStatus.ImageOptions.LargeImage")));
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnStatus_ItemClick);
            // 
            // btnActions
            // 
            this.btnActions.Caption = "Actions";
            this.btnActions.Id = 23;
            this.btnActions.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnActions.ImageOptions.Image")));
            this.btnActions.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnActions.ImageOptions.LargeImage")));
            this.btnActions.Name = "btnActions";
            this.btnActions.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnActions_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup3,
            this.ribbonPageGroup6});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Dashboard";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDashboard);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Dashboard";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnPPe);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnWO);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnMes);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnDeliveries);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnTechSpec);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "ICT Transaction";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.lblUser);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "User Details";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Reports";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItem10);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "View Reports";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.rbFilemanagements});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Maintenance";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem5);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem6);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Users";
            // 
            // rbFilemanagements
            // 
            this.rbFilemanagements.ItemLinks.Add(this.btnSupplier);
            this.rbFilemanagements.ItemLinks.Add(this.btnEmployees);
            this.rbFilemanagements.ItemLinks.Add(this.barOffices);
            this.rbFilemanagements.ItemLinks.Add(this.btnDocActionTreeList);
            this.rbFilemanagements.ItemLinks.Add(this.btnActions);
            this.rbFilemanagements.ItemLinks.Add(this.btnStatus);
            this.rbFilemanagements.Name = "rbFilemanagements";
            // 
            // repositoryItemHypertextLabel1
            // 
            this.repositoryItemHypertextLabel1.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.repositoryItemHypertextLabel1.Name = "repositoryItemHypertextLabel1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.lblTime);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 428);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(924, 21);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Suppliers";
            this.barButtonItem2.Id = 3;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // pnlDashoard
            // 
            this.pnlDashoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDashoard.Location = new System.Drawing.Point(0, 146);
            this.pnlDashoard.Name = "pnlDashoard";
            this.pnlDashoard.Size = new System.Drawing.Size(924, 282);
            this.pnlDashoard.TabIndex = 4;
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnSupplier);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnEmployees);
            this.ribbonPageGroup4.ItemLinks.Add(this.barOffices);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // lblTime
            // 
            this.lblTime.Caption = "OFMIS: No update available";
            this.lblTime.Id = 24;
            this.lblTime.Name = "lblTime";
            // 
            // FrmMain
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 449);
            this.Controls.Add(this.pnlDashoard);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.backstageViewControl1);
            this.Controls.Add(this.ribbon);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmMain";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "ICT System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backstageViewControl1)).EndInit();
            this.backstageViewControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHypertextLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDashoard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Ribbon.BackstageViewControl backstageViewControl1;
        private DevExpress.XtraBars.Ribbon.BackstageViewClientControl backstageViewClientControl1;
        private DevExpress.XtraBars.Ribbon.BackstageViewTabItem backstageViewTabItem1;
        private DevExpress.XtraBars.BarButtonItem btnDashboard;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barOffices;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem btnDeliveries;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem btnSupplier;
        private DevExpress.XtraBars.BarButtonItem btnEmployees;
        private DevExpress.XtraBars.BarButtonItem btnPPe;
        private DevExpress.XtraBars.BarButtonItem btnWO;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
        private DevExpress.XtraBars.BarHeaderItem lblUser;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraEditors.Repository.RepositoryItemHypertextLabel repositoryItemHypertextLabel1;
        private DevExpress.XtraBars.BarButtonItem btnTechSpec;
        private DevExpress.XtraBars.BarButtonItem btnMes;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbFilemanagements;
        private DevExpress.XtraBars.BarButtonItem btnDocActionTreeList;
        private DevExpress.XtraBars.BarButtonItem btnStatus;
        private DevExpress.XtraBars.BarButtonItem btnActions;
        public DevExpress.XtraEditors.PanelControl pnlDashoard;
        private DevExpress.XtraBars.BarHeaderItem lblTime;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}