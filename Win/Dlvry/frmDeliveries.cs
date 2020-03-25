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
using Models;
using Models.Repository;
using Win.Xcanner;

namespace Win.Dlvry
{
    public partial class frmDeliveries : DevExpress.XtraEditors.XtraForm
    {
        public frmDeliveries()
        {
            InitializeComponent();

            DeliveryGrid.CreateUcControl();
            DeliveryGrid.GridView.FocusedRowChanged += GridView_FocusedRowChanged;
        }

        private void GridView_FocusedRowChanged(object sender,
            DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

            detail();

        }

        void detail()
        {
            if (DeliveryGrid.GridView.GetFocusedRow() is Deliveries item)
            {
                txtOffice.Text = item.Offices?.OfficeName;
                txtChief.Text = item.Offices?.Chief;
                txtTel.Text = item.Offices?.TelNo;
                txtSupplierName.Text = item.Suppliers?.SupplierName;
                txtSupplierAddress.Text = item.Suppliers?.Address;
                txtSupplierTelNo.Text = item.Suppliers?.ContactNumber;
                lblDelDescription.Text = item.DeliveryId;
                EquipmentProfileBindingSource.DataSource =
                    new UnitOfWork().EquipmentProfilesRepo.Get(m => m.RefId == item.Id && m.TableName == "Deliveries");
            }

        }

        private void btnNewPO_Click(object sender, EventArgs e)
        {
            frmAddEditDeliveries frm = new frmAddEditDeliveries(null, MethodType.Add);
            frm.ShowDialog();
            DeliveryGrid.CreateUcControl();
            detail();
        }

        private void btnEditPo_Click(object sender, EventArgs e)
        {
            if (DeliveryGrid.GridView.GetFocusedRow() is Deliveries item)
            {
                frmAddEditDeliveries frm = new frmAddEditDeliveries(item, MethodType.Edit);
                frm.ShowDialog();
                DeliveryGrid.CreateUcControl();
                detail();
            }
        }

        private void frmDeliveries_Load(object sender, EventArgs e)
        {

        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            var deliveries = DeliveryGrid.GridView.GetFocusedRow() as Deliveries;
            if (deliveries == null)
                return;

            frmScanner frm = new frmScanner(scanners =>
            {
                scanners.RefId = deliveries.Id;
                scanners.TableName = "Deliveries";
            });
            frm.ShowDialog();
        }
    }
}