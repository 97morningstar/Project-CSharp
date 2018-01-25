using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
namespace Proyecto
{
    public partial class Inicio : Form
    {

        public SoundPlayer fondo = new SoundPlayer("Go.wav");

        public Inicio()
        {
            InitializeComponent();
            progressBar1.Maximum = 100;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value++;
                lblNum.Text = progressBar1.Value.ToString() + "%";
            }
            else
                Close();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
           fondo.PlayLooping();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

    }
}
