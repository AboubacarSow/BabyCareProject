using BabyCareProject.Dtos.MessageDtos;
using BabyCareProject.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using System.Threading.Tasks;

namespace BabyCareProject.Areas.Admin.Controllers;
[Area("Admin")]
public class MessageController(IServiceManager manager):Controller
{
    public async Task<IActionResult> Index()
    {
       return View(await manager.MessageService.GetAllAsync());
    }
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Create(CreateMessageDto messageDto)
    {
        await manager.MessageService.CreateAsync(messageDto);
        return RedirectToAction(nameof(Index));
    }
    [HttpGet]
    public async Task<IActionResult> Edit(string Id)
    {
        return View(await manager.MessageService.GetByIdAsync(Id)); 
    }
    [HttpPost]
    public async Task<IActionResult> Edit(UpdateMessageDto messageDto)
    {
        await manager.MessageService.UpdateAsync(messageDto);   
        return RedirectToAction(nameof(Index));
    }
    [HttpGet]
    public async Task<ActionResult> Delete(string Id)
    {
        await manager.MessageService.DeleteAsync(Id);
        return RedirectToAction(nameof(Index));
    }
}
