using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Repository;

namespace Models
{
    public partial class DocActions
    {
        private UnitOfWork unitOfWork = new UnitOfWork();

        //public List<Dropdowns> SubActivity => unitOfWork.DropdownsRepo.Get(m => m.Category == "SubActivity" && m.Id);
        public Dropdowns SubActivity => unitOfWork.DropdownsRepo.Find(m => m.Category == "SubActivity" && m.Id == SubActivityId);

        public string ActionAndStatus
        {
            get
            {
                var res = this.ActionTaken;
                if (!string.IsNullOrWhiteSpace(this.Remarks))
                    res = res + "-" + Remarks;
                return res;
            }
        }
    }
}
