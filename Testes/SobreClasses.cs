using ConsoleApplication01.Entidades;
using NUnit.Framework;

namespace KoansCSharpPtBr
{
    [TestFixture]
    public class SobreClasses
    {
        string __ = "COMPLETAR";

        [Test]
        public void _001_A_classe_inicializa_propriedade_no_construtor()
        {
            Cachorro cachorro = new Cachorro("Godofredo");
            Assert.AreEqual(__, cachorro.GetNome(), "Qual é o nome do cachorro?");
        }
    }
}

