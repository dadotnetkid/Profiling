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
using Helpers;
using Models;
using Models.Repository;
using Win.Properties;

namespace Win.WO
{
    public partial class frmTechnicalEvalSheet : DevExpress.XtraEditors.XtraForm
    {
        private bool isSubmit;

        public frmTechnicalEvalSheet()
        {
            InitializeComponent();
            this.Icon = Resources.apply_16x16.ToIcon();

        }

        void LoadTechEvalSheet()
        {
        
            EvaluationLookUpRepo.DataSource = new UnitOfWork().EvaluationSheetsRepo.Get();
            this.gridControl1.DataSource = new UnitOfWork().TechnicalEvaluationSheetRepo.Get(m => m.WorkOrderId == WorkOrderId);
        }
        private void frmTechnicalEvalSheet_Load(object sender, EventArgs e)
        {
            UnitOfWork unitOfWork = new UnitOfWork();

            if (!unitOfWork.TechnicalEvaluationSheetRepo.Fetch(m => m.WorkOrderId == WorkOrderId).Any())
            {
                foreach (var i in unitOfWork.EvaluationSheetsRepo.Fetch())
                {
                    unitOfWork.TechnicalEvaluationSheetRepo.Insert(new Models.TechnicalEvaluationSheet()
                    {
                        EvaluationSheets = i,
                        WorkOrderId = this.WorkOrderId
                    });
                }
                unitOfWork.Save();
            }

            LoadTechEvalSheet();

        }

        public int? WorkOrderId { get; set; }

        private void frmTechnicalEvalSheet_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (this.isSubmit == true && this.MethodType == MethodType.Edit)
            //    return;
            //using (UnitOfWork unitOfWork = new UnitOfWork())
            //{
            //    unitOfWork.TechnicalEvaluationSheetRepo.DeleteRange(m => m.WorkOrderId == WorkOrderId);
            //    unitOfWork.Save();
            //}

        }

        public MethodType MethodType { get; set; }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            if (e.Row is TechnicalEvaluationSheet item)
            {
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    unitOfWork.TechnicalEvaluationSheetRepo.Update(item);
                    unitOfWork.Save();
                }
            }

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}