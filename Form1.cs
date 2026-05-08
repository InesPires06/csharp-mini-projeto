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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmH = new Sobre(); 
            frmH.Show();
        }

        private void conversorTemperaturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmH = new ConversorTemperaturas(); 
            frmH.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var frmH = new Dificuldade();
            frmH.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
