using System;
using System.Collections.Generic;
using ConsoleApplication01.Entidades;

namespace ConsoleApplication01
{
    class Program
    {
        static void Main(string[] args)
        {
            Cachorro cachorro = null;
            List<Cachorro> cachorrosLista = new List<Cachorro>();

            bool fimPrograma = false;
            while (!fimPrograma)
            {
                Console.WriteLine("\r\nCriar cachorro.");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                try
                {
                    cachorro = new Cachorro(nome);
                    cachorrosLista.Add(cachorro);
                }
                catch (ArgumentException argumentException)
                {
                    Console.WriteLine("\r\nERRO DISPARADO PELO CACHORRO: \r\n" + argumentException.Message + "\r\n");
                }

                if (cachorro != null)
                {
                    foreach (var cachorroItem in cachorrosLista)
                    {
                        Console.WriteLine(" - " + cachorro.GetNome());
                    }
                }
                else
                {
                    Console.WriteLine("O cachorro não existe");
                }
            }
        }
    }
}
