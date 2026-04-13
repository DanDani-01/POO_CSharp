using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_CSharp_Git
{
    internal class Automovel
    {
        //visibilidade: private, public, protected, internal
            //public = pode ser acessado por qualquer classe
            //private = só pode ser acessado pela própria classe
            //protected = só acessada pela própria classe e pela classe derivada
            //internal = só pode ser acessada pelo mesmo assembly

        // Criar umn construtor

        public string Marca { get; set; }
        public Automovel() { 
            
        }
    }
}
