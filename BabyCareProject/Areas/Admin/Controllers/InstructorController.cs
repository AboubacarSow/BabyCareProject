using BabyCareProject.Dtos.InstructorDtos;
using BabyCareProject.Services.Contracts;
using Microsoft.AspNetCore.Mvc;


namespace BabyCareProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class InstructorController : Controller
    {
        private readonly IInstructorService _instructorService;

        public InstructorController(IInstructorService instructorService)
        {
            _instructorService = instructorService;
        }

        public async Task<IActionResult> Index()
        {
            var results =await  _instructorService.GetAllAsync();
            return View(results);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateInstructorDto instructorDto)
        {
            await _instructorService.CreateAsync(instructorDto);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Update(string id)
        {
            var model = await _instructorService.GetByIdAsync(id);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Update(UpdateInstructorDto instructorDto)
        {
            await _instructorService.UpdateAsync(instructorDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(string id)
        {
            await _instructorService.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}
