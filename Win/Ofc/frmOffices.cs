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

namespace Win.Ofc
{
    public partial class frmOffices : DevExpress.XtraEditors.XtraForm
    {
        public frmOffices()
        {
            InitializeComponent();
            this.Icon = Resources.home.ToIcon();
        }

        private void frmOffices_Load(object sender, EventArgs e)
        {
            this.OfficeBindingSource.DataSource = new UnitOfWork().OfficesRepo.Get();
            var uc = new ucAddEditOffices();
            this.OfficeGrid.OptionsEditForm.PopupEditFormWidth = uc.Width;
            this.OfficeGrid.OptionsEditForm.CustomEditFormLayout = uc;

        }

        private void OfficeGrid_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    if (e.Row is Offices item)
                    {
                        if (item.Id == 0)
                            unitOfWork.OfficesRepo.Insert(item);
                        else
                            unitOfWork.OfficesRepo.Update(item);

                    }

                    unitOfWork.Save();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        private void OfficeGrid_RowDeleting(object sender, DevExpress.Data.RowDeletingEventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this row", "Deleting", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                if (e.Row is Offices item)
                {
                    unitOfWork.OfficesRepo.Delete(item);

                }

                unitOfWork.Save();
            }

        }

        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void repositoryItemHyperLinkEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            MessageBox.Show("");
        }

        private void repositoryItemButtonEdit1_ButtonClick_1(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {


            if (MessageBox.Show("Do you want to delete this row", "Deleting", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.No)
                return;
            var res = OfficeGrid.GetFocusedRow();
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                if (res is Offices item)
                {
                    unitOfWork.OfficesRepo.Delete(item);

                }

                unitOfWork.Save();
            }
            this.OfficeBindingSource.DataSource = new UnitOfWork().OfficesRepo.Get();

        }

        private void searchControl1_Properties_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnEditPo_Click(object sender, EventArgs e)
        {
            var res = OfficeGrid.GetFocusedRow();
            if (res is Offices item)
            {
                frmAddEditOffices frm = new frmAddEditOffices(item, MethodType.Edit);
                frm.ShowDialog();
                this.OfficeBindingSource.DataSource = new UnitOfWork().OfficesRepo.Get();
            }
        }

        private void searchControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void searchControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.OfficeBindingSource.DataSource =
                    new UnitOfWork().OfficesRepo.Get(m => m.OffcAcr.Contains(searchControl1.Text) || m.OfficeName.Contains(searchControl1.Text));

        }

        private void btnNewPO_Click(object sender, EventArgs e)
        {

            frmAddEditOffices frm = new frmAddEditOffices(null, MethodType.Add);
            frm.ShowDialog();
            this.OfficeBindingSource.DataSource = new UnitOfWork().OfficesRepo.Get();
        }

        private void OfficeGrid_DoubleClick(object sender, EventArgs e)
        {
            btnEditPo.PerformClick();
        }
    }
}