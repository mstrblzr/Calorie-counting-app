using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaloriräknarapp
{
    internal class Frukost:Måltider
    {
        public Frukost(string namn, Maträtt mat) : base(namn, mat)
        {
            
        }
    }
}
