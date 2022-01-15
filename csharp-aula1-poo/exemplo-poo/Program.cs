using System;
using exemplo_poo.Models;

namespace exemplo_poo
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();
            System.Console.WriteLine("Resultado da primeira soma: "
            + calc.Somar(15, 12));
            System.Console.WriteLine("Resultado da primeira soma: "
            + calc.Somar(15, 12, 10));

            Aluno aluno1 = new Aluno();
            aluno1.Nome = "Zeca";
            aluno1.Idade = 19;
            aluno1.Nota = 8;
            aluno1.Apresentar();

            Professor prof1 = new Professor();
            prof1.Nome = "Seu Zé";
            prof1.Idade = 59;
            prof1.Salario = 8000;
            prof1.Apresentar();

            //Valores Válidos
            Retangulo ret1 = new Retangulo();
            ret1.definirMedidas(10, 20);
            Console.WriteLine($"Área: {ret1.calcArea()} metros²");

            //Valores Inválidos
            Retangulo ret2 = new Retangulo();
            ret2.definirMedidas(-10, 20);
            Console.WriteLine($"Área: {ret2.calcArea()} metros²");
            
            Pessoa p1 = new Pessoa();   //Criamos o objeto p1 do tipo Pessoa.
            //Agora podemos manipular o objeto.
            //Dica: Ctrl + . para importar classe.
            p1.Nome = "João";
            p1.Idade = 34;
            p1.Apresentar();
            //Dica: Ctrl + ' para abrir o terminal.
        }
    }
}