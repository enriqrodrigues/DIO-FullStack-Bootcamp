namespace exemplo_construtores.Models
{
    public class Pessoa
    {
        private string nome;
        private string sobrenome;

        //Atalho para criar construtor: digite ctor e aperte tab
        // public Pessoa() //Contrutor vazio, ou seja, sem parâmetros e sem retorno.
        // {
        //     this.nome = string.Empty;
        //     this.sobrenome = string.Empty;
            
        // }
    
        public Pessoa(string nome, string sobrenome) //Contrutor com parâmetros de entrada.
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            System.Console.WriteLine("construtor pessoa");
        }

        public void Apresentar(){
            System.Console.WriteLine($"Olá, meu nome é: {nome} {sobrenome}");
        }
    }
}
