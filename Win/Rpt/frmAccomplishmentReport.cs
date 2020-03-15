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
using Models.ViewModels;
using Win.Properties;

namespace Win.Rpt
{
    public partial class frmAccomplishmentReport : DevExpress.XtraEditors.XtraForm
    {
        public frmAccomplishmentReport()
        {
            InitializeComponent();
            this.Icon = Resources.search.ToIcon();
        }

        private void frmAccomplishmentReport_Load(object sender, EventArgs e)
        {
            this.StaffBindingSource.DataSource = new UnitOfWork().UsersRepo.Get();

        }

        private void btnNewPO_Click(object sender, EventArgs e)
        {
            if (lookUpEdit1 != null)
            {
                var report = new AccomplishmentReportViewModel()
                {
                    DateFrom = dateEdit1.EditValue.ToDate(),
                    DateTo = dateEdit2.EditValue.ToDate(),
                    UserId = ((Users)lookUpEdit1.GetSelectedDataRow())?.Id
                };
                report.AccomplishmentReport = report.GetAccomplishmentReport();
                frmReportViewer frm = new frmReportViewer()
                {
                    xtraReport = new rptAccomplishmentReport()
                    {
                        DataSource = new List<AccomplishmentReportViewModel>() { report }
                    }
                };

                frm.ShowDialog();
            }
        }

        private void btnEditPo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}