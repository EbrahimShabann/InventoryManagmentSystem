﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Models
{
    public class SalesOrderLine
    {
        public int Id { get; set; }
        [Display(Name = "Sales Order")]
        public int SalesOrderId { get; set; }
        public SalesOrder SalesOrder { get; set; }
        [Display(Name = "Sales Order")]

        public int ProductId { get; set; }
        public string Description { get; set; }
        public double Quantity { get; set; }
        public double Amount { get; set; }
        public double Price { get; set; }
        [Display(Name = "Discount Percentage")]

        public double DiscountPercentage { get; set; }
        [Display(Name = "Discount Amount")]

        public double DiscountAmount { get; set; }
        [Display(Name = "Sub Total")]

        public double SubTotal { get; set; }
        [Display(Name = "Tax Percentage")]

        public double TaxPercentage { get; set; }
        [Display(Name = "Tax Amount")]

        public double TaxAmount { get; set; }
        public double Total { get; set; }
    }
}
