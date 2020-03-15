using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Repository;

namespace Models
{
    public partial class TechSpecRequests
    {
        public bool isSelected { get; set; }
        private List<EquipmentProfiles> _equipmentProfiles;

        public List<EquipmentProfiles> EquipmentProfiles
        {
            get
            {
                if (_equipmentProfiles == null)
                {
                    _equipmentProfiles = new List<EquipmentProfiles>();

                }

                return _equipmentProfiles;
            }
            set => _equipmentProfiles = value;
        }

        public IEnumerable<EquipmentProfiles> profiles => EquipmentProfiles.Where(m => m.ItemNumber == null);
        public string UOM => this.EquipmentProfiles.Find(m => m.ItemNumber != null)?.UnitTypes?.UnitType;
        public decimal? TotalCost => this.Qty * this.Budget;
        public string Description => this.EquipmentProfiles.Find(m => m.ItemNumber == ItemNumber)?.Description;
    }
}
