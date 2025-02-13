using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Repositories.Services.IRepo
{
    public interface IVendorRepo
    {
        PaginatedList<VendorListViewModel> GetAll(int PageNumber, int PageSize);
        VendorViewModel GetById(int id);
        void Update(VendorViewModel model);
        void Add(CreateVendorViewModel model);
        void Delete(int id);
    }
}
