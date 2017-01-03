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
    public partial class Agenda : Form
    {
        public Agenda()
        {
            InitializeComponent();
        }

        private void pessoasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pessoasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.agendaDataSet);

        }

        private void pessoasBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.pessoasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.agendaDataSet);

        }

        private void Agenda_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'agendaDataSet.Pessoas' table. You can move, or remove it, as needed.
            this.pessoasTableAdapter.Fill(this.agendaDataSet.Pessoas);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fotoPictureBox.ImageLocation = openFileDialog1.FileName;
                fotoPictureBox.Load();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
