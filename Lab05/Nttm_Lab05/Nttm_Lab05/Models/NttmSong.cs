using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Nttm_Lab05.Models
{
    public class NttmSong
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nttm: Hãy nhập tiêu đề")]
        [DisplayName("Tiêu đề")]
        public string NttmTitle { get; set; }

        [Required(ErrorMessage = "Nttm: Hãy nhập tác giả")]
        [DisplayName("Tác giả")]
        public string NttmAuthor { get; set; }

        [Required(ErrorMessage = "Nttm: Hãy nhập nghệ sĩ")]
        [StringLength(50, MinimumLength =2, ErrorMessage = "Nttm: Tên nghệ sĩ có tối thiểu 2 ký tự và tối đa 50 kí tự")]
        [DisplayName("Nghệ sĩ")]
        public string NttmArtist { get; set; }

        [Required(ErrorMessage = "Nttm: Hãy nhập năm xuất bản")]
        [RegularExpression(@"[0-9]{4}",ErrorMessage ="Nttm: Năm xuất bản phải có 2 kí tự số")]
        [Range(1990,2024, ErrorMessage ="Nttm: Năm xuất bản trong khoảng 1900 - 2024")]
        [DisplayName("Năm xuất bản")]
        public int NttmYearRelease { get; set; }
    }
}