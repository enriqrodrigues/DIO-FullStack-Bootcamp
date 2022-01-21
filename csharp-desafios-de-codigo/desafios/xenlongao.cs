using System;
using System.Collections.Generic;
using System.Text;

namespace desafios
{
    class Xenlongao
    {
        static void Main(string[] args)
        {
            //Código fornecido
            // int N = Convert.ToInt32(Console.ReadLine());
            // while(N-- > 0)
            // {
            //     int val =                                ;
            //     int newval =                         ;        //complete com a sua lógica
            //     int resposta =                      ;
            //     Console.WriteLine(resposta);
            // }

            //RESPOSTA
            int N = Convert.ToInt32(Console.ReadLine());
            while(N-- > 0)
            {
                int val = Convert.ToInt32(Console.ReadLine());
                int newval = val;        
                int resposta = 1;

                //Testa as esferas de 1 a val
                while(newval-- > 2)
                {
                    //Testa o número de divisores de cada esfera.
                    int numDivisores = 0;
                    
                    for(int i = newval; i > 0; i--)
                    {
                        if (newval % i == 0)
                        {
                            numDivisores++;
                        }
                    }

                    if(numDivisores % 2 == 0)
                    {
                        resposta++;
                    }
                }

                Console.WriteLine(resposta);
            }
            
        }
    }
}