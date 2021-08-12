using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIapplication.BusinessLogic;
using APIapplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace APIapplication.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly dbContext _context;
        private readonly IReportBusinessLogic _reportBusinessLogic;

        public WeatherForecastController(dbContext context , IReportBusinessLogic reportBusinessLogic)
        {
            _context = context;
            _reportBusinessLogic = reportBusinessLogic;
        }

        [HttpGet]
        public IEnumerable<TbStockCard> GetAll()
        {
            return _context.TbStockCard.ToList();
        }


        [HttpPost]
        public IActionResult Search(SearchReportModel searchCriteria)
        {
            try
            {
                var res = _reportBusinessLogic.SearchCriteria(searchCriteria);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
