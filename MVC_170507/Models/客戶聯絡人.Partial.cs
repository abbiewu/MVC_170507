namespace MVC_170507.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using ValidAttributes;
    using System.Linq;
    [MetadataType(typeof(客戶聯絡人MetaData))]
    public partial class 客戶聯絡人 : IValidatableObject
    {
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var db = new 客戶資料Entities();
            
            if (this.Id == 0)
            {
                //新增資料
                if (db.客戶聯絡人.Where(p => p.客戶Id == this.客戶Id && p.Email == this.Email).Any())
                {
                    //有email資料時
                    yield return new ValidationResult("Email重複", new string[] { "Email" });
                }
            }
            else
            {
                //更新資料
                if (db.客戶聯絡人.Where(p => p.客戶Id == this.客戶Id && p.Id != this.Id && p.Email == this.Email).Any())
                {
                    //有email資料時
                    yield return new ValidationResult("Email重複", new string[] { "Email" });
                }
            }

            yield return ValidationResult.Success;
        }
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
        [RegularExpression(@"\d{4}-\d{6}",ErrorMessage ="手機格式錯誤，須為09xx-xxxxxx")]
        public string 手機 { get; set; }

        [StringLength(10, ErrorMessage = "電話號碼長度不符")]
        public string 電話 { get; set; }
    
        public virtual 客戶資料 客戶資料 { get; set; }

    }
}
