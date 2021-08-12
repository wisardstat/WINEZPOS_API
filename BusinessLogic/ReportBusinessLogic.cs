using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIapplication.DATAACCESS;
using APIapplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace APIapplication.BusinessLogic
{
    public interface IReportBusinessLogic
    {
         ReturnDataListModel<TbStockCard> SearchCriteria(SearchReportModel model);

    }
    public class ReportBusinessLogic : IReportBusinessLogic
    {
        private readonly dbContext _context;
        private readonly IReportRepository _reportRepository;

        public ReportBusinessLogic(dbContext context , IReportRepository reportRepository)
        {
            _context = context;
            _reportRepository = reportRepository;
        }

        public ReturnDataListModel<TbStockCard> SearchCriteria(SearchReportModel model)
        {

            //do logic about BusinessLogic
            var rows = _reportRepository.SearchReport(model);

            return new ReturnDataListModel<TbStockCard>
            {
                Rows = rows,
                ReturnCode = rows != null ? 200 : 500,
                Success = rows != null,
                TotalRecords = rows.Count()
            };
        }
    }
}
