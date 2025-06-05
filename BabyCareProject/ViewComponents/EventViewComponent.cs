using BabyCareProject.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace BabyCareProject.ViewComponents;

public class EventViewComponent(IServiceManager _manager):ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync()
    {
        var events = await _manager.EventService.GetAllAsync();
        return View(events);
    }
}

