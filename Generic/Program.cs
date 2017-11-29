using System;
using Generic.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            //p1
            StartGeneric<int>.Swap(4, 9);
            StartGeneric<string>.Swap("mahdi", "hajian");
            Console.WriteLine("-------------------------------------------------");
            //----------------------------------------
            //p2
            /// اگر مثلا اینت بگذاریم غلط میگیرد چون محدودش کردیم به رفرنس ها
            ConstraintGeneric<string>.Swap("mahdi", "mahdi");

            Console.WriteLine("-------------------------------------------------");
            //----------------------------------------
            //p3
            List<int> lst = new List<int>
            {
                ///مقدار دهی اولیه یا اینیشیالایز
                3,
                8,
                1,
                5
            };
            lst.Add(7);
            ///پاک کردن شماره ارایه
            lst.RemoveAt(2);
            ///پاک کردن خوده عدد. جستوجو میکند و پاکش میکند
            lst.Remove(5);
            lst.Sort();
            Console.WriteLine(lst.Count);
            ///اگر مقدار درونش در لیست بود صحیح برمیگرداند وگرنه غلط
            Console.WriteLine( lst.Contains(2));
            ///کل اعداد لیست را پاک میکند     lst.Clear();

            int[] array = new int[lst.Count];
            ///دو روش ریختن محتویات لیست در آرایه
            array = lst.ToArray();
            lst.CopyTo(array);
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-------------------------------------------------");
            //-------------------------------------------------
            //p4
            ///زیاد کاربرد ندارد
            //Tuple

            //----------------------------------------------------
            //p5
            ///۴۷

            Console.ReadKey();
        }
    }
}
