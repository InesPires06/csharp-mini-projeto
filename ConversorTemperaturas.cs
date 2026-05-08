using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinal_InêsPires
{
    public partial class ConversorTemperaturas : Form
    {
        double temp;
        public ConversorTemperaturas()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
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

        private void rbtnKelvin_CheckedChanged(object sender, EventArgs e)
        {

            //lblGraus.Text = (double.Parse(txtGraus.Text) + 273.15 + "K" ).ToString();
            //lblGraus.Hide();
            if (int.TryParse(txtGraus.Text, out var n) != false)
            {
                btnConverter.Enabled = true;
                temp = (double.Parse(txtGraus.Text) +273);

            }
            else
            {
                rbtnFahrenheit.Checked = rbtnKelvin.Checked = false;
                MessageBox.Show("Deve inserir valores numéricos na caixa de texto!", "Valor numéricos");
            }
        }

        private void rbtnFahrenheit_CheckedChanged(object sender, EventArgs e)
        {
            //lblGraus.Text = (double.Parse(txtGraus.Text) * (1.8) + 32 + "ºF" ).ToString();
            //lblGraus.Hide() ;

            if(int.TryParse(txtGraus.Text, out var n) != false)
            {
                btnConverter.Enabled = true;
                temp = ((double.Parse(txtGraus.Text)*1.8)+32);
                
            }
            else
            {
                rbtnFahrenheit.Checked = rbtnKelvin.Checked = false;
                MessageBox.Show("Deve inserir valores numéricos na caixa de texto!", "Valor numéricos");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblGraus.Text = txtGraus.Text = string.Empty;
            picTemp.Image = Properties.Resources.globofrio;
            rbtnFahrenheit.Checked = rbtnKelvin.Checked = false;
         
        }

        private void lblHoras_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHoras.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void picTemp_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblGraus.Show();
            double n;
            n = (double.Parse(txtGraus.Text));
            if (n < 1)
            { 
                picTemp.Image = Properties.Resources.frio;
                DialogResult resposta;
                resposta = MessageBox.Show("Está demasiado frio, fique em casa!!", "PERIGO",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Warning, 
                 MessageBoxDefaultButton.Button1,
                 0) ;
            }
            if (n >= 1 && n <= 15)
            {
                picTemp.Image = Properties.Resources.frio2;
                DialogResult resposta;
                resposta = MessageBox.Show("Está frio, agasalhe-se antes de sair!", "Atenção",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information,
                 MessageBoxDefaultButton.Button1,
                 0);
            }
            if (n >= 16 && n <24)
            {
                picTemp.Image = Properties.Resources.termometro;
                DialogResult resposta;
                resposta = MessageBox.Show("Está um bom dia para sair de casa. Aproveite!!", " ",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information,
                 MessageBoxDefaultButton.Button1,
                 0);
            }
            if (n >= 24 && n <= 29)
            {
                picTemp.Image = Properties.Resources.termometro2;
                DialogResult resposta;
                resposta = MessageBox.Show("Está um bom dia para um belo passeio pela praia. Divirta-se!!", " ",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information,
                 MessageBoxDefaultButton.Button1,
                 0);
            }
            if (n > 29 )
            {
                picTemp.Image = Properties.Resources.termometroquente;
                DialogResult resposta;
                resposta = MessageBox.Show("Está muito calor para sair de casa!!!", " ",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Warning,
                 MessageBoxDefaultButton.Button1,
                 0);
            }
        }

        private void ConversorTemperaturas_Load(object sender, EventArgs e)
        {
            lblHoras.Visible = true;
            timer1.Start();

        }

        private void txtGraus_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
