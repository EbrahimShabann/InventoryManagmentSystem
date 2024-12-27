using Inventory.Repositories.Paging;
using Inventory.ViewModels.BillVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Repositories.Services.IRepo
{
    public interface IBillTypeRepo
    {
        PaginatedList<BillTypeListViewModel> GetAll(int pageNumber, int pageSize);
        BillTypeViewModel GetById(int id);
        void Add(CreateBillTypeViewModel model);
        void Update(BillTypeViewModel model);
        void Delete(int id);
    }
}
