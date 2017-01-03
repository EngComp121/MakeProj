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
    public partial class Taxa : Form
    {
        public Taxa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DECLARAÇÃO DE VARIAVEIS 
            double juros, capital, taxa, tempo;

            //ARMAZANANDO VALORES AS VARIAVEIS E CONVERTENDO PARA O FORMATO DO TEXTBOX(TEXT)
            juros = Convert.ToDouble(textJuros.Text);
            capital = Convert.ToDouble(textCapital.Text);
            tempo = Convert.ToDouble(textTempo.Text);

            //FORMULA PARA TAXA
            taxa = ((juros * 100) / (tempo * capital));

            //EXIBINDO O RESULTADO NO LABEL DEPOIS DE CONVERTIDO
            lbResultado.Text = Convert.ToString(taxa);
 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //LIMPANDO AS VARIAVEIS E MENSAGENS
            textJuros.Clear();
            textCapital.Clear();
            textTempo.Clear();

            lbResultado.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //FECHANDO O FORMULARIO
            this.Close();
        }
    }
}
