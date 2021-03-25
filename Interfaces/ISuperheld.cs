using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface ISuperheld
    {
        bool KanVliegen { get; set; }
        void SchietLaser();
        int Lengte { get; }
    }
}
