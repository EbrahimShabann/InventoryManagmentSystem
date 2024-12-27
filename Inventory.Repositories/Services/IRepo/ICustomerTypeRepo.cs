using Inventory.Repositories.Paging;
using Inventory.ViewModels.BillVM;
using Inventory.ViewModels.CustomerVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Repositories.Services.IRepo
{
    public interface ICustomerTypeRepo
    {
        PaginatedList<CustomerTypeListViewModel> GetAll(int pageNumber, int pageSize);
        CustomerTypeViewModel GetById(int id);
        void Add(CreateCustomerTypeViewModel model);
        void Update(CustomerTypeViewModel model);
        void Delete(int id);
    }
}
