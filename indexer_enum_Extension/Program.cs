using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using indexer_enum_Extension.Models;

namespace indexer_enum_Extension
{
    class Program
    {
        static void Main(string[] args)
        {
            ///برای اینکه یک خط بیاد پایین و جواب ها به بالا نچسبد
            Console.WriteLine();

            //p1
            ///تعریف ایندکسر

            //Indexerr array = new Indexerr();

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write("enter id {0} : ", i + 1);
            //    lbl1:
            //    string b = Console.ReadLine();
            //    /// ترای پارس یک رشته مانند بی را میگیرد سعی میکند درون آیدی بریزد اگر توانست صحیح اگر نتوانست
            //    /// غلط را برمیگرداند
            //    Boolean parsResult = int.TryParse(b, out int Id);    
            //    if (parsResult == false)
            //    {
            //        Console.Write("enter a nummber : ");
            //        goto lbl1;
            //    }
            //    array[i] = Id;
            //}
            //Console.WriteLine("-------------------------");
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Array {0} = {1}", i, array[i]);
            //}


            //p2
            ///تعریف ایندکسر
            //Indexerr flag = new Indexerr();
            //flag[0] = true;
            //flag[1] = false;
            //flag[2] = true;
            //flag[3] = true;
            ////...
            //for (int i = 0; i < 32; i++)
            //{
            //    Console.WriteLine(flag[i]);
            //}

            //----------------------------------------------------------------------------
            //p3
            /// Extension Method
            //int a = 2;
            //Console.WriteLine(a.Plus_5());

            //string b = "mahdi";
            //Console.WriteLine(b.Up());

            //------------------------------------------------------------------------------
            //p4

            //SeasonsEnumeration happySeason = SeasonsEnumeration.spring;
            //Console.WriteLine(happySeason);

            //-------------------------------------------------------------------------------
            //p5
            ///برای تعریف کردن اینام ان را با روزش مساوی قرار میدهیم
            FlagEnumeration meetingDay = FlagEnumeration.saturday | FlagEnumeration.monday;
            Console.WriteLine("the meeting days is : {0}", meetingDay);

            ///برای اضافه کردن باید نام متغیری ک تعریف کردیم را بنویسیم نماد خط را میگذاریم
            ///و پارامتر های دیگر را اضافه میکنیم
            meetingDay = meetingDay | FlagEnumeration.wednesday | FlagEnumeration.friday;
            Console.WriteLine("\nthe meeting days is : {0}", meetingDay);

            ///برای حذف کردن مانند اضافه کردن فقط نماد توان را میگذاریم
            ///نکته مهم
            ///ولی اگر موجود نباشد ان را اضافه میکند
            meetingDay = meetingDay ^ FlagEnumeration.friday;
            Console.WriteLine("\nthe meeting days is : {0}", meetingDay);

            ///برای چک کردن میتینگ دی 
            bool checkmeeting = (meetingDay & FlagEnumeration.wednesday) == FlagEnumeration.wednesday;
            Console.WriteLine("\n"+checkmeeting);

            Console.ReadKey();
        }
    }
}
