using AutoMapper;

namespace Inventory.Repositories.Services.Repo
{
    public class VendorRepo : IVendorRepo
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public VendorRepo(ApplicationDbContext _context, IMapper _mapper)
        {
            context = _context;
            mapper = _mapper;
        }
        public PaginatedList<VendorListViewModel> GetAll(int PageNumber, int PageSize)
        {
            var VendorList = context.Vendors;
            var vm = mapper.Map<IEnumerable<VendorListViewModel>>(VendorList).AsQueryable();
            return PaginatedList<VendorListViewModel>.Create(vm, PageNumber, PageSize);
        }
        public void Add(CreateVendorViewModel model)
        {
            var Vendor = mapper.Map<Vendor>(model);
            context.Vendors.Add(Vendor);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var Vendor = context.Vendors.FirstOrDefault(v => v.VendorId == id);
            if (Vendor != null)
            {
                context.Vendors.Remove(Vendor);

            }
            context.SaveChanges();
        }

       

        public VendorViewModel GetById(int id)
        {
            var Vendor = context.Vendors.Find(id);
            
             var vm = mapper.Map<VendorViewModel>(Vendor);
            
            return vm;
        }

        public void Update(VendorViewModel model)
        {
            var Vendor = context.Vendors.FirstOrDefault(v=>v.VendorId==model.VendorId);
            if (Vendor != null)
            {
                Vendor.Address = model.Address;
                Vendor.City = model.City;
                Vendor.Email = model.Email;
                Vendor.Phone = model.Phone;
                Vendor.ContactPerson = model.ContactPerson;
                Vendor.State = model.State;
                Vendor.VendorName = model.VendorName;
                Vendor.VendorTypeId = model.VendorTypeId;
                Vendor.ZipCode = model.ZipCode;
            }
            context.SaveChanges();
        }
    }
}
