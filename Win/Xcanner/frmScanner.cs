using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.RichEdit.Export;
using DevExpress.XtraEditors;
using Helpers;
using Models.Repository;
using Models.ViewModels;
using Win.PO;
using Win.Properties;


namespace Win.Xcanner
{
    public partial class frmScanner : DevExpress.XtraEditors.XtraForm
    {
        private Scanners Scanners = new Scanners();
        public frmScanner(Action<Scanners> scanner)
        {
            InitializeComponent();
            this.Icon = Resources.search.ToIcon();
            scanner(Scanners);
        }



        private void btnScan_Click(object sender, EventArgs e)
        {


            var res = new frmListOfScanner().ShowDialogResult() as frmListOfScanner; 
            this.pictureEdit1.Image = res.scanImage;
            Scanners.ScanImage = res.scanImage;
        }


        private void frmScanPO_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                Scanners.ImageId = Guid.NewGuid().ToString();
                var updatePath = @"\\PLGUNV_ADSERVER\c$\Installers\Profiling\Profiling_Data\Scanned Documents";
                //NetworkCredential theNetworkCredential = new NetworkCredential("administrator", "Itpower@123");
                //CredentialCache theNetcache = new CredentialCache();
                //theNetcache.Add(new Uri(updatePath), "Basic", theNetworkCredential);

                using (NetworkShareAccesser.Access("PLGUNV_ADSERVER", @"PLGUNV", "administrator", "itpower@123"))
                {
                    this.pictureEdit1.Image.Save(Path.Combine(updatePath, Scanners.ImageId + ".png"));
                }


                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    unitOfWork.DocumentsRepo.Insert(new Models.Documents()
                    {
                        FileId = Scanners.ImageId,
                        ExtName = ".png",
                        RootDirectory = updatePath,
                        TableName = Scanners.TableName,
                        RefId = Scanners.RefId,
                        CreatedBy = User.UserId,
                        FileSize = new FileInfo(Path.Combine(updatePath, Scanners.ImageId + ".png")).Length,
                        DocumentDescription = memoExEdit1.Text,
                        DateCreated = DateTime.Now
                    });
                    unitOfWork.Save();
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }


    }
}