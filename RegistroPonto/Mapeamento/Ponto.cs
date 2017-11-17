using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RegistroPonto.Mapeamento
{
    [DataContract]
    public class Ponto
    {
        [DataMember]
        public string Data { get; set; }
        [DataMember]
        public IEnumerable<Hora> Hora { get; set; }

        public Ponto(string data, List<Hora> hora)
        {
            Data = data;
            Hora = hora;
        }

        public Ponto(string data)
        {
            Data = data;
        }

    }
}