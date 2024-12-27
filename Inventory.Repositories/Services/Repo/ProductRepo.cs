using Inventory.Repositories.Paging;
using Inventory.Repositories.Services.IRepo;
using Inventory.ViewModels.Mapping;
using Inventory.ViewModels.ProductVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Repositories.Services.Repo
{
    public class ProductRepo : IProductRepo
    {
        private ApplicationDbContext _context;

        public ProductRepo(ApplicationDbContext context)
        {
            _context = context;
        }
        public PaginatedList<ProductListViewModel> GetAll(int pageNumber, int pageSize)
        {
            var ProductList = _context.Products.ToList();
            var vm = ProductList.ModelToVM().AsQueryable();
            return PaginatedList<ProductListViewModel>.Create(vm, pageNumber, pageSize);

        }
    }
}
