using APIapplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIapplication.DATAACCESS
{
    public interface IReportRepository
    {
        List<TbStockCard> SearchReport(SearchReportModel model);

    }
    public class ReportRepository : IReportRepository
    {
        private readonly dbContext _context;
        public ReportRepository(dbContext context)
        {
            _context = context;
        }

        public List<TbStockCard> SearchReport(SearchReportModel model)
        {
            //do logic about Database
            return _context.TbStockCard.Where(x=> x.doc_date>=model.dateStart && x.doc_date<=model.dateEnd  ).ToList();
        }
    }
}
