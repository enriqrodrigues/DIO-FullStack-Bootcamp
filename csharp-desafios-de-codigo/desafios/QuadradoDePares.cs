using System; 

namespace desafios
{
    class QuadradoDePares {

        static void Main(string[] args) { 

            int n = int.Parse(Console.ReadLine());
        
            for(int i = 2; i <= n; i += 2)
            {
                System.Console.WriteLine($"{i}^2 = {Math.Pow(i, 2)}");
            }
        }
    }
}
