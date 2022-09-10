using eCommerceProject.Data;
using eCommerceProject.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;
using eCommerceProject.Helpers;

namespace eCommerceProject.Controllers
{
    public class AccountController : Controller
    {
        private readonly eCommerceProjectDbContext _context;

        public AccountController(eCommerceProjectDbContext context)
        {
            _context = context;
        }

        //GET: Login
        public IActionResult Login()
        {
            return View();
        }
        
        //POST: Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(string WebUserEmail, string WebUserPassword)
        {
            ClaimsIdentity myIdentity = null;
            bool identityIsValid = false;
            WebUser selectedUser = await _context.WebUsers.Include(k => k.UserRole).FirstOrDefaultAsync(m => m.WebUserEmail == WebUserEmail && m.WebUserPassword == WebUserPassword);

            if (selectedUser == null)
            {
                ModelState.AddModelError("", "User not found.");
                return View();
            }

            myIdentity = new ClaimsIdentity
                (new[]
                        {
                            new Claim(ClaimTypes.Sid,selectedUser.WebUserID.ToString()),
                            new Claim(ClaimTypes.Email,selectedUser.WebUserEmail),
                            new Claim(ClaimTypes.Role,selectedUser.UserRole.UserRoleName),
                        }, CookieAuthenticationDefaults.AuthenticationScheme
                );

            identityIsValid = true;

            if (identityIsValid)
            {
                ClaimsPrincipal principals = new ClaimsPrincipal(myIdentity);
                Task loginn = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principals);

                if (selectedUser.UserRoleID == 4)
                {
                    return Redirect("~/Account/ActivationEmailSendedNotification");
                }
                else if (selectedUser.UserRoleID == 3)
                {
                    return Redirect("~/Home/Index");
                }
                else if (selectedUser.UserRoleID == 2)
                {
                    return Redirect("~/Product/Index");
                }
                else if (selectedUser.UserRoleID == 1)
                {
                    return Redirect("~/Product/Index");
                }
                else
                {
                    return Redirect("~/");
                }
            }
            return View();

        }

        public IActionResult ActivationEmailSendedNotification()
        {
            return View();
        }
        
        public IActionResult ReSendActivationEmail()
        {
            return View();
        }

        //GET: Register
        public IActionResult Register()
        {
            WebUser webUser = new WebUser();
            return View(webUser);
        }

        //POST: Register
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register([Bind("WebUserFullName,WebUserEmail,WebUserPassword,WebUserRePassword")] WebUser webUser)
        {
            webUser.UserRoleID = 4;
            if (ModelState.IsValid)
            {
                WebUser selectedUserr = _context.WebUsers.FirstOrDefault(a => a.WebUserEmail == webUser.WebUserEmail);
                if (selectedUserr != null)
                {
                    ModelState.AddModelError("", "User already exists.");
                    return View(webUser);
                }

                _context.WebUsers.Add(webUser);
                _context.SaveChanges();

                HotmailActivationMail.SendActivationMail(webUser.WebUserEmail);
                return RedirectToAction("Login", "Account");
            }
            return View(webUser);
        }
    }
}
