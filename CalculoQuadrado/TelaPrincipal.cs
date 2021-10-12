using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoQuadrado
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            int numero = 0;
            int quadrado = 0;

            numero = Convert.ToInt32(textBox1.Text);
            quadrado = numero * numero;

            labelResultado.Text = "Quadrado de " + numero + " é " + quadrado;

            textBox1.Text = "";
            textBox1.Focus();
        }
    }
}
