using Agile_board.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Agile_board.Services
{
    public class SeedBoard
    {
        private AgileContext context;
        public SeedBoard(AgileContext agileContext, bool seed=false)
        {
            if (seed)
            {
                context = agileContext;
                SeedColumns();
                SeedTickets();
            }
        }

        private void SeedColumns()
        {
            if (!context.Columns.Any())
            {
                context.Columns.Add(new Column { Name = "TO DO" });
                context.Columns.Add(new Column { Name = "In Progress" });
                context.Columns.Add(new Column { Name = "Done" });
                context.SaveChanges();
            }
        }

        private void SeedTickets()
        {
            context.Tickets.AddRange(new List<Ticket>
            {
                new Ticket {
                    Name = "Some todo",
                    Description ="some very long description. For example, I need some text to fill the space and see how does it look like!",
                    ColumnId = 1
                },
                new Ticket {
                    Name = "Another todo",
                    Description ="some very short description.",
                    ColumnId = 1
                }
            });

            context.Tickets.AddRange(new List<Ticket>
            {
                new Ticket {
                    Name = "In process task",
                    Description ="very short desc.",
                    ColumnId = 2
                },
                new Ticket {
                    Name = "My next in process",
                    Description ="just a desc",
                    ColumnId = 2
                },
                new Ticket {
                    Name = "Trying hard",
                    Description ="some extremly long description. So, in process tickets are the tickets where you write some info about task which you currently are working on" +
                    " I need some text to fill the space and see how does it look like!",
                    ColumnId = 2
                },
                new Ticket {
                    Name = "No description",
                    ColumnId = 2
                },
            });
            context.SaveChanges();
        }
    }
}
