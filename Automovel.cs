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



        //criar uma propriedade para a marca do automóvel
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Velocidade { get; set; }
        public int Ano { get; set; }
        public string Imagen { get; set; }



        // Criar um construtor para a classe Automovel
        public Automovel() { 
            
        }

        public Automovel(string marca)
        {
            this.Marca = marca;
        }
    }
}

//    private string Marca;

////public void SetMarca(string marca)
////{
////    this.Marca = marca;
////}

////public string GetMarca()
////{
////    return this.Marca;
////}