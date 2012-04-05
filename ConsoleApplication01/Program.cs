using System;
using ConsoleApplication01.Entidades;

namespace ConsoleApplication01
{
    class Program
    {
        static void Main(string[] args)
        {
            // SEM OBJETO
            string nome = "Godofredo";
            Console.WriteLine("sem criar classe = olá " + nome);

            var cachorroObjeto = CriarCachorroObjeto("Godofredo", 14, "marrom");

            Console.WriteLine("O " + cachorroObjeto.GetNome() + " tem " + cachorroObjeto.Idade + " anos e tem a cor "
                                   + cachorroObjeto.Cor);

            cachorroObjeto.LatidoForte = false;
            Console.WriteLine("cachorroObjeto.LatidoForte = " + cachorroObjeto.LatidoForte);
            Console.WriteLine("Cachorro lata:" + cachorroObjeto.Latir());

            cachorroObjeto.LatidoForte = true;
            Console.WriteLine("cachorroObjeto.LatidoForte = " + cachorroObjeto.LatidoForte);
            Console.WriteLine("Cachorro lata:" + cachorroObjeto.Latir());

            OutrosCachorros();
        }

        /// <summary>
        /// Fabrica do cachorro
        /// </summary>
        private static Cachorro CriarCachorroObjeto(string nome, int idade, string cor)
        {
            // COM OBJETO
            // objeto é uma classe instanciada(new)
            Cachorro cachorroObjeto = new Cachorro();

            //Validação
            if (nome.Length != 0)
            {
                cachorroObjeto.SetNome(nome);
            }
            else
            {
                throw new ArgumentException("o nome é obrigatório", "nome");
            }

            cachorroObjeto.Idade = idade;
            cachorroObjeto.Cor = cor;
            return cachorroObjeto;
        }

        private static void OutrosCachorros()
        {
            // Criando mais dois objetos
            Cachorro cachorro1 = new Cachorro();
            cachorro1.LatidoForte = true;

            Cachorro cachorro2 = new Cachorro();
            cachorro2.LatidoForte = false;

            cachorro1.CachorroAmigo = cachorro2;

            cachorro1.Latir();
            cachorro1.CachorroAmigo.Latir();
        }
    }
}
