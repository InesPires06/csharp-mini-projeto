using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.CompilerServices;
using WMPLib;

namespace ProjetoFinal_InêsPires
{
    public partial class nivelfacil : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        int movimentos, toques, cartasencontradas, tagimagens, h, m, s;
        
        Image [] imagem = new Image[6];

        List<string> listas = new List<string> ();

        int[] tags = new int[2];
        bool relogio = false;
        
        public nivelfacil()
        {
            InitializeComponent();
            Inicio();
        }

        private void Inicio()
        {
            foreach (PictureBox item in Controls.OfType<PictureBox>()) 
            { 
                int tagimagens = int.Parse(String.Format("{0}", item.Tag));
                imagem[tagimagens] = item.Image;
                item.Image = Properties.Resources.Care_Bears___Ursinhos_Carinhosos__1985; 
                item.Enabled = true;
            }
            Coordenadas();
        }
        private void Coordenadas()
        {
            foreach (PictureBox item in Controls.OfType<PictureBox>())
            {
                Random rdm = new Random();
                int[] posicaoX = { 65, 170, 275, 380, 485, 590 };
                int[] posicaoY = { 58, 209 };
            Refazer:
                var coordenadasX = posicaoX[rdm.Next(0, posicaoX.Length)];
                var coordenadasY = posicaoY[rdm.Next(0, posicaoY.Length)];



                string verificar = coordenadasX.ToString() + coordenadasY.ToString();

                if (listas.Contains(verificar))
                {
                    goto Refazer;
                }
                else
                {
                    item.Location = new Point(coordenadasX, coordenadasY);
                    listas.Add(verificar);
                }
            }

        }

        private void lblMinutos_Click(object sender, EventArgs e)
        {

        }

        private void lblSair_Click(object sender, EventArgs e)
        {
            player.URL = "somClique.mp3";

            DialogResult resposta;
            resposta = MessageBox.Show("Tem a certeza?", "Questão", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1,
            0);
            if (resposta == DialogResult.Yes)
            {
                Close();
            }
            else
            {

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int segundos;
            segundos = int.Parse(lblMinutos.Text);
            if(relogio = true)
            {
                lblMinutos.Text = (segundos+1).ToString();
            }
            
        }

        private void nivelfacil_Load(object sender, EventArgs e)
        {

        }

        private void Imagens_Clique(object sender, EventArgs e)
        {
           
            bool par = false;
            
         
            PictureBox foto = (PictureBox)sender;
            relogio = true;
           
            toques++;
            tagimagens = int.Parse(String.Format("{0}", foto.Tag));
            foto.Image = imagem[tagimagens];
            foto.Refresh();
            if (toques == 1) { tags[0] = int.Parse(String.Format("{0}", foto.Tag)); }
            if (toques == 2)
            {
                movimentos++;
                lblMovimentos.Text = "Movimentos: " + movimentos.ToString();
                tags[1] = int.Parse(String.Format("{0}", foto.Tag));
                par = ConfirmarPares();
                Virar(par);
            }
           
        }

        

        private void btnMudarNivel_Click(object sender, EventArgs e)
        {
            player.URL = "somClique.mp3"; 
            var frm = new Dificuldade();
            frm.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            player.URL = "somClique.mp3";
            DialogResult resposta;
            resposta = MessageBox.Show("Clica em duas cartas de cada vez. " +
                "Se forem um par, iram ficar voltadas para cima." +
                " Se forem diferentes, voltam a ficar viradas para baixo, procure encontrar o seu par na próxima jogada." +
                " O objetivo é encontrar todos os pares no menor tempo possível e com um menor números de movimentos.",
                "Como Jogar?", MessageBoxButtons.OK,
            MessageBoxIcon.None);
        }

        private bool ConfirmarPares()
        {
            toques = 0;
            if (tags[0] == tags[1]) { return true; }
            else { return false; }
        }

        private void Virar(bool confirmar)
        {
            Thread.Sleep(500);
            foreach (PictureBox item in Controls.OfType<PictureBox>())
            {
                if (int.Parse(String.Format("{0}", item.Tag)) == tags[0] ||
                    int.Parse(String.Format("{0}", item.Tag)) == tags[1])
                {
                    if (confirmar == true) 
                    {
                        player.URL = "somCerto.mp3";
                        item.Enabled = false;
                        cartasencontradas++;
                    } else 
                    {
                        player.URL = "somErro.mp3";
                        item.Image = Properties.Resources.Care_Bears___Ursinhos_Carinhosos__1985;
                        item.Refresh();
                    }

                }
            }

            Final();

        }
        private void Final()
        {
           
            if(cartasencontradas == (imagem.Length*2)) 
            {
                timer1.Stop();
           

                player.controls.play();
                player.URL = "somVitoria.mp3";

                MessageBox.Show("Parabéns!! Terminou o jogo com " + movimentos.ToString() + " movimentos em apenas "
                    + lblMinutos.Text.ToString()+ " segundos");
                
                DialogResult mensagemfinal=
                MessageBox.Show("Deseja continuar o jogo?", "Pergunta", MessageBoxButtons.YesNo);
                if (mensagemfinal == DialogResult.Yes)
                {
                    DialogResult mensagemf =
                    MessageBox.Show("Deseja mudar de nível?", "Pergunta", MessageBoxButtons.YesNo);
                    if (mensagemf == DialogResult.No) 
                    {
                        toques = 0;
                        movimentos = 0;
                        cartasencontradas = 0;
                        listas.Clear();
                        Inicio();
                        lblMovimentos.Text = "Movimentos: ";
                        lblMinutos.Text = "0";
                        timer1.Start();
                    }
                    else if (mensagemf == DialogResult.Yes)
                    {
                        var frmV = new Dificuldade();
                        frmV.Show();
                        Close();
                    }
                    
                }
                else if (mensagemfinal== DialogResult.No)
                {
                    MessageBox.Show("Obrigada por jogar!");
                    Close();
                }

            }
        }



    }
}
