namespace desafios
{
    public class SequenciaS
    {
        static void Main(string[] args)
        {
            double a = 0, S = 0;

            for (int i = 1; i <= 100; i++)
            {
                a = (double)1/i;
                S += a;
            }
            var x = Math.Round(S,2);
            Console.WriteLine(x);
        }
    }
}