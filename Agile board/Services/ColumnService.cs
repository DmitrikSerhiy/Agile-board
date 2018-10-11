using Agile_board.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Agile_board.Services
{
    public class ColumnService : IDisposable
    {
        private AgileContext context;
        public ColumnService()
        {
            context = new AgileContext();
        }

        public Column GetColumn(int columnId)
        {
            return context.Columns.FirstOrDefault(c => c.Id == columnId);
        }

        public IEnumerable<Column> GetColumns()
        {
            return context.Columns.Include(t => t.Tickets).ToList();
        }

        public void AddColumn(string Name)
        {
            context.Columns.Add(new Column { Name = Name });
            context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}