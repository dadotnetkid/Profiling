using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Repository;

namespace Models
{
    public partial class Deliveries
    {
        public List<DocActions> DocActionses =>
            new UnitOfWork().DocActionsRepo.Get(x => x.RefId == Id && x.TableName == "Deliveries");
        public List<EquipmentProfiles> EquipmentProfiles =>
            new UnitOfWork().EquipmentProfilesRepo.Get(x => x.RefId == Id && x.TableName == "Deliveries");
    }
}
