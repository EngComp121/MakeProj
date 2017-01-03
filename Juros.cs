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
    public partial class Juros : Form
    {
        public Juros()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            double juros, capital, taxa, tempo;

            capital = Convert.ToDouble(textCapital.Text);
            taxa = Convert.ToDouble(textTaxa.Text);
            tempo = Convert.ToDouble(textTempo.Text);
            
            juros = ((capital * tempo * taxa) / 100);

            lbResultado.Text = Convert.ToString(juros);
 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textCapital.Clear();
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
