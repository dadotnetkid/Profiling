using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public partial class EquipmentProfiles
    {
        public string UnitType => EquipmentType;
        public string TotalCost => this.Total == 0 ? "" : Total?.ToString("P #,#.00");
    }
}
