using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RegistroPonto.Mapeamento
{
    [DataContract]
    public class Hora
    {
        [DataMember]
        public string Valor { get; set; }
        [DataMember]
        public string Tipo { get; set; }

        [System.Runtime.Serialization.IgnoreDataMember]
        public Ponto Ponto { get; set; }

        public Hora(string valor, string tipo, Ponto ponto)
        {
            Valor = valor;
            Tipo = tipo;
            Ponto = ponto;
        }
    }
}
