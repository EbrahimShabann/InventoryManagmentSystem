namespace Inventory.Repositories.Services.IRepo
{
    public interface IProductTypeRepo
    {
        PaginatedList<ProductTypeListViewModel> GetAll(int pageNumber, int pageSize);
    }
}
