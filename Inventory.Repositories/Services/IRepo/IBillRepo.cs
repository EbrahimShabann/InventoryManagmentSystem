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
