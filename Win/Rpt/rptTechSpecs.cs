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
            xrTableCell14.BeforePrint += xrTableCell14_BeforePrint;
            lblHead.BeforePrint += LblHead_BeforePrint;
            lblPosition.BeforePrint += LblPosition_BeforePrint;
            lblStaff.BeforePrint += LblStaff_BeforePrint;
            lblStaffPos.BeforePrint += LblStaffPos_BeforePrint;
        }

        private void LblStaffPos_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            lblStaffPos.Text = lblStaffPos.Text.ToSentenceCase();
        }

    

        private void LblStaff_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            lblStaff.Text = lblStaff.Text.ToSentenceCase();
        }

        private void LblPosition_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            lblPosition.Text = lblPosition.Text.ToSentenceCase();
        }

        private void LblHead_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            lblHead.Text = lblHead.Text.ToSentenceCase();
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
