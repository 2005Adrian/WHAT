using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHAT
{
    class Programac
    {
        static void Main(string[] args)
        {
            Cliente c = new Cliente("localhost", 4404);
            c.Start();
            c.Send("Hola");
        }
    }
}
