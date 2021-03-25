using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Superman : Superheld
    {
        public void Vermom()
        {
            Console.WriteLine("Superman zet ne zonnenbril op");
        }

        public override void SchietLaser()
        {
            Console.WriteLine("Superman schiet met laserogen.");
        }
    }
}
