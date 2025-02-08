namespace Inventory.Repositories.Services.Repo
{
    public class CustomerTypeRepo : ICustomerTypeRepo
    {
        private ApplicationDbContext _context;

        public CustomerTypeRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public PaginatedList<CustomerTypeListViewModel> GetAll(int pageNumber, int pageSize)
        {
            var customerTypeList = _context.CustomerTypes.ToList();
            var vm = customerTypeList.ModelToVM().AsQueryable();
            return PaginatedList<CustomerTypeListViewModel>.Create(vm, pageNumber, pageSize);

        }

        public void Add(CreateCustomerTypeViewModel model)
        {
            var customerType = model.VMtoModel();
            _context.CustomerTypes.Add(customerType);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var customerType = _context.CustomerTypes.FirstOrDefault(b => b.CustomerTypeId == id);
            if (customerType != null)
            {

                _context.CustomerTypes.Remove(customerType);
            }

            _context.SaveChanges();
        }
        public CustomerTypeViewModel GetById(int id)
        {
            var CustomerType = _context.CustomerTypes.FirstOrDefault(b => b.CustomerTypeId == id);
            var vm = new CustomerTypeViewModel(CustomerType);

            return vm;
        }

        public void Update(CustomerTypeViewModel vm)
        {

            var model = _context.CustomerTypes.FirstOrDefault(b => b.CustomerTypeId == vm.CustomerTypeId);
            if (model != null)
            {


                model.CustomerTypeName = vm.CustomerTypeName;
                model.Description = vm.Description;

            }
            _context.SaveChanges();

        }
    }
}
