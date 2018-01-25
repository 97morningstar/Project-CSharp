using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto.Clases;

namespace Proyecto
{
    public partial class Ranking : Form
    {

        string Resultados = "";
        int n;
        string[,] matriz;
        public Ranking(string[,] matriz)
        {
            InitializeComponent();


            this.matriz = matriz;

            
            /*  lblPrimero.Text = pri;
              lblSegundo.Text = seg;
              lblTercero.Text = ter;*/


           

            for (int i = 0; i < int.Parse(matriz[0,0]); i++)
            {
                listView1.Items.Add(matriz[i, 1]);
                listView1.Items[i].SubItems.Add(matriz[i, 2]);
                listView1.Items[i].SubItems.Add(matriz[i, 3]);
                listView1.Items[i].SubItems.Add(matriz[i, 4]);
                listView1.Items[i].SubItems.Add(matriz[i, 5]);
            }
           

        }
        private void Ranking_Load(object sender, EventArgs e)
        {
           

            WindowState = FormWindowState.Maximized;

            lblPrimero.Location = new Point(410, 630);
            lblSegundo.Location = new Point(760, 680);
            lblTercero.Location = new Point(20, 730);


            btnVolver.Location = new Point(995, 740);


           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
         
        }

        private void imgPrimer_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
   
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.Items.Count ; i++){

                
                listView1.Items[i].SubItems.Clear();
               
            }


            for (int i = 1; i < int.Parse(matriz[0, 0]); i++)
            {
                for (int j = 1; j < 4; j++)
                {
                    matriz[i, j] = null; 
                }
            }
            matriz[0, 0] = "0";
       }
    }
}
