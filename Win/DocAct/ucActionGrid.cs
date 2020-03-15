using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Models;
using Models.Repository;

namespace Win.DocAct
{
    public partial class ucActionGrid : DevExpress.XtraEditors.XtraUserControl
    {
        private int id;
        private string tableName;

        public ucActionGrid()
        {
            InitializeComponent();
            BackgroundWorker bg = new BackgroundWorker();
            bg.DoWork += Bg_DoWork;
            bg.RunWorkerAsync();
        }

        private void Bg_DoWork(object sender, DoWorkEventArgs e)
        {
            InitializeBindings();
        }

        public void LoadActions(int id, string tableName)
        {
            this.id = id;
            this.tableName = tableName;
            this.ActionGridControl.DataSource = new UnitOfWork().DocActionsRepo.Get(m => m.RefId == id && m.TableName == tableName);
        }
        void InitializeBindings()
        {

            var unitOfWork = new UnitOfWork();
            if (this.InvokeRequired)
            {
                Invoke(new Action(() =>
                {
                    this.ProgramLookUpRepo.DataSource = unitOfWork.DropdownsRepo.Get(m => m.Category == "Programs");
                    this.MainActLookUpRepo.DataSource = unitOfWork.DropdownsRepo.Get(m => m.Category == "Projects");
                    this.ActivityLookUpRepo.DataSource = unitOfWork.DropdownsRepo.Get(m => m.Category == "Activity");
                    this.SubActLookUpRepo.DataSource = unitOfWork.DropdownsRepo.Get(m => m.Category == "SubActivity");
                }));

            }
            else
            {
                this.ProgramLookUpRepo.DataSource = unitOfWork.DropdownsRepo.Get(m => m.Category == "Programs");
                this.MainActLookUpRepo.DataSource = unitOfWork.DropdownsRepo.Get(m => m.Category == "Projects");
                this.ActivityLookUpRepo.DataSource = unitOfWork.DropdownsRepo.Get(m => m.Category == "Activity");
                this.SubActLookUpRepo.DataSource = unitOfWork.DropdownsRepo.Get(m => m.Category == "SubActivity");
            }

        }

        private void btnEditRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (ActionGrid.GetFocusedRow() is DocActions item)
            {
                frmDocActions frm = new frmDocActions(item, "", item.RefId) { MethodType = MethodType.Edit };
                frm.ShowDialog();
            }


        }

        private void btnDelRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            try
            {
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    if (ActionGrid.GetFocusedRow() is DocActions item)
                    {
                        unitOfWork.DocActionsRepo.Delete(m => m.Id == item.Id);
                        unitOfWork.Save();
                    }
                    this.ActionGridControl.DataSource = unitOfWork.DocActionsRepo.Get(m => m.RefId == id && m.TableName == tableName);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
