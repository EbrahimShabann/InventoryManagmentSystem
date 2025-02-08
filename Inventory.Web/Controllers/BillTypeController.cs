namespace Inventory.Web.Controllers
{
    public class BillTypeController : Controller
    {
        private readonly IUnitOfWork _uof;

        public BillTypeController(IUnitOfWork uof)
        {
            _uof = uof;
        }
        [HttpGet]
        public IActionResult Index(int pageNumber = 1, int pageSize = 10)
        {
            var billTypes =  _uof.billTypeRepo.GetAll( pageNumber,  pageSize);
            return  View(billTypes);
        }
        [HttpGet]
        public IActionResult Create() 
        { 
            return View();
        }
        [HttpPost]
        public IActionResult Create (CreateBillTypeViewModel model)
        {
            if (ModelState.IsValid)
            {
                _uof.billTypeRepo.Add(model);
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Edit(int id) 
        {
            var model = _uof.billTypeRepo.GetById(id);
            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(BillTypeViewModel model) 
        {
            if (ModelState.IsValid) 
            {
                _uof.billTypeRepo.Update(model);
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {

            _uof.billTypeRepo.Delete(id);
            return RedirectToAction("Index");
        }

    }
}
