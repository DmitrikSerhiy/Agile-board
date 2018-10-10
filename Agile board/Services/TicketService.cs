using Agile_board.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Agile_board.Services
{
    public class TicketService : IDisposable
    {
        private AgileContext context;
        public TicketService()
        {
            context = new AgileContext();
        }

        public void AddTicketToColumn(string columnName, Ticket ticket)
        {
            var currTicket = ticket;
            currTicket.ColumnId = context.Columns.FirstOrDefault(c => c.Name == columnName).Id;
            context.Tickets.Add(currTicket);
            context.SaveChanges();
        }

        public void EditTicket(Ticket editedTicked)
        {
            context.Entry(editedTicked).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteTicket(string ticketId)
        {
            var Id = Int32.Parse(ticketId);
            var ticket = context.Tickets.FirstOrDefault(t => t.Id == Id);
            context.Entry(ticket).State = System.Data.Entity.EntityState.Deleted;
            context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}