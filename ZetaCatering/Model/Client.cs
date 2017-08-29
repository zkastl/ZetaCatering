using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZetaCatering.Model
{
    public class Client
    {
        public long ClientId { get; private set; }
        public string Name { get; private set; }
        public string PhoneNumber { get; private set; }
        public string EmailAddress { get; private set; }

        public Client()
        {}

        public Client(string name, string phoneNumber, string email)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            EmailAddress = email;
        }

        public bool Save()
        {
            return false;
        }

        public bool Delete()
        {
            return false;
        }

        public static bool Update(Client client)
        {
            return false;
        }
    }
}
