using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Agile_board.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Title for the ticket is required")]
        [MaxLength(length: 40, ErrorMessage = "Title has to be less than 40 symbols")]
        public string Name { get; set; }
        public string Description { get; set; }

        public int ColumnId { get; set; }
        public Column Column { get; set; }
    }
}