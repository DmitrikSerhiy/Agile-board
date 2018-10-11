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
            var columns = columnService.GetColumns();
            return View(columns);
        }

        //add new column

        [HttpPost]
        [Route("Home/newTicket")]
        public ActionResult AddTicket(string columnName, UnitOfWork unitOfWork)
        {
            ticketService.AddTicketToColumn(columnName, unitOfWork.Ticket);
            //if (!ModelState.IsValid)
            //{
            //    ViewData["InvalidModal"] = "true";
            //    ViewData["InvalidTicketData"] = ticket;
            //    ViewData["ColumnWithInvalidModalName"] = ColumnName;
            //    tup = new Tuple<string, Ticket>(ColumnName, ticket);
            //}
            return RedirectToAction("Index");
        }

        public ActionResult DeleteTicket(string ticketId)
        {
            //add validation
            ticketService.DeleteTicket(ticketId);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult EditTicket(UnitOfWork unitOfWork)
        {
            ticketService.EditTicket(unitOfWork.Ticket);
            //add validation
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult MoveTo(string targetColumn, string ticketId)
        {
            ticketService.MoveTicketToColumn(targetColumn, ticketId);
            return Redirect(Request.UrlReferrer.ToString());// RedirectToAction("Index",);
        }


        //public ActionResult TicketCard(UnitOfWork unitOfWork)
        //{
        //    return PartialView(new UnitOfWork()
        //    {
        //        Column = columnService.GetColumn(unitOfWork.Column.Id),
        //        Ticket = ticketService.GetTicket(unitOfWork.Ticket.Id)
        //    });
        //}








        //public ActionResult TicketCard()
        //{
        //    return PartialView();
        //}
        //public ActionResult TicketModal()
        //{
        //    return PartialView();
        //}

        //public ActionResult TicketModal(UnitOfWork unitOfWork)
        //{
        //    return PartialView(new UnitOfWork()
        //    {
        //        Column = columnService.GetColumn(unitOfWork.Column.Id),
        //        Ticket = ticketService.GetTicket(unitOfWork?.Ticket.Id ?? null)
        //    });
        //}
    }
}