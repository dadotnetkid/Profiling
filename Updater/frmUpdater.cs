using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using Updater.Properties;

namespace Updater
{
    public partial class frmUpdater : Form
    {
        private List<FileViewModel> updateFiles;
        private List<FileViewModel> installedFiles;
        private int progressCount = 0;
        private string programPath => @"C:\Program Files (x86)\PLGU-IT\Profiling";

        public frmUpdater()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            LoadFiles();
        }

        void LoadFiles()
        {
            try
            {
                var updatePath = @"\\PLGUNV_ADSERVER\c$\Installers\Updates";
                if (!Directory.Exists(programPath))
                    Directory.CreateDirectory(programPath);

                NetworkCredential theNetworkCredential = new NetworkCredential("administrator", "Itpower@123");
                CredentialCache theNetcache = new CredentialCache();
                theNetcache.Add(new Uri(updatePath), "Basic", theNetworkCredential);
                this.updateFiles = System.IO.Directory.EnumerateFiles(updatePath, "*.*", SearchOption.AllDirectories).Select(x =>
                    new FileViewModel
                    {
                        FileName = Path.GetFileName(x),
                        File = x,
                        DateCreated = File.GetLastWriteTime(x)
                    }).ToList();
                this.installedFiles = System.IO.Directory.EnumerateFiles(programPath, "*.*", SearchOption.AllDirectories).Select(x =>
                    new FileViewModel
                    {
                        FileName = Path.GetFileName(x),
                        File = x,
                        DateCreated = File.GetLastWriteTime(x),
                        path = Path.GetFullPath(x)
                    }).ToList();
                lblupdateFiles.Text = $"Updated Files: {updateFiles.Count() } and Installed Files: { installedFiles.Count()}";
                this.progressBar1.Maximum = updateFiles.Count();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (!Directory.Exists(programPath))
                Directory.CreateDirectory(programPath);
            foreach (var _updateFile in updateFiles)
            {
                var _installedFiles = installedFiles.Find(x => x.FileName == _updateFile.FileName);
                if (_updateFile != null)
                {
                    if (_installedFiles == null)
                    {
                        File.Copy(_updateFile.File, Path.Combine(programPath, _updateFile.FileName), true);
                    }
                    else if (_updateFile.DateCreated > _installedFiles.DateCreated)
                    {
                        File.Copy(_updateFile.File, _installedFiles.File, true);
                    }
                }

                this.progressCount++;
                Invoke(new Action(() => { progressBar1.Increment(progressCount); }));
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressCount = 0;
            this.Hide();
            this.notifyIcon1.ShowBalloonTip(100, "Update Completed", "Update",ToolTipIcon.Info);
        }
    }
}