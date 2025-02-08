﻿namespace Inventory.ViewModels.BillVM
{
    public class CreateBillViewModel
    {
        public int BillId { get; set; }
        [Display(Name = "Bill / Invoice Number")]
        public string BillName { get; set; }
        [Display(Name = "GRN")]

        public int GoodsReceivedNoteId { get; set; }
        [Display(Name = "Vendor Delivery Order")]

        public string VendorDoNumber { get; set; }
        [Display(Name = "Vendor Bill / Invoice ")]

        public string VendorInvoiceNumber { get; set; }
        [Display(Name = "Bill Date")]

        public DateTimeOffset BillDate { get; set; }
        [Display(Name = "Bill Due Date")]

        public DateTimeOffset BillDueDate { get; set; }
        public int BillTypeId { get; set; }

        
    }
}
