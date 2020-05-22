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
    public class InspirationPageController : Controller
    {
        private readonly kreaTidContext _context;

        public InspirationPageController(kreaTidContext context)
        {
            _context = context;
        }

        // GET: Products
        public async Task<IActionResult> Index()
        {
            var kreaTidContext = _context.BlogPost.Include(p => p.BlogPostComments).Include(p => p.BlogPostImgs);
            return View(await kreaTidContext.ToListAsync());
        }
    }
}