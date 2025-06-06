using Microsoft.AspNetCore.Mvc;
using BabyCareProject.Areas.Admin.Data;
using BabyCareProject.Services.Contracts;
namespace BabyCareProject.Areas.Admin.Controllers;

[Area("Admin")]
public class DashboardController(IServiceManager serviceManager) : Controller
{
    public async Task<IActionResult> Index()
    {
        var model = new DashboardViewModel
        {
            TotalTeachers = (await serviceManager.InstructorService.GetAllAsync()).Count,
            TotalSubscribers = (await serviceManager.SubscriberService.GetAllAsync()).Count,
            TotalCourses = (await serviceManager.ProductService.GetAllAsync()).Count,
            TotalRating = (await serviceManager.TestimonialService.GetAllAsync()).Count,
            TotalMessageReceived = (await serviceManager.MessageService.GetAllAsync()).Count,
            TotalEvents = (await serviceManager.EventService.GetAllAsync()).Count
        };
        return View(model);
    }
}
