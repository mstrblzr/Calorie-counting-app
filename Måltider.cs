using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaloriräknarapp
{
    public class Måltider
    {
        private string namn { get; set; }
        public int Totalkal { get; set; }

        private List<Maträtt> maträtter = new List<Maträtt>();

        
        
        public Måltider(string namn, Maträtt mat) { 
           
            
            
            this.namn = namn;
            maträtter.Add(mat);


        }
        public void GetMat()
        {
            foreach (Maträtt mat in maträtter)
            {

                Console.WriteLine(mat.namn);
            }
            
        }

        public void AddMat(Maträtt M)
        {
            maträtter.Add(M);
            Console.WriteLine("Du har lagt till " + M.namn + " i " + namn);
        }

        public int GetTotalkal() { return Totalkal; }

        //public void SetMat(string mat) { maträtt = mat; }

        public void RäknaKalorier() {
            foreach (Maträtt mat in maträtter)
            {
                Totalkal = Totalkal + mat.kalorier;
            }
             Console.WriteLine("Totala kalorier: " + Totalkal);
        }

    }
}
