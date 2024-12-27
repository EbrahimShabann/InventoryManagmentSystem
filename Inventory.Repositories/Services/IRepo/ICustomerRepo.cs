using Inventory.Repositories.Paging;
using Inventory.ViewModels.CustomerVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Repositories.Services.IRepo
{
    public interface ICustomerRepo
    {
        PaginatedList<CustomerListViewModel> GetAll(int pageNumber, int pageSize);
    }
}
