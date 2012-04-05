namespace ConsoleApplication01.Entidades
{
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
                return "AU AU AU";
            }
            else
            {
                return "au";
            }
        }
    }
}