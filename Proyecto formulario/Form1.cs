using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Has elegido la opcion Aceptar/Cancelar", "Opcion Aceptar/Cancelar", MessageBoxButtons.OKCancel);
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Has elegido la opcion Interrogacion", "Opcion Interrogacion", MessageBoxButtons.OK, MessageBoxIcon.Question);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Has elegido la opcion Si/No", "Opcion Si/No", MessageBoxButtons.YesNo);
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Has elegido la opcion Aceptar", "Opcion Aceptar",MessageBoxButtons.OK);

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Has elegido la opcion Exclamacion", "Opcion Exclamacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Has elegido la opcion Error", "Opcion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void erroresComunesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dispositivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void guardadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void ayudaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Ayuda Ayuda = new Ayuda();
            Ayuda.ShowDialog();
        }

        private void acercaDeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AcercaDe AcercaDe = new AcercaDe();
            AcercaDe.ShowDialog();
        }
    }
}
