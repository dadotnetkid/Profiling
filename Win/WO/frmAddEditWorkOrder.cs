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
using System.Data.Entity;

namespace Win.WO
{
    public partial class frmAddEditWorkOrder : DevExpress.XtraEditors.XtraForm
    {
        public frmAddEditWorkOrder()
        {
            InitializeComponent();
            this.Icon = Resources.maintenance.ToIcon();
        }

        public frmWorkOrders frmWorkOrders { get; set; }
        public int WOId { get; set; }
        public MethodType MethodType { get; set; }
        public string WorkOrderId { get; set; }

        private void frmAddEditWorkOrder_Load(object sender, EventArgs e)
        {
            Initialize();
            LoadWorkOrders();
            // this.Text = $"Work Order - {WorkOrderId}";

            this.lblWorkOrderNo.Text = this.WorkOrderId;
        }

        public void Initialize()
        {
            if (MethodType == MethodType.Edit)
                return;

            try
            {
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    WOId = (unitOfWork.WorkOrdersRepo.Fetch().Select(x => new { x.Id }).OrderByDescending(x => x.Id)
                                   .FirstOrDefault()?.Id ?? 0) + 1;
                    this.WorkOrderId = "EPiS-" + WOId.ToString("0000");

                    unitOfWork.WorkOrdersRepo.InsertIdentity("WorkOrders", $"insert into WorkOrders(Id,WorkOrderId) values({WOId},'{WorkOrderId}')");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        public void LoadWorkOrders()
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            this.EmployeeBindingSource.DataSource = unitOfWork.EmployeesRepo.Get();
            this.WorkOrderBindingSource.DataSource = unitOfWork.WorkOrdersRepo.Get();
            this.EquipmentTypeBindingSource.DataSource = unitOfWork.EquipmentTypesRepo.Get();
            this.PPEBindingSource.DataSource = unitOfWork.PPEsRepo.Get(includeProperties: "Employees");

            this.dtRequestedDate.EditValue = DateTime.Now;
            LoadWorkOrderDetails();
        }
        public void LoadWorkOrderDetails()
        {
            if (MethodType == MethodType.Add)
                return;
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                var item = unitOfWork.WorkOrdersRepo.Find(m => m.Id == WOId);
                cboEmployeeId.EditValue = item.Employees?.Id;
                txtPosition.Text = item.Position;
                this.FolderNo = item.FolderNo;
                txtOffice.Text = item.Employees?.Offices?.OfficeName;
                dtRequestedDate.EditValue = item.RequestedDate;
                cboEquipmentType.EditValue = item?.PPEs?.EquipmentTypeId;
                txtDescription.Text = item.PPEs?.Description;
                cboPropertyNo.EditValue = item.PPEId;
                txtFindings.Text = item.Findings;
                txtProblems.Text = item.Problem;
                txtRecommendation.Text = item.Recommendation;
                WorkOrderId = item.WorkOrderId;
                txtBox.EditValue = item.PPEs?.BoxNumber;
                txtItemDelivered.Text = item.DeliveredDescription;
                cboDeliveredBy.Text = item.DeliveredBy;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnNewPO_Click(object sender, EventArgs e)
        {
            if (!((XtraForm)this).ValidateForm())
                return;
            if (MessageBox.Show("Do you want to submit this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            try
            {
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    var workOrder = new WorkOrders()
                    {
                        Id = WOId,
                        WorkOrderId = WorkOrderId,
                        PPEId = cboPropertyNo.EditValue?.ToInt(),
                        RequestedDate = dtRequestedDate.EditValue?.ToDate(),
                        RequestedBy = cboEmployeeId.EditValue?.ToInt(),
                        Problem = txtProblems.Text,
                        Findings = txtFindings.Text,
                        DateCreated = DateTime.Now,
                        FolderNo = this.txtFolderNo.Text,
                        Box = this.txtBox.EditValue.ToInt(),
                        Recommendation = this.txtRecommendation.EditValue?.ToString(),
                        DeliveredDescription = txtItemDelivered.Text,
                        DeliveredBy = cboDeliveredBy.EditValue?.ToString(),
                        Position = (cboDeliveredBy.GetSelectedDataRow() as Employees)?.Position


                    };
                    unitOfWork.WorkOrdersRepo.Update(workOrder);
                    unitOfWork.Save();
                    this.MethodType = MethodType.Edit;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            this.frmWorkOrders.LoadWorkOrders();
            this.Close();
        }

        private void frmAddEditWorkOrder_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MethodType == MethodType.Edit)
                return;
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                unitOfWork.WorkOrdersRepo.Delete(WOId);
                unitOfWork.Save();
            }

        }

        private void btnEditPo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboPropertyNo_EditValueChanged(object sender, EventArgs e)
        {
            if (cboPropertyNo.GetSelectedDataRow() is PPEs item)
            {
                cboEquipmentType.EditValue = item.EquipmentTypeId;
                txtDescription.Text = item.Description;
                cboEmployeeId.EditValue = item.EmployeeId;
                txtPosition.Text = item.Employees?.Position;
                txtOffice.Text = item?.Employees?.Offices?.OfficeName;
                if (this.MethodType == MethodType.Add)
                    this.FolderNo = new WorkOrders().GeneratedId(item, WOId);
                lblWorkOrderNo.Text = WorkOrderId;
                lblFolderNo.Text = FolderNo;
                txtFolderNo.Text = FolderNo;
                txtBox.EditValue = item.BoxNumber;
            }
        }

        public string FolderNo { get; set; }

        private void PPEBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void cboEquipmentType_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void cboEmployeeId_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            Emp.frmEmployees frm = new Emp.frmEmployees();
            frm.ShowDialog();
        }
    }
}