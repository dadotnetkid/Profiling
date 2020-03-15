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

namespace Win.PO
{
    public partial class frmAddEditPurchaseOrder : DevExpress.XtraEditors.XtraForm
    {
        public int POId;

        public frmAddEditPurchaseOrder()
        {
            InitializeComponent();
            this.Icon = Resources.maintenance.ToIcon();
        }


        private void frmAddEditWorkOrder_Load(object sender, EventArgs e)
        {
            InitTransaction();
            LoadPODetails();
        }

        private void btnNewPO_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Do you want to submit this?", "Submit", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.No)
                return;
            Edit();
            //frmPurchaseOrders.InitializePurchaseOrder();

            this.Close();
        }
        void Edit()
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                unitOfWork.PurchaseOrdersRepo.Update(new PurchaseOrders()
                {
                    Id = POId,
                    EmployeeId = cboEmployeeId.EditValue.ToInt(),
                    OfficeId = cboEmployeeId.EditValue.ToInt(),
                    EquipmentTypeId = cboEquipmentType.EditValue.ToInt(),
                    Description = txtDescription.Text,
                    DateDelivered = dtPurchaseDate.EditValue?.ToDate(),
                    SupplierId = cboSupplierId.EditValue?.ToInt()
                });
                unitOfWork.Save();
                this.MethodType = MethodType.Edit;
            }
        }

        private void frmAddEditWorkOrder_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MethodType == MethodType.Edit)
                return;
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                unitOfWork.PurchaseOrdersRepo.Delete(m => m.Id == POId);
                unitOfWork.Save();
            }
        }
        public void InitTransaction()
        {
            if (this.MethodType == MethodType.Edit)
                return;
            using (var unitOfWork = new UnitOfWork())
            {
                this.POId = (unitOfWork.PurchaseOrdersRepo.Fetch().Select(x => new { x.Id }).OrderByDescending(m => m.Id)
                                       .FirstOrDefault()?.Id ?? 0) + 1;
                unitOfWork.PurchaseOrdersRepo.InsertIdentity("PurchaseOrders", $"insert into PurchaseOrders(id) values({POId})");
            }

        }
        void LoadPODetails()
        {

            var unitOfWork = new UnitOfWork();
            this.EmployeeBindingSource.DataSource = unitOfWork.EmployeesRepo.Get();
            this.OfficeBindingSource.DataSource = unitOfWork.OfficesRepo.Get();
            this.EquipmentTypeBindingSource.DataSource = unitOfWork.EquipmentTypesRepo.Get();
            this.SupplierBindingSource.DataSource = unitOfWork.SuppliersRepo.Get();
            //  this.EquipmentProfileBindingSource.DataSource = EquipmentProfiles;
            this.UnitTypeBindingSource.DataSource = unitOfWork.UnitTypesRepo.Get();
            var PO = unitOfWork.PurchaseOrdersRepo.Find(m => m.Id == this.POId);
            if (PO == null)
                return;


            this.PurchaseNo = PO.Id.ToString("PO-0000");
            this.lblPPENo.Text = PurchaseNo;

            cboOffice.EditValue = PO.OfficeId;
            cboEmployeeId.EditValue = PO.EmployeeId;
            this.txtPoNumber.Text = PurchaseNo;
            dtPurchaseDate.EditValue = PO.DateDelivered?.ToDate();
            cboSupplierId.EditValue = PO.SupplierId;
            cboEquipmentType.EditValue = PO.EquipmentTypeId;
            txtDescription.Text = PO.Description;

            this.EquipmentProfileBindingSource.DataSource =
                new UnitOfWork().EquipmentProfilesRepo.Get(m => m.RefId == this.POId && m.TableName == "PurchaseOrders").ToList() ?? new List<EquipmentProfiles>();
            }

        public string PurchaseNo { get; set; }
        public frmPurchaseOrders frmPurchaseOrders { get; set; }
        public MethodType MethodType { get; set; }

        private void EquipmentGrid_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            if (e.Row is EquipmentProfiles item)
            {
                item.Total = (item.QTY ?? 0) * (item.UnitCost ?? 0);
                if (item.ItemNumber == null)
                {
                    item.EquipmentName = "\t" + item.EquipmentName;
                    item.Serial = "\t" + item.Serial;
                    item.Description = "\t" + item.Description;
                }
                else
                {
                    //  this.ItemNumber = item.ItemNumber;
                }
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    item.RefId = POId;
                    item.TableName = "PurchaseOrders";
                    if (item.Id == 0)
                    {
                        item.DateCreated = DateTime.Now;
                        item.CreatedBy = User.UserId;
                        unitOfWork.EquipmentProfilesRepo.Insert(item);
                        unitOfWork.Save();
                    }
                    else
                    {
                        unitOfWork.EquipmentProfilesRepo.Update(item);
                        unitOfWork.Save();
                    }
                }
            }
        }

        private void btnEditPo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboOffice_EditValueChanged(object sender, EventArgs e)
        {
            if (sender is LookUpEdit lookUpEdit)
            {
                if (lookUpEdit.GetSelectedDataRow() is Offices item)
                {
                    txtChief.Text = item.Chief;
                    txtTel.Text = item.TelNo;
                }
            }

        }

        private void cboEmployeeId_EditValueChanged(object sender, EventArgs e)
        {
            if (sender is LookUpEdit lookUpEdit)
            {
                if (lookUpEdit.GetSelectedDataRow() is Employees item)
                {
                    txtPosition.Text = item.Position;
                    txtOffice.Text = item.Offices.OfficeName;
                }
            }
        }
    }
}