using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Models
{
    public class ShippmentType
    {
        public int ShippmentTypeId { get; set; }
        [Required]
        public string ShippmentName { get; set; }
        public string Description { get; set; }
    }
}
