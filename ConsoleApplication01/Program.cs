using System;
using ConsoleApplication01.Entidades;

namespace ConsoleApplication01
{
    class Program
    {
        static void Main(string[] args)
        {
            Cachorro cachorro = new Cachorro("Sem Nome");

            bool fimPrograma = false;
            while (!fimPrograma)
            {
                Console.WriteLine("\r\nCriar cachorro.");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                try
                {
                    cachorro = new Cachorro(nome);
                }
                catch (ArgumentException argumentException)
                {
                    Console.WriteLine("ERRO: " + argumentException.Message);
                }

                Console.WriteLine("O nome do cachorro é " + cachorro.GetNome());
            }
        }
    }
}
