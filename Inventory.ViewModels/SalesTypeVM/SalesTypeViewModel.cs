using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.ViewModels.SalesTypeVM
{
    public class SalesTypeViewModel
    {
        public int SalesTypeId { get; set; }
        [Required]
        public string SalesTypeName { get; set; }
        public string Description { get; set; }
    }
}
