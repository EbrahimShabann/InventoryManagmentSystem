namespace Inventory.Repositories.Services.IRepo
{
    public interface IVendorTypeRepo
    {
        PaginatedList<VendorTypeListViewModel> GetAll(int pageNumber, int pageSize);
        VendorTypeViewModel GetById(int id);
        void Add(CreateVendorTypeViewModel model);
        void Update(VendorTypeViewModel model);
        void Delete(int id);
    }
}
