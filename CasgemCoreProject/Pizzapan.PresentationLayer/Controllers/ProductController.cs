using Microsoft.AspNetCore.Mvc;
using Pizzapan.BusinessLayer.Abstract;
using Pizzapan.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzapan.PresentationLayer.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService ProductService;

        public ProductController(IProductService ProductService)
        {
            this.ProductService = ProductService;
        }

        public IActionResult Index()
        {
            var values = ProductService.TGetProductListByCategory();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Product Product)
        {
            ProductService.TInsert(Product);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteProduct(int id)
        {
            var value = ProductService.TGetByID(id);
            ProductService.TDelete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            var value = ProductService.TGetByID(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateProduct(Product Product)
        {
            ProductService.TUpdate(Product);
            return RedirectToAction("Index");
        }
    }
}
