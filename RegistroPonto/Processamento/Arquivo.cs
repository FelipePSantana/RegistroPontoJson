using System.IO;
using System.Runtime.Serialization.Json;
using RegistroPonto.Mapeamento;

namespace RegistroPonto.Processamento
{
    public class Arquivo
    {
        private static readonly string CaminhoCompleto = Configuracao.DiretorioAtual ;
        public static FileStream Criar()
        {
            //TO-DO - arrumar caminho

            Directory.CreateDirectory(@"C:\Users\felipe.santana\Documents\Visual Studio 2015\Projects\RegistroPontoJson\RegistroPonto.Test\bin\Debug\ponto\");

            return new FileStream(@"C:\Users\felipe.santana\Documents\Visual Studio 2015\Projects\RegistroPontoJson\RegistroPonto.Test\bin\Debug\ponto\" + Configuracao.NomeArquivo, FileMode.Create);
        }

        public static bool Existe()
        {
            return File.Exists(CaminhoCompleto);
        }

        public static FileStream Recuperar()
        {
            var arquivo = !Existe() ? Criar() : new FileStream(CaminhoCompleto, FileMode.Append);

            return arquivo;
        }

        public static StreamWriter Gravar()
        {
            var arquivo = new StreamWriter(Recuperar());
            return arquivo;
        }
    }
}
