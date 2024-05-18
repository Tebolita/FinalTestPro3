using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTestProgra3.Utility
{
    public class Nodo
    {
        public string Valor { get; set; }
        public Nodo Siguiente { get; set; }

        public Nodo(string valor)
        {
            Valor = valor;
            Siguiente = null;
        }
    }

}
