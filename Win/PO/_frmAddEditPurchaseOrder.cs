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

namespace Win.PO
{
    public partial class _frmAddEditPurchaseOrder : DevExpress.XtraEditors.XtraForm
    {
      
        public _frmAddEditPurchaseOrder()
        {
            InitializeComponent();
        }

        public int PurchaseId { get; set; }
        public MethodType MethodType { get; set; }
        public _frmPurchaseOrders frmPurchaseOrders { get; set; }

        private void frmAddEditPurchaseOrder_Load(object sender, EventArgs e)
        {
            Initialize();

            if (MethodType == MethodType.Edit)
                LoadPurchaseDetails();
           
        }
        void Initialize()
        {
            var unitOfWork = new UnitOfWork();
            this.SupplierBindingSource.DataSource = unitOfWork.SuppliersRepo.Get();
            this.OfficeBindingSource.DataSource = unitOfWork.OfficesRepo.Get();
            this.EquipTypeBindingSource.DataSource = unitOfWork.EquipmentTypesRepo.Get();
            this.UnitBindingSource.DataSource = unitOfWork.UnitTypesRepo.Get();
        }

        void LoadPurchaseDetails()
        {
            var unitOfWork = new UnitOfWork();
            var item = unitOfWork.PurchaseOrdersRepo.Find(m => m.Id == PurchaseId);
            txtPO.Text = item?.PurchaseNumber;
            dtPurchaseDate.EditValue = item?.PurchaseDate.ToString();
            cboSupplier.EditValue = item?.SupplierId;
            txtAddress.Text = item?.Suppliers?.Address;
            cboOffice.EditValue = item.OfficeId;
           // this.EquipmentBindingSource.DataSource = new UnitOfWork().EquipmentsRepo.Get(m => m.PurchaseOrderId == PurchaseId) ?? Equipments;
        }

        void Update()
        {
            var unitOfWork = new UnitOfWork();
            var item = unitOfWork.PurchaseOrdersRepo.Find(m => m.Id == PurchaseId);
            item.PurchaseNumber = txtPO.EditValue?.ToString();
            item.PurchaseDate = dtPurchaseDate.EditValue?.ToDate();
            item.OfficeId = cboOffice.EditValue.ToInt();
            item.SupplierId = cboSupplier.EditValue.ToInt();
            unitOfWork.Save();
        }

        void NewPO()
        {
            var unitOfWork = new UnitOfWork();
            var item = new PurchaseOrders()
            {
                PurchaseNumber = txtPO.EditValue?.ToString(),
                PurchaseDate = dtPurchaseDate.EditValue?.ToDate(),
                OfficeId = cboOffice.EditValue.ToInt(),
                SupplierId = cboSupplier.EditValue.ToInt(),
               
            };
            unitOfWork.PurchaseOrdersRepo.Insert(item);
            unitOfWork.Save();
        }
        private void textEdit3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnNewPO_Click(object sender, EventArgs e)
        {
            if (MethodType == MethodType.Edit)
                Update();
            else
                NewPO();
            this.frmPurchaseOrders.Initialize();
            this.Close();
        }

        private void EquipmentGrid_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
          /*  UnitOfWork unitOfWork = new UnitOfWork();
            if (e.Row is Equipments item)
            {
                item.Total = item.QTY * item.UnitCost;
                if (item.Id == 0)
                {
                    if (MethodType == MethodType.Add)
                        return;
                    else
                    {
                        item.PurchaseOrderId = PurchaseId;
                        unitOfWork.EquipmentsRepo.Insert(item);
                        unitOfWork.Save();
                    }
                }
                else
                {
                    unitOfWork.EquipmentsRepo.Update(item);
                    unitOfWork.Save();
                }
            }*/
        }

        private void btnEditPo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboSupplier_EditValueChanged(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.LookUpEdit editor = sender as DevExpress.XtraEditors.LookUpEdit;

            txtAddress.Text = editor.GetColumnValue("Address").ToString();
        }

        private void cboOffice_EditValueChanged(object sender, EventArgs e)
        {
            if (sender is DevExpress.XtraEditors.LookUpEdit editor)
                if (editor.Properties.GetDataSourceRowByKeyValue(editor.EditValue) is Offices item)
                {
                    txtChief.Text = item.Chief;
                    txtTel.Text = item.TelNo;
                }

        }

        private void frmAddEditPurchaseOrder_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.frmPurchaseOrders.LoadEquipments();
        }
    }


}
