using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaloriräknarapp
{
    public class Måltider
    {
        private Maträtt maträtt;
        private int Totalkal { get; set; }
        public Måltider(Maträtt maträtt) { 
           
            this.maträtt = maträtt;
            Totalkal = Totalkal;

        }
        public string GetMat() { return maträtt.GetNamn(); }

        public int GetTotalkal() { return Totalkal; }

        //public void SetMat(string mat) { maträtt = mat; }

        public int RäknaKalorier() {
            Totalkal = Totalkal + maträtt.GetKalorier();
            Console.WriteLine("Totala kalorier: " + Totalkal);
            return Totalkal;
        }

    }
}
