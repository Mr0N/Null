using System;
using System.Threading;

namespace Null
{
    class Program
    {
        static void Start()
        {
            for (int i = 0; i < 10; i++)
            {
                Check.IsNull(() => Console.WriteLine("isNull"), "", "", null);
            }
        }
        static void Main(string[] args)
        {
            new Thread(Start).Start();
            new Thread(() => Check.IsNull(() => Console.WriteLine("isNull"), "", "", null)).Start();
            new Thread(() => Check.IsNull(() => Console.WriteLine("isNull"), "", "", null)).Start();
        }
    }
}
