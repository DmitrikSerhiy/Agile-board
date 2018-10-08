using Agile_board.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Agile_board.Controllers
{
    public class HomeController : Controller
    {
        private ColumnService columnService;
        public HomeController()
        {
            columnService = new ColumnService();
        }

        public ActionResult Index()
        {
            var columns = columnService.GetColumns();
            return View(columns);
        }
    }
}