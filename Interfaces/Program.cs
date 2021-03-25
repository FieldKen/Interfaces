using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Superman superman = new Superman();
            Goku goku = new Goku();

            superman.SchietLaser();
            goku.SchietLaser();
            goku.Adem();

            if (superman is IMens && superman is ISuperheld)
            {
                Console.WriteLine("Superman is een superheld");
            }



            Console.ReadLine();
        }
    }
}
