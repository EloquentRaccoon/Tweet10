using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using Tweet10.Areas.Identity.Data;
using Tweet10.Data;
using Tweet10.Models;

namespace Tweet10.Controllers
{
    public class HomeController : Controller
    {
        private readonly DatabaseContext _context;
        private readonly UserManager<User> _userManager;
        private readonly ILogger<HomeController> _logger;

        public HomeController(DatabaseContext context, ILogger<HomeController> logger, UserManager<User> userManager)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;

        }

        public async Task<IActionResult> Index()
        {
            try
            {
                var user = await _userManager.GetUserAsync(User);
                if (user == null) {
                    return RedirectToPage("/Account/Login", new { area = "Identity" });
                } else {
                    return View(await _context.Tweets.OrderByDescending(t => t.CreatedDateTime).ToListAsync()); 
                    //filter on other people
                    //return View(await _context.Tweets.OrderByDescending(t => t.CreatedDateTime).Where(t => t.Username != user.UserName).ToListAsync());
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
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