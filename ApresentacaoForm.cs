using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using POO_CSharp_Git;
using System.Drawing.Text;

namespace POO_C__Git
{
    //Toda classe tem um construtor, mesmo que não seja declarado
    internal class ApresentacaoForm: Form
    {
        //Criar um objeto
        Label titulo1 = new Label();
        Label titulo2 = new Label();
        Button btn1 = new Button();
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
            btn1.Text = "Botão legal";
            btn1.Location = new Point(50, 50);
            btn1.Click += Clicar; //evento de clique

            //adicionar a marca a objeto 
            obj1.Marca = "Ferrari";
            titulo2.Text = obj1.Marca;

            //fazer o elemento exibir no from
                //fazer um array de controls
            Control[] elementos = { titulo1, titulo2, btn1 };
            this.Controls.AddRange(elementos);

            //Forma única: this.Controls.Add(titulo1);
        }

        //metodo de evento
        private void Clicar(object sender, EventArgs e)
        {
            MessageBox.Show("Clicou no botão");
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ApresentacaoForm
            // 
            this.ClientSize = new System.Drawing.Size(278, 244);
            this.Name = "ApresentacaoForm";
            this.Load += new System.EventHandler(this.ApresentacaoForm_Load);
            this.ResumeLayout(false);

        }

        private void ApresentacaoForm_Load(object sender, EventArgs e)
        {

        }
    }
}
