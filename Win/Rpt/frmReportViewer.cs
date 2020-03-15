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
using DevExpress.XtraReports.UI;
using Models.ViewModels;

namespace Win.Rpt
{
    public partial class frmReportViewer : DevExpress.XtraEditors.XtraForm
    {
        public frmReportViewer()
        {
            InitializeComponent();
        }

        public frmReportViewer(XtraReport xtraReport)
        {
            InitializeComponent();
            this.xtraReport = xtraReport;
        }

        public object DataSource { get; set; }
        public XtraReport xtraReport;
        private void frmReportViewer_Load(object sender, EventArgs e)
        {
            xtraReport.CreateDocument();
            this.documentViewer1.DocumentSource = xtraReport;
            this.documentViewer1.Refresh();
        }
    }
}