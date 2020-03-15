using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public partial class PPEs
    {
        public string EmployeeName => Employees?.EmployeeName;
        public string Position => Employees?.Position;
    }
}
