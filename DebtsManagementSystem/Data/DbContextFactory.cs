using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebtsManagementSystem.Data
{
    public class DbContextFactory
    {
        private static AppDbContext _context;
        public static AppDbContext context
        {
            get
            {
                if(_context==null)
                {
                    _context = new AppDbContext();
                }
                return _context;
            }
        }
        public static void Refresh()
        {
            _context?.Dispose();
            _context = new AppDbContext();
        }
    }
}
