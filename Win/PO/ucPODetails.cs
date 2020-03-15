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

namespace Win.PO
{
    public partial class ucPODetails : DevExpress.XtraEditors.XtraUserControl,IUserControl<PurchaseOrders>
    {
        public int PoId { get; set; }
        public ucPODetails()
        {
            InitializeComponent();
        }
        

        private void ucPODetails_Load(object sender, EventArgs e)
        {

        }

        public void CreateUcControl(int Id)
        {
            throw new NotImplementedException();
        }

        public void CreateUcControl()
        {
         
           
        }

        public void Details(PurchaseOrders item)
        {
            txtPropNo.Text = item.Id.ToString("PO-0000");

            cboOffice.EditValue = item?.OfficeId;
            txtChief.Text = item.Offices?.Chief;
            txtTel.Text = item.Offices?.TelNo;
            cboEmployeeId.EditValue = item.EmployeeId;
            txtPosition.Text = item.Employees?.Position;
            txtOffice.Text = item.Employees?.Offices?.OfficeName;
            txtDescription.Text = item.Description;
            cboEquipmentType.EditValue = item.EquipmentTypeId;
            cboSupplierId.EditValue = item.SupplierId;
        }


      

        public void Details(int Id)
        {
            throw new NotImplementedException();
        }

        public void Details(int id, string tableName)
        {
            throw new NotImplementedException();
        }

        public void Search(string search)
        {
            throw new NotImplementedException();
        }
    }
}
