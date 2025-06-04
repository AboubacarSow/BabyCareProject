using BabyCareProject.Dtos.TestimonialDtos;
using BabyCareProject.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace BabyCareProject.Areas.Admin.Controllers;
public class TestimonialController(IServiceManager manager) : Controller
{
    private readonly IServiceManager _manager = manager;

    public async Task<IActionResult> Index()
    {
        var models = await _manager.TestimonialService.GetAllAsync();
        return View(models);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateTestimonialDto testimonialDto)
    {
        await _manager.TestimonialService.CreateAsync(testimonialDto);
        return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    public async Task<IActionResult> Delete(string id)
    {
        await _manager.TestimonialService.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

   
}