using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_Mediator
{
    class ChatRoom : IChatRoom
    {
        private List<IUser> users;

        public bool Register(IUser user)
        {
            if(users == null)
                users = new List<IUser>();

            if (!users.Contains(user))
            {
                user.ChatRoom = this;
                users.Add(user);
                Console.WriteLine(user.Name + " has entered the chat room");
                return true;
            }
            return false;
        }

        public void Send(string message, IUser user1, IUser user2)
        {
            if (user2 == null)
            {
                foreach (IUser user in users)
                {
                    if(user != user1)
                    user1.Send(user, message);
                }
            }
            else
                user1.Send(user2, message);
        }

        public bool UnRegister(IUser user)
        {
            if (users != null && users.Contains(user))
            {
                user.ChatRoom = null;
                users.Remove(user);
                Console.WriteLine(user.Name + " has left the chat room");
                return true;
            }
            return false;
        }
    }
}
