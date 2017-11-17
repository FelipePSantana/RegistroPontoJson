using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RegistroPonto.Mapeamento;

namespace RegistroPonto.Processamento
{
    public class Registrador
    {
        public void Lancar(Ponto ponto)
        {
            GravarDados(ponto);
        }

        public void GravarDados(Ponto ponto)
        {
            var stream = Arquivo.Gravar();

            

            var stream1 = new MemoryStream();
            var ser = new DataContractJsonSerializer(typeof(Ponto));

            ser.WriteObject(stream1, ponto);

            stream1.Position = 0;
            var sr = new StreamReader(stream1);

            stream.WriteLine(sr.ReadToEnd());

            stream.AutoFlush = true;
            stream.Close();

            var dados = PegarDadosArquivo();
        }

        public List<Ponto> PegarDadosArquivo()
        {
            //TO-DO - não esta pegando dados do arquivo
            using (var stream = new System.IO.FileStream(@"C:\Users\felipe.santana\Documents\Visual Studio 2015\Projects\RegistroPontoJson\RegistroPonto.Test\bin\Debug\ponto\" +
                Configuracao.NomeArquivo, System.IO.FileMode.Open))
            {
                var serializer = new System.Runtime.Serialization.Json.DataContractJsonSerializer(typeof(List<Ponto>));
                return (List<Ponto>)serializer.ReadObject(stream);
            }
        } 

    }
}
