using System;


namespace PresentationLayer;

internal class Program
{
    static void Main(string[] args)
    {
        
        // UI ui = new UI();

        //MaträttsRepo maträttsrepo = new MaträttsRepo();
        IRepository<Maträtt>? maträttsrepo = new MaträttsRepo();
        IRepository<Måltid>? måltidsrepo = new MåltidsRepo();
        
        /////////////////////////////////////////////////////
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

        Dag idag = new Dag(0, måltidsrepo, DateTime.Today);
        Console.WriteLine(idag.date1);

        idag.SkrivUtLista();
        

        //for(int i = 0; i< måltidsrepo.GetAll().Count; i++)
        //{
        //    if(i == måltidsrepo.GetById(i).Id)
        //    {
        //        Console.WriteLine(måltidsrepo.GetById(i).Namn + " : " + måltidsrepo.GetById(i).GetMat());
        //    }
        //}
    }
    
}
