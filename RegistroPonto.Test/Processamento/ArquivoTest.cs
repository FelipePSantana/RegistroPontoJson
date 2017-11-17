using System.Collections.Generic;
using NUnit.Framework;
using RegistroPonto.Mapeamento;
using RegistroPonto.Processamento;

namespace RegistroPonto.Test.Processamento
{
    [TestFixture]
    public class ArquivoTest
    {
        [Test]
        public void DeveCriarUmNovoArquivo()
        {
            var ponto = new Ponto("17/11/2017");
            var teste = new Registrador();
            var lista = new List<Hora>
            {
                new Hora("08:00", "E", ponto),
                new Hora("12:00", "S", ponto),
                new Hora("13:30", "E", ponto),
                new Hora("18:00", "S", ponto)
            };

            ponto.Hora = lista;

            teste.Lancar(ponto);

            Assert.Pass("Your first passing test");
        }
    }
}
