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
    public partial class Capital : Form
    {
        public Capital()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double juros, capital, taxa, tempo;

            juros = Convert.ToDouble(textJuros.Text);
            taxa = Convert.ToDouble(textTaxa.Text);
            tempo = Convert.ToDouble(textTempo.Text);

            capital = ((juros * 100) /  (tempo * taxa));

            lbResultado.Text = Convert.ToString(capital);
 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textJuros.Clear();
            textTaxa.Clear();
            textTempo.Clear();

            lbResultado.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
