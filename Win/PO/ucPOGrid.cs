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
    public partial class ucPOGrid : DevExpress.XtraEditors.XtraUserControl,IUserControl<PurchaseOrders>
    {
        public ucPOGrid()
        {
            InitializeComponent();
        }

        private void ucPOGrid_Load(object sender, EventArgs e)
        {

        }
       
        private void POGrid_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.Name == "WorkOrderId")
            {
                if (POGrid.GetRow(e.RowHandle) is WorkOrders item)
                {
                    //     if (item.WOActions.OrderByDescending(m => m.Id)?.FirstOrDefault()?.Status == "")
                    var status = item.DocActions.OrderByDescending(m => m.Id)?.FirstOrDefault()?.Status;
                    var customValue = new UnitOfWork().StatusesRepo.Find(m => m.Value == status && m.TableName == "Status")?.CustomValue;
                    var color = System.Drawing.ColorTranslator.FromHtml(customValue);
                    e.Appearance.BackColor = color;
                }
            }
        }
        private void repositoryItemButtonEdit2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (!User.UserInAction("Delete Purchase Order"))
                return;
            if (MessageBox.Show("Do you want to delete this", "Deleting", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.No)
                return;
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                var po = POGrid.GetFocusedRow() as PurchaseOrders;
                unitOfWork.PurchaseOrdersRepo.Delete(po?.Id);
                unitOfWork.Save();
            }

            this.CreateUcControl();
            POGrid.RefreshData();
        }

        public void CreateUcControl(int Id)
        {
            throw new NotImplementedException();
        }

        public void CreateUcControl()
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            this.POBindingSource.DataSource = unitOfWork.PurchaseOrdersRepo.Get();
        }

        public void Details(PurchaseOrders item)
        {
            throw new NotImplementedException();
        }

        public void Details<TEntity>(TEntity entity)
        {
            throw new NotImplementedException();
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
