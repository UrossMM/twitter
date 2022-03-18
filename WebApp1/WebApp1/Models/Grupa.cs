using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp1.Models
{
    public class Grupa
    {
        public int Id { get; set; }
        public string Ime { get; set; }

        //admin grupe (strani kljuc za Grupu)
        //public int UsersId { get; set; }
        public Users Users { get; set; }
    }
}
