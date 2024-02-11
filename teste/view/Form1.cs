using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using teste.model;

namespace teste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Logica teste = new Logica();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void campoNumeroInicial_TextChanged(object sender, EventArgs e)
        {
            int numero;
            if (int.TryParse(campoNumeroInicial.Text, out numero))
            {
                teste.setNumeroInicial(numero);
            }
            else
            {
                MessageBox.Show("Digite um número inteiro válido.", "Erro", MessageBoxButtons.OK);
                campoNumeroInicial.Clear();
            }
        }

        private void campoNumeroFinal_TextChanged(object sender, EventArgs e)
        {
            int numero;
            if (int.TryParse(campoNumeroFinal.Text, out numero))
            {
                teste.setNumeroFinal(numero);
            }
            else
            {
                MessageBox.Show("Digite um número inteiro válido.", "Erro", MessageBoxButtons.OK);
                campoNumeroFinal.Clear();
            }

            if(teste.numeroInicial > teste.numeroFinal )
            {
                campoNumeroFinal.Clear();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            campoNumerosPares.Clear();
            for (int i = 1; i < teste.Soma(); i++)
            {
                if (i % 2 == 0)
                {
                    campoNumerosPares.AppendText(i.ToString() + "\n");
                }
            }

            camposNumerosImpares.Clear();
            for (int i = 1; i < teste.Soma(); i++)
            {
                if (i % 2 != 0)
                {
                    camposNumerosImpares.AppendText(i.ToString() + "\n");
                }
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
        }

        private void botaoLimpar_Click(object sender, EventArgs e)
        {
            teste.setNumeroInicial(0);
            teste.setNumeroFinal(0);
            campoNumeroInicial.Clear();
            campoNumeroFinal.Clear();
            campoNumerosPares.Clear();
            camposNumerosImpares.Clear();
        }
    }
}
