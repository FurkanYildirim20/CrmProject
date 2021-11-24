using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AuthCrm.ViewComponents
{
    public class SideBarViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.Factory.StartNew(() => { return View(); });
        }
    }
}
