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
