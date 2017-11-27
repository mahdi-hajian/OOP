using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_6.Models
{
    /// <summary>
    /// کلاس اقیم شد با سلید چون فرزندی نیاز نداریم
    /// </summary>
    sealed class Admis : Employee
    {
        /// <summary>
        /// فیلد جدیدی اضافه میشود
        /// </summary>
        private double _managemetntCoefficent;

        public double ManagemetntCoefficent
        {
            get { return _managemetntCoefficent; }
            set { _managemetntCoefficent = value; }
        }
        //--------------------------------------------
        /// <summary>
        /// دی تی او را همراه با فیلد اضافی ک ساخته ایم دریافت میکنیم
        /// </summary>
        /// <param name="d"></param>
        /// <param name="managemetntCoefficent"></param>
        public Admis(DTO d, double managemetntCoefficent) : base(d)
        {
            _managemetntCoefficent = managemetntCoefficent;
        }

        public Admis()
        {

        }

        //--------------------------------------------
        /// <summary>
        /// چون میخاستیم در فرزندش یک آورراید درست کنیم و از همین تابع تشکیل شده باشد ک اگر
        /// مثلا 0.9 را تغییر دادیم در آن  هم تغییر داده شود یک تابع دیگر درست کردیم
        /// و ان را ویرچوال کردیم
        /// </summary>
        /// <returns></returns>
        public override int CalculateNetIncomEmployee()
        {
            return (int)(base.CalculateNetIncomEmployee() * (1 + _managemetntCoefficent));
        }
        
    }
}
