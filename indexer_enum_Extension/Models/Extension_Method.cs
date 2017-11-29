using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexer_enum_Extension.Models
{
    /// <summary>
    /// خوده کلاس را پابلیک میکنیم ک در نیم اسپیس های دیگر هم قابل دسترسی باشد
    /// </summary>
    static class Extension_Method
    {
        /// <summary>
        /// توابع اکستنشن را پابکیک و حتما استاتیک میکنیم
        /// داخل پرانتر هم حتما کلمه دیس را مینویسیم
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int Plus_5(this int value)
        {
            value +=5;
            return value;
        }
        //---------------------------------
        public static string Up(this string value)
        {
            value = value.ToUpper();
            return value;
        }
    }
}
