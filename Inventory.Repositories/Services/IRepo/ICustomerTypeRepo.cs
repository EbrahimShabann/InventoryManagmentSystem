namespace Inventory.Repositories.Services.IRepo
{
    public interface ICustomerTypeRepo
    {
        PaginatedList<CustomerTypeListViewModel> GetAll(int pageNumber, int pageSize);
        CustomerTypeViewModel GetById(int id);
        void Add(CreateCustomerTypeViewModel model);
        void Update(CustomerTypeViewModel model);
        void Delete(int id);
    }
}
