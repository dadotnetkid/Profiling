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
using Models;
using Models.Repository;

namespace Win.Sup
{
    public partial class frmSuppliers : DevExpress.XtraEditors.XtraForm
    {
        public frmSuppliers()
        {
            InitializeComponent();
        }

        private void b(object sender, DevExpress.XtraGrid.Views.Printing.PrintRowEventArgs e)
        {

        }

        private void frmSuppliers_Load(object sender, EventArgs e)
        {
            SupplierBindingSource.DataSource = new UnitOfWork().SuppliersRepo.Get();
        }

        private void SupplierGrid_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                if (e.Row is Suppliers suppliers)
                {
                    if (suppliers.Id == 0)
                        unitOfWork.SuppliersRepo.Insert(suppliers);
                    else
                        unitOfWork.SuppliersRepo.Update(suppliers);
                }

                unitOfWork.Save();
            }
        }
    }
}