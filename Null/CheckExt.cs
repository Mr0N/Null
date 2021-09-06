using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Null
{
    static class CheckExt
    {
        public static void IsNull(this object x, Exception exception, params object[] obj)
        {
            object[] insert = null;
            lock (objLock)
            {
                List<object> ls = new List<object>();
                ls.Add(x);
                ls.AddRange(obj);
                insert = ls.ToArray();
            }
            Check.IsNull(exception, insert);
        }
        static object objLock;
        static CheckExt()
        {
            objLock = new object();
        }
    }
}
