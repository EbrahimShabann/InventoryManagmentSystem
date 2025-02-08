namespace Inventory.Repositories.Services.IRepo
{
    public interface IProductRepo
    {
        PaginatedList<ProductListViewModel> GetAll(int pageNumber, int pageSize);
    }
}
