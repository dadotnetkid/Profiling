using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Repository;

namespace Models.ViewModels
{
    public class DocumentLedgerViewModel
    {
        public List<DocActions> DocActions { get; set; }

        public WorkOrders WorkOrders { get; set; }
        public List<DocActions> GetDocActions(int workOrderId)
        {

            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                return unitOfWork.DocActionsRepo.Get(m => m.RefId == workOrderId && m.TableName == "WorkOrders",includeProperties:"CreatedByUsers");
            }

        }

        public string PrintedBy { get; set; }
    }
}
