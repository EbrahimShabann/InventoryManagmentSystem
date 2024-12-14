using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Models
{
    public class Shippment
    {
        public int Id { get; set; }
        [Display(Name ="Shippment Number")]
        public string ShippmentName { get; set; }
        [Display(Name = "Sales Order")]

        public int SalesOrderId { get; set; }
        public DateTimeOffset ShippmentDate { get; set; }
        [Display(Name = "Shippment Type")]

        public int ShippmentTypeId { get; set; }
        [Display(Name = "WareHouse")]

        public int WareHouseId { get; set; }
        [Display(Name = "Full Shippment?")]

        public bool IsFullShippment { get; set; } = true;
    }
}
