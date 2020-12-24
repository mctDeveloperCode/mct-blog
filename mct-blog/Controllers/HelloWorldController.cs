using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace mct_blog.Controllers
{
	public class HelloWorldController : Controller
	{
		// GET: /HelloWorld/
		public IActionResult Index() => View();

		// GET: /HelloWorld/Welcome/
		public string Welcome(string name, int ID) => HtmlEncoder.Default.Encode($"Hello {name}, are you {ID} years old?");
	}
}
