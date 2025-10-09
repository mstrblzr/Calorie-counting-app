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
        private int Totalkal { get; set; }

        private List<Maträtt> maträtter = new List<Maträtt>();
        
        public Måltider(string namn, Maträtt mat) { 
           
            
            //Totalkal = 0;
            this.namn = namn;
            maträtter.Add(mat);


        }
        public string GetMat()
        {
            foreach (Maträtt mat in maträtter)
            {
                return (mat.GetNamn());
            }
            return null;
        }

        public int GetTotalkal() { return Totalkal; }

        //public void SetMat(string mat) { maträtt = mat; }

        public int RäknaKalorier() {
            foreach (Maträtt mat in maträtter)
            {
                Totalkal = Totalkal + mat.GetKalorier();
                Console.WriteLine("Totala kalorier: " + Totalkal);
                
            }
            return Totalkal;
        }

    }
}
