using Inventory.Repositories.Paging;
using Inventory.ViewModels.BillVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Repositories.Services.IRepo
{
    public interface IBillRepo
    {
        PaginatedList<BillListViewModel> GetAll(int pageNumber, int pageSize);
        BillViewModel GetById(int id);
        void Add(CreateBillViewModel model);
        void Update(BillViewModel model);
        void Delete(int id);
    }
}
