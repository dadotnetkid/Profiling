namespace Win.WO
{
    partial class frmTechnicalEvalSheet
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
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EvaluationSheetId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EvaluationLookUpRepo = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.Value = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EvaluationLookUpRepo)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = global::Win.Properties.Resources.apply_16x16;
            this.simpleButton1.Location = new System.Drawing.Point(615, 239);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Submit";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(13, 13);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.EvaluationLookUpRepo});
            this.gridControl1.Size = new System.Drawing.Size(677, 220);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.EvaluationSheetId,
            this.Value});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.Inplace;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            // 
            // Id
            // 
            this.Id.Caption = "Id";
            this.Id.FieldName = "Id";
            this.Id.Name = "Id";
            // 
            // EvaluationSheetId
            // 
            this.EvaluationSheetId.Caption = "Evaluation";
            this.EvaluationSheetId.ColumnEdit = this.EvaluationLookUpRepo;
            this.EvaluationSheetId.FieldName = "EvaluationSheetId";
            this.EvaluationSheetId.Name = "EvaluationSheetId";
            this.EvaluationSheetId.OptionsColumn.AllowEdit = false;
            this.EvaluationSheetId.OptionsColumn.ReadOnly = true;
            this.EvaluationSheetId.Visible = true;
            this.EvaluationSheetId.VisibleIndex = 0;
            this.EvaluationSheetId.Width = 539;
            // 
            // EvaluationLookUpRepo
            // 
            this.EvaluationLookUpRepo.AutoHeight = false;
            this.EvaluationLookUpRepo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EvaluationLookUpRepo.DisplayMember = "Evaluation";
            this.EvaluationLookUpRepo.Name = "EvaluationLookUpRepo";
            this.EvaluationLookUpRepo.ValueMember = "Id";
            // 
            // Value
            // 
            this.Value.Caption = "Value";
            this.Value.FieldName = "Value";
            this.Value.Name = "Value";
            this.Value.Visible = true;
            this.Value.VisibleIndex = 1;
            // 
            // frmTechnicalEvalSheet
            // 
            this.Appearance.Image = global::Win.Properties.Resources.converttorange_16x16;
            this.Appearance.Options.UseImage = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 271);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.simpleButton1);
            this.Name = "frmTechnicalEvalSheet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Technical Evaluation Sheet";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTechnicalEvalSheet_FormClosing);
            this.Load += new System.EventHandler(this.frmTechnicalEvalSheet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EvaluationLookUpRepo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn EvaluationSheetId;
        private DevExpress.XtraGrid.Columns.GridColumn Value;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit EvaluationLookUpRepo;
    }
}