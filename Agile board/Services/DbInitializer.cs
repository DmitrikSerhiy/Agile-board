using Agile_board.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Agile_board.Services
{
    public class DbInitializer : DropCreateDatabaseAlways<AgileContext>
    {
        protected override void Seed(AgileContext db)
        {
            if (!db.Columns.Any())
            {
                db.Columns.Add(new Column { Name = "TO DO" });
                db.Columns.Add(new Column { Name = "In Progress" });
                db.Columns.Add(new Column { Name = "Done" });

                base.Seed(db);
            }
        }
    }
}
