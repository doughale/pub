using System;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Threads
    {
        public static void ThreadsMain(string[] args)
        {
            var n = 20;
            Console.WriteLine("Calling CountToN regular");
            var g1 = CountToN(n);
            Console.WriteLine($"CountToN returned {g1.ToString()}");

            Console.WriteLine("Calling CountToNAwait awaitable task");
            var g2 = CountToNAwait(n);
            Console.WriteLine($"CountToNAwait returned {g2.ToString()} .. note this is a Task's tostring .. not n .. and you're going to see another thread outputing as well");

            Console.WriteLine("Calling CountToNAwait awaitable task again");
            var g3 = CountToNAwait(n);
            Console.WriteLine($"CountToNAwait returned {g3.Result.ToString()} .. note this n because we used .Result()");

            Console.WriteLine("Calling CountToNAwait awaitable task 3 times in a row .. 3 threads will be outputting simultaneously");
            var g4 = CountToNAwait(n);
            var g5 = CountToNAwait(n);
            var g6 = CountToNAwait(n);

            Console.WriteLine("Waiting on all Tasks ..");
            Task.WaitAll(new Task[] {g3,g4,g5});

            Console.WriteLine($"The 3 CountToNAwaits returned {g3.Result.ToString()}, {g3.Result.ToString()}, {g3.Result.ToString()} ");

            Console.ReadKey();



        }
        public static async Task<Guid> CountToNAwait(int n)
        {
            var taskCompletionGuid = await Task.Run(() =>
            {
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"[Thread {System.Threading.Thread.CurrentThread.ManagedThreadId}] CountToNAwait: {i+1} of {n}");
                    // Do something
                    Task.Delay(100).Wait();
                }
                return Guid.NewGuid();
            });

            return taskCompletionGuid;
        }


        public static Guid CountToN(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"CountToN: {i + 1} of {n}");
                // Do something
                Task.Delay(100).Wait();
            }
            return Guid.NewGuid();

        }
    }
}
