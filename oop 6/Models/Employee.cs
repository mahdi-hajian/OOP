using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_6.Models
{
    class Employee : Personnel
    {
        
        /// <summary>
        /// dto را دریافت میکنیم
        /// </summary>
        /// <param name="d"></param>
        public Employee(DTO d) : base(d)
        {

        }

        public Employee()
        {

        }

        //--------------------------------------------
        /// <summary>
        /// const
        /// متغیری ک مقدار آن تغییر نمیکند
        /// </summary>
        const double scot = 0.9;
        //-----------
        public override int CalculateNetIncom()
        {
            return (int)(Salery * scot);
        }
        
        public virtual int CalculateNetIncomEmployee()
        {
            return CalculateNetIncom();
        }
    }

}

