using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Agile_board.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Column Column { get; set; }
        public int ColumnId { get; set; }
    }
}