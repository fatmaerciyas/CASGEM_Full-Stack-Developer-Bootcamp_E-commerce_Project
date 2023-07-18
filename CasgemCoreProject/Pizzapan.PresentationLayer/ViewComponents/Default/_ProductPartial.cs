using Microsoft.AspNetCore.Mvc;
using Pizzapan.BusinessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzapan.PresentationLayer.ViewComponents.Default
{
    public class _ProductPartial : ViewComponent
    {
        private readonly IProductService productService;

        public _ProductPartial(IProductService productService)
        {
            this.productService = productService;
        }

        public IViewComponentResult Invoke()
        {
            var values = productService.TGetList();
            return View(values);
        }
    }
}
