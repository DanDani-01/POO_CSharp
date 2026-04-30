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
        Automovel carro02 = new Automovel();

        //Criar um objeto
        PictureBox img = new PictureBox();
        Label titulo1 = new Label();
        Label txtMarca = new Label();
        Label txtModelo = new Label();
        Label txtTipo = new Label();
        Label txtVelocidade = new Label();
        Label txtAno = new Label();
        Button btn1 = new Button();
        Button btn2 = new Button();
        
        // CONSTRUTOR
        public ApresentacaoForm()
        {
            this.Text = " Apresentação ";
            this.Size = new Size(500,500);

            //configuração do label titulo1
            titulo1.Text = "Ana Maradun";
            titulo1.Font = new Font("Arial", 20);
            titulo1.AutoSize = true; //ajustar no tamanho do texto
            titulo1.Location = new Point(50, 20);
            btn1.Text = "Botão legal";
            btn1.Location = new Point(50, 60);
            btn1.Click += Clicar; //evento de clique
            btn2.Text = "Camaro Amarelo (Bumblebee)";
            btn2.Location = new Point(140, 60);
            btn2.Click += Clicar2;



            //fazer apresentação do carr01
            //carro01.SetMarca("Ferrari");
            //this.titulo2.Text = "Marca " + carro01.GetMarca();
            //this.titulo2.Location = new Point(280, 280);




            //fazer o elemento exibir no from
            //fazer um array de controls
            Control[] elementos = { titulo1, txtAno, txtMarca, txtModelo, txtVelocidade, btn1, btn2, img };
            this.Controls.AddRange(elementos);

            //Forma única: this.Controls.Add(titulo1);
        }

        //metodo de evento
        private void Clicar(object sender, EventArgs e)
        {
            //MessageBox.Show("Clicou no botão");
            carro01.Marca = "Ferrari";
            carro01.Ano = 2010;
            carro01.Velocidade = "200Km/h";
            carro01.Modelo = "F40";
            
           
            txtMarca.Text = "Marca: " + carro01.Marca;
            txtMarca.Location = new Point(50, 100);
            txtModelo.Text = "Modelo: " + carro01.Modelo;
            txtModelo.Location = new Point(50, 130);   
            txtVelocidade.Text = "Velocidade: " + carro01.Velocidade;
            txtVelocidade.AutoSize = true;
            txtVelocidade.Location = new Point(50, 160);
            txtAno.Text = "Ano: " + carro01.Ano;
            txtAno.Location = new Point(50, 190);

            img.Image = Image.FromFile(@"C:\Users\LabInfo\Source\Repos\POO_CSharp\img\f40.jpg");
            img.SizeMode = PictureBoxSizeMode.StretchImage;
            img.Width = 200;
            img.Height = 150;
            this.img.Location = new Point(50, 220);
        }
        private void Clicar2(object sender, EventArgs e)
        {
           
            carro01.Marca = "Chevrollet";
            carro01.Ano = 2020;
            carro01.Velocidade = "250Km/h";
            carro01.Modelo = "Camaro Amarelo";


            txtMarca.Text = "Marca: " + carro01.Marca;
            txtMarca.Location = new Point(50, 100);
            txtModelo.Text = "Modelo: " + carro01.Modelo;
            txtModelo.Location = new Point(50, 130);
            txtModelo.AutoSize = true;
            txtVelocidade.Text = "Velocidade: " + carro01.Velocidade;
            txtVelocidade.AutoSize = true;
            txtVelocidade.Location = new Point(50, 160);
            txtAno.Text = "Ano: " + carro01.Ano;
            txtAno.Location = new Point(50, 190);

            img.Image = Image.FromFile(@"C:\Users\LabInfo\Source\Repos\POO_CSharp\img\Camaro.jpg");
            img.SizeMode = PictureBoxSizeMode.StretchImage;
            img.Width = 250;
            img.Height = 150;
            this.img.Location = new Point(50, 220);
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
