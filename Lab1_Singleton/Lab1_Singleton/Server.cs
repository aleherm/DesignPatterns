using System.Threading;

namespace Lab1_Singleton
{
    class Server
    {
        public string Name { get; set; }
        public string IPAdress { get; set; }
        public int NumOfRequests { get; set; }
        public int MinTime { get; set; }
        public int MaxTime { get; set; }
        public int TotalTime { get; set; }

        public Server(string name, string ipAdress)
        {
            Name = name;
            IPAdress = ipAdress;
            MinTime = int.MaxValue;
            MaxTime = int.MinValue;
            NumOfRequests = 0;
            TotalTime = 0;
        }

        public void ProcessRequest(int time)
        {
            TotalTime += time;
            NumOfRequests++;

            if (time < MinTime)
            {
                MinTime = time;
            }

            if (time > MaxTime)
            {
                MaxTime = time;
            }

            //Thread.Sleep(time);
        }

        public override string ToString()
        {
            return "Name:" + Name + " | IP:" + IPAdress + " | Requests:" + NumOfRequests + " | Min:" + MinTime + " | Max: " + MaxTime + " | Total: " + TotalTime + "\n";
        }

    }
}
