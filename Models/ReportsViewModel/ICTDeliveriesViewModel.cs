using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Reports_ViewModel
{
    public class ICTDeliveriesViewModel
    {
        private List<PurchaseOrders> _purchaseOrders;

        public List<PurchaseOrders> PurchaseOrders
        {
            get { return _purchaseOrders ?? (_purchaseOrders = new List<PurchaseOrders>()); }
            set { _purchaseOrders = value; }
        }

    }
}
