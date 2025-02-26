﻿namespace Inventory.Repositories.Services.Repo
{
    public class CustomerRepo : ICustomerRepo
    {
        private ApplicationDbContext _context;

        public CustomerRepo(ApplicationDbContext context)
        {
            _context = context;
        }
        public PaginatedList<CustomerListViewModel> GetAll(int pageNumber, int pageSize)
        {
            var customerList = _context.Customers.ToList();
            var vm = customerList.ModelToVM().AsQueryable();
            return PaginatedList<CustomerListViewModel>.Create(vm, pageNumber, pageSize);

        }
    }
}
