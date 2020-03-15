namespace Win.Usr
{
    partial class frmUsers
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.UserBindingControl = new System.Windows.Forms.BindingSource(this.components);
            this.UserGrid = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MiddleName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.delCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.UserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Position = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Password = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.cboUserRole = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckedComboBoxEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit();
            this.UserRoleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnEditPo = new DevExpress.XtraEditors.SimpleButton();
            this.btnNewPO = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserBindingControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckedComboBoxEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserRoleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.UserBindingControl;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.UserGrid;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1,
            this.repositoryItemCheckedComboBoxEdit1,
            this.repositoryItemTextEdit1});
            this.gridControl1.Size = new System.Drawing.Size(908, 349);
            this.gridControl1.TabIndex = 10;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.UserGrid});
            // 
            // UserGrid
            // 
            this.UserGrid.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.UserGrid.Appearance.Row.Options.UseFont = true;
            this.UserGrid.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.FirstName,
            this.MiddleName,
            this.LastName,
            this.delCol,
            this.UserName,
            this.FullName,
            this.Position,
            this.Password,
            this.cboUserRole});
            this.UserGrid.GridControl = this.gridControl1;
            this.UserGrid.Name = "UserGrid";
            this.UserGrid.NewItemRowText = "New User";
            this.UserGrid.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.UserGrid.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace;
            this.UserGrid.OptionsEditForm.EditFormColumnCount = 2;
            this.UserGrid.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.False;
            this.UserGrid.OptionsNavigation.AutoFocusNewRow = true;
            this.UserGrid.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full;
            this.UserGrid.OptionsView.BestFitUseErrorInfo = DevExpress.Utils.DefaultBoolean.True;
            this.UserGrid.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.UserGrid.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.UserGrid.OptionsView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.UserGrid.OptionsView.ShowGroupPanel = false;
            this.UserGrid.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.UserGrid_RowUpdated);
            // 
            // Id
            // 
            this.Id.Caption = "Id";
            this.Id.FieldName = "Id";
            this.Id.Name = "Id";
            // 
            // FirstName
            // 
            this.FirstName.Caption = "FirstName";
            this.FirstName.FieldName = "FirstName";
            this.FirstName.Name = "FirstName";
            this.FirstName.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.True;
            // 
            // MiddleName
            // 
            this.MiddleName.Caption = "MiddleName";
            this.MiddleName.FieldName = "MiddleName";
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.True;
            // 
            // LastName
            // 
            this.LastName.Caption = "LastName";
            this.LastName.FieldName = "LastName";
            this.LastName.Name = "LastName";
            this.LastName.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.True;
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
            editorButtonImageOptions1.Image = global::Win.Properties.Resources.cancel_16;
            serializableAppearanceObject1.Image = global::Win.Properties.Resources.cancel_16;
            serializableAppearanceObject1.Options.UseImage = true;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEdit1.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEdit1_ButtonPressed);
            // 
            // UserName
            // 
            this.UserName.Caption = "UserName";
            this.UserName.FieldName = "UserName";
            this.UserName.Name = "UserName";
            this.UserName.Visible = true;
            this.UserName.VisibleIndex = 1;
            this.UserName.Width = 82;
            // 
            // FullName
            // 
            this.FullName.Caption = "FullName";
            this.FullName.FieldName = "FullName";
            this.FullName.Name = "FullName";
            this.FullName.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.FullName.Visible = true;
            this.FullName.VisibleIndex = 2;
            this.FullName.Width = 189;
            // 
            // Position
            // 
            this.Position.Caption = "Position";
            this.Position.FieldName = "Position";
            this.Position.Name = "Position";
            this.Position.OptionsEditForm.ColumnSpan = 4;
            this.Position.Visible = true;
            this.Position.VisibleIndex = 3;
            this.Position.Width = 130;
            // 
            // Password
            // 
            this.Password.Caption = "Password";
            this.Password.ColumnEdit = this.repositoryItemTextEdit1;
            this.Password.FieldName = "Password";
            this.Password.Name = "Password";
            this.Password.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.True;
            this.Password.Width = 102;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            this.repositoryItemTextEdit1.UseSystemPasswordChar = true;
            // 
            // cboUserRole
            // 
            this.cboUserRole.Caption = "User Role";
            this.cboUserRole.ColumnEdit = this.repositoryItemCheckedComboBoxEdit1;
            this.cboUserRole.FieldName = "UserRole";
            this.cboUserRole.Name = "cboUserRole";
            this.cboUserRole.Visible = true;
            this.cboUserRole.VisibleIndex = 4;
            // 
            // repositoryItemCheckedComboBoxEdit1
            // 
            this.repositoryItemCheckedComboBoxEdit1.AutoHeight = false;
            this.repositoryItemCheckedComboBoxEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCheckedComboBoxEdit1.DataSource = this.UserRoleBindingSource;
            this.repositoryItemCheckedComboBoxEdit1.DisplayMember = "Name";
            this.repositoryItemCheckedComboBoxEdit1.Name = "repositoryItemCheckedComboBoxEdit1";
            this.repositoryItemCheckedComboBoxEdit1.ValueMember = "Name";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnEditPo);
            this.panelControl1.Controls.Add(this.btnNewPO);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(912, 36);
            this.panelControl1.TabIndex = 11;
            // 
            // btnEditPo
            // 
            this.btnEditPo.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnEditPo.Appearance.Options.UseFont = true;
            this.btnEditPo.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnEditPo.ImageOptions.Image = global::Win.Properties.Resources.edit_16;
            this.btnEditPo.Location = new System.Drawing.Point(110, 5);
            this.btnEditPo.Name = "btnEditPo";
            this.btnEditPo.Size = new System.Drawing.Size(99, 26);
            this.btnEditPo.TabIndex = 3;
            this.btnEditPo.Text = "Edit User";
            this.btnEditPo.Click += new System.EventHandler(this.btnEditPo_Click);
            // 
            // btnNewPO
            // 
            this.btnNewPO.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNewPO.Appearance.Options.UseFont = true;
            this.btnNewPO.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnNewPO.ImageOptions.Image = global::Win.Properties.Resources.add_16;
            this.btnNewPO.Location = new System.Drawing.Point(5, 5);
            this.btnNewPO.Name = "btnNewPO";
            this.btnNewPO.Size = new System.Drawing.Size(99, 26);
            this.btnNewPO.TabIndex = 2;
            this.btnNewPO.Text = "New User";
            this.btnNewPO.Click += new System.EventHandler(this.btnNewPO_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 36);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(912, 353);
            this.panelControl2.TabIndex = 12;
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 389);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users";
            this.Load += new System.EventHandler(this.frmUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserBindingControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckedComboBoxEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserRoleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView UserGrid;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn delCol;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn UserName;
        private DevExpress.XtraGrid.Columns.GridColumn FullName;
        private DevExpress.XtraGrid.Columns.GridColumn Position;
        private DevExpress.XtraGrid.Columns.GridColumn FirstName;
        private DevExpress.XtraGrid.Columns.GridColumn MiddleName;
        private DevExpress.XtraGrid.Columns.GridColumn LastName;
        private DevExpress.XtraGrid.Columns.GridColumn Password;
        private System.Windows.Forms.BindingSource UserBindingControl;
        private System.Windows.Forms.BindingSource UserRoleBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn cboUserRole;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit repositoryItemCheckedComboBoxEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnEditPo;
        private DevExpress.XtraEditors.SimpleButton btnNewPO;
    }
}