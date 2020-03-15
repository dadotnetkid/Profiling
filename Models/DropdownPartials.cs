using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public partial class Dropdowns
    {
        private string _dropdownValue;

        public string DropdownValue
        {
            get
            {
                if (_dropdownValue == null)
                    _dropdownValue = this.Order + "." + this.Value;
                return _dropdownValue;
            }
            set => _dropdownValue = value;
        }
    }
}
