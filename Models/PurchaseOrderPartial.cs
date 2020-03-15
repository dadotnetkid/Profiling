using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [MetadataType(typeof(PurchaseOrdersMeta))]
    public partial class PurchaseOrders
    {

    }

    public class PurchaseOrdersMeta
    {
        [Required]
        public int SupplierId { get; set; }
    }




}
