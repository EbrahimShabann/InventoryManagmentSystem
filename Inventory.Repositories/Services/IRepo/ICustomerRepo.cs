namespace Inventory.Repositories.Services.IRepo
{
    public interface ICustomerRepo
    {
        PaginatedList<CustomerListViewModel> GetAll(int pageNumber, int pageSize);
    }
}
