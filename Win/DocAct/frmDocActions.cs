using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Helpers;
using Models;
using Models.Repository;
using Win.Properties;

namespace Win.DocAct
{
    public partial class frmDocActions : DevExpress.XtraEditors.XtraForm
    {
        public DocActions DocActions { get; set; }
        private string TableName { get; set; }
        private string Label { get; set; }
        private int RefId { get; set; }

        public frmDocActions(string tableName, string label, int refId)
        {
            InitializeComponent();
            this.Icon = Resources.maintenance.ToIcon();
            this.TableName = tableName;
            this.Label = label;
            this.RefId = refId;

        }

        public frmDocActions(DocActions OldValue, string label, int? refId)
        {
            InitializeComponent();
            this.Icon = Resources.maintenance.ToIcon();
            this.Label = label;
            this.RefId = refId ?? 0;
            this.DocActions = OldValue;
            LoadDetails();
        }

        void LoadDetails()
        {
            if (MethodType != MethodType.Edit)
                return;
            try
            {
                cboStatus.EditValue = DocActions.Status;
                dtDate.EditValue = DocActions.ActionDate;
                txtActionTaken.Text = DocActions.ActionTaken;
                cboUsers.EditValue = DocActions.EndorsedTo;
                cboPrograms.EditValue = DocActions.ProgramId ?? 0;
                cboMain.EditValue = DocActions.MainActivityId ?? 0;
                cboSub.EditValue = DocActions.SubActivityId ?? 0;
                cboActivity.EditValue = DocActions.ActivityId ?? 0;
                txtRemarks.Text = DocActions.Remarks;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }




        private void frmWOActions_Load(object sender, EventArgs e)
        {
            this.dtDate.EditValue = DateTime.Now;
            LoadActionDetails();
            LoadDetails();
            ActionTakenBindingSource.DataSource = new UnitOfWork().ActionListsRepo.Get();

        }

        void LoadActionDetails()
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            this.lblWorkOrder.Text = Label;
            this.StatusBindingSource.DataSource = unitOfWork.StatusesRepo.Get();
            this.UserBindingSource.DataSource = unitOfWork.UsersRepo.Get();
            this.cboPrograms.Properties.DataSource =
                unitOfWork.DropdownsRepo.Get(m => m.Category == "Programs", m => m.OrderBy(x => x.Order));
        }

        private void btnNewPO_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to save this", "Saving", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.No)
                return;
            if (MethodType == MethodType.Edit)
                update();
            else
                add();

            this.HasAction = true;
            this.Close();
        }

        void update()
        {
            var unitOfWork = new UnitOfWork();
            var action = unitOfWork.DocActionsRepo.Find(x => x.Id == DocActions.Id);
            //this.DocActions = unitOfWork.DocActionsRepo.Find(x => x.RefId == RefId);
            action.Status = cboStatus.EditValue?.ToString();
            action.DateCreated = DateTime.Now;
            action.ActionDate = dtDate.DateTime;
            action.ActionTaken = txtActionTaken.Text;
            action.CreatedBy = User.UserId;
            action.TableName = TableName;
            action.EndorsedTo = (cboUsers.GetSelectedDataRow() as Users)?.Id;
            action.ProgramId = cboPrograms.EditValue?.ToInt();
            action.MainActivityId = cboMain.EditValue.ToInt();
            action.SubActivityId = cboSub.EditValue?.ToInt();
            action.Remarks = txtRemarks.Text;
            action.ActivityId = cboActivity.EditValue?.ToInt();
            unitOfWork.Save();


        }

        void add()
        {
            UnitOfWork unitOfWork = new UnitOfWork();

            this.DocActions = new Models.DocActions()
            {
                RefId = RefId,
                Status = cboStatus.EditValue?.ToString(),
                DateCreated = DateTime.Now,
                ActionDate = dtDate.DateTime,
                ActionTaken = txtActionTaken.Text,
                CreatedBy = User.UserId,
                TableName = TableName,
                EndorsedTo = (cboUsers.GetSelectedDataRow() as Users)?.Id,
                ProgramId = cboPrograms.EditValue?.ToInt(),
                MainActivityId = cboMain.EditValue.ToInt(),
                SubActivityId = cboSub.EditValue?.ToInt(),
                ActivityId = cboActivity.EditValue?.ToInt(),
                Remarks = txtRemarks.Text
            };

            unitOfWork.DocActionsRepo.Insert(DocActions);
            unitOfWork.Save();

        }

        public bool HasAction { get; set; }
        public int ActionId { get; set; }
        public MethodType MethodType { get; set; }


        private void btnEditPo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboStatus_EditValueChanged(object sender, EventArgs e)
        {
            if (cboStatus.GetSelectedDataRow() is Statuses item)
            {
                cboUsers.Enabled = false;
                cboUsers.EditValue = null;
                if (item.Value == "Endorsed To")
                    cboUsers.Enabled = true;
            }
        }

        private void cboPrograms_EditValueChanged(object sender, EventArgs e)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                var dropdown = (sender as LookUpEdit)?.GetSelectedDataRow() as Dropdowns;
                if (dropdown == null)
                    return;
                this.cboMain.Properties.DataSource =
                    unitOfWork.DropdownsRepo.Get(m => m.ParentId == dropdown.Id, m => m.OrderBy(x => x.Order));
            }

        }

        private void cboMain_EditValueChanged(object sender, EventArgs e)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                var dropdown = (sender as LookUpEdit)?.GetSelectedDataRow() as Dropdowns;
                if (dropdown == null)
                    return;
                this.cboActivity.Properties.DataSource =
                    unitOfWork.DropdownsRepo.Get(m => m.ParentId == dropdown.Id, m => m.OrderBy(x => x.Order));
            }
        }

        private void cboActivity_EditValueChanged(object sender, EventArgs e)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                var dropdown = (sender as LookUpEdit)?.GetSelectedDataRow() as Dropdowns;
                if (dropdown == null)
                    return;
                this.cboSub.Properties.DataSource =
                    unitOfWork.DropdownsRepo.Get(m => m.ParentId == dropdown.Id, m => m.OrderBy(x => x.Order));
            }
        }

        private void btnAddAction_Click(object sender, EventArgs e)
        {
            frmActionList frm = new frmActionList();
            frm.ShowDialog();
            ActionTakenBindingSource.DataSource = new UnitOfWork().ActionListsRepo.Get();
        }
    }
}