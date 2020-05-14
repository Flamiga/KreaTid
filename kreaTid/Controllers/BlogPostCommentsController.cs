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
    public class BlogPostCommentsController : Controller
    {
        private readonly kreaTidContext _context;

        public BlogPostCommentsController(kreaTidContext context)
        {
            _context = context;
        }

        // GET: BlogPostComments
        public async Task<IActionResult> Index()
        {
            return View(await _context.BlogPostComment.ToListAsync());
        }

        // GET: BlogPostComments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blogPostComment = await _context.BlogPostComment
                .FirstOrDefaultAsync(m => m.BlogPostCommentId == id);
            if (blogPostComment == null)
            {
                return NotFound();
            }

            return View(blogPostComment);
        }

        // GET: BlogPostComments/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BlogPostComments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BlogPostCommentId,BlogPostCommentUser,BlogPostCommentText,BlogPostCommentPublishDate,BlogPostCommentLastUpdated")] BlogPostComment blogPostComment)
        {
            if (ModelState.IsValid)
            {
                _context.Add(blogPostComment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(blogPostComment);
        }

        // GET: BlogPostComments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blogPostComment = await _context.BlogPostComment.FindAsync(id);
            if (blogPostComment == null)
            {
                return NotFound();
            }
            return View(blogPostComment);
        }

        // POST: BlogPostComments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BlogPostCommentId,BlogPostCommentUser,BlogPostCommentText,BlogPostCommentPublishDate,BlogPostCommentLastUpdated")] BlogPostComment blogPostComment)
        {
            if (id != blogPostComment.BlogPostCommentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(blogPostComment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BlogPostCommentExists(blogPostComment.BlogPostCommentId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(blogPostComment);
        }

        // GET: BlogPostComments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blogPostComment = await _context.BlogPostComment
                .FirstOrDefaultAsync(m => m.BlogPostCommentId == id);
            if (blogPostComment == null)
            {
                return NotFound();
            }

            return View(blogPostComment);
        }

        // POST: BlogPostComments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var blogPostComment = await _context.BlogPostComment.FindAsync(id);
            _context.BlogPostComment.Remove(blogPostComment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BlogPostCommentExists(int id)
        {
            return _context.BlogPostComment.Any(e => e.BlogPostCommentId == id);
        }
    }
}
