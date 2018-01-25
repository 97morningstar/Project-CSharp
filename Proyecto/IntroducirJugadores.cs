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
    public partial class IntroducirJugadores : Form
    {
      public  Image jug1, jug2, jug3, jug4;
      public  string nameJug1, nameJug2, nameJug3, nameJug4;
      public string cualEs1, cualEs2, cualEs3, cualEs4;
        public bool SeCerro = false;
        public bool volverAlMenu = false;
        public bool AltF4 = false;
              SoundPlayer click = new SoundPlayer("Sonidos/Buttons/- ClickSlot.wav");
              SoundPlayer clicko = new SoundPlayer("Sonidos/Buttons/un boton.wav");
              SoundPlayer escrib = new SoundPlayer("Sonidos/Buttons/escrib.wav");


        public int cant = 0;

      public  int vez = 0;
      int dos, tres, cuatro;
      Form f = new Form();
        public IntroducirJugadores()
        {
            InitializeComponent();
           
        }

        private void IntroducirJugadores_Load(object sender, EventArgs e)
        {
        
         
            btnEmpezar.Location = new Point(800,270);
            label1.Location = new Point(700, 270);
           

            

        }

        private void rdiobtnJugador2_CheckedChanged(object sender, EventArgs e)
        {
            click.Play();
            if (rdiobtnJugador2.Checked == true)
            {
                lblPersonaje.Visible = true;
                imgFenix.Visible = true;
                imgCaballo.Visible = true;
                imgSirena.Visible = true;
                imgTRex.Visible = true;
                lblNombre.Visible = true;
                lblJug1.Visible = true;
                txtJug1.Visible = true;
                dos = 2;
                 

            }
            vez = 0;
        }

        private void imgFenix_Click(object sender, EventArgs e)
        {
            click.Play();
            imgFenix.Visible = false;
            vez++;
            if (vez == 1)
            {
                jug1 = imgFenix.BackgroundImage;
                cualEs1 = "fenix";
            }
            else if (vez == 2)
            {
                jug2 = imgFenix.BackgroundImage;
                cualEs2 = "fenix";
            }
            else if (vez == 3)
            {
                jug3 = imgFenix.BackgroundImage;
                cualEs3 = "fenix";
            }
            else if (vez == 4)
            {
                jug4 = imgFenix.BackgroundImage;
                cualEs4 = "fenix";
            }

            if (rdiobtnJugador2.Checked == true)
            {
                txtJug2.Visible = true;
                lblJug2.Visible = true;
                nameJug2 = txtJug2.Text;
            }
            else if (rdiobtnJugadores3.Checked == true)
            {
  
               
                 
                txtJug2.Visible = true;
                lblJug2.Visible = true;
                nameJug2 = txtJug2.Text;
                if (vez == 2)
                {
                    txtJug3.Visible = true;
                    lblJug3.Visible = true;
                    nameJug3 = txtJug3.Text;
                }
            }
            else if (rdiobtnJugadores4.Checked == true)
            {
                txtJug2.Visible = true;
                lblJug2.Visible = true;
                nameJug2 = txtJug2.Text;
                if (vez == 2)
                {
                    txtJug3.Visible = true;
                    lblJug3.Visible = true;
                    nameJug3 = txtJug3.Text;
                }
                else if (vez == 3)
                {
                    txtJug4.Visible = true;
                    lblJug4.Visible = true;
                    nameJug4 = txtJug4.Text;
                }
            }
        }

        private void imgCaballo_Click(object sender, EventArgs e)
        {
            click.Play();
            imgCaballo.Visible = false;
            vez++;
            if (vez == 1)
            {
                jug1 = imgCaballo.BackgroundImage;
                cualEs1 = "caballo";
            }
            else if (vez == 2)
            {
                jug2 = imgCaballo.BackgroundImage;
                cualEs2 = "caballo";
            }
            else if (vez == 3)
            {
                jug3 = imgCaballo.BackgroundImage;
                cualEs3 = "caballo";
            }
            else if (vez == 4)
            {
                jug4 = imgCaballo.BackgroundImage;
                cualEs4 = "caballo";
            }

            if (rdiobtnJugador2.Checked == true)
            {
                txtJug2.Visible = true;
                lblJug2.Visible = true;
                nameJug2 = txtJug2.Text;
            }
            else if (rdiobtnJugadores3.Checked == true)
            {

                 
                txtJug2.Visible = true;
                lblJug2.Visible = true;
                nameJug2 = txtJug2.Text;
                if (vez == 2)
                {
                    txtJug3.Visible = true;
                    lblJug3.Visible = true;
                    nameJug3 = txtJug3.Text;
                }
            }
            else if (rdiobtnJugadores4.Checked == true)
            {
                txtJug2.Visible = true;
                lblJug2.Visible = true;
                nameJug2 = txtJug2.Text;
                if (vez == 2)
                {
                    txtJug3.Visible = true;
                    lblJug3.Visible = true;
                    nameJug3 = txtJug3.Text;
                }
                else if (vez == 3)
                {
                    txtJug4.Visible = true;
                    lblJug4.Visible = true;
                    nameJug4 = txtJug4.Text;
                }
            }
        }

        private void imgSirena_Click(object sender, EventArgs e)
        {
            click.Play();

            imgSirena.Visible = false;
            vez++;
            if (vez == 1)
            {
                jug1 = imgSirena.BackgroundImage;
                cualEs1 = "sirena";
            }
            else if (vez == 2)
            {
                jug2 = imgSirena.BackgroundImage;
                cualEs2 = "sirena";
            }
            else if (vez == 3)
            {
                jug3 = imgSirena.BackgroundImage;
                cualEs3 = "sirena";
            }
            else if (vez == 4)
            {
                jug4 = imgSirena.BackgroundImage;
                cualEs4 = "sirena";
            }

            if (rdiobtnJugador2.Checked == true)
            {
                txtJug2.Visible = true;
                lblJug2.Visible = true;
                nameJug2 = txtJug2.Text;
            }
            else if (rdiobtnJugadores3.Checked == true)
            {

                 
                txtJug2.Visible = true;
                lblJug2.Visible = true;
                nameJug2 = txtJug2.Text;
                if (vez == 2)
                {
                    txtJug3.Visible = true;
                    lblJug3.Visible = true;
                    nameJug3 = txtJug3.Text;
                }
            }
            else if (rdiobtnJugadores4.Checked == true)
            {
                txtJug2.Visible = true;
                lblJug2.Visible = true;
                nameJug2 = txtJug2.Text;
                if (vez == 2)
                {
                    txtJug3.Visible = true;
                    lblJug3.Visible = true;
                    nameJug3 = txtJug3.Text;
                }
                else if (vez == 3)
                {
                    txtJug4.Visible = true;
                    lblJug4.Visible = true;
                    nameJug4 = txtJug4.Text;
                }
            }
        }

        private void imgTRex_Click(object sender, EventArgs e)
        {
            click.Play();
            imgTRex.Visible = false;

            vez++;
            if (vez == 1)
            {
                jug1 = imgTRex.BackgroundImage;
                cualEs1 = "TRex";
            }
            else if(vez == 2)
            {
                jug2 = imgTRex.BackgroundImage;
                cualEs2 = "TRex";
            }
            else if (vez == 3)
            {
                jug3 = imgTRex.BackgroundImage;
                cualEs3 = "TRex";
            }
            else if (vez == 4)
            {
                jug4 = imgTRex.BackgroundImage;
                cualEs4 = "TRex";
            }

            if (rdiobtnJugador2.Checked == true)
            {
                txtJug2.Visible = true;
                lblJug2.Visible = true;
                nameJug2 = txtJug2.Text;
            }
            else if (rdiobtnJugadores3.Checked == true)
            {

                 
                txtJug2.Visible = true;
                lblJug2.Visible = true;
                nameJug2 = txtJug2.Text;
                if (vez == 2)
                {
                    txtJug3.Visible = true;
                    lblJug3.Visible = true;
                    nameJug3 = txtJug3.Text;
                }
            }
            else if (rdiobtnJugadores4.Checked == true)
            {
                txtJug2.Visible = true;
                lblJug2.Visible = true;
                nameJug2 = txtJug2.Text;
                if (vez == 2)
                {
                    txtJug3.Visible = true;
                    lblJug3.Visible = true;
                    nameJug3 = txtJug3.Text;
                }
                else if (vez == 3)
                {
                    txtJug4.Visible = true;
                    lblJug4.Visible = true;
                    nameJug4 = txtJug4.Text;
                }
            }

        }

        private void rdiobtnJugadores3_CheckedChanged(object sender, EventArgs e)
        {
            click.Play();
            if (rdiobtnJugadores3.Checked == true)
            {
                lblPersonaje.Visible = true;
                imgFenix.Visible = true;
                imgCaballo.Visible = true;
                imgSirena.Visible = true;
                imgTRex.Visible = true;
                lblNombre.Visible = true;
                lblJug1.Visible = true;
                txtJug1.Visible = true;

                dos = 3;

            }
            vez = 0;
        }

        private void rdiobtnJugadores4_CheckedChanged(object sender, EventArgs e)
        {
            click.Play();
            if (rdiobtnJugadores4.Checked == true)
            {
                lblPersonaje.Visible = true;
                imgFenix.Visible = true;
                imgCaballo.Visible = true;
                imgSirena.Visible = true;
                imgTRex.Visible = true;
                lblNombre.Visible = true;
                lblJug1.Visible = true;
                txtJug1.Visible = true;

                dos = 4;

            }
            vez = 0;
        }

        private void btnEmpezar_Click(object sender, EventArgs e)
        {
            clicko.Play();
            nameJug1 = txtJug1.Text;
            nameJug2 = txtJug2.Text;
            nameJug3 = txtJug3.Text;
            nameJug4 = txtJug4.Text;

           // Todavia tengo que revisar esta parte del codigo para que no de errores

            


            if (rdiobtnJugador2.Checked)
            {
                cant = 2;
            }
            else if (rdiobtnJugadores3.Checked)
            {
                cant = 3;
            }
            else if(rdiobtnJugadores4.Checked)
            {
                cant = 4;
            }

            



           if (cant == 0)
            {
                MessageBox.Show("Por favor marque una opción");
            }
           else if (vez != cant)
           {
               MessageBox.Show("No ha seleccionado la cantidad de jugadores correcta\nDeben ser "+cant+" jugadores");
             
           }
            else
            {
                SeCerro = true;



                if (cant == 2)
                {
                    if (!string.IsNullOrEmpty(nameJug1) && !string.IsNullOrEmpty(nameJug2) && !string.IsNullOrWhiteSpace(nameJug1) && !string.IsNullOrWhiteSpace(nameJug2))
                    {
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Debe escribir su nombre en el espacio en blanco","Advertencia",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (cant == 3)
                {
                    if (!string.IsNullOrEmpty(nameJug1) && !string.IsNullOrEmpty(nameJug2) && !string.IsNullOrEmpty(nameJug3) && !string.IsNullOrWhiteSpace(nameJug1) && !string.IsNullOrWhiteSpace(nameJug2) && !string.IsNullOrWhiteSpace(nameJug3))
                    {
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Debe escribir su nombre en el espacio en blanco", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (cant == 4)
                {
                    if (!string.IsNullOrEmpty(nameJug1) && !string.IsNullOrEmpty(nameJug2) && !string.IsNullOrEmpty(nameJug3) && !string.IsNullOrEmpty(nameJug4) && !string.IsNullOrWhiteSpace(nameJug1) && !string.IsNullOrWhiteSpace(nameJug2) && !string.IsNullOrWhiteSpace(nameJug3) && !string.IsNullOrWhiteSpace(nameJug4))
                    {
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Debe escribir su nombre en el espacio en blanco", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
               
               
                


            }
            
            

           
        }

        private void btnIrAtrás_Click(object sender, EventArgs e)
        {
         

            Close();
        }

        private void IntroducirJugadores_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt == true)
            {
                if (e.KeyCode == Keys.F4)
                    AltF4 = true;
            }
        }

        private void txtJug1_TextChanged(object sender, EventArgs e)
        {
            escrib.Play();
        }

        private void txtJug2_TextChanged(object sender, EventArgs e)
        {
            escrib.Play();
        }

        private void txtJug3_TextChanged(object sender, EventArgs e)
        {
            escrib.Play();
        }

        private void txtJug4_TextChanged(object sender, EventArgs e)
        {
            escrib.Play();
        }

      
    }
}
