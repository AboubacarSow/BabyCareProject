using BabyCareProject.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace BabyCareProject.ViewComponents
{
    public class TeamViewComponent(IServiceManager serviceManager):ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var teams = await serviceManager.InstructorService.GetAllAsync();
            return View(teams);
        }
    }
}
