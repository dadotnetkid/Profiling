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
using DevExpress.XtraGrid.Views.Grid;
using Helpers;
using Models;
using Models.Repository;
using Win.DocAct;
using Win.Properties;
using Win.Xcanner;

namespace Win.PO
{
    public partial class frmPurchaseOrders : DevExpress.XtraEditors.XtraForm
    {
        public int PoId { get; set; }
        public frmPurchaseOrders()
        {
            InitializeComponent();
            this.Icon = Resources.maintenance.ToIcon();
        }


        private void btnNewPO_Click(object sender, EventArgs e)
        {
            if (!User.UserInAction("New Purchase Order"))
                return;
            frmAddEditPurchaseOrder frm = new frmAddEditPurchaseOrder()
            {
                frmPurchaseOrders = this,
                MethodType = MethodType.Add,

            };
            frm.ShowDialog();
            UcPOGrid.CreateUcControl();
        }

        private void btnEditPo_Click(object sender, EventArgs e)
        {
            if (!User.UserInAction("Edit Purchase Order"))
                return;
            frmAddEditPurchaseOrder frm = new frmAddEditPurchaseOrder()
            {
                frmPurchaseOrders = this,
                POId = this.PoId,
                MethodType = MethodType.Edit
            };
            frm.ShowDialog();
            //reload Details after saving
            UcPODetails.Details(new UnitOfWork().PurchaseOrdersRepo.Find(m => m.Id == PoId));
        }


        private void btnAction_Click(object sender, EventArgs e)
        {
            if (!User.UserInAction("Purchase Order Action"))
                return;
            if (UcPOGrid.POGrid.GetFocusedRow() is PurchaseOrders purchaseOrders)
            {
                try
                {
                    frmDocActions frm = new frmDocActions("PurchaseOrders",
                        purchaseOrders?.Employees?.EmployeeName + " - " + purchaseOrders?.EquipmentTypes?.EquipmentType, purchaseOrders.Id);

                    var res = frm.ShowDialogResult();
                    if (!res.HasAction)
                        return;
                    var unitOfWork = new UnitOfWork();
                    unitOfWork.DocActionsRepo.Insert(res.DocActions);
                    unitOfWork.Save();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
            }
        }



        private void btnScan_Click(object sender, EventArgs e)
        {
            if (!User.UserInAction("Purchase Order Scan Document"))
                return;
            frmScanner frmScanPO = new frmScanner(scanner =>
            {

            });
            var res = frmScanPO.ShowDialogResult();

        }

        private void frmPurchaseOrders_Load(object sender, EventArgs e)
        {
            UcPOGrid.CreateUcControl();
            UcPOGrid.POGrid.FocusedRowChanged += POGrid_FocusedRowChanged;
        }



        private void POGrid_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (sender is GridView gridView)
            {
                if (gridView.GetRow(e.FocusedRowHandle) is PurchaseOrders purchaseOrders)
                {
                    UcPODetails.Details(purchaseOrders);
                    UcActionGrid.LoadActions(purchaseOrders.Id, "PurchaseOrders");
                    ucPOEquipmentProfile1.Details(purchaseOrders.Id,"PurchaseOrders");
                    PoId = purchaseOrders.Id;
                }
            }
        }


    }
}