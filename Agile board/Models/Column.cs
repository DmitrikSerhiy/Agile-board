using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Agile_board.Models
{
    public class Column
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Ticket> Tikets { get; set; }
    }
}