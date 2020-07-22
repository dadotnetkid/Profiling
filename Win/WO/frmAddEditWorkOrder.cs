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
using Models.Interfaces;

namespace Win.WO
{
    public partial class frmAddEditWorkOrder : DevExpress.XtraEditors.XtraForm, ITransaction<WorkOrders>
    {
        private MethodType methodType;
        public WorkOrders workOrders;
        private bool isClosed;

        public frmAddEditWorkOrder(WorkOrders workOrders, MethodType methodType)
        {
            InitializeComponent();
            this.Icon = Resources.maintenance.ToIcon();
            this.workOrders = workOrders;
            this.methodType = methodType;
            Init();

        }

        public void Search(string search)
        {
            throw new NotImplementedException();
        }

        public void Init()
        {
            try
            {
                if (methodType == MethodType.Edit)
                {
                    Details(workOrders);
                    return;
                }
                UnitOfWork unitOfWork = new UnitOfWork();
                var id = (unitOfWork.WorkOrdersRepo.Fetch().OrderByDescending(x => x.Id).FirstOrDefault()?.Id ?? 0) + 1;

                workOrders = new WorkOrders()
                {
                    Id = id,
                    WorkOrderId = id.ToString("EPiS-0000")
                };
                unitOfWork.WorkOrdersRepo.Insert(workOrders);
                unitOfWork.Save();
                Details(workOrders);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Details()
        {
            throw new NotImplementedException();
        }
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            Emp.frmEmployees frm = new Emp.frmEmployees();
            frm.ShowDialog();
        }
        public void Details(WorkOrders item)
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            cboPropertyNo.Properties.DataSource = unitOfWork.PPEsRepo.Get(orderBy: x => x.OrderByDescending(m => m.Id));
            cboEmployeeId.Properties.DataSource = unitOfWork.EmployeesRepo.Get();
            cboEquipmentType.Properties.DataSource = unitOfWork.EquipmentTypesRepo.Get();
            cboDeliveredBy.Properties.DataSource = unitOfWork.EmployeesRepo.Get();
            cboOffice.Properties.DataSource = unitOfWork.OfficesRepo.Get();
            

            try
            {

                item = unitOfWork.WorkOrdersRepo.Find(m => m.Id == item.Id);


                cboEmployeeId.EditValue = item.Employees?.Id;
                txtPosition.Text = item.Position;
                cboOffice.EditValue = item.Employees?.Offices?.Id;
                dtRequestedDate.EditValue = item.RequestedDate;
                cboEquipmentType.EditValue = item?.PPEs?.EquipmentTypeId;
                txtDescription.Text = item.PPEs?.Description;
                cboPropertyNo.EditValue = item.PPEId;
                txtFindings.Text = item.Findings;
                txtProblems.Text = item.Problem;
                txtRecommendation.Text = item.Recommendation;
                txtBox.EditValue = item.PPEs?.BoxNumber;
                txtItemDelivered.Text = item.DeliveredDescription;
                cboDeliveredBy.Text = item.DeliveredBy;
                lblFolderNo.Text = item.FolderNo;
                txtFolderNo.Text = item.FolderNo;
                lblWorkOrderNo.Text = item.WorkOrderId ?? item.Id.ToString("EPiS-0000");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Save()
        {
            try
            {

                if (MessageBox.Show("Do you want to submit this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                UnitOfWork unitOfWork = new UnitOfWork();
                var item = unitOfWork.WorkOrdersRepo.Find(x => x.Id == workOrders.Id);
                item.WorkOrderId = item.Id.ToString("EPiS-0000");
                item.PPEId = cboPropertyNo.EditValue?.ToInt();
                item.RequestedDate = dtRequestedDate.EditValue?.ToDate();
                item.RequestedBy = cboEmployeeId.EditValue?.ToInt();
                item.Problem = txtProblems.Text;
                item.Findings = txtFindings.Text;
                item.DateCreated = DateTime.Now;
                item.FolderNo = this.txtFolderNo.Text;
                item.Box = this.txtBox.EditValue.ToInt();
                item.Recommendation = this.txtRecommendation.EditValue?.ToString();
                item.DeliveredDescription = txtItemDelivered.Text;
                item.DeliveredBy = cboDeliveredBy.EditValue?.ToString();
                item.Position = (cboDeliveredBy.GetSelectedDataRow() as Employees)?.Position;
                item.OfficeNo = (cboOffice.GetSelectedDataRow() as Offices)?.BoxNo;
                item.EquipmentTypeNo = (cboEquipmentType.GetSelectedDataRow() as EquipmentTypes)?.Box;
                item.EquipmentCount = txtFolderNo.Text.Split('-')[2].ToInt();
                unitOfWork.Save();
                isClosed = true;
                this.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cboEquipmentType_EditValueChanged(object sender, EventArgs e)
        {
            if (cboEquipmentType.GetSelectedDataRow() is EquipmentTypes item)
            {
                var employee = cboOffice.GetSelectedDataRow() as Offices;
                lblFolderNo.Text = new WorkOrders().GeneratedId(employee?.BoxNo, item.Box, workOrders.Id);
                txtFolderNo.Text = lblFolderNo.Text;
            }
        }
        private void cboOffice_EditValueChanged(object sender, EventArgs e)
        {
            if (cboOffice.GetSelectedDataRow() is Offices item)
            {
                var equipmentTypes = cboEquipmentType.GetSelectedDataRow() as EquipmentTypes;
                lblFolderNo.Text = new WorkOrders().GeneratedId(item.BoxNo, equipmentTypes?.Box, workOrders.Id);
                txtFolderNo.Text = lblFolderNo.Text;
            }
        }
        private void cboPropertyNo_EditValueChanged(object sender, EventArgs e)
        {
            if (cboPropertyNo.GetSelectedDataRow() is PPEs item)
            {
                cboEquipmentType.EditValue = item.EquipmentTypeId;
                txtDescription.Text = item.Description;
                cboEmployeeId.EditValue = item.EmployeeId;
                txtPosition.Text = item.Employees?.Position;
                cboOffice.Text = item?.Employees?.Offices?.OfficeName;
                if (this.methodType == MethodType.Add)
                    this.FolderNo = new WorkOrders().GeneratedId(item, item.Id);
                lblWorkOrderNo.Text = workOrders.Id.ToString("EPiS-0000");
                lblFolderNo.Text = FolderNo;
                txtFolderNo.Text = FolderNo;
                txtBox.EditValue = item.BoxNumber;
            }
        }
        private void btnEditPo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewPO_Click(object sender, EventArgs e)
        {
            Save();
        }
        private void frmAddEditWorkOrder_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (methodType == MethodType.Edit)
                return;
            if (isClosed)
                return;
            try
            {
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    unitOfWork.WorkOrdersRepo.Delete(workOrders.Id);
                    unitOfWork.Save();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        public string FolderNo { get; set; }
    }
}