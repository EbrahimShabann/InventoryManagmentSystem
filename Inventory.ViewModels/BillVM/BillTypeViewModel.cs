using Inventory.Models;
using System.ComponentModel.DataAnnotations;

namespace Inventory.ViewModels.BillVM
{
    public class BillTypeViewModel()
    {
        
        public int BillTypeId { get; set; }
        [Required]
        public string BillTypeName { get; set; }
        public string Description { get; set; }

        public BillTypeViewModel(BillType billType) : this()
        {
            this.BillTypeId = billType.BillTypeId;
           this.BillTypeName = billType.BillTypeName;
           this.Description = billType.Description;
        }
       
    }
}