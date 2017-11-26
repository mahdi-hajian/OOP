using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_4.Models
{
    /// <summary>
    /// اطلاعات کالا
    /// </summary>
    class Stuff
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private int _price;

        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }
        /// <summary>
        /// Constactor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="price"></param>
        public Stuff(int id,string name,int price)
        {
            _id = id;
            _name = name;
            _price = price;
        }
        
        public Stuff():this(-1,string.Empty,-1)
        {

        }
    }
    //------------------------------------------------
    /// <summary>
    /// مورد های فاکتور
    /// یکی اطلاعات خوده کالا
    /// یکی تعداد کالا ها
    /// </summary>
    class InvoiceItem
    {
        private int _count;

        public int Count
        {
            get { return _count; }
            set { _count = value; }
        }
        private Stuff _stuff;

        public Stuff Stuff
        {
            get { return _stuff; }
            set { _stuff = value; }
        }
        /// <summary>
        /// گرفتن کالا و تعداد
        /// </summary>
        /// <param name="stuff"></param>
        /// <param name="count"></param>
        public InvoiceItem(Stuff stuff,int count)
        {
            _stuff = stuff;
            _count = count;
        }
    }
    //-------------------------------------
    /// <summary>
    /// خوده فاکتور ک آیدی فاکتور و تاریخ ثبت فاکتور دارد
    /// </summary>
    class Invoice
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private DateTime _date;

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        /// <summary>
        /// یک لیست درست میکنیم ک جنس مورد های فاکتور را دارا میباشد
        /// یادآوری : یکی اطلاعات کالا یکی تعداد
        /// </summary>
        private List<InvoiceItem> _items;
        /// <summary>
        /// ایدی فاکتور و تاریخ فاکتور
        /// </summary>
        /// <param name="id"></param>
        /// <param name="date"></param>
        public Invoice(int id,DateTime date)
        {
            _id = id;
            _date = date;

            //چون جنسش یک ابجکت است باید هردفعه ک میخاهد اضافه کنن به لیست باید لیست نیو شود
            _items = new List<InvoiceItem>();
        }

        public Invoice():this(-1,new DateTime())
        {

        }

        public void AddItemToInvoice(Stuff stuff,int count)
        {
            InvoiceItem temp = new InvoiceItem(stuff,count);

            _items.Add(temp);
        }

        /// <summary>
        /// تابع دریافت کل هزینه ی فاکتور
        /// </summary>
        /// <returns></returns>
        public int CalculateTotalSum()
        {
            int sum = 0;
            for (int i = 0; i < _items.Count; i++)
            {
                sum = sum + _items[i].Count * _items[i].Stuff.Price;
            }            
            return sum ;
        }

       
    }
}
