using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Repository;

namespace Models
{
    public partial class WorkOrders
    {



        public string GeneratedId(PPEs ppe, int wOId)
        {
            // var ppe = new UnitOfWork().PPEsRepo.Find(m => m.Id == ppeId);
            if (ppe == null)
                return "";
            var count = ppe.WorkOrders.Count() + 1;
            return ppe?.Employees?.Offices?.BoxNo + "-" + ppe?.EquipmentTypes?.Box + "-" + count.ToString("0000");
        }

        public string Actions => string.Join(Environment.NewLine, this.DocActions.Where(x=>x.TableName=="WorkOrders").Select(x => x.ActionTaken));
        public string PrintedBy { get; set; }
    }
}
