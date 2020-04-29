using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_Mediator
{
    class User : IUser
    {
        public string Name { get; set; }
        public IChatRoom ChatRoom { get; set; }

        public User(string name)
        {
            Name = name;
            ChatRoom = null;
        }
        public void Receive(IUser sender, string message)
        {
            Console.WriteLine(Name + " received: " + message + " from " + sender.Name);
        }

        public void Send(IUser receiver, string message)
        {
            if(ChatRoom == null)
            {
                Console.WriteLine("You (" + Name + ") don't have acces to any chat room!");
                return;
            }
            if (receiver == null)
            {
                ChatRoom.Send(message, this, receiver);
            }
            else
                Console.WriteLine(Name + " sent: " + message + " to " + receiver.Name);
        }
    }
}
