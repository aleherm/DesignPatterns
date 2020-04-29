using System.Collections.Generic;

namespace Lab1_Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            // 20 de threaduri/taskuri
            // cate 5 requesturi din LoadBalancer

            const int nrThreads = 5;
            List<WorkerThread> threads = new List<WorkerThread>();
            LoadBalancer.Instance.RandomAccess = true;

            for (int i = 0; i < nrThreads; i++)
            {
                threads.Add(new WorkerThread());
            }

            for (int i = 0; i < threads.Count; i++)
            {
                threads[i].Join();
            }

            LoadBalancer.Instance.WriteServers();
        }
    }
}
