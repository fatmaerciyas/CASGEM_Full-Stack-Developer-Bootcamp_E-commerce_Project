using Microsoft.AspNetCore.Mvc;
using Pizzapan.BusinessLayer.Abstract;
using Pizzapan.EntityLayer.Concrete;
using Pizzapan.PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzapan.PresentationLayer.Controllers
{
    public class ProductImageController : Controller
    {
        private readonly IProductImageService productImageService;

        public ProductImageController(IProductImageService productImageService)
        {
            this.productImageService = productImageService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(ImageFileViewModel model)
        {
            var resource = Directory.GetCurrentDirectory();
            var extension = Path.GetExtension(model.Image.Name);
            var imageName = Guid.NewGuid() + extension;
            var saveLocation = resource + "/wwwroot/images" + imageName;
            var stream = new FileStream(saveLocation, FileMode.Create);
            model.Image.CopyTo(stream);
            ProductImage productImage = new ProductImage();
            productImage.ImageUrl = imageName;
            productImageService.TInsert(productImage);
            return RedirectToAction("ImageList");
          
        }
    }
}
