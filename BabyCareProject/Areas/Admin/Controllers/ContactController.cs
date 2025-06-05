using BabyCareProject.Dtos.ContactDtos;
using BabyCareProject.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BabyCareProject.Areas.Admin.Controllers;

[Area("Admin")]
public class ContactController(IServiceManager _manager) : Controller
{
    public async Task<IActionResult> Index()
    {
        var models=await _manager.ContactService.GetAllAsync();
        return View(models);
    }
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Create(CreateContactDto contactDto)
    {
        if(!ModelState.IsValid)
            return View(contactDto);
        await _manager.ContactService.CreateAsync(contactDto);
        return RedirectToAction(nameof(Index));
    }
    [HttpGet]
    public async Task<IActionResult> Update(string Id)
    {
        var model=await _manager.ContactService.GetByIdAsync(Id);   
        return View(model);
    }
    [HttpPost]
    public async Task<IActionResult> Update(UpdateContactDto contactDto)
    {
        if(!ModelState.IsValid)
            return View(contactDto);
        await _manager.ContactService.UpdateAsync(contactDto);
        return RedirectToAction(nameof(Index));
    }
    public async Task<IActionResult> Delete(string Id)
    {
        await _manager.ContactService.DeleteAsync(Id);
        return RedirectToAction(nameof(Index)); 
    }
}
