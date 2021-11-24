using AuthCrm.Service.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AuthCrm.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public async Task<IActionResult> Index()
        {
            var result = await _customerService.GetItems();
            return View(result);
        }
        //public IActionResult Create()
        //{
        //List<SelectListItem> values = (from item in _companyService.GetCompanies()
        //                               select new SelectListItem()
        //                               {
        //                                   Text = item.CompanyName,
        //                                   Value = item.CompanyId.ToString()
        //                               }).ToList();
        //ViewBag.Companies = values;
        //    return View();
        //}
        //[HttpPost]
        //public IActionResult Create(Customer customer)
        //{
        //    _customerService.Add(customer);
        //    return RedirectToAction("Index");
        //}
        //public IActionResult Update(int Id)
        //{
        //List<SelectListItem> values = (from item in _companyService.GetCompanies()
        //                               select new SelectListItem()
        //                               {
        //                                   Text = item.CompanyName,
        //                                   Value = item.CompanyId.ToString()
        //                               }).ToList();
        //ViewBag.Companies = values;
        //var result = _customerService.GetByCustomerId(Id);
        //return View(result);
        //    return View();
        //}
        //[HttpPost]
        //public IActionResult Update(CustomerDetailDto model)
        //{
        //if (!ModelState.IsValid)
        //{
        //    return BadRequest();
        //}
        //var oldItem = _customerService.GetById(model.Id);

        //oldItem.CustomerName = model.CustomerName;
        //oldItem.CustomerNumber = model.CustomerNumber;
        //oldItem.CustomerEmail = model.CustomerEmail;
        //oldItem.CompanyId = model.CompanyId;
        //_customerService.Update(oldItem);
        //return RedirectToAction("Index");
        //    return Ok();
        //}
        //public IActionResult Delete(int Id)
        //{
        //    var result = _customerService.GetById(Id);
        //    if (result != null)
        //    {
        //        _customerService.Delete(result);
        //    }
        //    return RedirectToAction("Index");
        //}
        //public IActionResult Detail(int Id)
        //{
        //    var result = _customerService.GetByCustomerId(Id);
        //    return View(result);
        //}
    }
}