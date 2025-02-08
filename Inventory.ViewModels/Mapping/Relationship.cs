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
