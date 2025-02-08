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
