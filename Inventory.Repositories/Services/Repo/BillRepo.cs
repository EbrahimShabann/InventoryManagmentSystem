using AutoMapper;

namespace Inventory.Repositories.Services.Repo
{
    public class BillRepo : IBillRepo
    {

        private ApplicationDbContext _context;
        private readonly IMapper _mapper;

       

        public BillRepo(ApplicationDbContext context,IMapper mapper )
        {
            _context = context;
            _mapper = mapper;
        }
        public PaginatedList<BillListViewModel> GetAll(int pageNumber, int pageSize)
        {
            var BillList = _context.Bills;
            var vm = _mapper.Map<IEnumerable<BillListViewModel>>(BillList).AsQueryable();
            return PaginatedList<BillListViewModel>.Create(vm, pageNumber, pageSize);

        }
        public void Add(CreateBillViewModel model)
        {
            var bill = _mapper.Map<Bill>(model);
            _context.Bills.Add(bill);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var bill = _context.Bills.FirstOrDefault(b => b.BillId == id);
            if (bill != null)
            {

                _context.Bills.Remove(bill);
            }

            _context.SaveChanges();
        }
        public BillViewModel GetById(int id)
        {
            var bill = _context.Bills.FirstOrDefault(b => b.BillId == id);
            var vm =_mapper.Map<BillViewModel>(bill);

            return vm;
        }

        public void Update(BillViewModel vm)
        {

            var model = _context.Bills.FirstOrDefault(b => b.BillId == vm.BillId);
            if (model != null)
            {
                model.BillName = vm.BillName;
                model.BillDate = vm.BillDate;
                model.BillDueDate = vm.BillDueDate;
                model.VendorDoNumber = vm.VendorDoNumber;
                model.VendorInvoiceNumber = vm.VendorInvoiceNumber;
                model.GoodsReceivedNoteId = vm.GoodsReceivedNoteId;
                model.BillTypeId = vm.BillTypeId;


            }
            _context.SaveChanges();

        }
    }
}

