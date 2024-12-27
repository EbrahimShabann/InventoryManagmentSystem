using Inventory.Models;
using Inventory.ViewModels.BillVM;
using Inventory.ViewModels.CustomerVM;
using Inventory.ViewModels.ProductVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.ViewModels.Mapping
{
    public static class Relationship
    {
        public static IEnumerable<CustomerTypeListViewModel> ModelToVM(this IEnumerable<CustomerType> customerTypes)
        {
            List<CustomerTypeListViewModel> list = new List<CustomerTypeListViewModel> ();
            foreach (var ct in customerTypes)
            {
                list.Add(new CustomerTypeListViewModel()
                {
                    CustomerTypeId = ct.CustomerTypeId,
                    CustomerTypeName = ct.CustomerTypeName,
                    Description = ct.Description
                });
            }
            return list;
        }
        public static IEnumerable<CustomerListViewModel> ModelToVM(this IEnumerable<Customer> customers)
        {
            List<CustomerListViewModel> list = new List<CustomerListViewModel>();
            foreach (var c in customers)
            {
                list.Add(new CustomerListViewModel()
                {
                    CustomerId = c.CustomerId,
                    CustomerName=c.CustomerName,
                    City = c.City,
                    ContactPerson=c.ContactPerson,
                    CustomerTypeId=c.CustomerTypeId,
                    Address = c.Address,
                    Email=c.Email,
                    Phone=c.Phone,
                     State = c.State,
                     ZipCode=c.ZipCode                
                });
                
            }
            return list;
        }
        public static IEnumerable<BillTypeListViewModel> ModelToVM(this IEnumerable<BillType> BillTypes)
        {
            List<BillTypeListViewModel> list = new List<BillTypeListViewModel>();
            foreach (var bt in BillTypes)
            {
                list.Add(new BillTypeListViewModel()
                {
                    BillTypeId = bt.BillTypeId,
                     BillTypeName = bt.BillTypeName,
                    Description = bt.Description
                });
            }
            return list;
        }
        public static IEnumerable<BillListViewModel> ModelToVM(this IEnumerable<Bill> Bills)
        {
            List<BillListViewModel> list = new List<BillListViewModel>();
            foreach (var bt in Bills)
            {
                list.Add(new BillListViewModel()
                {
                    BillId=bt.BillId,
                    BillTypeId=bt.BillTypeId,
                    BillDate=bt.BillDate,
                    BillDueDate = bt.BillDueDate,
                    BillName = bt.BillName,
                    GoodsReceivedNoteId=bt.GoodsReceivedNoteId,
                     VendorDoNumber = bt.VendorDoNumber,
                      VendorInvoiceNumber = bt.VendorInvoiceNumber
                     
                });
            }
            return list;
        }
        public static IEnumerable<ProductTypeListViewModel> ModelToVM(this IEnumerable<ProductType> ProductTypes)
        {
            List<ProductTypeListViewModel> list = new List<ProductTypeListViewModel>();
            foreach (var pt in ProductTypes)
            {
                list.Add(new ProductTypeListViewModel()
                {
                    ProductTypeId = pt.ProductTypeId,
                    ProductTypeName = pt.ProductTypeName,
                    Description = pt.Description
                });
            }
            return list;
        }
        public static IEnumerable<ProductListViewModel> ModelToVM(this IEnumerable<Product> Products)
        {
            List<ProductListViewModel> list = new List<ProductListViewModel>();
            foreach (var p in Products)
            {
                list.Add(new ProductListViewModel()
                {
                    BarCode = p.BarCode,
                    BranchId = p.BranchId,
                    BuyingPrice = p.BuyingPrice,
                     CurrencyId = p.CurrencyId,
                     Description = p.Description,
                     MeasureUnitId = p.MeasureUnitId,
                     Prdouctimage = p.Prdouctimage,
                     ProductCode = p.ProductCode,
                     ProductId = p.ProductId,
                     ProductName = p.ProductName,
                     SellingPrice = p.SellingPrice
                });
            }
            return list;
        }
    }
}
