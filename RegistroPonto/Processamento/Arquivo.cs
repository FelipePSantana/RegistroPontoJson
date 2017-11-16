using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using RegistroPonto.Mapeamento;

namespace RegistroPonto.Processamento
{
    public class Arquivo
    {
        private static readonly string CaminhoCompleto = Configuracao.DiretorioAtual + Configuracao.NomeArquivo;
        public static FileStream Criar()
        {
            return new FileStream(CaminhoCompleto, FileMode.Create);
        }

        public static bool Existe()
        {
            return File.Exists(CaminhoCompleto);
        }

        public static FileStream Recuperar()
        {
            FileStream arquivo = null;

            arquivo = !Existe() ? Criar() : new FileStream(CaminhoCompleto, FileMode.Append);

            return arquivo;
        }

        public static StreamWriter Gravar()
        {
           return new StreamWriter(Recuperar());
        }

        public static void GravarDados(Ponto ponto)
        {
            var stream = Gravar();

        }
    }
}
