using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using POO_CSharp_Git;

namespace POO_C__Git
{
    internal class ApresentacaoForm: Form
    {
        //Criar um objeto label
        Label titulo1 = new Label();
        Label titulo2 = new Label();
        Automovel obj1 = new Automovel();

        // CONSTRUTOR
        public ApresentacaoForm()
        {
            this.Text = " Apresentação ";
            this.Size = new Size(500,500);
            //configuração do label titulo1
            titulo1.Text = "Bem vindo ao inferno";
            titulo1.Font = new Font("Arial", 20);
            titulo1.AutoSize = true; //ajustar no tamanho do texto
            titulo1.Location = new Point(250, 250);

            //adicionar a marca a objeto 
            obj1.Marca = "Ferrari";
            titulo2.Text = obj1.Marca;

            //fazer o elemento exibir no from
            //fazer um array de controls
            Control[] elementos = { titulo1, titulo2 };
            this.Controls.AddRange(elementos);

            //this.Controls.Add(titulo1);
        }
    }
}
