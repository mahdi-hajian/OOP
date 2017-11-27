using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using oop_6.Models;

namespace oop_6
{
    class Program
    {
        static void Main(string[] args)
        {
            ///نمیتوان پرسونال را نیو کرد زیرا ابستراکت است
            //Personnel p = new Personnel(12,"mahdi","hajian",1000);
            Console.Write("enter number of your Personnel ");
            int n1 = int.Parse(Console.ReadLine());

            Employee[] Array = new Employee[n1];

            Console.Write("enter number of your Normal Employee ");
            int n2 = int.Parse(Console.ReadLine());

            // در این مورد دو راه برای فرستادن اطلاعات هست یکی دی تی او مثل حلقه پایین و
            //یکی مانند همین حلقه
            for (int i = 0; i < n2; i++)
            {

                Array[i] = new Employee();
                Console.Write("id : ");
                Array[i].Id = int.Parse(Console.ReadLine());

                Console.Write("first name : ");
                Array[i].FirstName = Console.ReadLine();

                Console.Write("last name : ");
                Array[i].LastName = Console.ReadLine();

                Console.Write("salery : ");
                Array[i].Salery = int.Parse(Console.ReadLine());
            }

            DTO d = new DTO();              //ساخت DTO

            //در این حلقه فقط میتوان با این روش ارسال کرد زیرا به ضریب مدیریت دسترسی نداریم 
            for (int i = n2; i < n1; i++)
            {
                Console.Write("Id : ");
                d._idDTO = int.Parse(Console.ReadLine());

                Console.Write("Firat Name : ");
                d._firstNameDTO = Console.ReadLine();

                Console.Write("Last Name : ");
                d._lastNameDTO = Console.ReadLine();

                Console.Write("salery : ");
                d._saleryDTO = int.Parse(Console.ReadLine());

                Console.Write("Coefficent : ");
                double f = double.Parse(Console.ReadLine());

                Array[i] = new Admis(d,f);
            }

            //چاپ آرایه
            //خوده کلاس ها میفهمند ک اگر عضو ادمین هست ضریب مدیریت هم حساب میشود اگر
            //جزو کارمندان باشد عادی حساب میکند
            for (int i = 0; i < n1; i++)
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine(Array[i].CalculateNetIncomEmployee());
                
            }

            Console.ReadLine();
        }
    }
}
