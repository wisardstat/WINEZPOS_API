using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIapplication.Models;
using Microsoft.EntityFrameworkCore;


namespace APIapplication
{

        public class dbContext : DbContext
        {
            public dbContext(DbContextOptions<dbContext> options)
                : base(options)
            {
            }
            public DbSet<tbl_role> tbl_role { get; set; }
            public DbSet<TbStockCard> TbStockCard { get; set; }
            public DbSet<tbWareHouse> tbWareHouse { get; set; }


    }
    
}
