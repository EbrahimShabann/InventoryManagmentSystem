﻿namespace Inventory.ViewModels.ProductVM
{
    public class ProductTypeListViewModel
    {
        public int ProductTypeId { get; set; }
        [Required]
        public string ProductTypeName { get; set; }
        public string Description { get; set; }
    }
}
