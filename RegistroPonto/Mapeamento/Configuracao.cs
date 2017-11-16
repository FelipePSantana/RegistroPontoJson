using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RegistroPonto.Mapeamento
{
    public class Configuracao
    {
        public const string FormatData = @"dd\/MM\/yyyy";
        public const string FormatHora = @"HH:mm";
        public static readonly string DiretorioAtual = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase) + @"\ponto\";
        public const string NomeArquivo = @"ponto.json";
        
    }
}
