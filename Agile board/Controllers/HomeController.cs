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
        private TicketService ticketService;
        public HomeController()
        {
            columnService = new ColumnService();
            //ticketService = new TicketService();
        }

        public ActionResult Index()
        {
            var columns = columnService.GetColumns();
            return View(columns);
        }

        //add new column

        [HttpPost]
        public ActionResult AddTicket()
        {
            //to do
        }

        //public ActionResult Tickets(string ColumnName)
        //{
        //    var tickets = ticketService.GetTicketsForColumn(ColumnName);
        //    return Model;
        //}

    }
}