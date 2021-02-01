using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segunda_lista_de_exercicios_sobre_herança.Models2
{
    class Gerente : Empregado
    {
        public override string ToString()
        {
            return base.ToString() + "\n" + departamento;
        }

        public string departamento { get; set; }

        public Gerente() { }

        public Gerente(string _departamento)
        {
            departamento = _departamento;
        }

    }
}
