using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace MVC5HomeWorkW1.Models
{
    public class 電話格式必須為四碼減號六碼Attribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var regex = new Regex(@"\d{4}-\d{6}");
            return regex.IsMatch((string)value);
            //return base.IsValid(value);
        }
    }
}