using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using oop_4.Models;

//ارتباط بین اعضاء

namespace oop_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // فرستادن کد کالا و نام کالا و قیمت کالا
            Stuff pen = new Stuff(22356, "Pen", 1000);
            Stuff eraser = new Stuff(63556, "Eraser", 500);
            Stuff boteBook = new Stuff(32324, "Note Book", 5000);

            //دادن گزارش شماره فاکتور و تاریخ فاکتور
            Invoice m = new Invoice(100, DateTime.Now);

            //نام کالا ک در بالا تعریف کرده ایم را با تعدادش میفرستیم ک برود در لیست
            m.AddItemToInvoice(pen, 1);
            m.AddItemToInvoice(eraser, 2);
            m.AddItemToInvoice(boteBook, 3);


            Console.WriteLine(m.CalculateTotalSum());

            Console.ReadLine();
        }
    }
}
