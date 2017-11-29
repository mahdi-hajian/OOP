using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexer_enum_Extension.Models
{
    /// <summary>
    /// ابتدا کلمه فلگ را بین دو براکت میگذاریم و کلاس را اینام میکنیم
    /// </summary>
    [Flags]
    enum FlagEnumeration
    {
        /// <summary>
        /// باید اعداد در مبنای دو را به مبنای شونزده میبریم و با پارامتر های اینام مساوی قرار میدهیم
        /// </summary>
        none = 0x0,       ///0
        saturday = 0x1,   ///1
        sunday = 0x2,     ///2
        monday = 0x4,     ///4
        tuesday = 0x8,    ///8
        wednesday = 0x10, ///16
        thursday = 0x20,  ///32
        friday = 0x40     ///64 
    }
}
