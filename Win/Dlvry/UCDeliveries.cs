using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Data.Linq;
using DevExpress.XtraEditors;
using Helpers;
using Models;
using Models.Interfaces;
using Models.Repository;
using Win.DocAct;
using Win.Rpt;
using Win.Xcanner;

namespace Win.Dlvry
{
    public partial class UCDeliveries : DevExpress.XtraEditors.XtraUserControl, ILoad<Deliveries>
    {
        public UCDeliveries()
        {
            InitializeComponent();
            Init();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Search(txtSearch.Text);
        }

        public void Search(string search)
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            var deliveries = new UnitOfWork().DeliveriesRepo.Fetch(x => x.Offices.OfficeName.Contains(search) || x.Offices.OffcAcr.Contains(search) || x.DeliveryId.Contains(search));
            DeliveryGridControl.DataSource = new EntityServerModeSource()
            {
                QueryableSource = deliveries
            };
            this.Details(deliveries.OrderBy(x => x.Id).FirstOrDefault());
        }

        public void Init()
        {
            var deliveries = new UnitOfWork().DeliveriesRepo.Fetch();
            DeliveryGridControl.DataSource = new EntityServerModeSource()
            {
                QueryableSource = deliveries
            };
            this.Details(deliveries.OrderBy(x => x.Id).FirstOrDefault());

        }

        public void Details()
        {
            if (DeliveriesGrid.GetFocusedRow() is Deliveries item)
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
                UcActionGrid.LoadActions(item.Id, "Deliveries");
            }
        }

        public void Details(Deliveries item)
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
            UcActionGrid.LoadActions(item.Id, "Deliveries");
        }

        private void btnEditDeliveries_Click(object sender, EventArgs e)
        {
            if (DeliveriesGrid.GetFocusedRow() is Deliveries item)
            {
                frmAddEditDeliveries frm = new frmAddEditDeliveries(item, MethodType.Edit);
                frm.ShowDialog();
                Details();
            }
        }

        private void btnNewDelivery_Click(object sender, EventArgs e)
        {
            frmAddEditDeliveries frm = new frmAddEditDeliveries(null, MethodType.Add);
            frm.ShowDialog();
            Details(new UnitOfWork().DeliveriesRepo.Fetch().OrderByDescending(x => x.Id).FirstOrDefault());
        }

        private void btnDeleteRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (!User.UserInAction("Delete Deliveries"))
                return;

            if (MessageBox.Show("Do you want to delete this", "Deleting", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.No)
                return;
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                var delivery = DeliveriesGrid.GetFocusedRow() as Deliveries;
                if (delivery == null)
                    return;
                unitOfWork.DeliveriesRepo.Delete(delivery.Id);
                unitOfWork.Save();
                Init();
            }

        }

        private void DeliveriesGrid_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (DeliveriesGrid.GetFocusedRow() is Deliveries item)
            {
                Details(item);
            }
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            var deliveries = DeliveriesGrid.GetFocusedRow() as Deliveries;
            if (deliveries == null)
                return;

            frmScanner frm = new frmScanner(scanners =>
            {
                scanners.RefId = deliveries.Id;
                scanners.TableName = "Deliveries";
            });
            frm.ShowDialog();
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (!User.UserInAction("Deliveries Action"))
                return;
            try
            {
                if (DeliveriesGrid.GetFocusedRow() is Deliveries item)
                {
                    frmDocActions frm = new frmDocActions(tableName: "Deliveries",
                        label: item.Offices.OfficeName,
                        refId: item.Id);

                    var res = frm.ShowDialogResult();
                    Details(item);
                }



            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (DeliveriesGrid.GetFocusedRow() is Deliveries item)
                {
                    frmReportViewer frm = new frmReportViewer(new rptItemquipmentWidrawalSlip()
                    {
                        DataSource = new UnitOfWork().DeliveriesRepo.Get(x => x.Id == item.Id)
                    });
                    frm.ShowDialog();
                }



            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
