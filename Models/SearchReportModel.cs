using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIapplication.Models
{
    public class SearchReportModel
    {
        public string branch { get; set; }
        public DateTime dateStart { get; set; }
        public DateTime dateEnd  { get; set; }
}
}
