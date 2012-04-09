using System;
using System.Collections.Generic;
using ConsoleApplication01.Entidades;

namespace ConsoleApplication01
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaração da única lista utilizada
            List<Cachorro> cachorrosLista = new List<Cachorro>();

            while (true)
            {
                Console.WriteLine("\r\nDigite o comando. (digite ajuda para mais informações)");
                Console.Write("> ");

                // recebe iput do usuário
                string comando = Console.ReadLine();

                if (comando == "exit")
                {
                    return;
                }
                else if (comando == "limpar")
                {
                    cachorrosLista.Clear();
                    ImprimirLista(cachorrosLista);
                }
                else if (comando == "incluir")
                {
                    {
                        Console.Write("\r\nNome do cachorro: ");
                        string nome = Console.ReadLine();
                        IncluirCachorro(nome, cachorrosLista);
                        ImprimirLista(cachorrosLista);
                    }
                }
                else if (comando == "ajuda")
                {
                    Console.WriteLine("\r\n Comandos disponíveis:");
                    Console.WriteLine(" - ajuda");
                    Console.WriteLine(" - incluir");
                    Console.WriteLine(" - limpar");
                    Console.WriteLine(" - exit");
                }
            }
        }

        /// <summary>
        /// Imprime a lista de cachorros.
        /// </summary>
        /// <param name="cachorrosLista">lista atual de cachorros</param>
        private static void ImprimirLista(List<Cachorro> cachorrosLista)
        {
            if (cachorrosLista.Count == 0)
            {
                Console.WriteLine("Não existem cachorros na lista");
            }

            foreach (var cachorroItem in cachorrosLista)
            {
                Console.WriteLine(" - " + cachorroItem.GetNome());
            }
        }

        private static void IncluirCachorro(string nomeCachorro, List<Cachorro> cachorrosLista)
        {
            try
            {
                // novo cachorro
                var cachorro = new Cachorro(nomeCachorro);

                // inclui na lista já existente
                // que recebeu por referencia.
                cachorrosLista.Add(cachorro);
            }
            catch (ArgumentException argumentException)
            {
                Console.WriteLine("\r\nERRO DISPARADO PELO CACHORRO: \r\n" + argumentException.Message + "\r\n");
            }
        }
    }
}
