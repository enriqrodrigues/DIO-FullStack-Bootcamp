using System;
using System.Collections.Generic;
using collections.Helper;

namespace Collections {
    class Program {
        static void Main(string[] args) {
            //Array Unidimensional
            int [] arrayInteiros = new int[3];
            arrayInteiros[0] = 23;
            arrayInteiros[1] = 32;
            arrayInteiros[2] = 50;

            System.Console.WriteLine("Iterando com o for");
            for (int i = 0; i < arrayInteiros.Length; i++) {
                System.Console.WriteLine(arrayInteiros[i]);
            }            

            System.Console.WriteLine("Iterando com o foreach");
            foreach (int item in arrayInteiros) {
                System.Console.WriteLine(item);
            }

            //Array multidimensional
            int[,] matriz = new int [4, 2] {    //4 linhas e 2 colunas
                { 0, 0 }, 
                { 0, 1 }, 
                { 1, 0 }, 
                { 1, 1 }
            };
            matriz[0,0] = 5;

            System.Console.WriteLine("Multidimensional: Iterando com for.");
            for (int i = 0; i < matriz.GetLength(0); i++)   //GetLength = 0 para usar o número de linhas.
            {
                for (int j = 0; j < matriz.GetLength(1); j++)   //GetLength = 1 para usar o número de colunas.
                {
                    System.Console.WriteLine(matriz[i, j]);
                }
            }

            //Ordenando com BubbleSort
            OperacoesArray op = new OperacoesArray();
            int[] array = new int[5] {6, 3, 7, 1, 2};

            System.Console.WriteLine("Array original");
            op.ImprimirArray(array);

            System.Console.WriteLine("Array ordenado");
            //op.OrdenarBubbleSort(ref array);
            op.Ordenar(ref array);
            op.ImprimirArray(array);

            //Copiando um array
            int[] arrayCopia = new int[10];

            op.Copiar(ref array, ref arrayCopia);
            System.Console.WriteLine("Array copiado");
            op.ImprimirArray(arrayCopia); 

            bool existe = op.Existe(array, 7); 

            bool maiorQue = op.VerifcaTodos(array, 1);

            //LISTAS
            List<string> estados = new List<string>();
            
            //Addicionando elementos
            estados.Add("PE");
            estados.Add("PB");
            estados.Add("AL");
            
            //Acessando elemetos
            foreach (var item in estados) {
                System.Console.WriteLine(item);
            }
            //Outra forma
            for (int i = 0; i < estados.Count; i++) {
                    System.Console.WriteLine($"{i} - {estados[i]}");
            }

            //Número de elementos
            System.Console.WriteLine($"Número de elementos: {estados.Count}");

            //Remover elemento
            estados.Remove("PB");

            //Adicionar um lista dentro da outra
            List<string> estadosSul = new List<string>();
            estadosSul.Add("RS");
            estadosSul.Add("SC");
            estadosSul.Add("PR");
            estados.AddRange(estadosSul);

            //Adicionar elemento por índice
            estados.Insert(2, "CE");
            //não substitui o elemento existente no índice 

            //FILAS
            Queue<string> fila = new Queue<string>();
            fila.Enqueue("Brasil"); //Coloca elemento na lista
            fila.Enqueue("Chile");
            fila.Enqueue("Peru");

            string saidaFila = fila.Dequeue(); //Retorna e remove o primeiro elemento 
            string ProxSaidaFila = fila.Peek(); //Retorna (sem remover) o primeiro elemento 
            int tamanhoFila = fila.Count;

            //PILHA
            Stack<string> pilha = new Stack<string>();
            pilha.Push("Recife");       //Coloca o elemento na pilha
            pilha.Push("Aracaju");
            pilha.Push("Maceio");
            pilha.Push("Joao Pessoa");

            int tamanhoPilha = pilha.Count();
            string saidaPilha = pilha.Pop(); //Retorna e remove o primeiro elemento 
            string ProxSaidaPilha = pilha.Peek(); //Retorna (sem remover) o primeiro elemento 

            //DICTIONARY    
            Dictionary<string, string> capitais = new Dictionary<string, string>();
            capitais.Add("PE", "Recife");
            capitais.Add("PB", "João Pessoa");
            capitais.Add("CE", "Fortaleza");
            capitais.Add("AL", "Maceió");
            capitais.Add("AL", "Teste");
            //Chaves não pode ser reprtidas
            foreach (var item in capitais)
            {
                System.Console.WriteLine($"{item.Key} - {item.Value}");
            }

            string valor = capitais["PB"];  //Retornar valor buscando pela chave
            capitais["PE"] = "Olinda";      //Definindo valor pela chave

            capitais.Remove("PE"); //Remove o valor pela chave

            //Método buscar um valor pela chave e retorna um booleano e o valor, se encontrar.
            string chaveTeste = "PA";
            if (capitais.TryGetValue(chaveTeste, out string valorEncontrado)) {
                System.Console.WriteLine($"Valor encontrado: {valorEncontrado}.");
            } else {
                System.Console.WriteLine($"Chave {chaveTeste} não existe.");
            }

            //LINQ
            int[] arrayTeste = new int[10] {12, 13, 14, 31, 52, 42, 56, 15, 78, 11};

            var numerosParesQuery = 
                from num in arrayTeste
                where num % 2 == 0
                orderby num
                select num;

            var numerosParesMethod = arrayTeste.Where(x => x % 2 == 0).OrderBy(x => x).ToList();

            System.Console.WriteLine("Números pares (Query): " 
                + string.Join(", ", numerosParesQuery));
            System.Console.WriteLine("Números pares (Method): " 
                + string.Join(", ", numerosParesMethod));
            
            var minimo = arrayTeste.Min();
            var maximo = arrayTeste.Max();
            var medio = arrayTeste.Average();

            var somaTudo = arrayTeste.Sum();

            //Retorna os elementos distintos, exclui as repetições
            var unicos = arrayTeste.Distinct(); 
        }       
    }
}