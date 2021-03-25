using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mijnArray = new int[5];

            mijnArray[0] = 2;
            mijnArray[1] = 3;
            mijnArray[2] = 4;
            mijnArray[3] = 5;
            mijnArray[4] = 1;

            Array.Sort(mijnArray);

            foreach (var item in mijnArray)
            {
                Console.WriteLine(item);
            }


            Land[] landen = new Land[3];
            landen[0] = new Land("Belgie", 11500000, 1000);
            landen[1] = new Land("Nederland", 23000000, 1000);
            landen[2] = new Land("Luxemburg", 2000000, 80);

            Array.Sort(landen);

            foreach (var item in landen)
            {
                Console.WriteLine(item.Naam);
            }

            Console.ReadLine();

        }
    }
}
