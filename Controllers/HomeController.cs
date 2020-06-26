using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;

namespace spa.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Spa()
		{
			return File("~/index.html", "text/html");
		}
	}
}
