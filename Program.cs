using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHAT
{
    class Program
    {
        static void Main(string[] args)
        {
            SERVER s = new SERVER("localhost", 4404);
            s.Start();
            
        }
    }
}
