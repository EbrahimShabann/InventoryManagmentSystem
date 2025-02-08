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
