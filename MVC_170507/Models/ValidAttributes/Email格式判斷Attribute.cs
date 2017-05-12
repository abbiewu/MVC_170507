using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_170507.Models.ValidAttributes
{
    public class Email格式判斷Attribute : DataTypeAttribute
    {
        public Email格式判斷Attribute() : base(DataType.Text)
        {

        }
        public override bool IsValid(object value)
        {
            var str = (string)value;
            if (str.Contains("@")) return true;

            else return false;
        }
    }
}