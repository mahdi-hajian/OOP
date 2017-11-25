using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_4.Models
{
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

        public InvoiceItem(Stuff s,int count)
        {
            _stuff = s;
            _count = count;
        }
    }
    //-------------------------------------
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

        private List<InvoiceItem> _items;

        public Invoice(int id,DateTime date)
        {
            _id = id;
            _date = date;

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

        public int CalculateTotalSum()
        {
            int sum = 0;
            for (int i = 0; i < _items.Count; i++)
            {
                sum = sum + _items[i].Count * _items[i].Stuff.Price;
            }

            return sum;

        }
    }
}
