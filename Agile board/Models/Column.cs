using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Agile_board.Models
{
    public class Column
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public ICollection<Ticket> Tickets { get; set; }

        public Column()
        {
            Tickets = new List<Ticket>();
        }
    }
}