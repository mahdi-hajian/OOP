using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop.Models
{
    class Stuff
    {
        private int _stuffId;

        public int StuffId
        {
            get { return _stuffId; }
            set { _stuffId = value; }
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
        //--------------------------------
        public Stuff(int stuffId,string name,int price)
        {
            _stuffId = stuffId;
            _name = name;
            _price = price;
        }
        public Stuff():this(-1,string.Empty,-1)
        {

        }
        //-------------------------------------
        public int GetDisCount(double disCount)
        {
            return (int)(_price * (1 - disCount));
        }
        public int GetDisCount()
        {
            return GetDisCount(0.1);
        }
    }
}
