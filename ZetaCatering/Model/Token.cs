using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace ZetaCatering.Model
{
    public class Token
    {
        public long TokenId { get; private set; }
        public string TokenString { get; private set; }
        public DateTime ExpireDate { get; private set; }
        public EventPlanner planner { get; private set; }

        public Token()
        {}

        public Token(EventPlanner planner)
        {
            RandomNumberGenerator random = RandomNumberGenerator.Create();
            byte[] randomBytes = new byte[256];
            this.planner = planner;
            random.GetNonZeroBytes(randomBytes);
            TokenString = randomBytes.ToString();
            ExpireDate = DateTime.Now.AddSeconds(3600);
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
