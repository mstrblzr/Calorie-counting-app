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

            Måltider måltider = new Måltider(mat1);
            Console.WriteLine(måltider.RäknaKalorier());
        }
    }
}
