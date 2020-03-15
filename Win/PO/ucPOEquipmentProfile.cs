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

namespace Win.PO
{
    public partial class ucPOEquipmentProfile : DevExpress.XtraEditors.XtraUserControl, IUserControl<EquipmentProfiles>
    {
        public ucPOEquipmentProfile()
        {
            InitializeComponent();
        }

        public void CreateUcControl(int Id)
        {
            throw new NotImplementedException();
        }

        public void CreateUcControl()
        {
            throw new NotImplementedException();
        }

        public void Details(EquipmentProfiles entity)
        {
       
        }

    
        public void Details(int Id)
        {
            throw new NotImplementedException();
        }

        public void Details(int id, string tableName)
        {
            this.EquipmentProfileBindingSource.DataSource = new UnitOfWork().EquipmentProfilesRepo.Get(m => m.RefId == id && m.TableName == tableName);
        }

        public void Search(string search)
        {
            throw new NotImplementedException();
        }
    }
}
