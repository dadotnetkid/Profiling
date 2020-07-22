namespace Win.PGN
{
    partial class UCPGN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCPGN));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PGNGridControl = new DevExpress.XtraGrid.GridControl();
            this.PGNServerModeSource = new DevExpress.Data.Linq.EntityServerModeSource();
            this.PGNGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colControlNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRequestProblem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBtnDel = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtSearch = new DevExpress.XtraEditors.SearchControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblControl = new DevExpress.XtraEditors.LabelControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textEdit6 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit5 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PGNGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PGNServerModeSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PGNGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colBtnDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PGNGridControl);
            this.panel1.Controls.Add(this.panelControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 733);
            this.panel1.TabIndex = 0;
            // 
            // PGNGridControl
            // 
            this.PGNGridControl.DataSource = this.PGNServerModeSource;
            this.PGNGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PGNGridControl.Location = new System.Drawing.Point(0, 37);
            this.PGNGridControl.MainView = this.PGNGridView;
            this.PGNGridControl.Name = "PGNGridControl";
            this.PGNGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.colBtnDel});
            this.PGNGridControl.Size = new System.Drawing.Size(409, 696);
            this.PGNGridControl.TabIndex = 4;
            this.PGNGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.PGNGridView});
            // 
            // PGNServerModeSource
            // 
            this.PGNServerModeSource.DefaultSorting = "Id ASC";
            this.PGNServerModeSource.ElementType = typeof(Models.PGNs);
            this.PGNServerModeSource.KeyExpression = "Id";
            // 
            // PGNGridView
            // 
            this.PGNGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colControlNo,
            this.colDate,
            this.colRequestProblem});
            this.PGNGridView.GridControl = this.PGNGridControl;
            this.PGNGridView.Name = "PGNGridView";
            this.PGNGridView.OptionsView.ShowGroupPanel = false;
            // 
            // colControlNo
            // 
            this.colControlNo.FieldName = "ControlNo";
            this.colControlNo.Name = "colControlNo";
            this.colControlNo.Visible = true;
            this.colControlNo.VisibleIndex = 0;
            // 
            // colDate
            // 
            this.colDate.FieldName = "Date";
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 1;
            // 
            // colRequestProblem
            // 
            this.colRequestProblem.FieldName = "RequestProblem";
            this.colRequestProblem.Name = "colRequestProblem";
            this.colRequestProblem.Visible = true;
            this.colRequestProblem.VisibleIndex = 2;
            // 
            // colBtnDel
            // 
            this.colBtnDel.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.colBtnDel.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.colBtnDel.Name = "colBtnDel";
            this.colBtnDel.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtSearch);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Padding = new System.Windows.Forms.Padding(2);
            this.panelControl1.Size = new System.Drawing.Size(409, 37);
            this.panelControl1.TabIndex = 2;
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
            this.txtSearch.Size = new System.Drawing.Size(401, 28);
            this.txtSearch.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblControl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(409, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(808, 37);
            this.panel2.TabIndex = 1;
            // 
            // lblControl
            // 
            this.lblControl.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControl.Appearance.Options.UseFont = true;
            this.lblControl.Location = new System.Drawing.Point(7, 7);
            this.lblControl.Name = "lblControl";
            this.lblControl.Size = new System.Drawing.Size(54, 21);
            this.lblControl.TabIndex = 0;
            this.lblControl.Text = "000000";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textEdit6);
            this.panel3.Controls.Add(this.textEdit5);
            this.panel3.Controls.Add(this.textEdit4);
            this.panel3.Controls.Add(this.labelControl6);
            this.panel3.Controls.Add(this.labelControl5);
            this.panel3.Controls.Add(this.textEdit3);
            this.panel3.Controls.Add(this.labelControl4);
            this.panel3.Controls.Add(this.textEdit2);
            this.panel3.Controls.Add(this.labelControl3);
            this.panel3.Controls.Add(this.textEdit1);
            this.panel3.Controls.Add(this.labelControl2);
            this.panel3.Controls.Add(this.labelControl1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(409, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(808, 259);
            this.panel3.TabIndex = 2;
            // 
            // textEdit6
            // 
            this.textEdit6.Location = new System.Drawing.Point(87, 166);
            this.textEdit6.Name = "textEdit6";
            this.textEdit6.Properties.AutoHeight = false;
            this.textEdit6.Size = new System.Drawing.Size(450, 65);
            this.textEdit6.TabIndex = 2;
            // 
            // textEdit5
            // 
            this.textEdit5.Location = new System.Drawing.Point(87, 101);
            this.textEdit5.Name = "textEdit5";
            this.textEdit5.Properties.AutoHeight = false;
            this.textEdit5.Size = new System.Drawing.Size(450, 65);
            this.textEdit5.TabIndex = 2;
            // 
            // textEdit4
            // 
            this.textEdit4.Location = new System.Drawing.Point(87, 81);
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Size = new System.Drawing.Size(450, 20);
            this.textEdit4.TabIndex = 2;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(6, 173);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(67, 13);
            this.labelControl6.TabIndex = 1;
            this.labelControl6.Text = "Action Taken";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(7, 104);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(55, 26);
            this.labelControl5.TabIndex = 1;
            this.labelControl5.Text = "Requested\r\nProblem";
            // 
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(87, 61);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(450, 20);
            this.textEdit3.TabIndex = 2;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(7, 84);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(63, 13);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "Designation";
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(87, 41);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(450, 20);
            this.textEdit2.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(7, 64);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(29, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Name";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(87, 21);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(450, 20);
            this.textEdit1.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(7, 44);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(27, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Date:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(7, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Control No.";
            // 
            // UCPGN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UCPGN";
            this.Size = new System.Drawing.Size(1217, 733);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PGNGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PGNServerModeSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PGNGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colBtnDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl PGNGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView PGNGridView;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit colBtnDel;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SearchControl txtSearch;
        private DevExpress.Data.Linq.EntityServerModeSource PGNServerModeSource;
        private DevExpress.XtraGrid.Columns.GridColumn colControlNo;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colRequestProblem;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.LabelControl lblControl;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textEdit5;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit textEdit6;
        private DevExpress.XtraEditors.LabelControl labelControl6;
    }
}
