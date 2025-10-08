using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaloriräknarapp
{
    public class Maträtt
    {
        public int kalorier { get; set; }
        public string namn { get; set; }
        public Maträtt(string namn, int kalorier)
        {
            this.namn = namn;
            this.kalorier = kalorier;
        }
        public int GetKalorier()
        {
            return kalorier;
        }
        public string GetNamn()
        {
            return namn;
        }
    }
}
