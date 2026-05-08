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
    public partial class Form2 : Form
    {
        Image[] imagem = new Image[21];

        WindowsMediaPlayer player = new WindowsMediaPlayer();

        int movimentos, toques, cartasencontradas, tagimagem;

       List<string> listas = new List<string>();

        bool relogio = false;

        int[] tags = new int[2];

        public Form2()
        {
            InitializeComponent();
            Inicio();
        }

        private void Inicio()
        {
            int conta;
            conta = 0;
            foreach ( PictureBox item in Controls.OfType<PictureBox>() )
            {
                //tagimagem = int.Parse(String.Format("{0}", item.Tag));
               if (conta<22)
                { 
                tagimagem = conta;
                conta++;
                imagem[tagimagem] = item.Image;
                item.Image = Properties.Resources.HD_wallpaper_marvel_comics_avenger_avengers_logo_marvel_comics_of;
                item.Enabled = true;
                }
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
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

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new Dificuldade();
            frm.Show();
            Close();
        }

        private void btnRegras_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            resposta = MessageBox.Show("Clica em duas cartas de cada vez. " +
                "Se forem um par, iram ficar voltadas para cima." +
                " Se forem diferentes, voltam a ficar viradas para baixo, procure encontrar o seu par na próxima jogada." +
                " O objetivo é encontrar todos os pares no menor tempo possível e com um menor números de movimentos.",
                "Como Jogar?", MessageBoxButtons.OK,
            MessageBoxIcon.None);
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

       
    }
}
