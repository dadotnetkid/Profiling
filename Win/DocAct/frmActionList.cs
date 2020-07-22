using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Models;
using Models.Repository;
using Models.Interfaces;

namespace Win.DocAct
{
    public partial class frmActionList : DevExpress.XtraEditors.XtraForm, ITransaction<ActionLists>
    {
        public frmActionList()
        {
            InitializeComponent();
            Init();
        }

        private void btnDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (ActionListGridView.GetFocusedRow() is ActionLists item)
                {
                    UnitOfWork unitOfWork = new UnitOfWork();
                    unitOfWork.ActionListsRepo.Delete(m => m.Id == item.Id);
                    unitOfWork.Save();
                    Init();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Search(string search)
        {
            throw new NotImplementedException();
        }

        public void Init()
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                this.ActionListGridControl.DataSource = new BindingList<ActionLists>(unitOfWork.ActionListsRepo.Get());
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Details()
        {
            throw new NotImplementedException();
        }

        public void Details(ActionLists item)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {

        }

        private void ActionListGridView_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                if (e.Row is ActionLists item)
                {
                    if (item.Id == 0)
                    {
                        item.DateCreated = DateTime.Now;
                        unitOfWork.ActionListsRepo.Insert(item);
                        unitOfWork.Save();
                    }
                    else
                    {
                        var res = unitOfWork.ActionListsRepo.Find(x => x.Id == item.Id);
                        res.Action = item.Action;
                        unitOfWork.Save();
                    }
                    Init();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}