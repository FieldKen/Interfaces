using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Land : IComparable
    {
        public string Naam { get; set; }
        public int Inwoners { get; set; }
        public int Oppervlakte { get; set; }
        public Land(string naam, int inwoners, int oppervlakte)
        {
            Naam = naam;
            Inwoners = inwoners;
            Oppervlakte = oppervlakte;
        }

        public int CompareTo(object obj)
        {
            Land temp = obj as Land;


            if (temp != null)
            {
                /*int oppervlakteResult = Oppervlakte.CompareTo(temp.Oppervlakte);
                if (oppervlakteResult == 0)
                {
                    return Inwoners.CompareTo(temp.Inwoners);
                }
                return oppervlakteResult;*/

                if (Oppervlakte > temp.Oppervlakte)
                    return 1;
                if (Oppervlakte < temp.Oppervlakte)
                    return -1;
                if (Inwoners > temp.Inwoners)
                    return 1;
                if (Inwoners < temp.Inwoners)
                    return -1;
                return 0;
            }
            else
            {
                throw new NotImplementedException("Da is geen land");
            }
        }
    }
}
