using Agile_board.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Agile_board.Services
{
    public class ColumnService : IDisposable
    {
        private AgileContext context;
        public ColumnService()
        {
            context = new AgileContext();
        }

        public IEnumerable<Column> GetColumns()
        {
            return context.Columns.ToList();
        }

        public void AddColumn(string Name)
        {
            context.Columns.Add(new Column { Name = Name });
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}