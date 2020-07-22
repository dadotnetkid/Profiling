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

namespace Win.TS
{
    public partial class UcTSEquipmentProfiles : DevExpress.XtraEditors.XtraUserControl
    {
        public UcTSEquipmentProfiles()
        {
            InitializeComponent();
        }

      
        public void Details(int id, string tableName)
        {
            this.EquipmentProfileBindingSource.DataSource =new UnitOfWork().EquipmentProfilesRepo.Get(m => m.RefId == id && m.TableName == tableName,orderBy:x=>x.OrderBy(m=>m.RowNumber));
        }

    }
}
