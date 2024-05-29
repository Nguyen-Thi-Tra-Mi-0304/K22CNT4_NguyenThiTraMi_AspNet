using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Nttm_BaiThiGiuaKy.Models
{
    public class NttmCustormer
    {
        [Required(ErrorMessage ="Nttm: Hãy nhập ID")]
        [DisplayName("ID")]
        public string Nttm2210900041_CustId { get; set; }

        [Required(ErrorMessage = "Nttm: Hãy nhập họ và tên")]
        [DisplayName("Họ và tên")]
        public string Nttm_FullName { get; set; }

        [Required(ErrorMessage = "Nttm: Hãy nhập địa chỉ")]
        [DisplayName("Địa chỉ")]
        public string Nttm_Address { get; set; }

        [Required(ErrorMessage = "Nttm: Hãy nhập Email")]
        [DisplayName("Email")]
        public string Nttm_Email { get; set; }

        [Required(ErrorMessage = "Nttm: Hãy nhập số điện thoại")]
        [DisplayName("Số điện thoại")]
        public string Nttm_Phone { get; set; }

        [Required(ErrorMessage = "Nttm: Hãy nhập Balance")]
        [DisplayName("Banlance")]
        public int Nttm_Balance { get; set; }
    }
}