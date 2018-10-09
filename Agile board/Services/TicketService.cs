using Agile_board.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Agile_board.Services
{
    public class TicketService
    {
        private AgileContext context;
        public TicketService()
        {
            context = new AgileContext();
        }

        public IEnumerable<Ticket> GetTicketsForColumn(string ColumnName)
        {
            return context.Tickets.Where(c => c.Column.Name == ColumnName).ToList();
        }
    }
}