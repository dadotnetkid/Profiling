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
using Models.Repository;
using Models;

namespace Win.Dlvry
{
    public partial class frmSearchTechSpecDetail : DevExpress.XtraEditors.XtraForm
    {
        private int techSpecsId;

        public frmSearchTechSpecDetail(int techSpecsId)
        {
            InitializeComponent();
            this.techSpecsId = techSpecsId;
            TechSpecsRequestDetailBindingSource.DataSource = new UnitOfWork().TechSpecRequestsRepo.Get();
        }

        private void txtSearch_Properties_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnNewPO_Click(object sender, EventArgs e)
        {
            var selectedRows = gridTechSpecRequest.GetSelectedRows();
            try
            {
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    foreach (var i in selectedRows)
                    {
                        var techSpecRequest = gridTechSpecRequest.GetRow(i);


                        if (techSpecRequest is TechSpecRequests item)
                        {
                            item.Id = unitOfWork.TechSpecRequestsRepo.Fetch().OrderByDescending(x => x.Id).Select(x => new { x.Id }).FirstOrDefault().Id + 1;

                            foreach (var ep in unitOfWork.EquipmentProfilesRepo.Get(m =>
                                m.ItemNumber == item.ItemNumber && m.RefId == item.TechSpecsId))
                            {
                                ep.Id = item.Id = unitOfWork.EquipmentProfilesRepo.Fetch().OrderByDescending(x => x.Id).Select(x => new { x.Id }).FirstOrDefault().Id + 1;
                                ep.RefId = techSpecsId;
                                ep.TableName = "TechSpecs";
                                ep.TechSpecEquipmentProfiles = null;
                                ep.PurchaseOrders = null;
                                ep.TechSpecs = null;
                                unitOfWork.EquipmentProfilesRepo.Insert(ep);
                                unitOfWork.Save();
                            }
                            foreach (var ep in unitOfWork.EquipmentProfilesRepo.Get(m =>
                                m.ParentItem == item.ItemNumber && m.RefId == item.TechSpecsId))
                            {
                                ep.Id = item.Id = unitOfWork.EquipmentProfilesRepo.Fetch().OrderByDescending(x => x.Id).Select(x => new { x.Id }).FirstOrDefault().Id + 1;
                                ep.RefId = techSpecsId;
                                ep.TableName = "TechSpecs";
                                ep.TechSpecEquipmentProfiles = null;
                                ep.PurchaseOrders = null;
                                ep.TechSpecs = null;
                                unitOfWork.EquipmentProfilesRepo.Insert(ep);
                                unitOfWork.Save();
                            }
                            item.TechSpecsId = techSpecsId;
                            item.TechSpecs = null;
                            unitOfWork.TechSpecRequestsRepo.Insert(item);
                            unitOfWork.Save();
                        }

                    }


                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            this.Close();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TechSpecsRequestDetailBindingSource.DataSource =
                    new UnitOfWork().TechSpecRequestsRepo.Get(m => m.EquipmentType.Contains(txtSearch.Text));
            }
        }

        private void frmSearchTechSpecDetail_Load(object sender, EventArgs e)
        {

        }
    }
}