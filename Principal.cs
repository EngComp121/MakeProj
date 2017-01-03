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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void jurosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Juros juros = new Juros();
            juros.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Juros juros = new Juros();
            juros.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Taxa taxa = new Taxa();
            taxa.ShowDialog();
        }

        private void taxaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Taxa taxa = new Taxa();
            taxa.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Tempo tempo = new Tempo();
            tempo.ShowDialog();
        }

        private void tempoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tempo tempo = new Tempo();
            tempo.ShowDialog();
        }

        private void capitalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Capital capital = new Capital();
            capital.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Capital capital = new Capital();
            capital.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Player player = new Player();
            player.ShowDialog();
        }

        private void jurosCompostoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JurosComposto juroscomp = new JurosComposto();
            juroscomp.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            JurosComposto juroscomp = new JurosComposto();
            juroscomp.ShowDialog();
        }

        private void musicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Player player = new Player();
            player.ShowDialog();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("     Projeto Z \n \nOrientação: Joabe Fuzaro \nAlunos:\n \n        Marcos Vinicius \n        Hleio Gomes \n        Washinton Luis");
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Agenda agenda = new Agenda();
            agenda.ShowDialog();
        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agenda agenda = new Agenda();
            agenda.ShowDialog();
        }
        
    }
}
