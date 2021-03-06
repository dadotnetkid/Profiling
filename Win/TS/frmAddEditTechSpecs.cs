﻿using System;
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

namespace Win.TS
{
    public partial class frmAddEditTechSpecs : DevExpress.XtraEditors.XtraForm
    {
        public frmAddEditTechSpecs()
        {
            InitializeComponent();
            this.Icon = Resources.maintenance.ToIcon();
        }
        public frmAddEditTechSpecs(WorkOrders workOrders)
        {
            InitializeComponent();
            this.Icon = Resources.maintenance.ToIcon();
            this.workOrders = workOrders;
            //Initialize(workOrders);
        }

        private WorkOrders workOrders;

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
            {
                UnitOfWork uow = new UnitOfWork();
                var res = uow.EquipmentProfilesRepo
                    .Fetch(x => x.RowNumber == null && x.RefId == TechSpecsId && x.TableName == "TechSpecs").Any();
                if (res)
                {
                    var rowNumber = 1;
                    foreach (var i in uow.EquipmentProfilesRepo
                        .Get(x => x.RefId == TechSpecsId && x.TableName == "TechSpecs"))
                    {
                        var eq = uow.EquipmentProfilesRepo.Find(x => x.Id == i.Id);
                        eq.RowNumber = rowNumber;
                        rowNumber++;
                        uow.Save();
                    }

                }
                return;
            }

