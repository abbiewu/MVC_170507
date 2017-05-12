using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_170507.Models.ValidAttributes
{
    public class 手機格式判斷Attribute : DataTypeAttribute
    {
        public 手機格式判斷Attribute() : base(DataType.Text)
        {

        }


    }
}