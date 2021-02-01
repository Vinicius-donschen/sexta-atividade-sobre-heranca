using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Segunda_lista_de_exercicios_sobre_herança.Models;
using Segunda_lista_de_exercicios_sobre_herança.Models2;

namespace Segunda_lista_de_exercicios_sobre_herança
{
    class Program
    {
        static void Main(string[] args)
        {
            Ingresso padrao = new Ingresso();
            padrao.valor = 10;
            padrao.imprimeIngresso();

            IngressoVIP vip = new IngressoVIP();
            vip.valorAdicional = 5;
            vip.valor = 10;
            vip.imprimeIngressoVIP();
        }
    }
}
