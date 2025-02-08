namespace Inventory.ViewModels.VendorVM
{
    public class CreateVendorTypeViewModel
    {
        public int VendorTypeId { get; set; }
        [Required]
        public string VendorTypeName { get; set; }
        public string Description { get; set; }

        
    }
}
