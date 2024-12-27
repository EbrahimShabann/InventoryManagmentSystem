using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        void save();
    }
}
