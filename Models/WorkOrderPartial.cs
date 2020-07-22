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
            if (ppe.WorkOrders.Any())
            {
                return ppe.WorkOrders.OrderByDescending(x => x.Id).FirstOrDefault()?.FolderNo;
            }
            var count = 1000 + ppe.WorkOrders.Count() + 1;

            return ppe?.Employees?.Offices?.BoxNo + "-" + ppe?.EquipmentTypes?.Box + "-" + count.ToString("0000");
        }

        public string GeneratedId(int? officeNo, int? typeNo, int wOId)
        {
            // var ppe = new UnitOfWork().PPEsRepo.Find(m => m.Id == ppeId);
            UnitOfWork unitOfWork = new UnitOfWork();
            var lastId = unitOfWork.WorkOrdersRepo.Fetch(m => m.OfficeNo == officeNo && m.EquipmentTypeNo == typeNo)
                .OrderByDescending(x => x.EquipmentCount).FirstOrDefault();
            if (lastId != null)
            {
                var id = $"{officeNo}-{typeNo}-{(lastId.EquipmentCount + 1)}";
                return $"{id}";
            }
            return $"{officeNo}-{typeNo}-{1001}";
        }

        public string Actions => string.Join(Environment.NewLine, this.DocActions.Where(x => x.TableName == "WorkOrders").Select(x => x.ActionAndStatus));
        public string PrintedBy { get; set; }
    }
}
