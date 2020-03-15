using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Models.ViewModels;

namespace Win.Rpt
{
    public partial class rptDocumentLedger : DevExpress.XtraReports.UI.XtraReport
    {
        public rptDocumentLedger()
        {
            InitializeComponent();
            this.BeforePrint += rptDocumentLedger_BeforePrint;
        }

        private void rptDocumentLedger_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xrLabel2.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy");
        }
    }
}
