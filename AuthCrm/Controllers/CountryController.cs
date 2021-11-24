using AuthCrm.Service.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AuthCrm.Controllers
{
    public class CountryController : Controller
    {
        private readonly ICountryService _countryService;
        public CountryController(ICountryService countryService)
        {
            _countryService = countryService;
        }
        public async Task<IActionResult> Index()
        {
            var result = await _countryService.GetItems();
            return await Task.FromResult(View(result)) ;
        }
        public async Task<IActionResult> Create()
        {
            return await Task.FromResult(View());
        }
    }
}
