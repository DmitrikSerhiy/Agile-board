using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Agile_board.Models
{
    public class AgileContext : DbContext
    {
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Column> Columns { get; set; }

        public AgileContext() : base("AgileBoardDb")
        {

        }
    }
}