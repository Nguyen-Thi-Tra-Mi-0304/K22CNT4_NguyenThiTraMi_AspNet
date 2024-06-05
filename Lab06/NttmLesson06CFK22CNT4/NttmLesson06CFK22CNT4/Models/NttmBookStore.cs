using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NttmLesson06CFK22CNT4.Models
{
    public class NttmBookStore : DbContext
    {
        public NttmBookStore() : base("NttmBookStoreConnectionString")
        {
        }
        // Khai báo các thuộc tính tương ứng vói các bảng trong csdl
        public DbSet<NttmCategory> NttmCategories { get; set; }
        public DbSet<NtmBook> NttmBooks { get; set; }
    }
}