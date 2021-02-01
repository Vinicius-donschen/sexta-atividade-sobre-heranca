using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segunda_lista_de_exercicios_sobre_herança.Models2
{
    class Empregado
    {
        public override string ToString()
        {
            return nome + "\n" + salario + "\n";
        }

        public string nome { get; set; }
        public double salario { get; set; }
    }
}
