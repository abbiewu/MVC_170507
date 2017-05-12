using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_170507.Models.ViewModel
{
    public class 客戶資料VM
    {
        [StringLength(50, ErrorMessage = "欄位長度不得大於 50 個字元")]
        [Required]
        public string 客戶名稱 { get; set; }

        [StringLength(50, ErrorMessage = "欄位長度不得大於 50 個字元")]
        [Required]
        public string 帳戶名稱 { get; set; }

        [StringLength(50, ErrorMessage = "姓名長度不符")]
        [Required]
        public string 姓名 { get; set; }
    }
}