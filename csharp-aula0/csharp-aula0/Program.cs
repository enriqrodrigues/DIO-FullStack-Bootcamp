//Usando (Importando) classes nativas do C#/.Net.
using System;
using System.Collections.Generic;
using System.Text;
using ClasseTeste;
using InterfaceTeste;
using EnumTeste;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var pessoa0 = (EnumPessoas)0; //var pessoa0 será igual ao valor 
                                          //de índice 0 do enum Pessoas.
            EnumPessoas pessoa1 = EnumPessoas.Dany; //variável pessoa 1 recebe o valor
                                                    //Dany a partir do EnumPessoas.
            EnumPessoas pessoa2 = (EnumPessoas)3; //var pessoa2 será igual ao valor 
                                                  //de índice 3 do enum Pessoas.

            Usuario user1 = new Usuario();
            user1.Nome = "João";
            user1.Idade = 34;
            user1.Estado = "PE";

            Usuario user2 = new Usuario();
            user1.Nome = "Fulano";
            user1.Idade = 54;
            user1.Estado = "CE";

            Animal animal1 = new Animal();
            animal1.Nome = "Enzo";
            animal1.Especie = "Felino";
        }
    }
}