using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using oop_5.Models;

//(Inheritance)  وراثت

namespace oop_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //p1
            //Employee e = new Employee(949566503,"Mahdi","Hajian",930);

            //Console.WriteLine("\nId is  {0}",e.Id);
            //Console.WriteLine("-----------------------------");
            //Console.WriteLine("name is  {0} {1}",e.FirstName,e.LastName);
            //Console.WriteLine("-----------------------------");
            //Console.WriteLine("Salery is  {0}",e.Salery);
            //Console.WriteLine("-----------------------------");
            //Console.WriteLine("Net In Com  {0}",e.CalulateNetIncome());

            //p2
            //پارامتر هارا پاس میکنیم
            Maneger m = new Maneger(949566503, "Mahdi", "Hajian", 930,0.7);

            Console.WriteLine("\nId is  {0}", m.Id);
            Console.WriteLine("-----------------------------");
            Console.WriteLine("name is  {0} {1}", m.FirstName, m.LastName);
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Salery is  {0}", m.Salery);
            Console.WriteLine("-----------------------------");
            Console.WriteLine(m.CalulateNetIncome());

            Console.ReadLine();
        }
    }
}
