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
using Models.Repository;
using Win.Properties;

namespace Win.PO
{
    public partial class _frmAddEditActions : DevExpress.XtraEditors.XtraForm
    {
        public _frmAddEditActions()
        {
            InitializeComponent();
            this.Icon = Resources.action_16.ToIcon();
        }

        private void btnNewPO_Click(object sender, EventArgs e)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                unitOfWork.DocActionsRepo.Insert(new Models.DocActions()
                {
                    ActionTaken = txtAction.Text,
                    ActionDate = dtActionDate.EditValue.ToDate(),
                    RefId = this.PurchaseId,
                    Status = txtRemarks.Text,
                    TableName = "PurchaseOrders"

                });
                unitOfWork.Save();
            }

            this.frmPurchaseOrders.LoadActionActions();
            this.Close();
        }

        public int? PurchaseId { get; set; }
        public _frmPurchaseOrders frmPurchaseOrders { get; set; }

        private void btnEditPo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddEditActions_Load(object sender, EventArgs e)
        {
            this.dtActionDate.Text = DateTime.Now.ToString();
        }
    }
}