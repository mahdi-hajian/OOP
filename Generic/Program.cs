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
            Console.WriteLine(lst.Contains(2));
            ///کل اعداد لیست را پاک میکند     lst.Clear();

            int[] array = new int[lst.Count];
            ///دو روش ریختن محتویات لیست در آرایه
            array = lst.ToArray();
            lst.CopyTo(array);
            foreach (int item in array)
            {
                Console.WriteLine("list is : {0}", item);
            }
            Console.WriteLine("-------------------------------------------------");
            //-------------------------------------------------
            //p4
            ///همان اول باید مقدار دهی کنیم
            Tuple<int, string, string, int[], bool> s =
                new Tuple<int, string, string, int[], bool>(1, "mahdi", "hajian", new int[] { 1, 2, 3, 4 }, true);
            Console.WriteLine("student be id: {0},name: {1},lastName: {2}, is {3}", s.Item1, s.Item2, s.Item3, s.Item5);
            foreach (var item in s.Item4)
            {
                int i = 1;
                Console.WriteLine($"nomre {i} : {item}");
                i++;
            }
            Console.WriteLine("-------------------------------------------------");

            //----------------------------------------------------
            //p5
            ///(null,0)(0,1)(1,2)(2,3)(3,null)
            LinkedList<int> lnk = new LinkedList<int>();
            lnk.AddFirst(1);   //یک عدد به اول لیست اضافه میکند
            lnk.AddLast(4);    //یک عدد به آخر لیست اضافه میکند
            lnk.AddFirst(0);   //یک عدد به اول لیست اضافه میکند
            lnk.AddLast(5);    //یک عدد به آخر لیست اضافه میکند
            lnk.AddLast(6);    //یک عدد به آخر لیست اضافه میکند
            //0,1,4,5,6
            LinkedListNode<int> lnkN = lnk.Find(1);      //برروی ارایه ای ک شماره یک داخلشه می ایسیتد
            //نکته: اولین یک را ک دید می ایستد مثلا اگر دوجا یک داشته باشیم اولیش حسابه
            lnk.AddAfter(lnkN, 2);                       //از همان ارایه بعدش دو را اضافه میکند
            lnkN = lnk.Find(4);                          //بر روی ارایه ای ک چهار درونش هست می ایسیتد
            lnk.AddBefore(lnkN, 3);                      //قبلش سه را اضفافه میکند
            lnk.Remove(5); lnk.RemoveFirst(); lnk.RemoveLast(); lnk.Count();
            foreach (var item in lnk)
            {
                Console.WriteLine($"linkedList is : {item}");
            }
            Console.WriteLine("-------------------------------------------------");

            //----------------------------------------------------
            //p6
            //صف یعنی از اخر وارد میشود و از اول حذف میشود
            Queue<int> que = new Queue<int>();
            que.Enqueue(0);                                            //اضافه کردن صف
            ///در جنریک ها و آرایه به این صورت هم میتوان عدد وارد کرد
            foreach (var item in new int[] { 1, 2, 3, 4, 5 })          //وارد کردن یک ارایه یا ... به صف
            {                                                          //
                que.Enqueue(item);
                Console.WriteLine($"enqueue {item}");
            }
            que.Dequeue();                                             //پاک کردن یک عدد از صف
            foreach (var item in que)
            {
                Console.WriteLine($"Queue = {item}");
            }
            Console.WriteLine($"first Queue {que.First()}");           //نمایش اول صف
            Console.WriteLine($"last Queue {que.Last()}");             //نمایش اخر صف

            Console.WriteLine("-------------------------------------------------");

            //----------------------------------------------------
            //p7
            //در پشته مثل یک دسته ظرف است ک متغیر اول اخر قرار میگیرد و از رو برمیداریم
            //در پشته مانند کیو است ولی خواندش هم از اخر است. کیو از اخر پاک میکند ولی موقع خانندن ازاول میخواند
            Stack<int> stk = new Stack<int>();
            foreach (var item in new int[] { 0, 1, 2, 3, 4 })
            {
                stk.Push(item);                             //ریختن درون استک
                Console.WriteLine($"push {item}");
            }
            stk.Pop();                                      //برداشتن از استک
            foreach (var item in stk)
            {
                Console.WriteLine($"stack is {item}");
            }
            Console.WriteLine("-------------------------------------------------");

            //----------------------------------------------------
            //p8
            //Dictionary< key,value >
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1, "mahdi");
            dic[2] = "mohammad";
            foreach (KeyValuePair<int, string> keyVP in dic)
            {
                int id = keyVP.Key;
                string name = keyVP.Value;
                Console.WriteLine($"Dictionary key: {id},value: {name}");
            }
            Console.WriteLine("-------------------------------------------------");

            //----------------------------------------------------
            //p9
            //SortedSet & HashSet     مانند لیست اند ولی مجموعه اند یعنی متغیر های تکراری حذف میشوند
            //مانند همدیگ اند ولی هشست سریع تر است ولی سورتست برخی ویژگی های بدرد نخور بیشتری دارد 
            SortedSet<int> srtSet = new SortedSet<int>();
            List<int> lstSet = new List<int>();
            HashSet<int> hashSet = new HashSet<int>();

            Console.ReadKey();
        }
    }
}
