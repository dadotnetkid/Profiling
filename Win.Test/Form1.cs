using Models;
using Models.Repository;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Win.Test.UC;

namespace Win.Test
{
    public partial class Form1 : Form
    {
        UnitOfWork unitOfWork = new UnitOfWork();
        public Form1()
        {
            InitializeComponent(); RibbonInit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (var i = 0; i <= 10; i++)
            {
                var ucToken = new ucToken();
                ucToken.SetText("asdasd " + i);
                flowLayoutPanel1.Controls.Add(ucToken);
            }


        }

        #region Ribbon Init
        private Syncfusion.Windows.Forms.Tools.RibbonControlAdv ribbonControlAdv1;
        void RibbonInit()
        {
            this.ribbonControlAdv1 = new RibbonControlAdv();
            this.ribbonControlAdv1.RibbonStyle = RibbonStyle.Office2016;
            this.Controls.Add(ribbonControlAdv1);
        }
        #endregion

        private void Form1_Activated(object sender, EventArgs e)
        {
            var list = new List<Employees>() { new Employees() { FirstName = "hell", MiddleName = "xdf", LastName = "asdfasdf" } };

        }
    }
}
