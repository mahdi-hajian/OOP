using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using oop.Models;
using Telegram.Bot;

namespace oop
{
    class Program
    {
        private static TelegramBotClient bot = new TelegramBotClient("433435274:AAFUb3dz2ZT-II1boe3-MPKUBKR2M1exjAY");
        static void Main(string[] args)
        {
            //p1

            //Stuff[] digital = new Stuff[3];                           //لیست را نیو میکنیم چون ابجکت است
            //for (int i = 0; i < 3; i++)
            //{
            //    digital[i] = new Stuff();                               //خوده استف را نیو میکنیم و هر دفعه ک میخاهیم عدد بدهیم باید نیو شود برای همین داخل فور میگذاریم

            //    Console.WriteLine("enter next stuff \n");

            //    digital[i].StuffId = int.Parse(Console.ReadLine());
            //    digital[i].Name = Console.ReadLine();
            //    digital[i].Price = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < digital.Length; i++)
            //{
            //    Console.WriteLine(digital[i].StuffId);
            //    Console.WriteLine(digital[i].Name);
            //    Console.WriteLine(digital[i].Price);
            //}

            //p2

            List<Stuff> kalaHa = new List<Stuff>();

            int n;
            Console.Write("enter number of stuff : ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Stuff kala = new Stuff();

                Console.Write("stufid of {0} : ", i + 1);
                kala.StuffId = int.Parse(Console.ReadLine());

                Console.Write("name of {0} : ", i + 1);
                kala.Name = Console.ReadLine();

                Console.Write("price of {0} : ", i + 1);
                kala.Price = int.Parse(Console.ReadLine());

                kalaHa.Add(kala);

                Console.WriteLine("\n -----------------------");
            }

            for (int i = 0; i < kalaHa.Count; i++)
            {
                Console.WriteLine("stuffId of {0} stuff is  : {1}", i + 1, kalaHa[i].StuffId);

                Console.WriteLine("Name of {0} stuff is  : {1}", i + 1, kalaHa[i].Name);

                Console.WriteLine("Price of {0} stuff is  : {1}", i + 1, kalaHa[i].Price);
                Console.WriteLine("off of {0} stuff is  : {1}\n-------------------------------", i + 1, kalaHa[i].GetDisCount(0.2));    //برای گرفتن تخفیف
            }


            Console.ReadLine();
        }
    }
}
