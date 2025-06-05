using BabyCareProject.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace BabyCareProject.ViewComponents;

public class TestimonialViewComponent(IServiceManager serviceManager):ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync()
    {
        var resultTestimonials = await serviceManager.TestimonialService.GetAllAsync();
        return View(resultTestimonials);
    }
}
