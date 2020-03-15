using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using Helpers;
using Models.ViewModels;
using WIA;
using Win.Properties;

namespace Win.Xcanner
{
    public partial class frmListOfScanner : DevExpress.XtraEditors.XtraForm
    {
        private List<string> ListOfString = new List<string>();
        private List<ScannerViewModels> Devices = new List<ScannerViewModels>();
        public Image scanImage;
        private frmLoading frmLoading;

        public frmListOfScanner()
        {
            InitializeComponent();
            this.Icon = Resources.search.ToIcon();
        }


        private void frmListOfScanner_Load(object sender, EventArgs e)
        {

            SplashScreenManager.ShowForm(this, typeof(frmLoading), true, true, SplashFormStartPosition.Default, new Point(0, 0), ParentFormState.Locked);
            BackgroundWorker scannerbg = new BackgroundWorker();
            scannerbg.DoWork += ScannerBg_DoWork;
            scannerbg.RunWorkerCompleted += ScannerBg_RunWorkerCompleted;
            scannerbg.RunWorkerAsync();
        }

        private void ScannerBg_DoWork(object sender, DoWorkEventArgs e)
        {
            ListOfDevices();
        }

        private void ScannerBg_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            SplashScreenManager.CloseForm();
            this.lookUpEdit1.Properties.DataSource = this.Devices;
        }



        void ListOfDevices()
        {
            try
            {
                var deviceManager = new DeviceManager();



                for (int i = 1; i <= deviceManager.DeviceInfos.Count; i++) // Loop Through the get List Of Devices.
                {
                    if (deviceManager.DeviceInfos[i].Type != WiaDeviceType.ScannerDeviceType) // Skip device If it is not a scanner
                    {
                        continue;
                    }

                    this.Devices.Add(new ScannerViewModels()
                    {
                        Id = i,
                        ScannerName = deviceManager.DeviceInfos[i].Properties["Name"].get_Value()

                    });
                }
                if (deviceManager.DeviceInfos.Count <= 0)
                    throw new COMException("No Device found");

            }
            catch (COMException ex)
            {
                Invoke(new Action(() =>
                {
                    MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }));
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.frmLoading = new frmLoading();
        
            BackgroundWorker bg = new BackgroundWorker();
            bg.DoWork += Bg_DoWork;
            bg.RunWorkerCompleted += Bg_RunWorkerCompleted;
            bg.RunWorkerAsync();
            this.frmLoading.ShowDialog();
        }

        private void Bg_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.frmLoading.Close();
            this.Close();
        }

        private void Bg_DoWork(object sender, DoWorkEventArgs e)
        {
            DoWork();
        }

        void DoWork()
        {
            var deviceManager = new DeviceManager();

            DeviceInfo AvailableScanner = null;

            //for (int i = 1; i <= deviceManager.DeviceInfos.Count; i++) // Loop Through the get List Of Devices.
            //{
            //    if (deviceManager.DeviceInfos[i].Type != WiaDeviceType.ScannerDeviceType) // Skip device If it is not a scanner
            //    {
            //        continue;
            //    }

            //    AvailableScanner = deviceManager.DeviceInfos[i];

            //    break;
            //}
            var selectedDevice = lookUpEdit1.GetSelectedDataRow() as ScannerViewModels;
            AvailableScanner = deviceManager.DeviceInfos[selectedDevice.Id];
            var device = AvailableScanner.Connect(); //Connect to the available scanner.

            var ScanerItem = device.Items[1]; // select the scanner.

            var imgFile = (ImageFile)ScanerItem.Transfer(); //Retrive an image in Jpg format and store it into a variable.
            this.scanImage = Image.FromStream(new MemoryStream((byte[])imgFile.FileData.get_BinaryData()));

        }
    }
}