using BabyCareProject.Dtos.EventDtos;
using BabyCareProject.Services.Contracts;
using Microsoft.AspNetCore.Mvc;


[Area("Admin")]
public class EventController(IServiceManager manager) : Controller
{
    public async Task<IActionResult> Index()
    {
        var models=await manager.EventService.GetAllAsync();    
        return View(models);
    }
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Create(CreateEventDto eventDto)
    {
        await manager.EventService.CreateAsync(eventDto);
        return RedirectToAction("Index");   
    }
    [HttpPost]
    public async Task<IActionResult> Delete(string id)
    {
        await manager.EventService.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }
    [HttpGet]
    public async Task<IActionResult> Update(string Id)
    {
        var model=await manager.EventService.GetByIdAsync(Id);  
        return View(model);
    }
    [HttpPost]
    public async Task<IActionResult> Update(UpdateEventDto eventDto)
    {
        await manager.EventService.UpdateAsync(eventDto);
        return RedirectToAction(nameof(Index)); 
    }
}
