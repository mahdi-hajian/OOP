using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// چند ریختی Polymorphism
/// 
/// کلا وقتی از ابستراکت استفاده میکنیم ک نشود خروجی برایش تعریف کرد 
/// مثلا میدانیم ک دایره و مثلث و مربع و ... جزو اشکال هستند ولی نمیتوانیم خوده اشکال را رسم کنیم
/// ولی دایره و ... را میتوانیم رسم کنیم
/// 
/// sealed کلاس را اقیم میکند
/// یعنی دیگر نمیتواند فرزندی داشته باشد و یا باید سیلد باشد یا ابسترکت
/// </summary>

namespace oop_6.Models
{
    /// <summary>
    /// اگر نوع کلاس را ابسترکت کنیم نمیشود دیگر این را نیو کرد
    /// </summary>
    abstract class Personnel
    {
        private int _id;

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
        //---------------------------------
        /// <summary>
        /// dto را میسازیم
        /// </summary>
        DTO d = new DTO();
        public Personnel(DTO d)                          //پارامتر دی تی او را دریافت میکنیم
        {
            _id = d._idDTO;                                  //جایگذاری عناصر دی تی او
            _firstName = d._firstNameDTO;
            _lastName = d._lastNameDTO;
            _salery = d._saleryDTO;
        }

        public Personnel()
        {

        }

        //----------------------------------------------------
        /// <summary>
        /// نباید برای ان محاسبات انجام بدهیم یا حتی اکولاد بگذاریم چون ابسترکت است
        /// </summary>
        /// <returns></returns>
        public abstract int CalculateNetIncom();
    }
}