            try
            {
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    this.TechSpecsId = (unitOfWork.TechSpecsRepo.Fetch().Select(x => new { x.Id }).OrderByDescending(x => x.Id)
                                .FirstOrDefault()?.Id ?? 0) + 1;
                    var ts = new TechSpecs()
                    {
                        Id = TechSpecsId,
                        WorOrderId = workOrders?.Id,
                        Requestedby = workOrders?.RequestedBy,
                        DateRequested = DateTime.Now
                    };
                    unitOfWork.TechSpecsRepo.Insert(ts);
                    unitOfWork.Save();
                    lblTechSpecNo.Text = TechSpecsId.ToString("EPIS-0000");
                    LoadTechSpecs();
                    LoadTechSpecsDetails(ts);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public MethodType MethodType { get; set; }

        public int TechSpecsId { get; set; }
        public frmTechSpecs frmTechSpecs { get; set; }

        public void LoadTechSpecs()
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                this.PPEBindingSource.DataSource = unitOfWork.TechSpecsRepo.Paginate(m => m.OrderBy(x => x.Id), 20, 0);
                this.OfficeBindingSource.DataSource = unitOfWork.OfficesRepo.Get();
                TechSpecsRequestDetailBindingSource.DataSource = new List<TechSpecRequests>();
                this.EquipmentTypeBindingSource.DataSource = unitOfWork.EquipmentTypesRepo.Get();
                this.UnitTypeBindingSource.DataSource = unitOfWork.UnitTypesRepo.Get();
                this.AssignedToBindingSource.DataSource = unitOfWork.UsersRepo.Get();
                this.workOrdersBindingSource.DataSource = unitOfWork.WorkOrdersRepo.Get();
                this.EquipmentProfileBindingSource.DataSource = new List<EquipmentProfiles>();
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
                this.EquipmentProfileBindingSource.DataSource =
                    new UnitOfWork().EquipmentProfilesRepo.Get(m => m.RefId == item.Id && m.TableName == "TechSpecs", orderBy: x => x.OrderBy(m => m.RowNumber));
                new UnitOfWork().DocActionsRepo.Get(m => m.RefId == item.Id && m.TableName == "TechSpecs");
                var unitOfWork = new UnitOfWork();
                lblTechSpecNo.Text = item.Id.ToString("EPIS-0000");
                this.TechSpecsRequestDetailBindingSource.DataSource = unitOfWork.TechSpecRequestsRepo.Get(m => m.TechSpecsId == item.Id);
                item = unitOfWork.TechSpecsRepo.Find(x => x.Id == item.Id);
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
                lblWONo.Text = item.WorkOrders?.WorkOrderId;
                cboWO.EditValue = item.WorOrderId;
                this.EquipmentProfileBindingSource.DataSource = unitOfWork.EquipmentProfilesRepo.Get(m => m.RefId == item.Id && m.TableName == "TechSpecs", orderBy: x => x.OrderBy(m => m.RowNumber));
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Load Tech Specs Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        private void cboOffice_EditValueChanged(object sender, EventArgs e)
        {
            if (sender is SearchLookUpEdit gridLookUp)
            {
                if (gridLookUp.GetSelectedDataRow() is Offices item)
                {
                    txtChief.Text = item.Chief;
                    txtTel.Text = item.TelNo;
                    this.EmployeeBindingSource.DataSource = item.Employees.ToList();
                }
            }
        }

        private void cboEmployeeId_EditValueChanged(object sender, EventArgs e)
        {
            if (sender is SearchLookUpEdit gridLookUp)
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
                    //var workOrder = new TechSpecs()
                    //{
                    //    Id = TechSpecsId,
                    //    Requestedby = cboEmployeeId.EditValue.ToInt(),
                    //    DateRequested = dtDateRequest.EditValue.ToDate(),
                    //    AssignedTo = cboAssignedTo.EditValue?.ToString(),

                    //};

                    var techSpecs = unitOfWork.TechSpecsRepo.Find(x => x.Id == TechSpecsId);
                    techSpecs.Requestedby = cboEmployeeId.EditValue?.ToInt();
                    techSpecs.DateRequested = dtDateRequest.EditValue?.ToDate();
                    techSpecs.AssignedTo = cboAssignedTo.EditValue?.ToString();
                    techSpecs.WorOrderId = cboWO.EditValue?.ToInt();
                    //unitOfWork.TechSpecsRepo.Update(techSpecs);
                    unitOfWork.Save();
                    unitOfWork.TechSpecRequestsRepo.DeleteRange(m =>
                        m.TechSpecsId == TechSpecsId && m.ItemNumber == null);
                    unitOfWork.Save();
                    foreach (var i in unitOfWork.EquipmentProfilesRepo.Get(m =>
                        m.RefId == TechSpecsId && m.TableName == "TechSpecs",x=>x.OrderBy(m=>m.RowNumber)))
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

            EquipmentProfileBindingSource.DataSource =
                new UnitOfWork().EquipmentProfilesRepo.Get(m => m.RefId == TechSpecsId && m.TableName == "TechSpecs");
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
                this.EmployeeBindingSource.DataSource = new UnitOfWork().EmployeesRepo.Get(m => m.OfficeId == office.Id);
        }

        private void cboEquipmentType_Properties_ProcessNewValue(object sender, DevExpress.XtraEditors.Controls.ProcessNewValueEventArgs e)
        {
            try
            {
                if (MessageBox.Show(this, "Add the '" + e.DisplayValue.ToString() + "' entry to the list?",
                        "Confirm", MessageBoxButtons.YesNo) == DialogResult.No && (string)e.DisplayValue == String.Empty)
                    return;

                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    unitOfWork.EquipmentTypesRepo.Insert(new EquipmentTypes()
                    {
                        EquipmentType = e.DisplayValue.ToString()
                    });
                    unitOfWork.Save();
                    EquipmentTypeBindingSource.DataSource = unitOfWork.EquipmentTypesRepo.Get();
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void gridTechSpecRequest_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {
                if (e.Row is TechSpecRequests item)
                {


                    using (UnitOfWork unitOfWork = new UnitOfWork())
                    {
                        item.TechSpecsId = TechSpecsId;
                        if (item.Id == 0)
                        {
                            item.DateCreated = DateTime.Now;
                            item.CreatedBy = User.UserId;
                            unitOfWork.TechSpecRequestsRepo.Insert(item);
                            unitOfWork.Save();
                        }
                        else
                        {
                            unitOfWork.TechSpecRequestsRepo.Update(item);
                            unitOfWork.Save();
                        }
                    }

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Update Tech Specs Details", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        private void btnDeleteTechSpecsRequestDetails_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (!User.UserInAction("Delete Tech Spec Request Details"))
                return;

            if (MessageBox.Show("Do you want to delete this", "Deleting", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.No)
                return;
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                var eP = this.gridTechSpecRequest.GetFocusedRow() as TechSpecRequests;
                if (eP == null)
                    return;
                unitOfWork.TechSpecRequestsRepo.Delete(m => m.Id == eP.Id);
                unitOfWork.Save();
            }

            TechSpecsRequestDetailBindingSource.DataSource =
                new UnitOfWork().TechSpecRequestsRepo.Get(m => m.TechSpecsId == TechSpecsId);
            gridTechSpecRequest.RefreshData();
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

        private void TechSpecReqEquipmentTypeRepo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                new frmSearchTechSpecDetail(this.TechSpecsId).ShowDialog();
                LoadTechSpecsDetails(new UnitOfWork().TechSpecsRepo.Find(m => m.Id == TechSpecsId));
            }
        }

        private void EquipmentGrid_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        {
            var index = e.FocusedColumn.AbsoluteIndex;

        }

        private void cboWO_EditValueChanged(object sender, EventArgs e)
        {
            lblWONo.Text = cboWO.Text;
        }

        private void addTopRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (EquipmentGrid.GetFocusedRow() is EquipmentProfiles item)
                {
                    UnitOfWork unitOfWork = new UnitOfWork();
                    var rowNumber = item.RowNumber;
                    foreach (var i in unitOfWork.EquipmentProfilesRepo.Get(x => x.RefId == item.RefId && x.TableName == "TechSpecs" && x.RowNumber >= rowNumber))
                    {
                        var eq = unitOfWork.EquipmentProfilesRepo.Find(x => x.Id == i.Id);
                        eq.RowNumber = i.RowNumber + 1;
                        unitOfWork.Save();
                    }

                    unitOfWork = new UnitOfWork();
                    unitOfWork.EquipmentProfilesRepo.Insert(new EquipmentProfiles() { RefId = TechSpecsId, TableName = "TechSpecs", RowNumber = rowNumber, ParentItem = item.ParentItem });
                    unitOfWork.Save();

                    this.EquipmentProfileBindingSource.DataSource = unitOfWork.EquipmentProfilesRepo.Get(m => m.RefId == TechSpecsId && m.TableName == "TechSpecs", orderBy: x => x.OrderBy(m => m.RowNumber));
                }

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private void addBottomRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (EquipmentGrid.GetFocusedRow() is EquipmentProfiles item)
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                var rowNumber = item.RowNumber + 1;
                foreach (var i in unitOfWork.EquipmentProfilesRepo.Get(x => x.RefId == item.RefId && x.TableName == "TechSpecs" && x.RowNumber >= rowNumber))
                {
                    var eq = unitOfWork.EquipmentProfilesRepo.Find(x => x.Id == i.Id);
                    eq.RowNumber = i.RowNumber + 1;
                    unitOfWork.Save();
                }

                unitOfWork = new UnitOfWork();
                unitOfWork.EquipmentProfilesRepo.Insert(new EquipmentProfiles() { RefId = TechSpecsId, TableName = "TechSpecs", RowNumber = rowNumber, ParentItem = item.ParentItem });
                unitOfWork.Save();

                this.EquipmentProfileBindingSource.DataSource = unitOfWork.EquipmentProfilesRepo.Get(m => m.RefId == TechSpecsId && m.TableName == "TechSpecs", orderBy: x => x.OrderBy(m => m.RowNumber));
            }
        }
    }
}