using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace list001
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // using System.Collections.Generic;

            // cria uma List genérica de inteiros
            List<string> valores = new List<string>();

            // insere valores na lista
            valores.Add("Luiz");
            valores.Add("Peixoto");
            valores.Add("Eça de Queiroz");
            valores.Add("Parabólica");

            // acessa os valores da lista e os exibe
            // usando um laço foreach
            foreach (string valor in valores)
            {
                Console.WriteLine(valor);
            }

            // pausa o programa
            Console.ReadKey();
        }
    }
}