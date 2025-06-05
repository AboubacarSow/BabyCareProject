using BabyCareProject.Dtos.AboutDtos;
using BabyCareProject.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace BabyCareProject.Areas.Admin.Controllers;

[Area("Admin")]
public class AboutController(IServiceManager manager) : Controller
{
    private readonly IServiceManager _manager = manager;

    public async Task<IActionResult> Index()
    {
        var models=await _manager.AboutService.GetAllAsync();
        return View(models);
    }
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Create(CreateAboutDto createAboutDto)
    {
        if (!ModelState.IsValid)
            return View(createAboutDto);
        await _manager.AboutService.CreateAsync(createAboutDto);
        return RedirectToAction(nameof(Index));
    }
    public async Task<IActionResult> Delete(string id)
    {
        await _manager.AboutService.DeleteAsync(id);    
        return RedirectToAction(nameof(Index)); 
    }
    [HttpGet]
    public async Task<IActionResult> Update(string Id)
    {
        var about=await _manager.AboutService.GetByIdAsync(Id);
        return View(about);
    }
    [HttpPost]
    public async Task<IActionResult> Update(UpdateAboutDto aboutDto)
    {
        if (!ModelState.IsValid)
            return View(aboutDto);
        await _manager.AboutService.UpdateAsync(aboutDto);
        return RedirectToAction($"{nameof(Index)}");
    }
}
