using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace APIapplication.Models
{
    public class tbWareHouse
    {
        [Key]
        public string wh_id { get; set; }
        public string wh_name { get; set; }
        
    }
}
