using Inv.BL.Interface;
using Inv.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Inv.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ISupplierService _supplierService;
        public ProductController(IProductService productService, ISupplierService supplierService)
        {
            _productService = productService;
            _supplierService = supplierService;
        }
        [HttpGet("Index")]
        public async Task<IActionResult> Index()
        {
            var Products = await _productService.GetAllProductAsync();
            ViewBag.Suppliers =new SelectList(await _supplierService.GetAllSupplierAsync(), "Id", "Name");
            return View(Products);
        }
        [HttpGet("Details")]
        public async Task<IActionResult> Details(int id)
        {
            var Products = await _productService.GetProductByIdAsync(id);
            if(Products ==null)
            {
                return NotFound();
            }
            return View(Products);
        }
        [HttpGet("Create")]
        public async Task<IActionResult> Create() 
        {
            ViewBag.Supplier = new SelectList(await _supplierService.GetAllSupplierAsync());
            return View();
        }
        [HttpPost("Create")]
        public async Task<IActionResult> Create(Product product)
        {
            if(ModelState.IsValid)
            {
                await _productService.GetAllProductAsync();
                return RedirectToAction ("Index");
            }
            return View(product);
        }
        [HttpGet("Edit")]
        public async Task<IActionResult>Edit()
        {
            var pro
            return View(Product);
        }
        [HttpPut("Edit")]
        public async Task<IActionResult> Edit()
        {

        }
        [HttpGet("Delete")]
        public async Task<IActionResult>Delete()
        {

        }
        [HttpPost("Delete")]
        public async Task<IActionResult>Delete()
        {

        }
    }
}
