using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FrontEnd.Models;

namespace FrontEnd.Data
{
    public interface IUserRepository
    {
        IEnumerable<Users> GetAllUsers();
    }
}