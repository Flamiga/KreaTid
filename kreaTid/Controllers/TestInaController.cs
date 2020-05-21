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
        //public IActionResult Index()
        //{


        //    return View();
        //}
        //note to self the index part belov could be anything as long as there is a corresponding view file
        public async Task<IActionResult> Index()
        {
            var kreaTidContext = _context.Product.Include(p => p.Category);
            return View(await kreaTidContext.ToListAsync());
        }

    }
}