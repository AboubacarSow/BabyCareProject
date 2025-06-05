using BabyCareProject.Areas.Admin.Data;
using BabyCareProject.Dtos.SubscriberDtos;
using BabyCareProject.Infrastructure.Utilities;
using BabyCareProject.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace BabyCareProject.Areas.Admin.Controllers;
[Area("Admin")]
public class SubscriberController(IServiceManager manager,EmailService emailService) : Controller
{
    private readonly IServiceManager _manager = manager;
    private readonly EmailService _emailService=emailService;
    public async Task<IActionResult> Index()
    {
        var models = await _manager.SubscriberService.GetAllAsync();
        return View(models);
    }
    
    public async Task<IActionResult> Delete(string id)
    {
        await _manager.SubscriberService.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }
    [HttpPost]
    public async Task<IActionResult> SendEmail([FromBody]SendEmailModel model)
    {
        var result = await _emailService.SendEmailAsync(model);
        return result ? Json(new { success = true }) : Json(new { success = false });
    }
}