using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_6.Models
{
    /// <summary>
    /// وقتی میخاهیم تمام ورودی هارا داخل یک پوشه بگذاریم یک دی تی او درست میکنیم که راحت تر باشد
    /// </summary>
    class DTO
    {
        public int _idDTO { get; set; }
        public string _firstNameDTO { get; set; }
        public string _lastNameDTO { get; set; }
        public int _saleryDTO { get; set; }

        //---------------------------------------
        public DTO(int idDTO, string firstNameDTO, string lastNameDTO, int saleryDTO)
        {
            _idDTO = idDTO;
            _firstNameDTO = firstNameDTO;
            _lastNameDTO = lastNameDTO;
            _saleryDTO = saleryDTO;
        }
        public DTO()
        {

        }
    }
}
