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

namespace Win.EquipProfile
{
    public partial class frmAddEditEquipmentProfiles : DevExpress.XtraEditors.XtraForm
    {
        private List<EquipmentProfiles> _equipmentProfiles;
        private string PPENo;

        public frmAddEditEquipmentProfiles()
        {
            InitializeComponent();
            this.Icon = Resources.computer.ToIcon();
        }

        public MethodType MethodType { get; set; }
        public int PropertyId { get; set; }

        public List<EquipmentProfiles> EquipmentProfiles
        {
            get
            {
                if (_equipmentProfiles == null)
                    _equipmentProfiles = new List<EquipmentProfiles>();
                return _equipmentProfiles;
            }
            set => _equipmentProfiles = value;
        }

        public frmEquipmentProfiles frmEquipmentProfiles { get; set; }

        private void frmAddEditEquipmentProfiles_Load(object sender, EventArgs e)
        {
            var unitOfWork = new UnitOfWork();
            this.EmployeeBindingSource.DataSource = new UnitOfWork().EmployeesRepo.Get();
            this.OfficeBindingSource.DataSource = new UnitOfWork().OfficesRepo.Get();
            this.EquipmentTypeBindingSource.DataSource = new UnitOfWork().EquipmentTypesRepo.Get();
            //  this.EquipmentProfileBindingSource.DataSource = EquipmentProfiles;
            this.UnitTypeBindingSource.DataSource = unitOfWork.UnitTypesRepo.Get();
            InitTransaction();
            LoadPPEDetails();

        }

        public void InitTransaction()
        {
            if (this.MethodType == MethodType.Edit)
                return;
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {


                    this.PropertyId = (unitOfWork.PPEsRepo.Fetch().Select(x => new { x.Id }).OrderByDescending(m => m.Id)
                                           .FirstOrDefault()?.Id ?? 0) + 1;

                    this.PPENo = PropertyId.ToString("0000");
                    this.txtPropNo.EditValue = PPENo;
                    unitOfWork.PPEsRepo.ExecuteQuery("insert into ppes(id,PPEId) values(@p0,@p1)", PropertyId.ToString(), PropertyId.ToString());
                    //       unitOfWork.Save();

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        void LoadPPEDetails()
        {

            var unitOfWork = new UnitOfWork();
            var ppe = unitOfWork.PPEsRepo.Find(m => m.Id == PropertyId);
            if (ppe == null)
                return;
            this.cboOffice.EditValue = ppe.Employees?.OfficeId;
            this.cboEmployeeId.EditValue = ppe.EmployeeId;
            txtDescription.Text = ppe.Description;
            cboEquipmentType.EditValue = ppe.EquipmentTypeId;
            dtPurchaseDate.EditValue = ppe.DateDelivered?.ToDate();
            this.EquipmentProfileBindingSource.DataSource =
                new UnitOfWork().EquipmentProfilesRepo.Get(m => m.RefId == PropertyId).ToList();
            PPENo = ppe.PPEId;
            this.txtPropNo.Text = PPENo;

            txtBarcode.Text = ppe.Barcode;
            txtSerial.Text = ppe.Serial;
            txtBoxNo.Text = ppe.BoxNumber?.ToString();
            this.lblPPENo.Text = PPENo;
        }



        private void cboOffice_EditValueChanged(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.LookUpEdit editor = sender as DevExpress.XtraEditors.LookUpEdit;

            if (editor.GetSelectedDataRow() is Offices item)
            {
                txtChief.Text = item.Chief;
                txtTel.Text = item.TelNo;

            }
        }

        private void cboEmployeeId_EditValueChanged(object sender, EventArgs e)
        {

            DevExpress.XtraEditors.LookUpEdit editor = sender as DevExpress.XtraEditors.LookUpEdit;

            if (editor.GetSelectedDataRow() is Employees item)
            {
                txtPosition.Text = item.Position;
                txtOffice.Text = item.Offices?.OfficeName;
            }
        }

        private void btnNewPO_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to submit this?", "Submit", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.No)
                return;
            Edit();
            frmEquipmentProfiles.search(this.PPENo);


            this.Close();
        }



        void Edit()
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                unitOfWork.PPEsRepo.Update(new PPEs()
                {
                    Id = PropertyId,
                    EmployeeId = cboEmployeeId.EditValue.ToInt(),
                    OfficeId = cboEmployeeId.EditValue.ToInt(),
                    PropertyNo = txtPropNo.EditValue?.ToString(),
                    EquipmentTypeId = cboEquipmentType.EditValue.ToInt(),
                    Description = txtDescription.Text,
                    DateDelivered = dtPurchaseDate.EditValue?.ToDate(),
                    Serial = txtSerial.Text,
                    Barcode = txtBarcode.Text,
                    BoxNumber = txtBoxNo.Text?.ToInt(),
                    PPEId = txtPropNo.EditValue?.ToString(),
                    DateCreated = dtPurchaseDate.EditValue?.ToDate(),
                    PurchaseDate = dtPurchaseDate.EditValue?.ToDate(),


                });
                unitOfWork.Save();
                this.MethodType = MethodType.Edit;
            }
        }

