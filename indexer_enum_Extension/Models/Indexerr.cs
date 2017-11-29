using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexer_enum_Extension.Models
{
    public class Indexerr
    {
        //p1
        /// <summary>
        /// تعریف ایندکسر
        /// </summary>
        private int[] _id = new int[5];
        public int this[int index]
        {
            get { return _id[index]; }
            set { _id[index] = value; }
        }

        //-------------------------------------------------
        //p2
        /// <summary>
        /// Flag
        /// تعریف ایندکسر به صورت فلگ
        /// </summary>
        //private bool[] _indxer2 = new bool[32];
        //public bool this[int index2]
        //{
        //    get { return _indxer2[index2]; }
        //    set { _indxer2[index2] = value; }
        //}

    }
}
