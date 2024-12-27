using Inventory.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.ViewModels.CustomerVM
{
    public class CustomerTypeViewModel
    {
        public int CustomerTypeId { get; set; }
        [Required]
        public string CustomerTypeName { get; set; }
        public string Description { get; set; }
        public CustomerTypeViewModel(CustomerType customerType) : this()
        {
            this.CustomerTypeId = customerType.CustomerTypeId;
            this.CustomerTypeName = customerType.CustomerTypeName;
            this.Description = customerType.Description;
        }
        public CustomerTypeViewModel()
        {
            
        }
    }
}
