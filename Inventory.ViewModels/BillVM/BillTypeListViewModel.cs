namespace Inventory.ViewModels.BillVM
{
    public class BillTypeListViewModel
    {
        public int BillTypeId { get; set; }
        [Required]
        public string BillTypeName { get; set; }
        public string Description { get; set; }
    }
}
