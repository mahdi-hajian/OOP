using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Models
{
    /// <summary>
    /// class StartGeneric<T,V,...>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class StartGeneric<T>
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
