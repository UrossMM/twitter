using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp1.Models
{
    public class Users : IdentityUser
    {
        //public int Id { get; set; }
        //public string Name { get; set; }
        //public string Email { get; set; }
        //public string Password { get; set; }
        public string Country { get; set; }
        public string Pol { get; set; }
        public string CreditCard { get; set; }
        public List<Grupa> Grupe { get; set; }
    }
}
