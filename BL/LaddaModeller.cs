using DataAccess;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class LaddaModeller
    {
        public Dag idag;
        IRepository<Dag>? dagsrepo;
        public LaddaModeller()
        {
            IRepository<Maträtt>? maträttsrepo = new MaträttsRepo();
            IRepository<Måltid>? måltidsrepo = new MåltidsRepo();
            dagsrepo = new DagRepo();

            Maträtt mat1 = new Maträtt(0, 100, "Banan");
            Maträtt mat2 = new Maträtt(1, 80, "Äpple");
            Maträtt mat3 = new Maträtt(2, 300, "Pasta");
            Maträtt mat4 = new Maträtt(3, 400, "Kött");

            Måltid måltider1 = new Måltid(0, "frukost");
            Måltid måltider2 = new Måltid(1, "lunch");
            Måltid måltider3 = new Måltid(2, "middag");
            Måltid måltider4 = new Måltid(3, "mellanmål");

            maträttsrepo.Add(mat1);
            maträttsrepo.Add(mat2);
            maträttsrepo.Add(mat3);
            maträttsrepo.Add(mat4);

            måltider1.AddMat(mat1);
            måltider2.AddMat(mat3);

            måltidsrepo.Add(måltider1);
            måltidsrepo.Add(måltider2);

            List<Måltid> allaMåltider = måltidsrepo.GetAll();
            idag = new Dag(0, allaMåltider, DateTime.Today);

            dagsrepo.Add(idag);


            Console.WriteLine(idag.date1 + idag.SkrivUtLista2());


        }

        public string SkrivUtDag()
        {
            string resultat = "";

            foreach (Dag d in dagsrepo.GetAll())
            {
                resultat += d.SkrivUtLista2() + "\n";
            }

            return resultat;
        }
    }
}
