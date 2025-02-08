using Inventory.ViewModels.SalesTypeVM;

namespace Inventory.Repositories.Services.IRepo
{
    public interface ISalesTypeRepo 
    {
        PaginatedList<SalesTypeListViewModel> GetAll(int pageNumber, int pageSize);
        SalesTypeViewModel GetById(int id);
        void Add(CreateSalesTypeViewModel model);
        void Update(SalesTypeViewModel model);
        void Delete(int id);
    }
}
