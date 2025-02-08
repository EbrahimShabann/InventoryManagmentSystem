using AutoMapper;

namespace Inventory.Repositories.Services.Repo
{
    public class BillTypeRepo : IBillTypeRepo
    {

        private ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public BillTypeRepo(ApplicationDbContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;

        }

        public void Add(CreateBillTypeViewModel model)
        {
            var billType = _mapper.Map<BillType>(model);
            _context.BillTypes.Add(billType);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var billType = _context.BillTypes.FirstOrDefault(b => b.BillTypeId == id);
            if (billType != null)
            {

                _context.BillTypes.Remove(billType);
            }

            _context.SaveChanges();
        }

        public PaginatedList<BillTypeListViewModel> GetAll(int pageNumber, int pageSize)
        {
            var BillTypeList = _context.BillTypes.ToList();
            var vm = _mapper.Map<List<BillTypeListViewModel>>(BillTypeList).AsQueryable();
            return PaginatedList<BillTypeListViewModel>.Create(vm, pageNumber, pageSize);

        }

        public BillTypeViewModel GetById(int id)
        {
            var billType = _context.BillTypes.FirstOrDefault(b => b.BillTypeId == id);
            var vm = _mapper.Map<BillTypeViewModel>(billType);

            return vm;
        }

        public void Update(BillTypeViewModel vm)
        {

            var model = _context.BillTypes.FirstOrDefault(b => b.BillTypeId == vm.BillTypeId);
            if (model != null)
            {


                model.BillTypeName = vm.BillTypeName;
                model.Description = vm.Description;

            }
            _context.SaveChanges();

        }
    }
}

