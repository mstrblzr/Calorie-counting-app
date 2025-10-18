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

            Måltider måltider1 = new Måltider("frukost",mat1);
            Måltider måltider2 = new Måltider("lunch", mat3);
            Måltider måltider3 = new Måltider("middag", mat4);
            Måltider måltider4 = new Måltider("mellanmål", mat2);

            måltider1.AddMat(mat3);

<<<<<<< HEAD
            måltider1.GetMat();
            
            måltider1.RäknaKalorier();

            
=======
            List<Måltider> allaMaträtter = new List<Måltider>();

            allaMaträtter.Add(måltider1);
            allaMaträtter.Add(måltider2);
            allaMaträtter.Add(måltider3);
            allaMaträtter.Add(måltider4);

            foreach (Måltider måltid in allaMaträtter)
            {
                Console.WriteLine(måltid.GetMat());
            }
            //Console.WriteLine(måltider1.GetMat());
            //måltider1.RäknaKalorier();
>>>>>>> 1527fc7000d12017064a1091944ef3829043b6b5
            
        }
    }
}
