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
    public async Task<ActionResult> Delete(string Id)
    {
        await manager.MessageService.DeleteAsync(Id);
        return RedirectToAction(nameof(Index));
    }
}
