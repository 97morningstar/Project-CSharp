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

namespace Proyecto
{
    public partial class Poder : Form
    {
        public int CualFue = 0;
        SoundPlayer poder = new SoundPlayer("Sonidos/Buttons/poderusado.wav");
        public Poder(string nombre, string jug1, string jug2, string jug3, string jug4, Image img1, Image img2, Image img3, Image img4)
        {
            InitializeComponent();
            lblInfo.Text = nombre;

            lblJug1.Text = jug1;
            lblJug2.Text = jug2;
            lblJug3.Text = jug3;
            lblJug4.Text = jug4;
            imgJug1.BackgroundImage = img1;
            imgJug2.BackgroundImage = img2;
            imgJug3.BackgroundImage = img3; 
            imgJug4.BackgroundImage = img4;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Poder_Load(object sender, EventArgs e)
        {
            poder.Play();
        }

        private void imgJug1_Click(object sender, EventArgs e)
        {
            CualFue = 1;
            Close();
        }

        private void imgJug2_Click(object sender, EventArgs e)
        {
            CualFue = 2;
            Close();
        }

        private void imgJug3_Click(object sender, EventArgs e)
        {
            CualFue = 3;
            Close();
        }

        private void imgJug4_Click(object sender, EventArgs e)
        {
            CualFue = 4;
            Close();
        }
    }
}
