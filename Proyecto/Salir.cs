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
    public partial class Salir : Form
    {
      public  DialogResult cual;
      SoundPlayer click = new SoundPlayer("Sonidos/Buttons/- ClickSlot.wav");

        public Salir()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            click.Play();
            cual = DialogResult.Yes;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cual = DialogResult.No;
            click.Play();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Salir_Load(object sender, EventArgs e)
        {
            this.Location = new Point(500, 400);
        }
    }
}
