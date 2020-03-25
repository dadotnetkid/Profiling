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

        public int ImageIndex
        {
            get
            {
                if (this.Category == "Programs")
                    return 0;
                if (this.Category == "Projects")
                    return 1;
                if (this.Category == "Activity")
                    return 2;
                if (this.Category == "SubActivity")
                    return 3;
                return 0;
            }
        }
    }
}
