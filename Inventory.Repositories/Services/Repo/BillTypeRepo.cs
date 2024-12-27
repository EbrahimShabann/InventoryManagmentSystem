using Inventory.Models;
using Inventory.Repositories.Paging;
using Inventory.Repositories.Services.IRepo;
using Inventory.ViewModels.BillVM;
using Inventory.ViewModels.Mapping;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Repositories.Services.Repo
{
    public class BillTypeRepo : IBillTypeRepo
    {

        private ApplicationDbContext _context;

        public BillTypeRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(CreateBillTypeViewModel model)
        {
            var billType = model.VMtoModel();
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
            var vm = BillTypeList.ModelToVM().AsQueryable();
            return PaginatedList<BillTypeListViewModel>.Create(vm, pageNumber, pageSize);

        }

        public BillTypeViewModel GetById(int id)
        {
            var billType = _context.BillTypes.FirstOrDefault(b => b.BillTypeId == id);
            var vm = new BillTypeViewModel(billType);

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

