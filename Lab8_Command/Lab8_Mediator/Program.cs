using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            IChatRoom chatRoom = new ChatRoom();
            IUser user1 = new User("A");
            IUser user2 = new User("B");
            IUser user3 = new User("C");

            chatRoom.Register(user1);
            chatRoom.Register(user2);
            chatRoom.Register(user3);

            user1.Send(null, "Hello!");

            user2.Send(user3, "Mesaj privat...");

            chatRoom.Send("Buna!", user2, null);

            chatRoom.UnRegister(user2);

            user2.Send(null, "mesaj");

            chatRoom.Send("Unde a plecat " + user2.Name + '?', user3, null);
        }
    }
}
