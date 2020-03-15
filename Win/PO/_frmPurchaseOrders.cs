using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
using Win.Xcanner;

namespace Win.PO
{
    public partial class _frmPurchaseOrders : DevExpress.XtraEditors.XtraForm
    {
        private int purchaseId;
        private BindingSource ActionBindingSource = new BindingSource();
        public _frmPurchaseOrders()
        {
            InitializeComponent();
            this.ActionGrinControl.DataSource = ActionBindingSource;
            this.Icon = Resources.delivery.ToIcon();
        }

        private void frmPurchaseOrders_Load(object sender, EventArgs e)
        {
            Initialize();
        }

        public void Initialize()
        {
            var unitOfWork = new UnitOfWork();
            this.SupplierBindingSource.DataSource = unitOfWork.SuppliersRepo.Get();
            this.OfficeBindingSource.DataSource = unitOfWork.OfficesRepo.Get();
            this.PurchaseOrderBindingSource.DataSource = unitOfWork.PurchaseOrdersRepo.Get();
            if (!unitOfWork.PurchaseOrdersRepo.Fetch().Any())
            {
                gridControl1.Enabled = false;
            }
            else
            {


                this.EquipTypeBindingSource.DataSource = unitOfWork.EquipmentTypesRepo.Get();
                this.UnitBindingSource.DataSource = unitOfWork.UnitTypesRepo.Get();

            }
        }

        private void PurchaseOrderGrid_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle >= 0)
            {

                if (PurchaseOrderGrid.GetRow(e.FocusedRowHandle) is PurchaseOrders item)
                {
                    txtPO.Text = item.PurchaseNumber;
                    dtPurchaseDate.EditValue = item.PurchaseDate.ToString();
                    cboSupplier.EditValue = item?.SupplierId;
                    txtAddress.Text = item.Suppliers?.Address;
                    purchaseId = item.Id;

                    lblPODescription.Text = item.PurchaseNumber + " - " + item.Offices?.OfficeName;
                    cboOffice.EditValue = item.OfficeId;
                    LoadEquipments();
                    LoadActionActions();
                }
            }

        }

        public void LoadEquipments()
        {
            //  this.EquipmentBindingSource.DataSource = new UnitOfWork().EquipmentsRepo.Get(m => m.PurchaseOrderId == purchaseId);
        }
        public void LoadActionActions()
        {
            this.ActionBindingSource.DataSource = new UnitOfWork().DocActionsRepo.Get(m => m.RefId == purchaseId && m.TableName == "PurchaseOrders");
        }

        private void PurchaseOrderGrid_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            var res = PurchaseOrderGrid.GetRow(e.ControllerRow);
        }

        private void PurchaseOrderGrid_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            if (e.Row is PurchaseOrders item)
            {
                if (item.Id == 0)
                    unitOfWork.PurchaseOrdersRepo.Insert(item);
                else
                    unitOfWork.PurchaseOrdersRepo.Update(item);
            }

            unitOfWork.Save();
            this.PurchaseOrderBindingSource.DataSource = unitOfWork.PurchaseOrdersRepo.Get();

            PurchaseOrderGrid.RefreshData();
        }

        private void EquipmentGrid_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            /*  using (UnitOfWork unitOfWork = new UnitOfWork())
              {
                  if (e.Row is Equipments item)
                  {
                      item.PurchaseOrderId = purchaseId;
                      item.Total = (item.UnitCost ?? 0) * (item.QTY ?? 0);
                      if (item.Id == 0)
                          unitOfWork.EquipmentsRepo.Insert(item);
                      else
                          unitOfWork.EquipmentsRepo.Update(item);
                  }
                  unitOfWork.Save();
                  //  this.EquipmentBindingSource.DataSource=unitOfWork.EquipmentsRepo.Get(m => m.PurchaseOrderId == purchaseId);
              }*/

            //EquipmentGrid.RefreshData();
        }


        private void repositoryItemImageEdit1_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Purchase Id:" + purchaseId);
        }

        private void repositoryItemImageEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Debug.WriteLine("Purchase Id:" + purchaseId);
        }

        private void EquipmentGrid_RowDeleting(object sender, DevExpress.Data.RowDeletingEventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this", "Deleting", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                /*  if (e.Row is Equipments item)
                  {
                      unitOfWork.EquipmentsRepo.Delete(item);
                  }
                  unitOfWork.Save();*/
                //   this.EquipmentBindingSource.DataSource=unitOfWork.EquipmentsRepo.Get(m => m.PurchaseOrderId == purchaseId);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var str = txtSearch.Text;
            this.PurchaseOrderBindingSource.DataSource = new UnitOfWork().PurchaseOrdersRepo.Get(m => m.PurchaseNumber.Contains(str));
        }

        private void EquipmentGrid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 4)
            {

            }
        }

        private void btnEditPo_Click(object sender, EventArgs e)
        {
            _frmAddEditPurchaseOrder frmAddEditPurchaseOrder = new _frmAddEditPurchaseOrder()
            {
                PurchaseId = purchaseId,
                MethodType = MethodType.Edit,
                frmPurchaseOrders = this
            };
            frmAddEditPurchaseOrder.ShowDialog();
        }

        private void btnNewPO_Click(object sender, EventArgs e)
        {
            _frmAddEditPurchaseOrder frmAddEditPurchaseOrder = new _frmAddEditPurchaseOrder()
            {

                MethodType = MethodType.Add,
                frmPurchaseOrders = this
            };
            frmAddEditPurchaseOrder.ShowDialog();
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

        private void EquipmentGrid_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            /*   if (e.FocusedRowHandle >= 0)
                   if (EquipmentGrid.GetRow(e.FocusedRowHandle) is Equipments item)
                   {
                       this.EquipmentDetailBindingSource.DataSource = new UnitOfWork().EquipmentDetailsRepo.Get(m => m.EquipmentId == item.Id);
                   }
           */
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            _frmAddEditActions frm = new _frmAddEditActions() { PurchaseId = purchaseId, frmPurchaseOrders = this };
            frm.ShowDialog();
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            frmScanner frm = new frmScanner() { };
            frm.ShowDialog();
        }
    }
}