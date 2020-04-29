using System;
using System.Collections.Generic;
using System.Threading;

namespace Lab1_Singleton
{
    class LoadBalancer
    {
        private static LoadBalancer _instance;
        public bool RandomAccess { get; set; }
        private static readonly Object locker = new Object();

        private Random random = new Random();

        List<Server> servers;

        public LoadBalancer()
        {
            servers = new List<Server>{ new Server("Server0", "0.0.0.0"),
                                        new Server("Server1", "1.0.0.0"),
                                        new Server("Server2", "2.0.0.0"),
                                        new Server("Server3", "3.0.0.0"),
                                        new Server("Server4", "4.0.0.0"),
                                        new Server("Server5", "5.0.0.0"),
                                        new Server("Server6", "6.0.0.0"),
                                        new Server("Server7", "7.0.0.0"),
                                        new Server("Server8", "8.0.0.0"),
                                        new Server("Server9", "9.0.0.0")};
            RandomAccess = false;
            _instance = null;
        }

        public static LoadBalancer Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (locker)
                    {
                        if (_instance == null)
                        {
                            _instance = new LoadBalancer();
                        }
                    }
                }
                return _instance;
            }
        }

        public void ProcessRequest(int time)
        {
            if (RandomAccess)
            {
                int serverIndex = random.Next(0, servers.Count);
                servers[serverIndex].ProcessRequest(time);
            }
        }
        public void WriteServers()
        {
            for (int i = 0; i < servers.Count; i++)
            {
                Console.WriteLine(servers[i].ToString());
            }
        }
    }
}
