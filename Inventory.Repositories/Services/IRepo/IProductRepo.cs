using Inventory.Repositories.Paging;
using Inventory.ViewModels.ProductVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Repositories.Services.IRepo
{
    public interface IProductRepo
    {
        PaginatedList<ProductListViewModel> GetAll(int pageNumber, int pageSize);
    }
}
