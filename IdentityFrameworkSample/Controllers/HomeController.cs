using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using IdentityFrameworkSample.Models;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace IdentityFrameworkSample.Controllers
{
    public class HomeController : Controller
    {
        private readonly IdentityDBContext _identityDBContext;
        public HomeController(IdentityDBContext identityDBContext)
        {
            _identityDBContext = identityDBContext;
        }
        [Authorize]
        public IActionResult Index()
        {
            // get the logged in user id
            string id = User.FindFirst(ClaimTypes.NameIdentifier).Value;

            // get the logged in user info
            var loggedUser = _identityDBContext.AspNetUsers.Where(u => u.Id == id).FirstOrDefault();
            
            // extract the user name from email id
            string userName = loggedUser.UserName;
            int indexOfAt = userName.IndexOf('@');
            userName=userName.Substring(0, indexOfAt);
            
            // send username for display in view
            ViewBag.UserName = userName;
            
            return View();
        }

        [Authorize]
        public IActionResult Privacy()
        {
            string id = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var todoList = _identityDBContext.Todo.Where(x => x.UserId == id).ToList();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
