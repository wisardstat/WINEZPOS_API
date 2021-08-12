using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APIapplication.Models
{
    public class tbl_role
    {
        [Key]
        public int ROLE_ID { get; set; }

        public string ROLE_NAME { get; set; }
        public string ROLE_STATUS  { get; set; }
        public DateTime CREATE_DATE { get; set; }
        public string CREATE_BY { get; set; }
        public DateTime UPDATE_DATE { get; set; }
        public string UPDATE_BY { get; set; }

    }
}
