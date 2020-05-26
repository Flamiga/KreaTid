using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using kreaTid.Models;
using kreaTid.Data;
using Microsoft.EntityFrameworkCore;

namespace kreaTid.Controllers
{
    public class HomeController : Controller
    {

        private readonly kreaTidContext _context;

        public HomeController(kreaTidContext context)
        {
            _context = context;
        }

        // GET: Products
        public async Task<IActionResult> Index()
        {
            var kreaTidContext = _context.Product.Include(p => p.Category).Include(p => p.ProductImgs);
            return View(await kreaTidContext.ToListAsync());
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
