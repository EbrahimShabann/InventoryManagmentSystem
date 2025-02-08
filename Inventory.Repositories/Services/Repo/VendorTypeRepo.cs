using AutoMapper;

namespace Inventory.Repositories.Services.Repo
{
    public class VendorTypeRepo : IVendorTypeRepo
    {
        
        
            private ApplicationDbContext _context;
            private readonly IMapper _mapper;

        public VendorTypeRepo(ApplicationDbContext context, IMapper mapper)
            {
                _context = context;
            _mapper = mapper;
        }

            public PaginatedList<VendorTypeListViewModel> GetAll(int pageNumber, int pageSize)
            {
            var TypeList = _context.VendorTypes.AsEnumerable();
                var vm = _mapper.Map<IEnumerable<VendorTypeListViewModel>>(TypeList).AsQueryable();
                return PaginatedList<VendorTypeListViewModel>.Create(vm, pageNumber, pageSize);

            }

            public void Add(CreateVendorTypeViewModel model)
            {
                var vendorType = _mapper.Map<VendorType>(model);
            _context.VendorTypes.Add(vendorType);
                _context.SaveChanges();
            }

            public void Delete(int id)
            {
                var vendorType = _context.VendorTypes.FirstOrDefault(b => b.VendorTypeId == id);
                if (vendorType != null)
                {

                    _context.VendorTypes.Remove(vendorType);
                }

                _context.SaveChanges();
            }
            public VendorTypeViewModel GetById(int id)
            {
                var vendorType = _context.VendorTypes.FirstOrDefault(b => b.VendorTypeId == id);
                var vm = _mapper.Map<VendorTypeViewModel>(vendorType);

            return vm;
            }

            public void Update(VendorTypeViewModel vm)
            {

                var model = _context.VendorTypes.FirstOrDefault(b => b.VendorTypeId == vm.VendorTypeId);
                if (model != null)
                {


                    model.VendorTypeName = vm.VendorTypeName;
                    model.Description = vm.Description;

                }
                _context.SaveChanges();

            
            }
    }
}
