namespace exemplo_poo.Models
{
    public class Professor : Pessoa
    {
        public int Salario { get; set; }

        public override void Apresentar(){
            Console.WriteLine($"Olá, meu nome é {Nome} e eu recebo R$ {Salario} por mês.");
        }
    }
}