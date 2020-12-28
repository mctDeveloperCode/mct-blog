using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace mct_blog.Controllers
{
	public class HelloWorldController : Controller
	{
		// GET: /HelloWorld/
		public IActionResult Index() => View();

		// GET: /HelloWorld/Welcome/
		public IActionResult Welcome(string name, int numTimes = 1)
		{
			ViewData["name"] = name;
			ViewData["numTimes"] = numTimes;
			return View();
		}
	}
}