        void updateProfiles()
        {

        }

        private void btnEditPo_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void frmAddEditEquipmentProfiles_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MethodType == MethodType.Edit)
                return;
            try
            {
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    unitOfWork.PPEsRepo.Delete(m => m.Id == PropertyId);
                    unitOfWork.Save();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void EquipmentGrid_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
        }

        private void EquipmentGrid_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            //   updateProfiles();
            try
            {
                if (e.Row is EquipmentProfiles item)
                {
                    item.Total = (item.QTY ?? 0) * (item.UnitCost ?? 0);
                    if (item.ItemNumber == null)
                    {
                        item.EquipmentName = "\t" + item.EquipmentName.Replace("\t", "");
                        item.Serial = "\t" + item.Serial.Replace("\t", "");
                        item.Description = "\t" + item.Description.Replace("\t", "");
                    }
                    else
                    {
                        this.ItemNumber = item.ItemNumber;
                    }
                    using (UnitOfWork unitOfWork = new UnitOfWork())
                    {
                        item.RefId = PropertyId;
                        item.TableName = "EquipmentProfiles";
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

        public int? ItemNumber { get; set; }


        private void EquipmentGrid_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            //if (EquipmentGrid.GetRow(e.RowHandle) is EquipmentProfiles item)
            //{
            //    if (item.ItemNumber == null)
            //    {
            //        //if (e.Column.Name == "UnitTypeId")
            //        //    e.DisplayText = "\t" + item.UnitTypes?.UnitType;
            //        //else if (e.Column.Name == "EquipmentTypeId")
            //        UnitTypesLookUpRepo.DataSource =
            //            (this.UnitTypeBindingSource.DataSource as List<UnitTypes>).Select(x =>
            //                new { x.Id, UnitType = "\t" + x.UnitType });
            //        //else if (e.Column.Name == "QTY")
            //        //    e.DisplayText = "\t" + item.QTY;
            //        //else if (e.Column.Name == "UnitCost")
            //        //    e.DisplayText = "\t" + item.UnitCost;
            //        //else if (e.Column.Name == "Total")
            //        //    e.DisplayText = "\t" + item.Total;
            //    }
            //}
        }

        private void repositoryItemButtonEdit1_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this profile", "Delete Equipment Profile",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation) == DialogResult.No)
                return;
            try
            {
                if (EquipmentGrid.GetFocusedRow() is EquipmentProfiles item)
                {
                    using (UnitOfWork unitOfWork = new UnitOfWork())
                    {
                        unitOfWork.EquipmentProfilesRepo.Delete(item);
                        unitOfWork.Save();
                        LoadPPEDetails();
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Delete Equipment Profile", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }

        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            Emp.frmEmployees frm = new Emp.frmEmployees();
            frm.ShowDialog();
        }
    }
}