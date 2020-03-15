using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [MetadataType(typeof(PartsMeta))]
    public partial class Parts
    {

    }
    public class PartsMeta
    {

        public int PartTypeId { get; set; }
        [Required(ErrorMessage = "Part Name is required")]
        public string PartName { get; set; }
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Quantity is required")]
        public int Qty { get; set; }
        [Required(ErrorMessage ="Cost is required")]
        public decimal Cost { get; set; }
        
    }
}
