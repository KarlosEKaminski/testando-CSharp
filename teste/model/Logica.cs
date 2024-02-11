using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste.model
{
    internal class Logica
    {
        public int numeroInicial;
        public int numeroFinal;
        private Form1 form;

        public Logica(Form1 form)
        {
            this.form = form;
        }

        public Logica()
        {

        }
        public Logica(int numeroInicial, int numeroFinal)
        {
            this.numeroInicial = numeroInicial;
            this.numeroFinal = numeroFinal;
        }

        public void setNumeroInicial(int numeroInicial)
        {
            this.numeroInicial = numeroInicial;
        }

        public void setNumeroFinal(int numeroFinal)
        {
            if (numeroFinal >= numeroInicial)
            {
                this.numeroFinal = numeroFinal;
            }
            else
            {
                MessageBox.Show("O número final deve ser maior ou igual ao número inicial.", "Erro", MessageBoxButtons.OK);
            }
        }

        public int Soma()
        {
            return numeroInicial + numeroFinal;
        }

        public void NumerosPares()
        {
            for (int i = 1; i < Soma(); i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public void NumerosImpares()
        {
            for (int i = 1; i < Soma(); i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
