using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segunda_lista_de_exercicios_sobre_herança.Models
{
    class Ingresso
    {
        public override string ToString()
        {
            return base.ToString();
        }

        public float valor { get; set; }

        public void imprimeIngresso()
        {
            Console.WriteLine($"o valor do ingresso é: {valor}");
        }

    }
}
