using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NttmLesson06CFK22CNT4.Models
{
    public class NtmBook
    {
        [Key]
        public int NttmId { get; set; }
        public string NttmBookId { get; set; }
        public string NttmTitle { get; set; }
        public string NttmAuthor { get; set; }
        public int NttmYear { get; set; }
        public string NttmPublisher { get; set; }
        public string NttmPicture { get; set; }
        public int NttmCategoryId { get; set; }

        // Thuộc tính quan hệ 
        public virtual NttmCategory NttmCategory { get; set; }
    }
}