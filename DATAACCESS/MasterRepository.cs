using APIapplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIapplication.DATAACCESS
{
    public interface IMasterRepository
    {
        List<tbWareHouse> tbWareHouse();
    }

    public class MasterRepository : IMasterRepository
    {
        private readonly dbContext _context;
        public MasterRepository(dbContext context)
        {
            _context = context;
        }

        /********** Warehouse *************/
        public List<tbWareHouse> tbWareHouse()
        {
            //do logic about Database
            return _context.tbWareHouse.ToList();
        }
    }
}
