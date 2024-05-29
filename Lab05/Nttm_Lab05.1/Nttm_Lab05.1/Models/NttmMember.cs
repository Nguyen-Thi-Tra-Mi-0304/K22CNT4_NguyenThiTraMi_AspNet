using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Nttm_Lab05._1.Models
{
    public class NttmMember
    {
        [Required(ErrorMessage = "Nttm: Hãy nhập mã số")]
        [DataType(DataType.Currency)]
        public int? Id { get; set; }

        [Required(ErrorMessage = "Nttm: Hãy tên đăng nhập")]
        public string NttmUserName { get; set; }

        [Required(ErrorMessage = "Nttm: Hãy nhập họ và tên")]
        public string NttmFullName { get; set; }

        [Required(ErrorMessage = "Nttm: Hãy nhập mật khẩu")]
        [DataType(DataType.Password)]
        public string NttmPassWord { get; set; }

        [Required(ErrorMessage = "Nttm: Hãy nhập tuổi")]
        [Range(18,50,ErrorMessage = "Tuổi từ 18 - 50")]
        public int? NttmAge { get; set; }

        [Required(ErrorMessage = "Nttm: Hãy nhập email")]
        [RegularExpression(@"[A-Za-z0-9.%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}",
            ErrorMessage = "Email phải đúng định dạng")]
        public string NttmEmail { get; set; }

    }
}