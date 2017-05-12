namespace MVC_170507.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using ValidAttributes;
    [MetadataType(typeof(客戶聯絡人MetaData))]
    public partial class 客戶聯絡人
    {
    }
    
    public partial class 客戶聯絡人MetaData
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int 客戶Id { get; set; }
        
        [StringLength(10, ErrorMessage= "職稱長度不符")]
        [Required]
        public string 職稱 { get; set; }
        
        [StringLength(50, ErrorMessage= "姓名長度不符")]
        [Required]
        public string 姓名 { get; set; }
        [Email格式判斷(ErrorMessage = "E-mail格式錯誤")]
        [StringLength(50, ErrorMessage="E-mail長度不符")]
        [Required]
        public string Email { get; set; }
        [StringLength(10, ErrorMessage="手機號碼長度不符")]
        public string 手機 { get; set; }

        [StringLength(10, ErrorMessage = "電話號碼長度不符")]
        public string 電話 { get; set; }
    
        public virtual 客戶資料 客戶資料 { get; set; }

    }
}
