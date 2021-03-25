using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Superheld : Levend, ISuperheld, IMens
    {
        public bool KanVliegen { get; set; }
        public int Lengte { get; set; }
        public int Gewicht { get; set; }

        public virtual void SchietLaser()
        {
            Console.WriteLine("Er wordt een laser geschoten");
        }
    }
}
