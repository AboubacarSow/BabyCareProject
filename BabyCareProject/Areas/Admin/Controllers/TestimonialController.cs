using BabyCareProject.Dtos.TestimonialDtos;
using BabyCareProject.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BabyCareProject.Areas.Admin.Controllers;
[Area("Admin")]
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
    [HttpGet]
    public async Task<IActionResult> Update(string id)
    {
        var model=await _manager.TestimonialService.GetByIdAsync(id);    
        return View(model); 
    }
    [HttpPost]
    public async Task<IActionResult> Update(UpdateTestimonialDto testimonialDto)
    {
        if(!ModelState.IsValid)
            return View(testimonialDto);
        await _manager.TestimonialService.UpdateAsync(testimonialDto);
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Delete(string id)
    {
        await _manager.TestimonialService.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

   
}