using BabyCareProject.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace BabyCareProject.ViewComponents
{
    public class AboutViewComponent(IServiceManager serviceManager): ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var about=(await serviceManager.AboutService.GetAllAsync()).FirstOrDefault();
            return View(about);
        }
    }
}
