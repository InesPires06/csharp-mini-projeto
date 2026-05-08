using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace ProjetoFinal_InêsPires
{
    public partial class Dificuldade : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        public Dificuldade()
        {
            InitializeComponent();

        }
         
        private void fmr2_Load(object sender, EventArgs e)
        {

        }

        private void btnfacil_Click(object sender, EventArgs e)
        {
            player.URL = "somClique.mp3";
            var frmH = new nivelfacil();
            frmH.Show();
            Close();
           

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

        private void btnmédio_Click(object sender, EventArgs e)
        {
            player.URL = "somClique.mp3";
            var frm = new nivelmedio();
            frm.Show();
           // Close();
        }

        private void btndificil_Click(object sender, EventArgs e)
        {
            player.URL = "somClique.mp3"; 
            var frmH = new Form2();
            frmH.Show();
            Close();
        }
    }
}
