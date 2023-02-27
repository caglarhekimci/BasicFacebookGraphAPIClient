using BasicFBGraphApi.GraphService;
using BasicFBGraphApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BasicFBGraphApi.Controllers
{
    public class FBGraphController : Controller
    {
        private readonly IGraphApi _graphApi;
        public static FacebookData model = new FacebookData();

        public FBGraphController(IGraphApi graphApi)
        {
            _graphApi = graphApi;
        }

        public IActionResult Index()
        {
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(string token)
        {
            model = _graphApi.GetProperties(token);
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}