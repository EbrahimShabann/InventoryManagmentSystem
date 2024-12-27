
using Inventory.Repositories.Paging;
using Inventory.Repositories.Services.IRepo;
using Inventory.ViewModels.BillVM;
using Inventory.ViewModels.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Repositories.Services.Repo
{
    public class BillRepo : IBillRepo
    {

        private ApplicationDbContext _context;

        public BillRepo(ApplicationDbContext context)
        {
            _context = context;
        }
        public PaginatedList<BillListViewModel> GetAll(int pageNumber, int pageSize)
        {
            var BillList = _context.Bills;
            var vm = BillList.ModelToVM().AsQueryable();
            return PaginatedList<BillListViewModel>.Create(vm, pageNumber, pageSize);

        }
        public void Add(CreateBillViewModel model)
        {
            var bill = model.VMtoModel();
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
            var vm = new BillViewModel(bill);

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

