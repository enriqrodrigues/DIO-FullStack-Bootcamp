using exemplo_construtores.Models;

namespace ExemploConstrutores
{
    class Program
    {
        public delegate void Operacao(int x, int y);

        static void Main(string[] Args)
        {
            Matematica mat = new Matematica(10, 20);
            mat.Somar();

            //Operacao op = Calculadora.Somar;            
            Operacao op = new Operacao(Calculadora.Somar);
            op += Calculadora.Subtrair; //Delegate Multicast (Chama vários métodos)
            //op(10, 10);
            op.Invoke(10, 10);

            Data data = new Data();
            data.Mes = 12;
            System.Console.WriteLine(data.Mes); 
 
            data.SetMes(2);
            data.Apresentar();

            Pessoa p1 = new Pessoa("Henrique", "Rodrigues");
            p1.Apresentar();

            // Pessoa p2 = new Pessoa();
            // p2.Apresentar();

            Log log = Log.GetInstance();
            log.PropriedadeLog = "Teste Instância.";

            Log log2 = Log.GetInstance();
            System.Console.WriteLine(log2.PropriedadeLog);

            Aluno a1 = new Aluno("Henrique", "Rodrigues", "Programação");
            a1.Apresentar();
            
        }
    }
}

