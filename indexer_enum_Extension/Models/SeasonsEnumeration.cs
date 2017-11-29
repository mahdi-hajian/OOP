using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexer_enum_Extension.Models
{
    /// <summary>
    /// کلاس را به اینام تغییر نام میدهیم
    /// آموزش فلگ کردن
    /// </summary>
    public enum SeasonsEnumeration : byte             //میتوانیم بایت را جلویش بنویسیم تا 255 عدد را ساپورت میکند. پیشفرض اینت هست
    {
        /// <summary>
        /// از صفر شروع میشود ولی اگر جلوی یکی عددش را بنویسیم
        /// از انجا به بعدش از ان شماره میرود بالا
        /// </summary>
        spring = 1,
        summer,
        fall,
        winter
    }
}
