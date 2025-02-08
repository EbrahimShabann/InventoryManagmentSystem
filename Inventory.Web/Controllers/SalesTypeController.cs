using AutoMapper;
using Inventory.ViewModels.SalesTypeVM;

namespace Inventory.Web.Controllers
{
    public class SalesTypeController: Controller
    {
        private readonly IUnitOfWork _Uof;
        
        public SalesTypeController(IUnitOfWork uof)
        {
            _Uof = uof;
            
        }
        public IActionResult Index(int pageNumber=1 , int PageSize=10)
        {
            
            var SalesTypeList = _Uof.salesTypeRepo.GetAll(pageNumber, PageSize);
            return View(SalesTypeList);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateSalesTypeViewModel model)
        {
            if (ModelState.IsValid)
            {
                _Uof.salesTypeRepo.Add(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public IActionResult Edit(int id)
        {
            var SalesType = _Uof.salesTypeRepo.GetById(id);
            return View(SalesType);
        }
        [HttpPost]
        public IActionResult Edit(SalesTypeViewModel model)
        {
            if (ModelState.IsValid)
            {
                _Uof.salesTypeRepo.Update(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public IActionResult Delete(int id)
        {
            _Uof.salesTypeRepo.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
