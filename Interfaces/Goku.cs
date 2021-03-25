using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Goku : Superheld
    {
        public void GaSaiyan()
        {
            Console.WriteLine("Goku gaat super saiyan");
        }

        public override void SchietLaser()
        {
            Console.WriteLine("Goku doet kamehameha.");
        }
    }
}
