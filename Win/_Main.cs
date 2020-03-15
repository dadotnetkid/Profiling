using Syncfusion.Windows.Forms.Tools;
using Syncfusion.WinForms.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Win.Profiles;
using Win.Properties;

namespace Win
{
    public partial class _Main : RibbonForm
    {
        public _Main()
        {
            // RibbonInit();
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //this.Icon = Icon.FromHandle(new Bitmap(Resources.computer_64).GetHicon());
       
        }
        #region Ribbon Init


        void Init()
        {


        }



        
        #endregion

        private void tsBtnDashboard_Click(object sender, EventArgs e)
        {

        }
        void showMdi(SfForm child)
        {


            if ((Application.OpenForms[child.Name]) == null)
            {
                child.MdiParent = this;
                child.Show();
            }
            else
            {

                (Application.OpenForms[child.Name]).WindowState = FormWindowState.Maximized;
                (Application.OpenForms[child.Name]).BringToFront();

            }



        }

       

        private void tsBtnEquipment_Click(object sender, EventArgs e)
        {
         //  showMdi(new frmMachines());
        }

        private void RibbonPanel_Click(object sender, EventArgs e)
        {

        }
    }
}
