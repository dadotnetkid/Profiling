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

namespace Win.DocAct
{
    public partial class FrmAddEditPrograms : DevExpress.XtraEditors.XtraForm
    {
        public FrmAddEditPrograms()
        {
            InitializeComponent();
        }

        private void btnNewPO_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Do you want to submit this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            add(new Dropdowns()
            {
                Category = "Programs",
                Value = txtValue.Text,
                Order = txtOrder.EditValue?.ToInt()
            });
        }
        void add(Dropdowns item)
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                item.Value = txtValue.Text;
                item.Order = txtOrder.EditValue?.ToInt();
                unitOfWork.DropdownsRepo.Insert(item);
                unitOfWork.Save();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}