using AuthCrm.Data.DTOs;
using AuthCrm.Models.CompanyViewModels;
using AuthCrm.Service.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AuthCrm.Controllers
{
    public class CompanyController : Controller
    {
        private readonly ICompanyService _companyService;
        private readonly ICityService _cityService;

        public CompanyController(ICompanyService companyService, ICityService cityService)
        {
            _companyService = companyService;
            _cityService = cityService;
        }

        public async Task<IActionResult> Index()
        {
            var result = await _companyService.GetItems();
            return View(result);
        }

        public async Task<IActionResult> Create()
        {
            var model = new CreateViewModel
            {
                Company = new CompanyDto(),
                Cities = await _cityService.GetItems()
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateViewModel model)
        {
            await _companyService.Insert(model.Company);
            return RedirectToAction("Index");
        }

        //public IActionResult Delete(int Id)
        //{
        //    var result = _companyService.GetById(Id);
        //    if (result != null)
        //    {
        //        _companyService.Delete(result);
        //    }
        //    return RedirectToAction("Index");
        //}

        public async Task<IActionResult> Update(int Id)
        {
            var result = await _companyService.GetById(Id);
            return View(result);
        }

        [HttpPost]
        public async Task<IActionResult> Update(CompanyDto company)
        {
           await _companyService.Update(company);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Detail(int Id)
        {
            var result = await _companyService.GetById(Id);
            return View(result);
        }
    }
}