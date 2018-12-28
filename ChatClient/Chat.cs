using System.Collections.Generic;

namespace Chat
{
    public class Chat
    {

        public string User { get; set; }

        public List<Message> Messages { get; set; }


        public Chat()
        {
            Messages = new List<Message>();
        }

    }
}
