using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzeChat.Classes
{
    public class Message
    {
        public string text { get; set; }
        public string time { get; set; }

      public Message(string text, DateTime time)
        {

            string short_time = time.ToString().Remove(0, 11);
            short_time = short_time.Remove(5);
            this.text = text;
            this.time = short_time;
        }

    }
}
