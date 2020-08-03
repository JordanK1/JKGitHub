using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7_4JordanK
{
    class Message
    {
        public DatingProfile sender;
        public string MessageTitle;
        public string MessageData;
        public bool isRead;

        public Message(DatingProfile sender, string MessageTitle, string MessageData)
        {
            this.sender = sender;
            this.MessageTitle = MessageTitle;
            this.MessageData = MessageData;
            isRead = false;
        }
    }
}
