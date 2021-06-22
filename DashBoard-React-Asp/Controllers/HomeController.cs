using System.Linq;
using Microsoft.AspNetCore.Mvc;
using DashBoard_React_Asp.Data;
using DashBoard_React_Asp.Data.Models;
using ApplicationContext = DashBoard_React_Asp.Data.ApplicationContext;

namespace DashBoard_React_Asp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationContext db;


        public HomeController(ApplicationContext context)
        {
            db = context;
        }

        public ActionResult Index()
        {
            return View();
        }

        public IActionResult GetBoards()
        {
            var boards = db.Board.ToList();
            return new JsonResult(boards);
        }
    }
}
