namespace Inventory.Repositories.Services.Repo
{
    public class ProductTypeRepo : IProductTypeRepo
    {
        private ApplicationDbContext _context;

        public ProductTypeRepo(ApplicationDbContext context)
        {
            _context = context;
        }
        public PaginatedList<ProductTypeListViewModel> GetAll(int pageNumber, int pageSize)
        {
            var ProductTypeList = _context.ProductTypes;
            var vm = ProductTypeList.ModelToVM().AsQueryable();
            return PaginatedList<ProductTypeListViewModel>.Create(vm, pageNumber, pageSize);

        }
    }
}
