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
    public partial class DeseaUsarSuPoder : Form
    {
        public DialogResult cual;
        SoundPlayer poder = new SoundPlayer("Sonidos/Buttons/poder.wav");
        public DeseaUsarSuPoder()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cual = DialogResult.No;
            Close();
        }

        private void btnSi_Click(object sender, EventArgs e)
        {
            cual = DialogResult.Yes;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cual = DialogResult.OK;
            Close();
        }

        private void DeseaUsarSuPoder_Load(object sender, EventArgs e)
        {
            poder.Play();
        }
    }
}
