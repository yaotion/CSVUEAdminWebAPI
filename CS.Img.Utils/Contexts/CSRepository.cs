using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkWithDapper;

namespace CS.Img.Utils
{
    public class CSRepository : ICSRepository
    {
        private readonly CSDBContext _context;
        public CSRepository(CSDBContext context)
        {
             _context = context;
        }
        protected CSDBContext DBContext
        {
            get { return _context; }
        }
    }
}
