using Inventory.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.ViewModels.CustomerVM
{
    public class CreateCustomerTypeViewModel
    {
        public int CustomerTypeId { get; set; }
        [Required]
        public string CustomerTypeName { get; set; }
        public string Description { get; set; }
        public CustomerType VMtoModel()
        {
            return new CustomerType
            {
                CustomerTypeId = CustomerTypeId,
                CustomerTypeName = CustomerTypeName,
                Description = Description
            };
        }
    }
}
