namespace MVC_170507.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using ValidAttributes;

    [MetadataType(typeof(客戶資料MetaData))]
    public partial class 客戶資料
    {
    }
    
    public partial class 客戶資料MetaData
    {
        [Required]
        public int Id { get; set; }
        
        [StringLength(50, ErrorMessage= "客戶名稱長度不符")]
        [Required]
        public string 客戶名稱 { get; set; }
        
        [StringLength(8, ErrorMessage= "統一編號長度不符")]
        [Required]
        public string 統一編號 { get; set; }

        [StringLength(10, ErrorMessage = "電話號碼長度不符")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "電話號碼格式錯誤")]
        [Required]
        public string 電話 { get; set; }
        [DataType(DataType.PhoneNumber, ErrorMessage = "傳真號碼格式錯誤")]
        [StringLength(10, ErrorMessage = "傳真號碼長度不符")]
        public string 傳真 { get; set; }
        
        [StringLength(100, ErrorMessage= "地址長度不得大於 100 個字")]
        public string 地址 { get; set; }

        //[DataType(DataType.EmailAddress, ErrorMessage = "E-mail格式錯誤")]
        [Email格式判斷(ErrorMessage = "E-mail格式錯誤")]
        [StringLength(50, ErrorMessage = "E-mail長度不符")]
        [Required]
        public string Email { get; set; }
    
        public virtual ICollection<客戶銀行資訊> 客戶銀行資訊 { get; set; }
        public virtual ICollection<客戶聯絡人> 客戶聯絡人 { get; set; }
    }
}
