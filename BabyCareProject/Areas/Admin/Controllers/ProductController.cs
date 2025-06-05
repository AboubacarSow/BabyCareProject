using BabyCareProject.Dtos.ProductDtos;
using BabyCareProject.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BabyCareProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController(IServiceManager _manager
        ) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var products =await _manager.ProductService.GetAllAsync();
            return View(products);
        }

        public async Task<IActionResult> Delete(string id)
        {
            await _manager.ProductService.DeleteAsync(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            await GetTeachers();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateProdutDto productDto)
        {
            if(!ModelState.IsValid){
                await GetTeachers();
                return View(productDto);
            }
            await _manager.ProductService.CreateAsync(productDto);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> Update([FromRoute] string id)
        {
            var product =await _manager.ProductService.GetByIdAsync(id);
            await GetTeachers();
            return View(product);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateAsync(UpdateProductDto productDto)
        {
            if(!ModelState.IsValid){
                await GetTeachers();
                return View(productDto);
            }
            await _manager.ProductService.UpdateAsync(productDto);
            return RedirectToAction(nameof(Index));
        }
        private async Task GetTeachers()
        {
            var teachers = await _manager.InstructorService.GetAllAsync();
            ViewBag.Teachers = (from p in teachers
                               select new SelectListItem
                               {
                                   Text = p.FullName,
                                   Value = p.FullName
                               }).ToList();
        }
    }
}
