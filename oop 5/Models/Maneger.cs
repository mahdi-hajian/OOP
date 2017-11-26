using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_5.Models
{
    //فیلد هایی ک میخاهیم اضافه کنیم را مینویسیم
    class Maneger:Employee    //با گذاشتن دو نقطه و نوشتن نام کلاس بیس این کلاس از کلاس بیس مشتق میشود یعنی ارث میبرد
    {
        private double _managemetntCoefficent;

        public double ManagemetntCoefficent
        {
            get { return _managemetntCoefficent; }
            set { _managemetntCoefficent = value; }
        }

        //-------------------------------------------
        //روش اول

        //public Maneger(int id,string firstName,string lastName,int salery,int managemetntCoefficent)
        //{
        //    Id = id;
        //    FirstName = firstName;
        //    LastName = lastName;
        //    Salery = salery;
        //    _managemetntCoefficent = managemetntCoefficent;
        //}

            //روش دوم
        public Maneger(int id, string firstName, string lastName, int salery, double managemetntCoefficent):base(id,firstName,lastName,salery)
        {
            _managemetntCoefficent = managemetntCoefficent;
        }

        //---------------------------------------------
        //override را مینویسیم تا بتوانیم تابع را تغییر بدهیم
        //وقتی تابع جدیدی میسازیم تابعی ک با مشتق شدن امده حذف و تابع جدید جایگذین میشود
        public override int CalulateNetIncome()
        {
            return (int)(base.CalulateNetIncome()*(1+_managemetntCoefficent));
        }
    }
}
