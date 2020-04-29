using System;
using System.Threading;

namespace Lab1_Singleton
{
    public class WorkerThread
    {
        private Thread thread;
        private const int nrRequests = 20;
        private Random random = new Random();

        public WorkerThread()
        {
            thread = new Thread(new ThreadStart(Post));
            thread.Start();
        }

        public void Post()
        {
            int randomTime = random.Next(500, 1000);
            for (int i = 0; i < nrRequests; i++)
                PostRequest(randomTime);
        }

        public void PostRequest(int time)
        {
            LoadBalancer.Instance.ProcessRequest(time);
        }

        public void Join()
        {
            thread.Join();
        }
    }
}
