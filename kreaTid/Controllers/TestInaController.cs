using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using kreaTid.Data;
using kreaTid.Models;


namespace kreaTid.Controllers
{
    public class TestInaController : Controller
    {
        private readonly kreaTidContext _context;

        public TestInaController(kreaTidContext context)
        {
            _context = context;
        }


        // GET: Products
        public async Task<IActionResult> Index()
        {
            //var kreaTidContext = _context.Product.Include(p => p.Category);
            //_context.ProductImg.Include(p => p.ProductId);
            //_context.ProductComment.Include(p => p.ProductId);
            var kreaTidContext = _context.Product.Include(p => p.Category).Include(p => p.ProductImgs).Include(p => p.ProductComments);
            return View(await kreaTidContext.ToListAsync());
        }

        // GET: BlogPostComments
        //public async Task<IActionResult> ProductComment()
        //{
        //    return View(await _context.ProductComment.ToListAsync());
        //}
        //public Task<IActionResult> Index()
        //{
        //    List<Product> Products = _context.Product.Include(p => p.ProductImg)

        //    return View(await kreaTidContext.ToListAsync());
        //}

        //public async IActionResult Index()
        //{
        //    ProductShopViewModel model = new ProductShopViewModel();
        //    model = new ProductShopViewModel
        //    {
        //        Products = kreaTidContext.Product
        //        .OrderBy(p => p.ProductId)


        //    };
        //    return View(model);

        //}

    }
}