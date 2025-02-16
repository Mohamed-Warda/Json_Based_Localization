using Microsoft.AspNetCore.Mvc;

namespace JsonBasedLocalization.Web.Controllers;

public class TestController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Create()
    {
        return View();
    }
}