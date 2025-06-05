using BabyCareProject.Dtos.ContactDtos;
using BabyCareProject.Models;
using BabyCareProject.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace BabyCareProject.ViewComponents;

public class FooterViewComponent(IServiceManager _serviceManager):ViewComponent
{
    
    public async Task<IViewComponentResult> InvokeAsync()
    {
        var model = new FooterModelView
        {
            Contact = (await _serviceManager.ContactService.GetAllAsync())[1] ?? new ResultContactDto(),
            Galleries = await _serviceManager.GalleryService.GetAllAsync()
        };
        return View(model);
    }
}
