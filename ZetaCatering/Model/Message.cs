using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZetaCatering.Model
{
    public class Message
    {
        private static long serialVersionUid = 1L;
        private string Code { get; set; }
        private string MessageText { get; set; }
        private string AttributeName { get; set; }

        public Message(string code, string messageText,
            string attributeName)
        {
            Code = code;
            MessageText = messageText;
            AttributeName = attributeName;
        }
    }
}
