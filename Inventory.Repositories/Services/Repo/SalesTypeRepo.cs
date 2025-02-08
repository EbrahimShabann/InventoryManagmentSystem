using AutoMapper;
using Inventory.ViewModels.SalesTypeVM;

namespace Inventory.Repositories.Services.Repo
{
    public class SalesTypeRepo : ISalesTypeRepo
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;
        public SalesTypeRepo(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public void Add(CreateSalesTypeViewModel model)
        {
           var salesType = _mapper.Map<SalesType>(model);
            _db.SalesTypes.Add(salesType);
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            var SalesType = _db.SalesTypes.Find(id);
            if (SalesType != null)
            {
                _db.SalesTypes.Remove(SalesType);
            }
            _db.SaveChanges();
        }

        public PaginatedList<SalesTypeListViewModel> GetAll(int pageNumber, int pageSize)
        {
            var SalesTypeList = _db.SalesTypes;
            var vm = _mapper.Map<IEnumerable<SalesTypeListViewModel>>(SalesTypeList).AsQueryable();
            return PaginatedList<SalesTypeListViewModel>.Create(vm, pageNumber, pageSize);
        }

        public SalesTypeViewModel GetById(int id)
        {
            var SalesType = _db.SalesTypes.Find(id);
            var vm = _mapper.Map<SalesTypeViewModel>(SalesType);
            return vm;
        }

        public void Update(SalesTypeViewModel model)
        {
            var SalesType = _db.SalesTypes.Find(model.SalesTypeId);
            SalesType.SalesTypeName = model.SalesTypeName;
            SalesType.Description = model.Description;
            _db.SaveChanges();
        }
    }
}
