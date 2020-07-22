using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Helpers;

namespace Win.Rpt
{
    public partial class rptTechSpecs : DevExpress.XtraReports.UI.XtraReport
    {
        public rptTechSpecs()
        {
            InitializeComponent();
        }


        private void xrTableCell14_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRLabel label = (XRLabel)sender;
            //     string unitType = GetCurrentColumnValue("UnitType").ToString();
            label.Font = new Font(label.Font, FontStyle.Regular);
            if (label.Text.Contains("<b>"))
            {
                label.Text = label.Text.Replace("<b>", "");
                label.Font = new Font(label.Font, FontStyle.Bold);
            }
        }


    }
}
