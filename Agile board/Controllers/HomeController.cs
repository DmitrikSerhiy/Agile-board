using Agile_board.Models;
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
            ticketService = new TicketService();
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View(columnService.GetColumns());
        }

        //add new column

        [HttpPost]
        [Route("Home/newTicket")]
        public ActionResult AddTicket(string columnName, UnitOfWork unitOfWork)
        {
            if (!ModelState.IsValid)
            {
                ViewData["InvalidTicketName"] = "true";
                ViewData["ModalIdToOpen"] = "AdditionModalFor" + columnName.Replace(" ", string.Empty) + "Id";
                return View("Index", columnService.GetColumns());
            }
            ticketService.AddTicketToColumn(columnName, unitOfWork.Ticket);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteTicket(string ticketId)
        {
            ticketService.DeleteTicket(ticketId);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult EditTicket(string columnName, UnitOfWork unitOfWork)
        {
            if (!ModelState.IsValid)
            {
                ViewData["InvalidTicketName"] = "true";
                ViewData["ModalIdToOpen"] = "EditModalFor" + columnName.Replace(" ", string.Empty) + unitOfWork.Ticket.Id + "Id";
                return View("Index", columnService.GetColumns());
            }
            ticketService.EditTicket(unitOfWork.Ticket);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult MoveTo(string targetColumn, string ticketId)
        {
            ticketService.MoveTicketToColumn(targetColumn, ticketId);
            return RedirectToAction("Index");
        }
    }
}