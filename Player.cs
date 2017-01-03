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
    public partial class Player : Form
    {
        string[] Musicas = new string[1000];
        int cont;

        public Player()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                axWindowsMediaPlayer1.URL = Musicas[listBox1.SelectedIndex];
                timer1.Start();

            }

            catch
            {
                MessageBox.Show("Primeiro Adicione uma musica ou uma lista de musicas!!!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
                {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = Convert.ToDouble(lbTempo.Text.Replace(":", ""));
                }

            catch
            {
                MessageBox.Show("Primeiro inicie a musica!!!");
            }

        }


        private void button4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {

                axWindowsMediaPlayer1.Ctlcontrols.play();
                axWindowsMediaPlayer1.Ctlcontrols.currentPosition = Convert.ToDouble(lbTempo.Text.Replace(":", ""));

            }

            catch
            {
                MessageBox.Show("Inicie primeiro a musica!!!");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex > 0)
            {
                listBox1.SetSelected(listBox1.SelectedIndex - 1, true);
                axWindowsMediaPlayer1.URL = Musicas[listBox1.SelectedIndex];
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.SelectedIndex <= listBox1.Items.Count - 1)
                {
                    listBox1.SetSelected(listBox1.SelectedIndex + 1, true);
                    axWindowsMediaPlayer1.URL = Musicas[listBox1.SelectedIndex];
                }
            }
            catch
            {
                MessageBox.Show("Selecione as musicas primeiro");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.SetSelected(0, true);
                axWindowsMediaPlayer1.URL = Musicas[listBox1.SelectedIndex];
            }
            catch
            {
                MessageBox.Show("Selecione as musicas primeiro!!!");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.SetSelected(listBox1.Items.Count - 1, true);
                axWindowsMediaPlayer1.URL = Musicas[listBox1.SelectedIndex];
            }
            catch
            {
                MessageBox.Show("Selecione as musicas primeiro!!!");
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Multiselect = true;

            if (abrir.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < abrir.FileNames.LongLength; i ++ )
                {
                    if(listBox1.Items.Contains(abrir.FileNames.GetValue(i)) == false)
                    {
                        listBox1.Items.Add(abrir.FileNames.GetValue(i));
                        Musicas[cont] = abrir.FileNames.GetValue(i).ToString();
                        cont += 1;
                    }
                }

                if(listBox1.SelectedIndex < 0)
                {
                    listBox1.SetSelected(0, true);
                }
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.fastForward();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            

                if (checkBox1.Checked == true && lbTempo.Text != " "
                    && Convert.ToInt32(lbTempo.Text.Replace(':', ' '))
                    == Convert.ToInt32(lbDuracao.Text.Replace(':', ' ')) - 2)
                {
                    Random variar = new Random();

                    listBox1.SetSelected(variar.Next(listBox1.Items.Count), true);
                    axWindowsMediaPlayer1.URL = Musicas[listBox1.SelectedIndex];
                }

                lbDuracao.Text = axWindowsMediaPlayer1.currentMedia.durationString;
                lbTempo.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;

                checkBox1.Enabled = false;
                trackBar1.Enabled = false;

            }
            


        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = trackBar1.Value;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
      
    }
}
