using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication01
{
    class Program
    {
        static void Main(string[] args)
        {
            // SEM OBJETO
            string nome = "Godofredo";
            Console.WriteLine("sem criar classe = olá " + nome);


            // COM OBJETO
            // objeto é uma classe instanciada(new)
            Cachorro cachorroObjeto = new Cachorro();

            cachorroObjeto.SetNome("Godofredo");
            cachorroObjeto.Idade = 14;
            cachorroObjeto.Cor = "marrom";
            Console.WriteLine("com classe = olá " + nome);
            Console.WriteLine("O " + cachorroObjeto.GetNome() + " tem " + cachorroObjeto.Idade + " anos e tem a cor " + cachorroObjeto.Cor);

            cachorroObjeto.LatidoForte = false;
            Console.WriteLine("Cachorro lata:" + cachorroObjeto.Latir());
            
            cachorroObjeto.LatidoForte = true;
            Console.WriteLine("Cachorro lata:" + cachorroObjeto.Latir());

            Cachorro cachorro1 = new Cachorro();
            cachorro1.LatidoForte = true;
            
            Cachorro cachorro2 = new Cachorro();
            cachorro2.LatidoForte = false;

            cachorro1.CachorroAmigo = cachorro2;

            cachorro1.Latir();
            cachorro1.CachorroAmigo.Latir();

        }
    }


    public class Cachorro
    {
        // field
        private string _nome;
        // get
        public string GetNome()
        {
            return _nome;
        }
        // set
        public void SetNome(string valor)
        {
            _nome = valor;
        }

        // Notação clássica de propriedade
        private int _idade;
        public int Idade
        {
            get { return _idade; }
            set { _idade = value; }
        }

        // Terceira forma de declarar uma propriedade
        public string Cor { get; set; }

        // Terceira forma de declarar uma propriedade
        public bool LatidoForte { get; set; }

        public Cachorro CachorroAmigo { get; set; }

        
        // COMPORTAMENTO
        public string Latir()
        {
            if (LatidoForte)
            {
                return "AU AU";
            }
            else
            {
                return "Au Au";
            }
        }
    }
}
