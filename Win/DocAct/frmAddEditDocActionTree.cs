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
using System.Data.Entity;
using Helpers;

namespace Win.WO
{
    public partial class frmAddEditDocActionTree : DevExpress.XtraEditors.XtraForm
    {
        private string category;
        private Dropdowns item;
        private MethodType methodType;

        public frmAddEditDocActionTree(string category, Dropdowns item, MethodType methodType)
        {
            InitializeComponent();
            this.category = category;
            this.item = item;
            this.methodType = methodType;


            txtParent.Properties.DataSource = new BindingList<Dropdowns>(new UnitOfWork().DropdownsRepo.Get());
            detail();
            addNewInit();
        }

        void detail()
        {
            if (methodType == MethodType.Add)
                return;

            if (item.Category == "Programs")
            {

            }
            else if (item.Category == "Projects")
            {

                txtParent.Properties.DataSource = new BindingList<Dropdowns>(new UnitOfWork().DropdownsRepo.Get(m => m.Category == "Programs"));
            }
            else if (item.Category == "Activity")
            {
                lblParent.Text = "Project";
                lblvalue.Text = "Activity";
                txtParent.Properties.DataSource = new BindingList<Dropdowns>(new UnitOfWork().DropdownsRepo.Get(m => m.Category == "Projects"));
            }
            else if (item.Category == "SubActivity")
            {
                lblParent.Text = "Activity";
                lblvalue.Text = "Sub Activity";
                txtParent.Properties.DataSource = new BindingList<Dropdowns>(new UnitOfWork().DropdownsRepo.Get(m => m.Category == "Activity"));
            }


            txtValue.Text = item.Value;
            txtParent.EditValue = new UnitOfWork().DropdownsRepo.Find(m => m.Id == item.ParentId)?.Id;
            txtOrder.Text = item.Order?.ToString();
            var parentId = item.ParentId;
            while (true)
            {
                if (item.ParentId == null)
                {
                    lblHeader.Text = item.Value;
                    break;
                }
                var dropdown = new UnitOfWork().DropdownsRepo.Find(x => x.Id == parentId);

                if (dropdown == null)
                {

                    break;
                }
                lblHeader.Text = dropdown.Value;
                parentId = dropdown.ParentId;

            }
        }

        void addNewInit()
        {
            if (methodType == MethodType.Edit)
                return;

            if (item.Category == "Programs")
            {
                txtParent.Properties.DataSource = new BindingList<Dropdowns>(new UnitOfWork().DropdownsRepo.Get(m => m.Category == "Programs"));
            }
            else if (item.Category == "Projects")
            {
                txtParent.Properties.DataSource = new BindingList<Dropdowns>(new UnitOfWork().DropdownsRepo.Get(m => m.Category == "Projects"));
            }
            else if (item.Category == "Activity")
            {
                lblParent.Text = "Activity";
                lblvalue.Text = "Sub Activity";
            }
            txtParent.EditValue = item.Id;
            var parentId = item.ParentId;
            while (true)
            {
                if (item.ParentId == null)
                {
                    lblHeader.Text = item.Value;
                    break;
                }
                var dropdown = new UnitOfWork().DropdownsRepo.Find(x => x.Id == parentId);

                if (dropdown == null)
                {

                    break;
                }
                lblHeader.Text = dropdown.Value;
                parentId = dropdown.ParentId;

            }
        }
        void Edit()
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            item.Value = txtValue.Text;
            item.Order = txtOrder.EditValue?.ToInt();
            item.ParentId = txtParent.EditValue?.ToInt();
            unitOfWork.DropdownsRepo.Update(item);
            unitOfWork.Save();
        }

        void add()
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            item.Value = txtValue.Text;
            item.Order = txtOrder.EditValue?.ToInt();
            item.ParentId = txtParent.EditValue?.ToInt();

            unitOfWork.DropdownsRepo.Insert(item);
            unitOfWork.Save();
        }

        private void frmAddEditDocActionTree_Load(object sender, EventArgs e)
        {

        }

        private void btnNewPO_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Do you want to submit this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            if (methodType == MethodType.Add)
            {
                add();
            }
            else if (methodType == MethodType.Edit)
            {
                Edit();
            }

            this.Close();
        }

        private void btnEditPo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}