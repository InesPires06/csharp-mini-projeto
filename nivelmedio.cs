using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace ProjetoFinal_InêsPires
{
    public partial class nivelmedio : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
    
        int movimentos, toques, cartasencontradas, tagimagens;

        Image[] imagem = new Image[12];

        List<string> lista = new List<string>();

        int[] tags = new int[2];
        bool relogio = false;


        public nivelmedio()
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
                item.Image = Properties.Resources.images__4_;
                item.Enabled = true;
            }
            Coordenadas();
        }
        private void Coordenadas()
        {
           foreach(PictureBox item in Controls.OfType<PictureBox>())
           {
                Random rdm = new Random();
                int[] posicaoX = { 69, 163, 257, 351, 446, 633 };
                int[] posicaoY = { 46, 154, 262 };
                Refazer:
                var coordenadasX = posicaoX[rdm.Next(posicaoX.Length)];
                var coordenadasY = posicaoY[rdm.Next(posicaoY.Length)];


                string verificar = coordenadasX.ToString() + coordenadasY.ToString();

                if (lista.Contains(verificar))
                {
                    goto Refazer;
                }
                else
                {
                    item.Location = new Point(coordenadasX, coordenadasY);
                    lista.Add(verificar);
                }

           }
        }
        private bool ConfirmarPares()
        {
            toques = 0;
            if (tags[0] == tags[1]) { return true; }
            else { return false; }
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
                    }
                    else
                    {
                        player.URL = "somErro.mp3";
                        item.Image = Properties.Resources.images__4_;
                        item.Refresh();
                    }

                }
            }

            Final();

        }
        private void Final()
        {

            if (cartasencontradas == (imagem.Length * 2))
            {
                timer1.Stop();


                player.controls.play();
                player.URL = "somVitoria.mp3";

                MessageBox.Show("Parabéns!! Terminou o jogo com " + movimentos.ToString() + " movimentos em apenas "
                    + lblHoras.Text.ToString() + " segundos");

                DialogResult mensagemfinal =
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
                        lista.Clear();
                        Inicio();
                        lblMovimentos.Text = "Movimentos: ";
                        lblHoras.Text = "0";
                        timer1.Start();
                    }
                    else if (mensagemf == DialogResult.Yes)
                    {
                        var frmV = new Dificuldade();
                        frmV.Show();
                        Close();
                    }

                }
                else if (mensagemfinal == DialogResult.No)
                {
                    MessageBox.Show("Obrigada por jogar!");
                    Close();
                }

            }
        }
        private void lblHoras_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int segundos;
            segundos = int.Parse(lblHoras.Text);
            if (relogio = true)
            {
                lblHoras.Text = (segundos + 1).ToString();
            }
        }
      
     
      


        private void btnSair_Click(object sender, EventArgs e)
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

        private void btnMudar_Click(object sender, EventArgs e)
        {
            player.URL = "somClique.mp3";
            var frm = new Dificuldade();
            frm.Show();
            Close();
        }

        private void btnRegras_Click(object sender, EventArgs e)
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
    }
}
