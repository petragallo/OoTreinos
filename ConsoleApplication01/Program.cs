using System;
using ConsoleApplication01.Entidades;

namespace ConsoleApplication01
{
    class Program
    {
        static void Main(string[] args)
        {
            Cachorro cachorro = null;

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
                    Console.WriteLine("\r\nERRO DISPARADO PELO CACHORRO: \r\n" + argumentException.Message + "\r\n");
                }

                if (cachorro != null)
                {
                    Console.WriteLine("O nome do cachorro é " + cachorro.GetNome());
                }
                else
                {
                    Console.WriteLine("O cachorro não existe");
                }
            }
        }
    }
}
