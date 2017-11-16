using NUnit.Framework;
using RegistroPonto.Processamento;

namespace RegistroPonto.Test.Processamento
{
    [TestFixture]
    public class ArquivoTest
    {
        [Test]
        public void DeveCriarUmNovoArquivo()
        {
            var teste = Arquivo.Existe();
            Assert.Pass("Your first passing test");
        }
    }
}
