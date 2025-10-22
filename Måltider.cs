using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaloriräknarapp
{
    public class Måltider
    {
        public string namn { get; set; }
        public int Totalkal { get; set; }
        

        public List<Maträtt> maträtter = new List<Maträtt>();

        public Måltider(string namn) { 
           
            this.namn = namn;
            
            //maträtter.Add(mat);
        }
        public Måltider()
        {
            
        }
        public string GetMat()
        {
            foreach (Maträtt mat in maträtter)
            {
                //Console.WriteLine(mat.namn);
                return mat.namn;
            }
            return default;
        }

        public void AddMat(Maträtt M)
        {
            maträtter.Add(M);
            Console.WriteLine("Du har lagt till " + M.namn + " i " + namn);
        }

        public string RäknaKalorier() {

            foreach (Maträtt mat in maträtter)
            {
                Totalkal = Totalkal + mat.kalorier;
            }
            return "Totala kalorier: " + Totalkal;
             //Console.WriteLine("Totala kalorier: " + Totalkal);
        }

    }
}
