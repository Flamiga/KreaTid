using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kreaTid.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace kreaTid.Controllers
{
    public class CartController : Controller
    {

        private readonly kreaTidContext _context;

        public CartController(kreaTidContext context)
        {
            _context = context;
        }

        // GET: Products
        public async Task<IActionResult> Index()
        {
            var kreaTidContext = _context.Product.Include(p => p.ProductId).Include(p => p.ProductImgs).Include(p => p.ProductName).Include(p => p.ProductPrice);
            return View(await kreaTidContext.ToListAsync());
        }
    }
}