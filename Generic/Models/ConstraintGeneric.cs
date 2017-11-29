using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Models
{
    class BaseClass
    {

    }
    /// <summary>
    /// int کلاس ها میتوانند محدود شوند به ورودی های استراکت مانند
    /// class =مانند=> strig
    /// BaseClass کلاس محدود به ورودیه کلاس است
    /// از اینترفیس هم مانند کلاس میشود محدود شود
    /// new() ...
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class ConstraintGeneric<T> where T : class/*,struct,BaseClass, new()*/
    {
        public static void Swap(T i, T j)
        {
            T temp;
            temp = i;
            i = j;
            j = temp;
            Console.WriteLine("Arg1 : {0} , Arg2 : {1}", i, j);
        }
    }
}
