using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_CSharp_Git
{
    internal class Carro: Automovel
    {
        public Carro(string marca, string tipo)
        {
            Marca = marca;
            Modelo = tipo;
        }

        //mesmo metodo da classe pai, mas com comportamento diferente
        public override string Frear()
        {
            return "Freando o carro com SLA";
        }
    }
}
