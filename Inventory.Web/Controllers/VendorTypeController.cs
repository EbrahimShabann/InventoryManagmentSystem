namespace Inventory.Web.Controllers
{
    public class VendorTypeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public VendorTypeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult Index(int pageNumber=1 ,int pageSize=10)
        {
            var tybes = _unitOfWork.vendorTypeRepo.GetAll(pageNumber,pageSize);
            return View(tybes);
        }
        [HttpGet]
        public IActionResult Create() 
        { 
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateVendorTypeViewModel model)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.vendorTypeRepo.Add(model);
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Edit(int id) {
            var type = _unitOfWork.vendorTypeRepo.GetById(id);
            return View(type);
        }
        [HttpPost]
        public IActionResult Edit(VendorTypeViewModel model)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.vendorTypeRepo.Update(model);
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            _unitOfWork.vendorTypeRepo.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
