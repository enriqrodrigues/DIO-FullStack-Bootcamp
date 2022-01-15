namespace exemplo_poo.Models
{
    public class Aluno : Pessoa
    //Assim dizemos que a classe Aluno herda da classe pessoas.
    {
        public int Nota { get; set; }
 
        public override void Apresentar() {
            Console.WriteLine($"Olá, meu nome é {Nome} e eu tenho nota {Nota}.");
        }   
    }
}