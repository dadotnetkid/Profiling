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
using Win.Emp;
using Win.Properties;
using System.Data.Entity;

namespace Win.Dlvry
{
    public partial class frmAddEditDeliveries : DevExpress.XtraEditors.XtraForm
    {
        public MethodType methodType;
        private Deliveries oldValue;
        private string deliveryId;

        public frmAddEditDeliveries(Deliveries oldValue, MethodType methodType)
        {
            InitializeComponent();
            this.Icon = Resources.maintenance.ToIcon();



            this.oldValue = oldValue;
            this.methodType = methodType;


        }

        void init()
        {

            if (methodType == MethodType.Edit)
                return;
            var unitOfWork = new UnitOfWork();
            this.Id = (unitOfWork.DeliveriesRepo.Fetch().OrderByDescending(m => m.Id).Select(x => new { x.Id }).FirstOrDefault()?.Id ?? 0) + 1;
            this.deliveryId = Id.ToString("EPiS-0000");
            unitOfWork.DeliveriesRepo.Insert(new Deliveries()
            {
                Id = Id,
                DeliveryId = deliveryId
            });
            unitOfWork.Save();
            this.lblDelNo.Text = this.deliveryId;
            EquipmentProfileBindingSource.DataSource =
                new UnitOfWork().EquipmentProfilesRepo.Get(m => m.RefId == Id && m.TableName == "Deliveries");

        }

        Deliveries deliveries()
        {
            return new Deliveries()
            {
                Id = Id,
                SupplierId = txtSupplierName.EditValue?.ToInt(),
                OfficeId = txtOffice.EditValue?.ToInt(),
                DeliveredDate = dtDeliveredDate.EditValue?.ToDate(),
                DeliveryId = deliveryId,

            };
        }

        void details(Deliveries item)
        {
            if (methodType == MethodType.Add)
                return;
            Id = item.Id;
            deliveryId = item.DeliveryId;
            txtChief.EditValue = item.Offices?.Chief;
            txtOffice.Text = item.Offices?.OfficeName;
            txtTel.Text = item.Offices?.TelNo;
            txtSupplierName.Text = item.Suppliers?.SupplierName;
            txtSupplierAddress.Text = item.Suppliers?.Address;
            txtSupplierTelNo.Text = item.Suppliers?.ContactNumber;
            dtDeliveredDate.EditValue = item.DeliveredDate;
            lblDelNo.Text = item.DeliveryId;
            EquipmentProfileBindingSource.DataSource =
                new UnitOfWork().EquipmentProfilesRepo.Get(m => m.RefId == Id && m.TableName == "Deliveries");
            isDelete = false;
        }

        void add(Deliveries item)
        {
            try
            {
                var unitOfWork = new UnitOfWork();
                var deliveries = unitOfWork.DeliveriesRepo.Find(m => m.Id == item.Id);
                deliveries.OfficeId = item.OfficeId;
                deliveries.DeliveredDate = item.DeliveredDate;
                deliveries.DeliveryId = item.DeliveryId;
                deliveries.Files = item.Files;
                deliveries.SupplierId = item.SupplierId;

                unitOfWork.Save();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void edit(Deliveries item)
        {
            try
            {
                var unitOfWork = new UnitOfWork();
                var deliveries = unitOfWork.DeliveriesRepo.Find(m => m.Id == item.Id);
                deliveries.OfficeId = item.OfficeId;
                deliveries.DeliveredDate = item.DeliveredDate;
                deliveries.DeliveryId = item.DeliveryId;
                deliveries.Files = item.Files;
                deliveries.SupplierId = item.SupplierId;

                unitOfWork.Save();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void frmAddEditTechSpecs_Load(object sender, EventArgs e)
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            txtOffice.Properties.DataSource = new BindingList<Offices>(unitOfWork.OfficesRepo.Get());
            txtSupplierName.Properties.DataSource = new BindingList<Suppliers>(unitOfWork.SuppliersRepo.Get());
            UOMBindingSource.DataSource = new BindingList<UnitTypes>(unitOfWork.UnitTypesRepo.Get());
            EquipTypeBindingSource.DataSource = new BindingList<EquipmentTypes>(unitOfWork.EquipmentTypesRepo.Get());
            init();
            details(oldValue);
        }

        private void txtOffice_EditValueChanged(object sender, EventArgs e)
        {
            if (sender is LookUpEdit lookUpEdit)
            {
                if (lookUpEdit.GetSelectedDataRow() is Offices offices)
                {
                    txtChief.Text = offices.Chief;
                    txtTel.Text = offices.TelNo;

                }
            }
        }

        private void txtSupplierName_EditValueChanged(object sender, EventArgs e)
        {
            if (sender is LookUpEdit lookUpEdit)
            {
                if (lookUpEdit.GetSelectedDataRow() is Suppliers item)
                {
                    txtSupplierAddress.Text = item.Address;
                    txtSupplierTelNo.Text = item.ContactNumber ?? item.PhoneNumber;

                }
            }
        }

        private void EquipmentGrid_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {

                if (e.Row is EquipmentProfiles item)
                {
                    item.Total = (item.QTY ?? 0) * (item.UnitCost ?? 0);

                    using (UnitOfWork unitOfWork = new UnitOfWork())
                    {
                        if (item.ItemNumber != null)
                        {
                            this.ItemNumber = item.ItemNumber;
                        }

                        item.RefId = this.Id;
                        item.TableName = "Deliveries";

                        if (!string.IsNullOrEmpty(item.Description))
                        {
                            var des = string.Join(Environment.NewLine, item.Description?.Split('\n')?.Where(x => x != "\r")?.Select(x => x.Replace("\r", "")?.Replace("\t", "")));

                            item.Description = des;
                        }

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
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Update Equipment Details", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        public int? ItemNumber;
        private int Id;
        private bool isDelete = true;


        private void btnNewPO_Click_1(object sender, EventArgs e)
        {

            if (MessageBox.Show("Do you want to submit this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            if (methodType == MethodType.Add)
                add(deliveries());
            else
                edit(deliveries());
            isDelete = false;
            this.Close();
        }

        private void btnEditPo_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void frmAddEditDeliveries_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (this.isDelete)
            {
                var unitOfWork = new UnitOfWork();
                unitOfWork.DeliveriesRepo.Delete(m => m.Id == Id);
                unitOfWork.Save();
            }
        }

        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            if (MessageBox.Show("Do you want to delete this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            if (EquipmentGrid.GetFocusedRow() is EquipmentProfiles item)
            {
                var unitOfWork = new UnitOfWork();
                unitOfWork.EquipmentProfilesRepo.Delete(m => m.Id == item.Id && m.TableName == "Deliveries");
                unitOfWork.Save();
            }
        }
    }
}