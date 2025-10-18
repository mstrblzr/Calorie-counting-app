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

            måltider1.AddMat(mat3);

            måltider1.GetMat();
            
            måltider1.RäknaKalorier();

            
            
        }
    }
}
