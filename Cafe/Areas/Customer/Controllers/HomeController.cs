using Cafe.Data;
using Cafe.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Cafe.Areas.Customer.Controllers
{
	[Area("Customer")]
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly ApplicationDbContext _db;

		public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
		{
			_logger = logger;
			_db = db;
		}

		public IActionResult Index()
		{
			var menu = _db.Menus.Where(i => i.Ozel).ToList();
			return View(menu);
		}
		public IActionResult Iletisim()
		{
			return View();
		}
		public IActionResult Blog()
		{
			return View();
		}
		public IActionResult Hakkında()
		{
			return View();
		}
		public IActionResult Galeri()
		{
			return View();
		}
		public IActionResult Rezervasyon()
		{
			return View();
		}
		public IActionResult Menu()
		{
			return View();
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