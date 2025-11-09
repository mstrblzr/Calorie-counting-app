using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Måltid
    {
        public int Id { get; set; }
        public string Namn { get; set; }
        public int Totalkal { get; set; }
        

        public List<Maträtt> maträtter = new List<Maträtt>();

        public Måltid(int id, string namn) {

            this.Id = id;
            this.Namn = namn;
            
            //maträtter.Add(mat);
        }
        public Måltid()
        {
            
        }
        public string GetMat()
        {
            string resultat = "";
            foreach (Maträtt mat in maträtter)
            {
                //Console.WriteLine(mat.Namn);
                resultat += mat.Namn;
            }
            return resultat;
        }

        public void AddMat(Maträtt M)
        {
            maträtter.Add(M);
            Console.WriteLine("Du har lagt till " + M.Namn + " i " + Namn);
        }

        public string RäknaKalorier() {

            foreach (Maträtt mat in maträtter)
            {
                Totalkal = Totalkal + mat.Kalorier;
            }
            return "Totala kalorier: " + Totalkal;
             //Console.WriteLine("Totala kalorier: " + Totalkal);
        }

    }
}
