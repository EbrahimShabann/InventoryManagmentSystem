using Inventory.Repositories.Services.IRepo;
using Inventory.ViewModels.BillVM;
using Microsoft.AspNetCore.Mvc;

namespace Inventory.Web.Controllers
{
    public class BillController : Controller
    {
        private readonly IUnitOfWork _uof;

        public BillController(IUnitOfWork uof)
        {
            _uof = uof;
        }

        public IActionResult Index(int pageNumber= 1 ,int pageSize= 10)
        {
            var bills = _uof.billRepo.GetAll(pageNumber, pageSize);
            return View(bills);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(); 
        }
        [HttpPost]
        public IActionResult Create(CreateBillViewModel model)
        {
            if (ModelState.IsValid) 
            {
                _uof.billRepo.Add(model);
                return RedirectToAction("Index");
            }
            return View();
            

        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var bill = _uof.billRepo.GetById(id);
            return View(bill);
        }
        [HttpPost]
        public IActionResult Edit(BillViewModel bill) 
        {
            if (ModelState.IsValid)
            {
                _uof.billRepo.Update(bill);
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Delete(int id) 
        {
            _uof.billRepo.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
