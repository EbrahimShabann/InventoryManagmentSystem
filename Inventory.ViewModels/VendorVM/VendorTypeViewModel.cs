namespace Inventory.ViewModels.VendorVM
{
    public class VendorTypeViewModel
    {
        public int VendorTypeId { get; set; }
        [Required]
        public string VendorTypeName { get; set; }
        public string Description { get; set; }

        public VendorTypeViewModel(VendorType type) :this()
        {
            this.VendorTypeId=type.VendorTypeId;
            this.VendorTypeName=type.VendorTypeName;
            this.Description=type.Description;
        }
        public VendorTypeViewModel()
        {
            
        }
    }
}
