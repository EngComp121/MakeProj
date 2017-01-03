using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjetoZ
{
    public partial class Tempo : Form
    {
        public Tempo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double juros, capital, taxa, tempo;

            juros = Convert.ToDouble(textJuros.Text);
            taxa = Convert.ToDouble(textTaxa.Text);
            capital = Convert.ToDouble(textCapital.Text);

            tempo = ((juros * 100) / (capital * taxa));

            lbResultado.Text = Convert.ToString(tempo);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textJuros.Clear();
            textTaxa.Clear();
            textCapital.Clear();

            lbResultado.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
