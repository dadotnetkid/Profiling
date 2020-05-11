using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;

namespace Helpers
{
    public static class FormTagValidator
    {
        static DXErrorProvider dXErrorProvider = new DXErrorProvider();
        public static bool ValidateForm(this XtraForm frm)
        {

            dXErrorProvider.ClearErrors();
            var ctrls = frm.Controls.Cast<Control>().OrderBy(x => x.TabIndex).ToList();

            foreach (Control c in ctrls)
            {
                foreach (var ctrl in GetControls(c))
                    if (ctrl is BaseEdit control)
                        if (!string.IsNullOrEmpty(control.Tag?.ToString()))
                        {
                            if (control.EditValue == null)
                            {
                                dXErrorProvider.SetError(control, control.Tag?.ToString());
                                dXErrorProvider.SetIconAlignment(control, ErrorIconAlignment.MiddleRight);
                                control.Focus();
                                return false;
                            }

                        }
            }

            return true;
        }

        static IEnumerable<Control> GetControls(Control control)
        {
            var controls = control.Controls.Cast<Control>().OrderBy(x => x.TabIndex).ToList();
          return controls;

        }
    }
}
