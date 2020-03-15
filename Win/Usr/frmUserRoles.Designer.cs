namespace Win.Usr
{
    partial class frmUserRoles
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.UserRoleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UserRoleGrid = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.delCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.UserRole = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Actions = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ActionComboCheckRepo = new DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit();
            this.ActionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserRoleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserRoleGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActionComboCheckRepo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.UserRoleBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.UserRoleGrid;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1,
            this.ActionComboCheckRepo});
            this.gridControl1.Size = new System.Drawing.Size(616, 426);
            this.gridControl1.TabIndex = 11;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.UserRoleGrid});
            // 
            // UserRoleGrid
            // 
            this.UserRoleGrid.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.UserRoleGrid.Appearance.Row.Options.UseFont = true;
            this.UserRoleGrid.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.delCol,
            this.UserRole,
            this.Actions});
            this.UserRoleGrid.GridControl = this.gridControl1;
            this.UserRoleGrid.Name = "UserRoleGrid";
            this.UserRoleGrid.NewItemRowText = "New User";
            this.UserRoleGrid.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.UserRoleGrid.OptionsEditForm.EditFormColumnCount = 2;
            this.UserRoleGrid.OptionsNavigation.AutoFocusNewRow = true;
            this.UserRoleGrid.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full;
            this.UserRoleGrid.OptionsView.BestFitUseErrorInfo = DevExpress.Utils.DefaultBoolean.True;
            this.UserRoleGrid.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.UserRoleGrid.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.UserRoleGrid.OptionsView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.UserRoleGrid.OptionsView.ShowGroupPanel = false;
            this.UserRoleGrid.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.UserRoleGrid_RowUpdated);
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
            this.delCol.Width = 20;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            editorButtonImageOptions2.Image = global::Win.Properties.Resources.cancel_16;
            serializableAppearanceObject5.Image = global::Win.Properties.Resources.cancel_16;
            serializableAppearanceObject5.Options.UseImage = true;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // UserRole
            // 
            this.UserRole.Caption = "UserRole";
            this.UserRole.FieldName = "Name";
            this.UserRole.Name = "UserRole";
            this.UserRole.Visible = true;
            this.UserRole.VisibleIndex = 1;
            this.UserRole.Width = 286;
            // 
            // Actions
            // 
            this.Actions.Caption = "Actions";
            this.Actions.ColumnEdit = this.ActionComboCheckRepo;
            this.Actions.FieldName = "Actions";
            this.Actions.Name = "Actions";
            this.Actions.Visible = true;
            this.Actions.VisibleIndex = 2;
            this.Actions.Width = 289;
            // 
            // ActionComboCheckRepo
            // 
            this.ActionComboCheckRepo.AutoHeight = false;
            this.ActionComboCheckRepo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ActionComboCheckRepo.DataSource = this.ActionsBindingSource;
            this.ActionComboCheckRepo.DisplayMember = "Action";
            this.ActionComboCheckRepo.Name = "ActionComboCheckRepo";
            this.ActionComboCheckRepo.ValueMember = "Action";
            // 
            // frmUserRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 426);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmUserRoles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Roles";
            this.Load += new System.EventHandler(this.frmUserRoles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserRoleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserRoleGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActionComboCheckRepo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActionsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView UserRoleGrid;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn delCol;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn UserRole;
        private DevExpress.XtraGrid.Columns.GridColumn Actions;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit ActionComboCheckRepo;
        private System.Windows.Forms.BindingSource UserRoleBindingSource;
        private System.Windows.Forms.BindingSource ActionsBindingSource;
    }
}