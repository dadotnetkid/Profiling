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

namespace Win.sts
{
    public partial class frmAddEditStatus : DevExpress.XtraEditors.XtraForm
    {
        private Statuses oldValue;
        private MethodType methodType;

        public frmAddEditStatus(Statuses oldValue, MethodType methodType)
        {
            InitializeComponent();
            this.oldValue = oldValue;
            this.methodType = methodType;
        }

        private void btnEditPo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void details()
        {
            if (methodType == MethodType.Add)
                return;
            txtStatus.Text = oldValue.Value;
            colorPickerStatus.EditValue =
                oldValue.CustomValue; //int.Parse(oldValue.CustomValue, System.Globalization.NumberStyles.HexNumber);
        }
        void add(Statuses item)
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                unitOfWork.StatusesRepo.Insert(item);
                unitOfWork.Save();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void edit(Statuses item)
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                item.CustomValue = "#" + colorPickerStatus.Color.ToArgb().ToString("X");
                item.Value = txtStatus.Text;
                unitOfWork.StatusesRepo.Update(item);
                unitOfWork.Save();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnNewPO_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Do you want to submit this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            if (methodType == MethodType.Add)
                add(new Statuses()
                {
                    TableName = "Status",
                    CustomValue = colorPickerStatus.Color.ToArgb().ToString("X")
                });
            else
                edit(oldValue);
            this.Close();
        }

        private void frmAddEditStatus_Load(object sender, EventArgs e)
        {
            details();
        }
    }
}