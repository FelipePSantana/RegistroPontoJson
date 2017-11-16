using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroPonto.Mapeamento
{
    public class Ponto
    {
        public string Data { get; set; }

        public List<Hora> Hora { get; set; }
    }
}
