using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Null
{
    class Check
    {
        public static void IsNull(Action action, params object[] obj)
        {
            lock (obj)
            {
                if (check == null) check = new Check();
            }
            check._IsNull(action, obj);
        }

        [ThreadStatic]
        static Check check;
        static object obj;
        static Check()
        {
            obj = new object();
        }
        int number;
        private void _IsNull(Action action, object[] obj)
        {
            Console.WriteLine(number);
            foreach (var item in obj)
                if (item is null) action();
        }
        public Check()
        {
            this.number = new Random().Next(10, 100);
        }
    }
}
