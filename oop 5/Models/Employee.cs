using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_5.Models
{
    class Employee
    {
        //اگر بجای پریویت پراتکتد بگذاریم در تابع مین قابل دسترسی نیست ولی در کلاس دیگر
        //ک ازش مشتق شده قابل دسترسی است مانند فیلد آیدی
        protected int _id;                          

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        private int _salery;

        public int Salery
        {
            get { return _salery; }
            set { _salery = value; }
        }
        //-------------------------------------
        public Employee(int id,string firstName,string lastName,int salery)
        {
            _id = id;
            _firstName = firstName;
            _lastName = lastName;
            _salery = salery;
        }

        public Employee():this(-1,string.Empty,string.Empty,-1)
        {

        }
        //-----------------------------------------------------
        //virtual برای اینکه در کلاس مشتق شده بتوان تغییر داد
        public virtual int CalulateNetIncome()
        {
            return (int)(_salery*0.9);
        }
    }
}
