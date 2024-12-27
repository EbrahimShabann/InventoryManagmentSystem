using Inventory.Repositories.Services.IRepo;
using Inventory.ViewModels.CustomerVM;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Reflection.Metadata.Ecma335;

namespace Inventory.Web.Controllers
{
    public class CustomerTypeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public CustomerTypeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult Index(int pageNumber = 1, int pageSize = 10)
        {
            var customerTypes = _unitOfWork.customerTypeRepo.GetAll(pageNumber, pageSize);

            return View(customerTypes);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateCustomerTypeViewModel model)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.customerTypeRepo.Add(model);
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = _unitOfWork.customerTypeRepo.GetById(id);
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(CustomerTypeViewModel model)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.customerTypeRepo.Update(model);
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Delete(int id) { 
        _unitOfWork.customerTypeRepo.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
