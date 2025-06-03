using BabyCareProject.Dtos.ProductDtos;
using BabyCareProject.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BabyCareProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController(IProductService _productServie,
        IInstructorService _instructorService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var products =await _productServie.GetAllAsync();
            return View(products);
        }

        public async Task<IActionResult> Delete(string id)
        {
            await _productServie.DeleteAsync(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            await GetTeachers();
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateProdutDto productDto)
        {
            _productServie.CreateAsync(productDto);
            return RedirectToAction("Index");
        }
        [Route("Admin/Product/Update/{id}")]
        [HttpGet]
        public async Task<IActionResult> Update([FromRoute] string id)
        {
            var product =await _productServie.GetByIdAsync(id);
            await GetTeachers();
            return View(product);
        }
        [HttpPost]
        public IActionResult Update(UpdateProductDto productDto)
        {
            _productServie.UpdateAsync(productDto);
            return RedirectToAction(nameof(Index));
        }
        private async Task GetTeachers()
        {
            var teachers = await _instructorService.GetAllAsync();
            ViewBag.Teachers = (from p in teachers
                               select new SelectListItem
                               {
                                   Text = p.FullName,
                                   Value = p.FullName
                               }).ToList();
        }
    }
}
