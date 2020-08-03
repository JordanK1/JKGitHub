using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7_4JordanK
{
    class DatingProfile
    {
        public string firstName;
        private string lastName;
        public int age;
        public string gender;
        public string bio;
        private List<Message> userMessages;

        public DatingProfile(string FirstName, string LastName, int age, string gender)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.gender = gender;
            userMessages = new List<Message>();
        }

        public void WriteBio(string text)
        {
            bio = text;
        }

        public void SendtoInbox(Message message)
        {
            userMessages.Add(message);
        }

        public void ReadMessage()
        {
            foreach (Message message in userMessages)
            {
                if (message.isRead == false)
                {
                    Console.WriteLine(message.MessageTitle);
                    Console.WriteLine(message.MessageData);
                    message.isRead = true;
                }
            }
        }

        public void SendMessage(string MessageTitle, string MessageData, DatingProfile sender)
        {
            Message message = new Message(this, MessageTitle, MessageData);
            sender.SendtoInbox(message);
        }
    }
}
