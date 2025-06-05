using BabyCareProject.Dtos.ServiceDtos;
using BabyCareProject.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace BabyCareProject.Areas.Admin.Controllers;
[Area("Admin")]
public class ServiceController(IServiceManager manager): Controller
{
    private readonly IServiceManager _manager = manager;

    public async Task<IActionResult> Index()
    {
        var models = await _manager.HizmetService.GetAllAsync();
        return View(models);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateServiceDto serviceDto)
    {
        await _manager.HizmetService.CreateAsync(serviceDto);
        return RedirectToAction("Index");
    }

    public async Task<IActionResult> Delete(string id)
    {
        await _manager.HizmetService.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public async Task<IActionResult> Update(string id)
    {
        var model = await _manager.HizmetService.GetByIdAsync(id);
        return View(model);
    }

    [HttpPost]
    public async Task<IActionResult> Update(UpdateServiceDto serviceDto)
    {
        await _manager.HizmetService.UpdateAsync(serviceDto);
        return RedirectToAction(nameof(Index));
    }
}