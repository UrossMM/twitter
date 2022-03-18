using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp1.Models;

namespace WebApp1.Repositories
{
    public interface IJWTManagerRepository
    {
        Tokens Authenticate(Users user);

    }
}
