using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using oop_4.Models;

namespace oop_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Stuff a = new Stuff(1,"Pen",1000);
            Stuff b = new Stuff(2,"Eraser",500);
            Stuff c = new Stuff(3,"Note Book",1000);

            Invoice m = new Invoice(100,DateTime.Now);
            m.AddItemToInvoice(a,1);
            m.AddItemToInvoice(b,2);
            m.AddItemToInvoice(c,3);

            Console.ReadLine();
        }
    }
}
