using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using POO_CSharp_Git;
using System.Drawing.Text;
using System.Net.Http.Headers;

namespace POO_C__Git
{
    //Toda classe tem um construtor, mesmo que não seja declarado
    internal class ApresentacaoForm: Form
    {
        //criar um objeto do automóvel
        Automovel carro01 = new Automovel();
        Automovel modelo01 = new Automovel();
        Automovel tipo = new Automovel();
        Automovel velocidade = new Automovel();
        Automovel ano = new Automovel();

        //Criar um objeto
        PictureBox img = new PictureBox();
        Label titulo1 = new Label();
        Label txtMarca = new Label();
        Label txtModelo = new Label();
        Label txtTipo = new Label();
        Label txtVelocidade = new Label();
        Label txtAno = new Label();
        Button btn1 = new Button();
        
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



            //fazer apresentação do carr01
            //carro01.SetMarca("Ferrari");
            //this.titulo2.Text = "Marca " + carro01.GetMarca();
            //this.titulo2.Location = new Point(280, 280);

            img.Image = Image.FromFile(@"C:\\Users\\LabInfo\\Source\\Repos\\POO_CSharp\\img\\f40.jpg");
            img.SizeMode = PictureBoxSizeMode.AutoSize;
            img.Width = 50;
            img.Height = 10;
            this.img.Location = new Point(280, 400);


            //fazer o elemento exibir no from
            //fazer um array de controls
            Control[] elementos = { titulo1, txtAno, txtMarca, txtModelo, txtVelocidade, btn1, img };
            this.Controls.AddRange(elementos);

            //Forma única: this.Controls.Add(titulo1);
        }

        //metodo de evento
        private void Clicar(object sender, EventArgs e)
        {
            MessageBox.Show("Clicou no botão");
            carro01.Marca = "Ferrari";
            carro01.Ano = 2010;
            carro01.Modelo = "F40";
            carro01.Velocidade = "300km/h";
           
            txtMarca.Text = "Marca: " + carro01.Marca;
            txtMarca.Location = new Point(280, 280);
            txtModelo.Text = "Modelo: " + carro01.Modelo;
            txtModelo.Location = new Point(280, 310);   
            txtVelocidade.Text = "Velocidade: " + carro01.Velocidade;
            txtVelocidade.Location = new Point(280, 340);
            txtAno.Text = "Ano: " + carro01.Ano;
            txtAno.Location = new Point(280, 370);  

            
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
