using BabyCareProject.Dtos.InstructorDtos;
using BabyCareProject.Services.Contracts;
using Microsoft.AspNetCore.Mvc;


namespace BabyCareProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class InstructorController(IServiceManager manager) : Controller
    {
        private readonly IServiceManager _manager = manager;

        public async Task<IActionResult> Index()
        {
            var results =await  _manager.InstructorService.GetAllAsync();
            return View(results);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateInstructorDto instructorDto)
        {
            if(!ModelState.IsValid)
                return View(instructorDto);
            await _manager.InstructorService.CreateAsync(instructorDto);
            return RedirectToAction("Index");
        }
        
        [HttpGet]
        public async Task<IActionResult> Update([FromRoute]string id)
        {
            var model = await _manager.InstructorService.GetByIdAsync(id);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Update(UpdateInstructorDto instructorDto)
        {
            if(!ModelState.IsValid)
                return View(instructorDto);
            await _manager.InstructorService.UpdateAsync(instructorDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(string id)
        {
            await _manager.InstructorService.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}
