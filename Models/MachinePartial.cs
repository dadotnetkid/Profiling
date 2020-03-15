using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [MetadataType(typeof(MachineMeta))]
    public partial class Machines
    {
        public string RequestOffice { get; set; }
    }
    public partial class MachineMeta
    {

    }

    public partial class MachineTypes
    {
        public string S { get; set; }
    }
}
