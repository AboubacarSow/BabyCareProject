using BabyCareProject.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace BabyCareProject.ViewComponents;

public class CourseViewComponent(IServiceManager _manager) : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync()
    {
        var programs = await _manager.ProductService.GetAllAsync();
        return View(programs);
    }
}
