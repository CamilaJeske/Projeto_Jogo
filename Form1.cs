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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int contagemClick = 0;
        string[] numerosSelecionados = new string[6];
        
        private void numero_clicado(object sender, EventArgs e)
        {
            Label clicklbl = sender as Label;

            if (clicklbl != null)
            {
                if (contagemClick <= 6)
                {
                    contagemClick++;
                    if (contagemClick <= 6)
                    {
                        clicklbl.BackColor = Color.White;
                        numerosSelecionados[contagemClick - 1] = clicklbl.Text;
                        //int teste = numerosSelecionados;
                        txtEsc.Text += numerosSelecionados[contagemClick - 1] + "  ";
                    }
                    else return;
                }
                else return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sorteio sorteio = new Sorteio();
            sorteio.Show();
            this.Hide();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
           txtEsc.Text += numerosSelecionados.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtEsc.Text= string.Empty;
        }
    }
}
