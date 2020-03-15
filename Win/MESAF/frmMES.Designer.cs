
namespace Win.MESAF
{
    partial class frmMES
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
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.ucMES1 = new Win.MESAF.ucMES();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnScan = new DevExpress.XtraEditors.SimpleButton();
            this.btnAction = new DevExpress.XtraEditors.SimpleButton();
            this.lblMesDescription = new DevExpress.XtraEditors.LabelControl();
            this.btnEditPo = new DevExpress.XtraEditors.SimpleButton();
            this.btnNewPO = new DevExpress.XtraEditors.SimpleButton();
            this.ucActionGrid1 = new Win.DocAct.ucActionGrid();
            this.txtPosition = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtEmployee = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtOffice = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dtDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtItemSpec = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtRequest = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPosition.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmployee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOffice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemSpec.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRequest.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.HiddenPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel1});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl",
            "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl"});
            // 
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel1.ID = new System.Guid("ca6941ad-127d-4c68-ae0a-94c9a70c4af7");
            this.dockPanel1.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanel1.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel1.SavedIndex = 0;
            this.dockPanel1.Size = new System.Drawing.Size(200, 534);
            this.dockPanel1.Text = "dockPanel1";
            this.dockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 40);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(191, 490);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // ucMES1
            // 
            this.ucMES1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ucMES1.Location = new System.Drawing.Point(0, 0);
            this.ucMES1.Name = "ucMES1";
            this.ucMES1.Size = new System.Drawing.Size(286, 401);
            this.ucMES1.TabIndex = 1;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.btnPrint);
            this.panelControl3.Controls.Add(this.btnScan);
            this.panelControl3.Controls.Add(this.btnAction);
            this.panelControl3.Controls.Add(this.lblMesDescription);
            this.panelControl3.Controls.Add(this.btnEditPo);
            this.panelControl3.Controls.Add(this.btnNewPO);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(286, 0);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(716, 78);
            this.panelControl3.TabIndex = 5;
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
            // lblMesDescription
            // 
            this.lblMesDescription.Appearance.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lblMesDescription.Appearance.Options.UseFont = true;
            this.lblMesDescription.Location = new System.Drawing.Point(13, 6);
            this.lblMesDescription.Name = "lblMesDescription";
            this.lblMesDescription.Size = new System.Drawing.Size(48, 30);
            this.lblMesDescription.TabIndex = 2;
            this.lblMesDescription.Text = "------";
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
            this.btnEditPo.Text = "Edit MES";
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
            this.btnNewPO.Text = "New MES";
            this.btnNewPO.Click += new System.EventHandler(this.btnNewPO_Click);
            // 
            // ucActionGrid1
            // 
            this.ucActionGrid1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucActionGrid1.Location = new System.Drawing.Point(286, 198);
            this.ucActionGrid1.Name = "ucActionGrid1";
            this.ucActionGrid1.Size = new System.Drawing.Size(716, 203);
            this.ucActionGrid1.TabIndex = 6;
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(349, 156);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPosition.Properties.Appearance.Options.UseFont = true;
            this.txtPosition.Properties.ReadOnly = true;
            this.txtPosition.Properties.UseReadOnlyAppearance = false;
            this.txtPosition.Size = new System.Drawing.Size(271, 24);
            this.txtPosition.TabIndex = 15;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(296, 159);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(46, 17);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "Position";
            // 
            // txtEmployee
            // 
            this.txtEmployee.Location = new System.Drawing.Point(349, 132);
            this.txtEmployee.Name = "txtEmployee";
            this.txtEmployee.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmployee.Properties.Appearance.Options.UseFont = true;
            this.txtEmployee.Size = new System.Drawing.Size(271, 24);
            this.txtEmployee.TabIndex = 16;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(296, 135);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(35, 17);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "Name";
            // 
            // txtOffice
            // 
            this.txtOffice.Location = new System.Drawing.Point(349, 108);
            this.txtOffice.Name = "txtOffice";
            this.txtOffice.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtOffice.Properties.Appearance.Options.UseFont = true;
            this.txtOffice.Properties.ReadOnly = true;
            this.txtOffice.Properties.UseReadOnlyAppearance = false;
            this.txtOffice.Size = new System.Drawing.Size(271, 24);
            this.txtOffice.TabIndex = 17;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(296, 111);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(34, 17);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "Office";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(296, 87);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(30, 17);
            this.labelControl1.TabIndex = 14;
            this.labelControl1.Text = "Date:";
            // 
            // dtDate
            // 
            this.dtDate.EditValue = null;
            this.dtDate.Location = new System.Drawing.Point(349, 84);
            this.dtDate.Name = "dtDate";
            this.dtDate.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtDate.Properties.Appearance.Options.UseFont = true;
            this.dtDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDate.Properties.ReadOnly = true;
            this.dtDate.Properties.UseReadOnlyAppearance = false;
            this.dtDate.Size = new System.Drawing.Size(271, 24);
            this.dtDate.TabIndex = 10;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(653, 84);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(60, 17);
            this.labelControl5.TabIndex = 11;
            this.labelControl5.Text = "Item Spec:";
            // 
            // txtItemSpec
            // 
            this.txtItemSpec.Location = new System.Drawing.Point(719, 84);
            this.txtItemSpec.Name = "txtItemSpec";
            this.txtItemSpec.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtItemSpec.Properties.Appearance.Options.UseFont = true;
            this.txtItemSpec.Properties.ReadOnly = true;
            this.txtItemSpec.Properties.UseReadOnlyAppearance = false;
            this.txtItemSpec.Size = new System.Drawing.Size(271, 24);
            this.txtItemSpec.TabIndex = 15;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(653, 108);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(47, 17);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Request";
            // 
            // txtRequest
            // 
            this.txtRequest.Location = new System.Drawing.Point(719, 108);
            this.txtRequest.Name = "txtRequest";
            this.txtRequest.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtRequest.Properties.Appearance.Options.UseFont = true;
            this.txtRequest.Properties.ReadOnly = true;
            this.txtRequest.Properties.UseReadOnlyAppearance = false;
            this.txtRequest.Size = new System.Drawing.Size(271, 84);
            this.txtRequest.TabIndex = 15;
            // 
            // frmMES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 401);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtItemSpec);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtEmployee);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtOffice);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.ucActionGrid1);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.ucMES1);
            this.Controls.Add(this.txtRequest);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
            this.Name = "frmMES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mobile/External Storage";
            this.Load += new System.EventHandler(this.frmMES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPosition.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmployee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOffice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemSpec.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRequest.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private ucMES ucMES1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.SimpleButton btnScan;
        private DevExpress.XtraEditors.SimpleButton btnAction;
        private DevExpress.XtraEditors.LabelControl lblMesDescription;
        private DevExpress.XtraEditors.SimpleButton btnEditPo;
        private DevExpress.XtraEditors.SimpleButton btnNewPO;
        private DocAct.ucActionGrid ucActionGrid1;
        private DevExpress.XtraEditors.TextEdit txtPosition;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtEmployee;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtOffice;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dtDate;
        private DevExpress.XtraEditors.TextEdit txtItemSpec;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.MemoEdit txtRequest;
    }
}