using BabyCareProject.Dtos.GalleryDtos;
using BabyCareProject.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace BabyCareProject.Areas.Admin.Controllers;

[Area("Admin")]
public class GalleryController(IServiceManager manager) : Controller
{
    public async Task<IActionResult> Index()
    {
        var models = await manager.GalleryService.GetAllAsync();
        return View(models);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateGalleryDto galleryDto)
    {
        if(!ModelState.IsValid)
            return View(galleryDto);
        await manager.GalleryService.CreateAsync(galleryDto);
        return RedirectToAction("Index");
    }

    public async Task<IActionResult> Delete(string id)
    {
        await manager.GalleryService.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public async Task<IActionResult> Update(string id)
    {
        var model = await manager.GalleryService.GetByIdAsync(id);
        return View(model);
    }

    [HttpPost]
    public async Task<IActionResult> Update(UpdateGalleryDto galleryDto)
    {
        if(!ModelState.IsValid)
            return View(galleryDto);
        await manager.GalleryService.UpdateAsync(galleryDto);
        return RedirectToAction(nameof(Index));
    }
}
