using System;
using System.Threading;

namespace Null
{
    class Program
    {
        static void Start()
        {
     
        }
        static void Main(string[] args)
        {
            string test = null;
            string testTwo = null;
            test.IsNull(new Exception(),testTwo);
            Console.WriteLine();
        }
    }
}
