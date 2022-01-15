using System;

namespace exemplo_poo.Models
{
    public class Pessoa
    {
        public string Nome { get; set;}
        public int Idade { get; set;}

        public virtual void Apresentar(){
            Console.WriteLine($"Olá, meu nome é {Nome} e eu tenho {Idade} anos.");
        }
    }   
}