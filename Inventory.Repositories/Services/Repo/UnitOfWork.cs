using Inventory.Repositories.Services.IRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Repositories.Services.Repo
{
    public class UnitOfWork(ApplicationDbContext db) : IUnitOfWork
    {
       private ApplicationDbContext _db = db;

        public IBillRepo billRepo { get; private set; } = new BillRepo(db);

        public IBillTypeRepo billTypeRepo { get; private set; } = new BillTypeRepo(db);

        public ICustomerRepo customerRepo { get; private set; } = new CustomerRepo(db);

        public ICustomerTypeRepo customerTypeRepo { get; private set; } = new CustomerTypeRepo(db);

        public IProductRepo productRepo { get; private set; } = new ProductRepo(db);

        public IProductTypeRepo productTypeRepo { get; private set; } = new ProductTypeRepo(db);

        public void save()
        {
            _db.SaveChanges();
        }
    }
}
