using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segunda_lista_de_exercicios_sobre_herança.Models
{
    class IngressoVIP : Ingresso
    {
        public override string ToString()
        {
            return valor.ToString();
        }

        public float valorAdicional { get; set; }

        public void imprimeIngressoVIP()
        {
            Console.WriteLine($"o valor do ingresso VIP é: {base.valor + valorAdicional}");
        }

    }
}
