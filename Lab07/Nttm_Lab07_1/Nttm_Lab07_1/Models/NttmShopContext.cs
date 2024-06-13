using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Nttm_Lab07_1.Models
{
    public class NttmShopContext : DbContext
    {
        public NttmShopContext() : base("name=NttmShopContext") {
            // khởi tạo những gì cần thiết
        }
        public DbSet<NttmProduct> NttmProducts { get; set; }
    }
}