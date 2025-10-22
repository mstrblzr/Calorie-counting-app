using System;

namespace kaloriräknarapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Maträtt mat1 = new Maträtt("Banan", 100);
            Maträtt mat2 = new Maträtt("Äpple", 80);
            Maträtt mat3 = new Maträtt("Pasta", 300);
            Maträtt mat4 = new Maträtt("Kött", 400);

            Måltider måltider1 = new Måltider("frukost");
            Måltider måltider2 = new Måltider("lunch");
            Måltider måltider3 = new Måltider("middag");
            Måltider måltider4 = new Måltider("mellanmål");

            List<Måltider> allamåltider = new List<Måltider>();

            allamåltider.Add(måltider1);
            allamåltider.Add(måltider2);
            allamåltider.Add(måltider3);
            allamåltider.Add(måltider4);


            Dag idag = new Dag(allamåltider);

            
            List<Dag> alladagar = new List<Dag>();


            alladagar.Add(idag);


            måltider1.AddMat(mat1);
            Serialiserare<List<Dag>> serie = new Serialiserare<List<Dag>>("dagar.xml");
            serie.Serialisera(alladagar);



            idag.SkrivUtLista();



        }
    }
}
