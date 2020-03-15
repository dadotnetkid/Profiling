using System;
using DevExpress.XtraGrid.Views.Grid;
using Models;
using Models.Repository;

namespace Win.MESAF
{
    public partial class frmMES : DevExpress.XtraEditors.XtraForm
    {
        public frmMES()
        {
            InitializeComponent();
        }

        private void frmMES_Load(object sender, EventArgs e)
        {
            ucMES1.GridView.FocusedRowChanged += GridView_FocusedRowChanged;
            ucMES1.Create();
        }

        void Detail()
        {
            if (ucMES1.GridView.GetFocusedRow() is MES item)
            {
                item = new UnitOfWork().MESRepo.Find(m => m.Id == item.Id);
                ucActionGrid1.LoadActions(item.Id, "MES");
                lblMesDescription.Text = item.MESId;
                dtDate.EditValue = item.DateCreated;
                txtEmployee.Text = item.Employees?.EmployeeName;
                txtOffice.Text = item.Offices?.OfficeName;
                txtPosition.Text = item.Position;
                txtItemSpec.Text = item.ItemSpec;
                txtRequest.Text = item.Request;
                lblMesDescription.Text = item.MESId;
                ucActionGrid1.LoadActions(item.Id, "MES");


            }
        }

        private void GridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (sender is GridView gridView)
            {
                Detail();
            }

        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (ucMES1.GridView.GetFocusedRow() is MES item)
            {
                DocAct.frmDocActions frm = new DocAct.frmDocActions("MES", item.Id.ToString("EPiS-00001") + " " + item.ItemSpec, item.Id);
                frm.ShowDialog();
                ucActionGrid1.LoadActions(item.Id, "MES");
            }

        }

        private void btnNewPO_Click(object sender, EventArgs e)
        {
            frmAddEditMES frm = new frmAddEditMES();
            frm.ShowDialog();
            Detail();
        }

        private void btnEditPo_Click(object sender, EventArgs e)
        {
            if (ucMES1.GridView.GetFocusedRow() is MES item)
            {
                item = new UnitOfWork().MESRepo.Find(m => m.Id == item.Id);
                frmAddEditMES frm = new frmAddEditMES(item, MethodType.Edit);
                frm.ShowDialog();
                Detail();

            }
        }
    }
}