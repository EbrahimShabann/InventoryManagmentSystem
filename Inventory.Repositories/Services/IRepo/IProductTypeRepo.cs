using Inventory.Repositories.Paging;
using Inventory.ViewModels.BillVM;
using Inventory.ViewModels.ProductVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Repositories.Services.IRepo
{
    public interface IProductTypeRepo
    {
        PaginatedList<ProductTypeListViewModel> GetAll(int pageNumber, int pageSize);
    }
}
