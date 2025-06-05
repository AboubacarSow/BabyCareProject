using BabyCareProject.Dtos.SocialMediaDtos;
using BabyCareProject.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace BabyCareProject.Areas.Admin.Controllers;
[Area("Admin")]
public class SocialMediaController(IServiceManager manager) : Controller
{
    private readonly IServiceManager _manager = manager;

    public async Task<IActionResult> Index()
    {
        var models = await _manager.SocialMediaService.GetAllAsync();
        return View(models);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateSocialMediaDto socialMediaDto)
    {
        await _manager.SocialMediaService.CreateAsync(socialMediaDto);
        return RedirectToAction("Index");
    }

    public async Task<IActionResult> Delete(string id)
    {
        await _manager.SocialMediaService.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public async Task<IActionResult> Update(string id)
    {
        var model = await _manager.SocialMediaService.GetByIdAsync(id);
        return View(model);
    }

    [HttpPost]
    public async Task<IActionResult> Update(UpdateSocialMediaDto socialMediaDto)
    {
        await _manager.SocialMediaService.UpdateAsync(socialMediaDto);
        return RedirectToAction(nameof(Index));
    }
}