using BabyCareProject.Dtos.SubscriberDtos;
using BabyCareProject.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace BabyCareProject.Areas.Admin.Controllers;  
public class SubscriberController(IServiceManager manager) : Controller
{
    private readonly IServiceManager _manager = manager;
    public async Task<IActionResult> Index()
    {
        var models = await _manager.SubscriberService.GetAllAsync();
        return View(models);
    }
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Create(CreateSubscriberDto subscriberDto)
    {
        await _manager.SubscriberService.CreateAsync(subscriberDto);
        return RedirectToAction(nameof(Index));
    }
    [HttpPost]
    public async Task<IActionResult> Delete(string id)
    {
        await _manager.SubscriberService.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }
}