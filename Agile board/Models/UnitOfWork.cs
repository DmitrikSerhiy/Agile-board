using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Agile_board.Models
{
    public class UnitOfWork
    {
        public Column Column { get; set; }
        public Ticket Ticket { get; set; }
    }
}