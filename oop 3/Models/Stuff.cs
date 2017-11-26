using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop.Models
{
    class Stuff
    {
        //-------Field----------
        private int _stuffId;                                // فیلد ها با حرف کوچک و ـ اولش شروع میشود

        //-------Method----------
        public int StuffId                                   //متد با حرف بزرگ شروع میشود
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
        //-------Constactor----------
        public Stuff(int stuffId,string name,int price)      //پارامتر با حرف کوچک شروع میشود
        {
            _stuffId = stuffId;
            _name = name;
            _price = price;
        }
        public Stuff():this(-1,string.Empty,-1)    //برای ننوشتن دوباره پارامتر ها با دیس مینویسیم و پاس میکنم هرچی میخایم
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
