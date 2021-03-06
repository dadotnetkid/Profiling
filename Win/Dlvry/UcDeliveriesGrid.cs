﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Models;
using Models.Repository;
using System.Data.Entity;

namespace Win.Dlvry
{
    public partial class UcDeliveryGrid : DevExpress.XtraEditors.XtraUserControl
    {
        public GridView GridView => this.DeliveriesGrid;


        public UcDeliveryGrid()
        {
            InitializeComponent();

            // This line of code is generated by Data Source Configuration Wizard
      
        }

        private void TechSpecGrid_DoubleClick(object sender, EventArgs e)
        {

        }

        private void repositoryItemButtonEdit2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            if (!User.UserInAction("Delete Deliveries"))
                return;

            if (MessageBox.Show("Do you want to delete this", "Deleting", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.No)
                return;
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                var delivery = GridView.GetFocusedRow() as Deliveries;
                if (delivery == null)
                    return;
                unitOfWork.DeliveriesRepo.Delete(delivery.Id);
                unitOfWork.Save();
            }
            CreateUcControl();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Search(txtSearch.Text);
        }
        public void Search(string search = "")
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            entityServerModeSource1.QueryableSource = new UnitOfWork().DeliveriesRepo.Fetch(x => x.Offices.OfficeName.Contains(search) || x.Offices.OffcAcr.Contains(search) || x.DeliveryId.Contains(search));

        }
        public void CreateUcControl()
        {

            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();

                Search(txtSearch.Text);
                DeliveriesGrid.RefreshData();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Load Tech Specs", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void UcDeliveryGrid_Load(object sender, EventArgs e)
        {
        }
    }
}
