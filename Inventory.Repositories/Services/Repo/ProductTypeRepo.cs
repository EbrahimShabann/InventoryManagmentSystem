using Inventory.Repositories.Paging;
using Inventory.Repositories.Services.IRepo;
using Inventory.ViewModels.BillVM;
using Inventory.ViewModels.Mapping;
using Inventory.ViewModels.ProductVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
