namespace exemplo_poo.Models
{
    public class Professor : Pessoa
    {
        public double Salario { get; set; }

        public sealed override void Apresentar(){
            Console.WriteLine($"Olá, meu nome é {Nome} e eu recebo R$ {Salario} por mês.");
        }
    }
}
