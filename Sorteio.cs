using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Jogo
{
    public partial class Sorteio : Form
    {
        int[] vetor = new int[30];
        private int[] numerosSelecionados;

        public Sorteio()
        {
            InitializeComponent();
            numerosSelecionados = vetor;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnsortear_Click(object sender, EventArgs e)
        {
            Random randNum1 = new Random();
            for (int i = 1; i < 7; i++)
            {
                vetor[i] = randNum1.Next(1,61);
                txtSorteado.Text += vetor[i].ToString();
                txtSorteado.Text += ", ";
            }

            var intersecao = vetor.Intersect(numerosSelecionados);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.ForeColor = label1.ForeColor == Color.Transparent ? Color.SteelBlue : Color.Transparent;
        }

        private void Sorteio_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
