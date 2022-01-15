using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTeste
{
    //Criamos a interface
    interface IAnimal
    {
    void Nome(string nome);
    void Especie(string especie);
    }
    
    //Criamos uma classe que referencia a interface
    class Animal : IAnimal
    {
        public string Nome { get; set; }
        public string Especie { get; set; }

        void IAnimal.Nome(string nome)
        {
            this.Nome = nome;
        }
        void IAnimal.Especie(string especie)
        {
            this.Nome = especie;
        }
    }
}


