using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NttmLesson06CFK22CNT4.Models
{
    public class NttmCategory
    {
        [Key]
        public int NttmId { get; set; }
        public string NttmCategoryName { get; set; }

        // Thuộc tính quan hệ
        public virtual ICollection<NtmBook> NttmBooks { get; set; }
    }
}