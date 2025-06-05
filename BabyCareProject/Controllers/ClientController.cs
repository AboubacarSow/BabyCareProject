using BabyCareProject.Dtos.MessageDtos;
using BabyCareProject.Dtos.SubscriberDtos;
using BabyCareProject.Services.Contracts;
using BabyCareProject.Services.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Threading.Tasks;

namespace BabyCareProject.Controllers;

public class ClientController(IServiceManager serviceManager) : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Subscribe([FromBody]CreateSubscriberDto subscriberDto)
    {
        try
        {
            await serviceManager.SubscriberService.CreateAsync(subscriberDto);
            return Json(new {success = true});
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex);
            return Json(new {success=false});
        }
    }
    public async Task<IActionResult> Contact()
    {
        var about = (await serviceManager.ContactService.GetAllAsync()).FirstOrDefault();
        return View(about);
    }
    public async Task<IActionResult> Course()
    {
        var programs = await serviceManager.ProductService.GetAllAsync();
        return View(programs);
    }
    public async Task<IActionResult> Team()
    {
        var teams = await serviceManager.InstructorService.GetAllAsync();
        return View(teams);
    }
    public async Task<IActionResult> Testimonial()
    {
        var resultTestimonials = await serviceManager.TestimonialService.GetAllAsync();
        return View(resultTestimonials);
    }
    public async Task<IActionResult> About()
    {
        var about = (await serviceManager.AboutService.GetAllAsync()).FirstOrDefault();
        return View(about);
    }
    public async Task<IActionResult> Service()
    {
        var services = await serviceManager.HizmetService.GetAllAsync();
        return View(services);
    }
    public async Task<IActionResult> Event()
    {
        var events = await serviceManager.EventService.GetAllAsync();
        return View(events);
    }
    [HttpPost]
    public async Task<IActionResult> SendMessage([FromBody]CreateMessageDto messageDto)
    {
        try
        {
            await serviceManager.MessageService.CreateAsync(messageDto);
            return Json(new {success=true});    

        }catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            return Json(new {success=false});
        }
    }
}
