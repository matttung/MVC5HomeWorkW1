using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace MVC5HomeWorkW1.Models
{
    public class 客戶聯絡人Email不能重複Attribute : ValidationAttribute
    {
        private 客戶資料Entities db = new 客戶資料Entities();

        public override bool IsValid(object value)
        {
            var isEmailDuplicated = db.客戶聯絡人.Any(x => x.Email == (string)value);
            return !isEmailDuplicated;
            //return base.IsValid(value);
        }
    }
}