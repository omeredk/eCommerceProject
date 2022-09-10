using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using eCommerceProject.Data;
using eCommerceProject.Models;

namespace eCommerceProject.Controllers
{
    public class WebUserController : Controller
    {
        private readonly eCommerceProjectDbContext _context;

        public WebUserController(eCommerceProjectDbContext context)
        {
            _context = context;
        }

        // GET: WebUser
        public async Task<IActionResult> Index()
        {
            var eCommerceProjectDbContext = _context.WebUsers.Include(w => w.UserRole);
            return View(await eCommerceProjectDbContext.ToListAsync());
        }

        // GET: WebUser/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.WebUsers == null)
            {
                return NotFound();
            }

            var webUser = await _context.WebUsers
                .Include(w => w.UserRole)
                .FirstOrDefaultAsync(m => m.WebUserID == id);
            if (webUser == null)
            {
                return NotFound();
            }

            return View(webUser);
        }

        // GET: WebUser/Create
        public IActionResult Create()
        {
            ViewData["UserRoleID"] = new SelectList(_context.UserRoles, "UserRoleID", "UserRoleName");
            return View();
        }

        // POST: WebUser/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("WebUserID,WebUserFullName,WebUserEmail,WebUserPassword,UserRoleID")] WebUser webUser)
        {
            if (ModelState.IsValid)
            {
                _context.Add(webUser);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserRoleID"] = new SelectList(_context.UserRoles, "UserRoleID", "UserRoleName", webUser.UserRoleID);
            return View(webUser);
        }

        // GET: WebUser/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.WebUsers == null)
            {
                return NotFound();
            }

            var webUser = await _context.WebUsers.FindAsync(id);
            if (webUser == null)
            {
                return NotFound();
            }
            ViewData["UserRoleID"] = new SelectList(_context.UserRoles, "UserRoleID", "UserRoleName", webUser.UserRoleID);
            return View(webUser);
        }

        // POST: WebUser/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("WebUserID,WebUserFullName,WebUserEmail,WebUserPassword,UserRoleID")] WebUser webUser)
        {
            if (id != webUser.WebUserID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(webUser);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WebUserExists(webUser.WebUserID))
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
            ViewData["UserRoleID"] = new SelectList(_context.UserRoles, "UserRoleID", "UserRoleName", webUser.UserRoleID);
            return View(webUser);
        }

        // GET: WebUser/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.WebUsers == null)
            {
                return NotFound();
            }

            var webUser = await _context.WebUsers
                .Include(w => w.UserRole)
                .FirstOrDefaultAsync(m => m.WebUserID == id);
            if (webUser == null)
            {
                return NotFound();
            }

            return View(webUser);
        }

        // POST: WebUser/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.WebUsers == null)
            {
                return Problem("Entity set 'eCommerceProjectDbContext.WebUsers'  is null.");
            }
            var webUser = await _context.WebUsers.FindAsync(id);
            if (webUser != null)
            {
                _context.WebUsers.Remove(webUser);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WebUserExists(int id)
        {
          return _context.WebUsers.Any(e => e.WebUserID == id);
        }
    }
}
