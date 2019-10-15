using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class BaseRepository
    {
        protected readonly RepositoryPatternDbContext _context;
        public BaseRepository()
        {
            _context = new RepositoryPatternDbContext();
        }
    }
}
