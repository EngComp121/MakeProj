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
    public partial class JurosComposto : Form
    {
        public JurosComposto()
        {
            InitializeComponent();
        }

        
        private void button1_Click_1(object sender, EventArgs e)
        {
            double juros, capital, taxa, tempo, montante;

            capital = Convert.ToDouble(textCapital.Text);
            taxa = Convert.ToDouble(textTaxa.Text);
            tempo = Convert.ToDouble(textTempo.Text);

            montante = capital * Math.Pow((1 + taxa), tempo);
            juros = (montante - capital);

            lbResultado.Text = Convert.ToString(Math.Round(juros, 2));
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textCapital.Clear();
            textTaxa.Clear();
            textTempo.Clear();

            lbResultado.Text = "";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
