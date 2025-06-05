using BabyCareProject.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace BabyCareProject.ViewComponents;

public class ServiceViewComponent(IServiceManager _manager):ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync()
    {
        var services=await _manager.HizmetService.GetAllAsync();
        return View(services);
    }
}
