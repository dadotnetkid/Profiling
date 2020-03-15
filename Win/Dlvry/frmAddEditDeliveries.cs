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

namespace Win.Dlvry
{
    public partial class frmAddEditDeliveries : DevExpress.XtraEditors.XtraForm
    {
        public frmAddEditDeliveries()
        {
            InitializeComponent();
            this.Icon = Resources.maintenance.ToIcon();
        }

        private void frmAddEditTechSpecs_Load(object sender, EventArgs e)
        {
            Initialize();
            LoadTechSpecs();
            if (MethodType == MethodType.Edit)
                LoadTechSpecsDetails(new UnitOfWork().TechSpecsRepo.Find(m => m.Id == TechSpecsId));
        }
        public void Initialize()
        {
            this.dtDateRequest.EditValue = DateTime.Now;

            if (MethodType == MethodType.Edit)
                return;

            try
            {
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    this.TechSpecsId = (unitOfWork.TechSpecsRepo.Fetch().Select(x => new { x.Id }).OrderByDescending(x => x.Id)
                                .FirstOrDefault()?.Id ?? 0) + 1;
                    unitOfWork.TechSpecsRepo.Insert(new TechSpecs() { Id = TechSpecsId });
                    unitOfWork.Save();
                    lblTechSpecNo.Text = TechSpecsId.ToString("EPIS-0000");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public MethodType MethodType { get; set; }

        public int TechSpecsId { get; set; }
        public frmDeliveries frmTechSpecs { get; set; }

        public void LoadTechSpecs()
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
           
                this.cboAssignedTo.EditValue = User.UserId;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Load Tech Specs", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }
        void LoadTechSpecsDetails(TechSpecs item)
        {

            try
            {
         
                new UnitOfWork().DocActionsRepo.Get(m => m.RefId == item.Id && m.TableName == "TechSpecs");
                var unitOfWork = new UnitOfWork();
                lblTechSpecNo.Text = item.Id.ToString("EPIS-0000");

                cboOffice.EditValue = item?.Employees?.OfficeId;
                txtChief.Text = item?.Employees?.Offices?.Chief;
                txtTel.Text = item?.Employees?.Offices?.Chief;
                cboEmployeeId.EditValue = item?.Employees?.Id;
                txtPosition.Text = item.Employees?.Position;
                cboOffice.EditValue = item.Employees?.Offices?.Id;
                txtTel.Text = item.Employees?.Offices?.TelNo;
                txtChief.Text = item.Employees?.Offices?.Chief;
                cboAssignedTo.EditValue = item.AssignedTo;
                dtDateRequest.EditValue = item.DateRequested;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Load Tech Specs Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        private void cboOffice_EditValueChanged(object sender, EventArgs e)
        {
            if (sender is GridLookUpEdit gridLookUp)
            {
                if (gridLookUp.GetSelectedDataRow() is Offices item)
                {
                    txtChief.Text = item.Chief;
                    txtTel.Text = item.TelNo;
                }
            }
        }

        private void cboEmployeeId_EditValueChanged(object sender, EventArgs e)
        {
            if (sender is GridLookUpEdit gridLookUp)
            {
                if (gridLookUp.GetSelectedDataRow() is Employees item)
                {
                    txtPosition.Text = item.Position;
                }
            }
        }


        private void btnNewPO_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to submit this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            try
            {
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    var workOrder = new TechSpecs()
                    {
                        Id = TechSpecsId,
                        Requestedby = cboEmployeeId.EditValue.ToInt(),
                        DateRequested = dtDateRequest.EditValue.ToDate(),
                        AssignedTo = cboAssignedTo.EditValue.ToString(),

                    };
                    unitOfWork.TechSpecsRepo.Update(workOrder);
                    unitOfWork.Save();
                    unitOfWork.TechSpecRequestsRepo.DeleteRange(m =>
                        m.TechSpecsId == TechSpecsId && m.ItemNumber == null);
                    unitOfWork.Save();
                    foreach (var i in unitOfWork.EquipmentProfilesRepo.Get(m =>
                        m.RefId == TechSpecsId && m.TableName == "TechSpecs"))
                    {
                        if (i.ItemNumber != null)
                            this.ItemNumber = i.ItemNumber;
                        else
                        {
                            i.ParentItem = this.ItemNumber;
                        }

                        unitOfWork.EquipmentProfilesRepo.Update(i);
                        unitOfWork.Save();
                    }


                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MethodType = MethodType.Edit;

            this.Close();
        }

        private void frmAddEditTechSpecs_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MethodType == MethodType.Edit)
                return;
            try
            {
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    unitOfWork.EquipmentProfilesRepo.DeleteRange(m => m.RefId == TechSpecsId && m.TableName == "TechSpecs");
                    unitOfWork.TechSpecsRepo.Delete(TechSpecsId);
                    unitOfWork.Save();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnEditPo_Click(object sender, EventArgs e)
        {
            this.Close();
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
                        else
                        {

                            item.ParentItem = ItemNumber;
                        }
                        item.RefId = TechSpecsId;
                        item.TableName = "TechSpecs";

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

        public int? ItemNumber { get; set; }


        private void repositoryItemButtonEdit1_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (!User.UserInAction("Delete Tech Spec"))
                return;

            if (MessageBox.Show("Do you want to delete this", "Deleting", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.No)
                return;
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                var eP = this.EquipmentGrid.GetFocusedRow() as EquipmentProfiles;
                if (eP == null || eP?.Id == null)
                    return;
                try
                {
                    unitOfWork.EquipmentProfilesRepo.Delete(m => m.Id == eP.Id && m.TableName == "TechSpecs");
                    unitOfWork.Save();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            EquipmentGrid.RefreshData();
        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            frmAddEditEmployees frm = new frmAddEditEmployees();
            frm.ShowDialog();
            if (cboOffice.GetSelectedDataRow() is Offices office)
            {
      
            }
        }

      
      
      

        private void frmAddEditTechSpecs_Activated(object sender, EventArgs e)
        {
            cboOffice.Focus();
        }

        private void TechSpecReqEquipmentTypeRepo_Leave(object sender, EventArgs e)
        {
            if (sender is LookUpEdit lookUpEdit)
            {
                var req = lookUpEdit.EditValue;

            }
        }

      

        private void EquipmentGrid_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        {
            var index = e.FocusedColumn.AbsoluteIndex;

        }
    }
}