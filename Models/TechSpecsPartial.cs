using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public partial class TechSpecs
    {
        public string TechSpecsId => "EPiS-" + this.Id;
        public string PrintedBy { get; set; }
        

    }
}
