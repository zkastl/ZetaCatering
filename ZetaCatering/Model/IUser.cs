using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZetaCatering.Model
{
    public interface IUser
    {
        string Username { get; set; }
        string Password { get; set; }
    }
}
