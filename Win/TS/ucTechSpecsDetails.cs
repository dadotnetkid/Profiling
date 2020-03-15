using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Models;
using Models.Repository;

namespace Win.TS
{
    public partial class ucTechSpecsDetails : DevExpress.XtraEditors.XtraUserControl
    {
        public ucTechSpecsDetails()
        {
            InitializeComponent();
        }

        public void Details(TechSpecs item)
        {
            OfficeBindingSource.DataSource = new UnitOfWork().OfficesRepo.Get();
            EmployeeBindingSource.DataSource = new UnitOfWork().EmployeesRepo.Get();
            new UnitOfWork().EquipmentProfilesRepo.Get(m => m.RefId == item.Id && m.TableName == "TechSpecs");
            //this.ActionGridControl.DataSource =
            //    new UnitOfWork().DocActionsRepo.Get(m => m.RefId == item.Id && m.TableName == "TechSpecs");
            var unitOfWork = new UnitOfWork();
            //lblPODescription.Text = item.Id + " - " + item.EquipmentTypes?.EquipmentType;


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


            //this.ActionGridControl.DataSource =
            //    unitOfWork.DocActionsRepo.Get(m => m.RefId == item.Id && m.TableName == "TechSpecs");
            this.TechSpecsRequestDetailBindingSource.DataSource = unitOfWork.TechSpecRequestsRepo.Get(m => m.TechSpecsId == item.Id);
            this.DocumentBindingSource.DataSource =
                unitOfWork.DocumentsRepo.Get(m => m.RefId == item.Id && m.TableName == "TechSpecs");
        }




    }
}
