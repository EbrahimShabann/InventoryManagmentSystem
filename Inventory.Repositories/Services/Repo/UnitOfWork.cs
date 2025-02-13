using AutoMapper;

namespace Inventory.Repositories.Services.Repo
{
    public class UnitOfWork(ApplicationDbContext db, IMapper mapper) : IUnitOfWork
    {
        private ApplicationDbContext _db = db;

        public IBillRepo billRepo { get; private set; } = new BillRepo(db,mapper);

        public IBillTypeRepo billTypeRepo { get; private set; } = new BillTypeRepo(db,mapper);

        public ICustomerRepo customerRepo { get; private set; } = new CustomerRepo(db);

        public ICustomerTypeRepo customerTypeRepo { get; private set; } = new CustomerTypeRepo(db);

        public IProductRepo productRepo { get; private set; } = new ProductRepo(db);

        public IProductTypeRepo productTypeRepo { get; private set; } = new ProductTypeRepo(db);
        public IVendorTypeRepo vendorTypeRepo { get; private set; } = new VendorTypeRepo(db,mapper);
        public ISalesTypeRepo salesTypeRepo { get; private set; } = new SalesTypeRepo(db,mapper);
        public IVendorRepo vendorRepo { get; private set; } = new VendorRepo(db, mapper);
        public void save()
        {
            _db.SaveChanges();
        }
    }
}
