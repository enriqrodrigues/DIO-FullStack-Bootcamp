namespace exemplo_poo.Models
{
    public abstract class Conta
    {
        protected double Saldo;

        public abstract void Creditar(double valor);
        // Perceba que o método é vazio, justamente por ser abstrato.

        public void ExibirSaldo(){
            System.Console.WriteLine("Saldo Atual: " + Saldo);
        }
    }
}
