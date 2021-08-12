using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace APIapplication.Models
{
    public class TbStockCard
    {
        [Key]
        public int seq { get; set; }
        public string doc_id { get; set; }
         public string vd_cu_code { get; set; }
        public string vd_cu_name { get; set; } 
        public DateTime doc_date { get; set; }
        public string type_doc { get; set; }
        public string wh_id { get; set; }
        public int Qty { get; set; }
        public double price { get; set; }
        public string bar_code { get; set; } 

    }
}
