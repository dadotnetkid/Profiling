using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Models.ViewModels;

namespace Win.Rpt
{
    public partial class rptAccomplishmentReport : DevExpress.XtraReports.UI.XtraReport
    {
        public rptAccomplishmentReport()
        {
            InitializeComponent();
            this.BeforePrint += RptAccomplishmentReport_BeforePrint;
        }

        private void RptAccomplishmentReport_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
           
        }
    }
}
