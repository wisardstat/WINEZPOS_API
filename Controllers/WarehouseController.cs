using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIapplication.BusinessLogic;
using APIapplication.DATAACCESS;
using APIapplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace APIapplication.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class WarehouseController : ControllerBase
    {
        private readonly dbContext _context; 
        private readonly IMasterRepository _iMasterRepository;
        public WarehouseController(dbContext context,IMasterRepository iMasterRepository )
        {
            _context = context;
             _iMasterRepository = iMasterRepository; 
        }

        [HttpGet]
        public IEnumerable<tbWareHouse> GetAll()
        {
            return  _iMasterRepository.tbWareHouse();
        } 
    }
}
