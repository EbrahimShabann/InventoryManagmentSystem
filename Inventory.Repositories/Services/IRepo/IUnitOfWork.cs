namespace Inventory.Repositories.Services.IRepo
{
    public interface IUnitOfWork
    {
        public IBillRepo billRepo { get; }
        public IBillTypeRepo billTypeRepo { get; }
        public ICustomerRepo customerRepo { get; }
        public ICustomerTypeRepo customerTypeRepo { get; }
        public IProductRepo productRepo { get; }
        public IProductTypeRepo productTypeRepo { get; }
        public IVendorTypeRepo vendorTypeRepo { get; }
        public ISalesTypeRepo salesTypeRepo { get; }
        void save();
    }
}
