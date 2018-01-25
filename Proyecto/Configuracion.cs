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
    public partial class Configuracion : Form
    {
        public int filas, columnas;
        public bool recomendada = false;
        public bool manual = false;
        public int cantRafaga, cantTornado, cantNautilus, cantTierra, cantFuego, cantCristal, cantAgua;
        int TotalElementos = 0;
        int CuantoselementospuedesPoner;

        public bool Cerrado = false;
        public bool VolverAlMenu = false;
        public bool AltF4 = false;
        Form p = new Form();
        bool marcado = false;

        Image BajoMar = new Bitmap("Fondo/mar.jpg");
        Image PlanetaVol = new Bitmap("Fondo/volcano.jpg");
        Image ParkJ = new Bitmap("Fondo/Jpark.jpg");
        Image Espacio = new Bitmap("Fondo/espacio.jpg");

        SoundPlayer click = new SoundPlayer("Sonidos/Buttons/- ClickSlot.wav");

        SoundPlayer jugar = new SoundPlayer("Sonidos/Buttons/jugar.wav");
        public Image Fondo;
        public string CualEs= "";
       public Configuracion()
        {
            InitializeComponent();

       


         


            //Aki abran 3 menus 1. Para poner un juego al azar previamente
            // predefinido mas sencillo 2. Para poner un juego al azay previamente
            //predefinido mas dificil  3. Para poner un juego definido por el usuario
            //poner los menus para que el usuario defina sus preferencias
        }
       int n = 1;
        private void Configuracion_Load(object sender, EventArgs e)
        {

     


         
            imgNautilus.BackgroundImage = new Bitmap("si.png");
            imgRafaga.BackgroundImage = new Bitmap("fuego.png");
            imgTierra.BackgroundImage = new Bitmap("PoderdeTRex.png");
            imgTornado.BackgroundImage = new Bitmap("PoderDePegaso.png");
            imgAgua.BackgroundImage = new Bitmap("agua.png");
            imgCristal.BackgroundImage = new Bitmap("cosa.png");
            imgFuego.BackgroundImage = new Bitmap("fuego.gif");
            

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
         
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void rdiobtnConf_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            click.Play();
            if (rdioManual.Checked == true)
            {
                gbOstaculos.Visible = true;
                gbPoderes.Visible = true;
            }
            else
            {
                gbOstaculos.Visible = false;
                gbPoderes.Visible = false;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            jugar.Play();
            filas = (int)nudheight.Value;
            columnas = (int)nudAncho.Value;
            cantAgua = (int)nudAgua.Value;
            cantCristal = (int)nudCristal.Value;
            cantFuego = (int)nudFuego.Value;
            cantNautilus = (int)nudNautilus.Value;
            cantRafaga = (int)nudRafaga.Value;
            cantTierra = (int)nudTierra.Value;
            cantTornado = (int)nudTornado.Value;

            if (rdioBtnJPark.Checked)
            {
                Fondo = ParkJ;
                CualEs = "JP";
            }
            else if (rdiobtnBajoAgua.Checked)
            {
                Fondo = BajoMar;
                CualEs = "Mar";
            }
            else if (rdiobtnplanetavolcano.Checked)
            {
                Fondo = PlanetaVol;
                CualEs = "Vol";
            }
            else if (rdiobtnespacioestelar.Checked)
            {
                Fondo = Espacio;
                CualEs = "Espacio";
            }



            TotalElementos = cantAgua + cantCristal + cantFuego + cantNautilus + cantRafaga + cantTierra + cantTornado - 2;
            CuantoselementospuedesPoner = filas * columnas;

            Cerrado = true;

            /*
            Close();*/

           int sum = cantAgua + cantCristal + cantFuego + cantNautilus + cantRafaga + cantTierra + cantTornado;

           if (sum <= (columnas * filas - 2) && (rdioBtnJPark.Checked || rdiobtnBajoAgua.Checked || rdiobtnplanetavolcano.Checked || rdiobtnespacioestelar.Checked))
            {
                Close();
            }
            else
            {
                MessageBox.Show("La cantidad de elementos que seleccionaste\nes mayor que los que el tablero puede tener a la vez\nTe recomendamos que reduzcas la cantidad de elementos\nO puede que no hayas seleccionado un mundo para empezar el juego");
            }

        }

        private void rdiobtn8x9_CheckedChanged(object sender, EventArgs e)
        {
       
        }

        private void rdiotbn10x13_CheckedChanged(object sender, EventArgs e)
        {
        
        }

        private void rdioRecomen_CheckedChanged(object sender, EventArgs e)
        {
            click.Play();
            if (rdioRecomen.Checked == true)
            {
                nudheight.Value = 11;
                nudAncho.Value = 9;
                nudAgua.Value = 2;
               nudCristal.Value = 3;
                nudFuego.Value = 2;
               nudNautilus.Value = 3;
               nudRafaga.Value = 3;
               nudTierra.Value = 4;
               nudTornado.Value = 4;
               gbOstaculos.Visible = true;
               gbPoderes.Visible = true;
            }
            else if (rdioManual.Checked == true)
            {
                nudheight.Value = 11;
                nudAncho.Value = 9;
                nudAgua.Value = 0;
                nudCristal.Value = 0;
                nudFuego.Value = 0;
                nudNautilus.Value = 0;
                nudRafaga.Value = 0;
                nudTierra.Value = 0;
                nudTornado.Value = 0;
                gbOstaculos.Visible = true;
                gbPoderes.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VolverAlMenu = true;
         
            Close();
        }

        private void nudAncho_ValueChanged(object sender, EventArgs e)
        {
            click.Play();
        }

        private void nudheight_ValueChanged(object sender, EventArgs e)
        {
            click.Play();
        }

        private void rdiobtnBajoAgua_CheckedChanged(object sender, EventArgs e)
        {
            click.Play();
        }

        private void rdioBtnJPark_CheckedChanged(object sender, EventArgs e)
        {
            click.Play();
        }

        private void rdiobtnplanetavolcano_CheckedChanged(object sender, EventArgs e)
        {
            click.Play();
        }

        private void rdiobtnespacioestelar_CheckedChanged(object sender, EventArgs e)
        {
            click.Play();
        }
    }
}
