namespace exemplo_construtores.Models
{
    public class Aluno : Pessoa
    {
        public Aluno(string nome, string sobrenome, string disciplina) : base(nome, sobrenome){
            System.Console.WriteLine("construtor aluno");
        }
        
    }
}