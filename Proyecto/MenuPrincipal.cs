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
using Proyecto.Clases;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Proyecto
{
    public partial class MenuPrincipal : Form
    {
        #region Variables necesarias

        public SoundPlayer menuPcpal = new SoundPlayer("FASES02.WAV");
        SoundPlayer jugar = new SoundPlayer("Sonidos/Buttons/- BlockMouse.wav");
        SoundPlayer salir = new SoundPlayer("Sonidos/Buttons/Salijr.wav");
        ListView list1 = new ListView();
        ListView list2 = new ListView();
        ListView list3 = new ListView();

        Image BajoMar = new Bitmap("Fondo/mar.jpg");
        Image PlanetaVol = new Bitmap("Fondo/volcano.jpg");
        Image ParkJ = new Bitmap("Fondo/Jpark.jpg");
        Image Espacio = new Bitmap("Fondo/espacio.jpg");
        Image Fondo = null;

        int cantidad = 0;
     static  bool c = false;
      static bool c1 = false;
      static bool c3 = true;

      IntroducirJugadores intJug;
      Configuracion conf;
      Game jugo;
      Stopwatch crono = new Stopwatch();
      string[,] matriz = new string[30, 30];
      string[,] Temp;

      int xx1;
      int yy1;
      int xx2;
      int yy2;
      int xx3;
      int yy3;
      int xx4;
      int yy4;

      int punto1;
      int punto2;
      int punto3;
      int punto4;

      bool gane1;
      bool gane2;
      bool gane3;
      bool gane4;

      bool poder1;
      bool poder2;
      bool poder3;
      bool poder4;

      string Nombre1;
      string Nombre2;
      string Nombre3;
      string Nombre4;

        #endregion

      // Game jugo = new Game();
        public MenuPrincipal()
        {
            
            InitializeComponent();

          

        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

         
                Inicio ini = new Inicio();
                ini.ShowDialog();

             
                ini.fondo.Stop();

              menuPcpal.PlayLooping();

              #region Localizaciones de los elementos de este form
              btnAlbum.BackgroundImage = new Bitmap("dialog.jpg");
               
               
                btnSalir.BackgroundImage = new Bitmap("dialog.jpg");
                this.BackgroundImage = new Bitmap("Abstract_Wallpaper_by_PL0.jpg");
                paneldeMenu.Location = new Point(403, 596);

                pictureBox1.Location = new Point(301, 59);

                paneldelAlbum.Visible = false;
                paneldelAlbum.Location = new Point(0, 0);
                paneldelAlbum.Size = new System.Drawing.Size(1300,800);

            //Aquí pongo los elementos del album suburbano y así me ahorro un formulario

                btnVolver.Location = new Point(50, 735);
                splitContainer1.Width = 1280;
                splitContainer1.Height = 790;
                WindowState = FormWindowState.Maximized;
                lblTitulo.Text = "Album\nSuburbano";
                lblIndicacion.Text = "Arrastra el mouse hasta\ncada imagen para ver\nsu descripción";

                //Colocar imagenes en la pantalla.

                //Heroes
                imgFenix.Location = new Point(40, 80);
                imgFenix.Width = 200;
                imgFenix.Height = 200;
                imgCaballo.Location = new Point(250, 80);
                imgCaballo.Width = 200;
                imgCaballo.Height = 200;
                imgSirena.Location = new Point(460, 80);
                imgSirena.Width = 200;
                imgSirena.Height = 200;
                imgTRex.Location = new Point(670, 80);
                imgTRex.Width = 200;
                imgTRex.Height = 200;

                //Poderes

                imgRafaga.Location = new Point(40, 400);
                imgRafaga.Width = 100;
                imgRafaga.Height = 100;
                imgTornado.Location = new Point(160, 400);
                imgTornado.Width = 100;
                imgTornado.Height = 100;
                imgNutilus.Location = new Point(280, 400);
                imgNutilus.Width = 100;
                imgNutilus.Height = 100;
                imgTierra.Location = new Point(400, 400);
                imgTierra.Width = 100;
                imgTierra.Height = 100;

                //Obstaculos estaticos

                imgFuego.Location = new Point(40, 620);
                imgFuego.Width = 100;
                imgFuego.Height = 100;
                imgCristal.Location = new Point(160, 620);
                imgCristal.Width = 100;
                imgCristal.Height = 100;
                imgAgua.Location = new Point(280, 620);
                imgAgua.Width = 100;
                imgAgua.Height = 100;

                lblPoderes.Location = new Point(10, 300);
                lblObstaculos.Location = new Point(10, 500);












            //Fin del album sub






                /*   btnJugar.Location = new Point(450,300);
                   btnAlbum.Location = new Point(450, 430);
                   btnAyuda.Location = new Point(450, 530);
            
                   btnSalir.Location = new Point(450, 630);*/
              #endregion
                WindowState = FormWindowState.Maximized;




           

            //Aqui va el codigo para salvar el ranking

                if (File.Exists(Directory.GetCurrentDirectory() + "\\Salva\\Salva.koe"))
                {
                    
                   matriz = (string[,])CargarObjeto(Directory.GetCurrentDirectory() + "\\Salva\\Salva.koe");


                }

        }
       public bool salirdeverdad = false;


       public static void GuardarObjeto(string path, object obj)
       {
           using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
           {
               BinaryFormatter bf = new BinaryFormatter();
               bf.Serialize(fs, obj);
           }
       }

       public static object CargarObjeto(string path)
       {
           using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
           {
               BinaryFormatter bf = new BinaryFormatter();
               return bf.Deserialize(fs);
           }
       }

        private void button1_Click(object sender, EventArgs e)
        {

       




          /*  paneldeMenu.Visible = false;

           AbrirFormulario(intJug);

           secerrojug.Start();

     //      AbrirFormulario(jugo);*/
           
        }


        
        private void MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            GuardarObjeto(Directory.GetCurrentDirectory() + "\\Salva\\Salva.koe", matriz);

            if (salirdeverdad)
            {
                Salir salir = new Salir();
                salir.ShowDialog();

                if (salir.cual == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
   
           
        }
       
        private void btnSalir_Click(object sender, EventArgs e)
        {
            salir.Play();
            salirdeverdad = true;
            this.Close();
        }


        Ranking rank = null;
        int tiempo;

        private void btnAlbum_Click(object sender, EventArgs e)
        {
            jugar.Play();
     

            intJug = new IntroducirJugadores();
            intJug.ShowDialog();
            conf = new Configuracion();
            conf.ShowDialog();

            crono.Start();
            jugo = new Game(intJug.vez, conf.filas, conf.columnas, conf.cantAgua, conf.cantFuego, conf.cantNautilus, conf.cantTornado, conf.cantTierra, conf.cantRafaga, conf.cantCristal, intJug.SeCerro, intJug.cualEs1, intJug.cualEs2, intJug.cualEs3, intJug.cualEs4, intJug.nameJug1, intJug.nameJug2, intJug.nameJug3, intJug.nameJug4, conf.Fondo, conf.CualEs);
            jugo.ShowDialog();

            crono.Stop();

          
            rank = new Ranking(matriz);


            if (!jugo.HeVuelto)
            {
              

                LlenarElRanking(jugo.Para2jugadores, jugo.Para3jugadores, jugo.Para4jugadores);


                matriz[0, 0] = ((int.Parse(matriz[0,0]))+cantidad).ToString();

                rank = new Ranking(matriz);
                rank.ShowDialog();
            }


        }
    
        
        public void LlenarElRanking(Jugador[] lista1, Jugador[] lista2, Jugador[] lista3)
        {
            int h = int.Parse(matriz[0, 0]);
            if (intJug.vez == 2)
            {
                cantidad = 2;
                for ( int i = 0; i < 2; i++)
                {
                   
                        rank.listView1.Items.Add(lista1[i].nombre);
                        rank.listView1.Items[h].SubItems.Add(lista1[i].Puntaje.ToString());

                        rank.listView1.Items[h].SubItems.Add(((double)((double)crono.ElapsedMilliseconds/1000)).ToString()+" segundos");

                        rank.listView1.Items[h].SubItems.Add(DateTime.Now.ToShortDateString().ToString() +"  "+ DateTime.Now.ToLongTimeString().ToString());
                        rank.listView1.Items[h].SubItems.Add((i+1).ToString());
                    
                     
                        matriz[h,1] = lista1[i].nombre;
                        matriz[h, 2] = lista1[i].Puntaje.ToString();
                    matriz[h,3]=((double)((double)crono.ElapsedMilliseconds/1000)).ToString()+" segundos";
                    matriz[h, 4] = DateTime.Now.ToShortDateString().ToString() + "  " + DateTime.Now.ToLongTimeString().ToString();
                    matriz[h++, 5] =(i+1).ToString();

                }


            }
            else if (intJug.vez == 3)
            {
                cantidad = 3;
                for (int i = 0; i < 3; i++)
                {
                 
                        rank.listView1.Items.Add(lista2[i].nombre);
                        rank.listView1.Items[h].SubItems.Add(lista2[i].Puntaje.ToString());

                        rank.listView1.Items[h].SubItems.Add(((double)((double)crono.ElapsedMilliseconds / 1000)).ToString() + " segundos");

                        rank.listView1.Items[h].SubItems.Add(DateTime.Now.ToShortDateString().ToString() + "  " + DateTime.Now.ToLongTimeString().ToString());
                        rank.listView1.Items[h].SubItems.Add((i + 1).ToString());

                      
                        matriz[h, 1] = lista2[i].nombre;
                        matriz[h, 2] = lista2[i].Puntaje.ToString();
                        matriz[h, 3] = ((double)((double)crono.ElapsedMilliseconds / 1000)).ToString() + " segundos";
                        matriz[h, 4] = DateTime.Now.ToShortDateString().ToString() + "  " + DateTime.Now.ToLongTimeString().ToString();
                        matriz[h++, 5] = (i + 1).ToString();
                }
            }
            else if (intJug.vez == 4)
            {
                cantidad = 4;
                for (int i = 0; i < 4; i++)
                {
                  
                        rank.listView1.Items.Add(lista3[i].nombre);
                        rank.listView1.Items[h].SubItems.Add(lista3[i].Puntaje.ToString());

                        rank.listView1.Items[h].SubItems.Add(((double)((double)crono.ElapsedMilliseconds / 1000)).ToString() + " segundos");

                        rank.listView1.Items[h].SubItems.Add(DateTime.Now.ToShortDateString().ToString() + "  " + DateTime.Now.ToLongTimeString().ToString());
                        rank.listView1.Items[h].SubItems.Add((i + 1).ToString());
                    
                        matriz[h, 1] = lista3[i].nombre;
                        matriz[h, 2] = lista3[i].Puntaje.ToString();
                        matriz[h, 3] = ((double)((double)crono.ElapsedMilliseconds / 1000)).ToString() + " segundos";
                        matriz[h, 4] = DateTime.Now.ToShortDateString().ToString() + "  " + DateTime.Now.ToLongTimeString().ToString();
                        matriz[h++, 5] = (i + 1).ToString();
                    
                }
            }





        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            paneldelAlbum.Visible = false;
            pictureBox1.Visible = true;
        }

        #region Descripcion de lo que hace cada jugador
        private void imgFenix_MouseMove(object sender, MouseEventArgs e)
        {
            lblDescripcion.Text = "Este jugador tiene el poder\nde bajar la puntuación de otros\njugadores en 1000 puntos\nEs inmune al obstaculo Tierra";
        }

        private void imgFenix_MouseLeave(object sender, EventArgs e)
        {
            lblDescripcion.Text = "";
        }

        private void imgCaballo_MouseMove(object sender, MouseEventArgs e)
        {
            lblDescripcion.Text = "Este jugador tiene el poder\nde teletransportarse hasta \nel proximo Tornado\nEs inmune al obstáculo Nautilus";
        }

        private void imgCaballo_MouseLeave(object sender, EventArgs e)
        {
            lblDescripcion.Text = "";
        }

        private void imgSirena_MouseMove(object sender, MouseEventArgs e)
        {
            lblDescripcion.Text = "Este jugador tiene el poder\nde aumentar tu puntuación\nen 1000 puntos\nEl obstaculo Tornado no tiene\nningun efecto sobre este\njugador";
        }

        private void imgSirena_MouseLeave(object sender, EventArgs e)
        {
            lblDescripcion.Text = "";
        }

        private void imgTRex_MouseMove(object sender, MouseEventArgs e)
        {
            lblDescripcion.Text = "El poder de este jugador es\nenviar a algún otro jugador\nal principio \nEs inmune al obstáculo\n Rafaga de fuego";
        }

        private void imgTRex_MouseLeave(object sender, EventArgs e)
        {
            lblDescripcion.Text = "";
        }

        private void imgRafaga_MouseMove(object sender, MouseEventArgs e)
        {
            lblDescripcion.Text = "Rafaga de fuego\nAl caer en esta casilla tu\npuntuación se incrementa\nen 500 puntos \nEsta casilla \ndesaparece una vez\nque hayas caido en \nella";
        }

        private void imgRafaga_MouseLeave(object sender, EventArgs e)
        {
            lblDescripcion.Text = "";
        }

        private void imgTornado_MouseMove(object sender, MouseEventArgs e)
        {
            lblDescripcion.Text = "Tornado\nCuando caes aquí tu\n puntuación aumenta \nen 1000 puntos \nEsta casilla \ndesaparece una vez\nque hayas caido en \nella";
        }

        private void imgTornado_MouseLeave(object sender, EventArgs e)
        {
            lblDescripcion.Text = "";
        }

        private void imgNutilus_MouseMove(object sender, MouseEventArgs e)
        {
            lblDescripcion.Text = "Nautilus\nCuando caes en nautilus\ntu puntuación disminuye\nen 500 puntos :( \nEsta casilla \ndesaparece una vez\nque hayas caido en \nella";
        }

        private void imgNutilus_MouseLeave(object sender, EventArgs e)
        {
            lblDescripcion.Text = "";
        }

        private void imgTierra_MouseMove(object sender, MouseEventArgs e)
        {
            lblDescripcion.Text = "Tierra\nAl caer en tierra \ntu puntuación disminuye\n en 1000 puntos  :O \nEsta casilla \ndesaparece una vez\nque hayas caido en \nella";
        }

        private void imgTierra_MouseLeave(object sender, EventArgs e)
        {
            lblDescripcion.Text = "";
        }

        private void imgFuego_MouseMove(object sender, MouseEventArgs e)
        {
            lblDescripcion.Text = "Fuego\nSi caes en esta casilla\n tienes que retroceder\n 7 pasos";
        }

        private void imgFuego_MouseLeave(object sender, EventArgs e)
        {
            lblDescripcion.Text = "";
        }

        private void imgCristal_MouseMove(object sender, MouseEventArgs e)
        {
            lblDescripcion.Text = "Cristal\nSi caes aquí tu puntuación\naumentará en 2000 punto\nEsta casilla NO \ndesaparece una vez\nque hallas caido en ella";
        }

        private void imgCristal_MouseLeave(object sender, EventArgs e)
        {
            lblDescripcion.Text = "";
        }

        private void imgAgua_MouseMove(object sender, MouseEventArgs e)
        {
            lblDescripcion.Text = "Agua\nAl caer en esta casilla\nadelantarás 5 pasos ";
        }

        private void imgAgua_MouseLeave(object sender, EventArgs e)
        {
            lblDescripcion.Text = "";
        }
        #endregion
        private void sobreElJugoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           MessageBox.Show("Este juego fue confeccionado para el proyecto de curso\nde primer año de informatica\nEsperamos que les guste\nSi notan algun error o que algo no le funciona\ncomo deberia no duden en contactar con nosotros\nEnjoy :)");
                          
        }

        private void jugarToolStripMenuItem_Click(object sender, EventArgs e)
        {



            paneldelAlbum.Visible = true;
            pictureBox1.Visible = false;
          


        }

        private void algunasReglasClickAquíToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void reglasGeneralesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido a nuestro Juego  \"Batallas de Gloria\"\nTe Presentamos algunas Reglas Básicas que deberías seguir\nPara verlas haz click en el albúm suburbano\nPara que despues no te tome por sorpresa\nBuena Suerte");
        }

        private void reglasQueDeberiasSaberPeroQueNoSonTanImportantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Todavia no estan listas");
        }

        private void ranikToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rankingToolStripMenuItem_Click(object sender, EventArgs e)
        {

            rank = new Ranking(matriz);
            rank.ShowDialog();
        }

        private void borrarRanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        public void limpiar()
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 1; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = null;
                }
            }
        }

        private void abrirJuegoGuardadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

            StreamReader b = new StreamReader(openFileDialog1.OpenFile());
            int cantJ = int.Parse(b.ReadLine());
            int filas = int.Parse(b.ReadLine());
            int columnas = int.Parse(b.ReadLine());
            string CualEs = b.ReadLine();

            Temp = new string[filas, columnas];

            if (CualEs == "JP")
            {
                Fondo = ParkJ;
                
            }
            else if (CualEs == "Mar")
            {
                Fondo = BajoMar;
                
            }
            else if (CualEs == "Vol")
            {
                Fondo = PlanetaVol;
                
            }
            else if (CualEs == "Espacio")
            {
                Fondo = Espacio;
                
            }


            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Temp[i,j] = CualEra(b.ReadLine());
                }
            }

            string jug="";
            string jug2="";
            string jug3="";
            string jug4="";

            int turno;

            //recopilacion de la informacion guardada
            if (cantJ==2)
            {
                //1er jugador
                jug = QueTipodeJugador(b.ReadLine());
                xx1 = int.Parse(b.ReadLine());
                yy1 = int.Parse(b.ReadLine());
                punto1 = int.Parse(b.ReadLine());
                if (b.ReadLine() == "True")
                    poder1 = true;
                else
                    poder1 = false;
                Nombre1 = b.ReadLine();
                if (b.ReadLine() == "True")
                    gane1 = true;
                else
                   gane1 = false;

                //2do jugador
                jug2 = QueTipodeJugador(b.ReadLine());
                xx2 = int.Parse(b.ReadLine());
                yy2 = int.Parse(b.ReadLine());
                punto2 = int.Parse(b.ReadLine());
                if (b.ReadLine() == "True")
                    poder2 = true;
                else
                    poder2 = false;
                Nombre2 = b.ReadLine();
                if (b.ReadLine() == "True")
                    gane2 = true;
                else
                    gane2 = false;



                //Jugadore que estaba de turno

               turno = int.Parse(b.ReadLine());

            }
            else if (cantJ == 3)
            {

                //1er jugador
                jug = QueTipodeJugador(b.ReadLine());
                xx1 = int.Parse(b.ReadLine());
                yy1 = int.Parse(b.ReadLine());
                punto1 = int.Parse(b.ReadLine());
                if (b.ReadLine() == "True")
                    poder1 = true;
                else
                    poder1 = false;
                Nombre1 = b.ReadLine();
                if (b.ReadLine() == "True")
                    gane1 = true;
                else
                    gane1 = false;

                //2do jugador
                jug2 = QueTipodeJugador(b.ReadLine());
                xx2 = int.Parse(b.ReadLine());
                yy2 = int.Parse(b.ReadLine());
                punto2 = int.Parse(b.ReadLine());
                if (b.ReadLine() == "True")
                    poder2 = true;
                else
                    poder2 = false;
                Nombre2 = b.ReadLine();
                if (b.ReadLine() == "True")
                    gane2 = true;
                else
                    gane2 = false;

                //3er jugador

                jug3 = QueTipodeJugador(b.ReadLine());
                xx3 = int.Parse(b.ReadLine());
                yy3 = int.Parse(b.ReadLine());
                punto3 = int.Parse(b.ReadLine());
                if (b.ReadLine() == "True")
                    poder3 = true;
                else
                    poder3 = false;
                Nombre3 = b.ReadLine();
                if (b.ReadLine() == "True")
                    gane3 = true;
                else
                    gane3 = false;

                //Jugadore que estaba de turno

                turno = int.Parse(b.ReadLine());
            }
            else
            {
                //1er jugador
                jug = QueTipodeJugador(b.ReadLine());
                xx1 = int.Parse(b.ReadLine());
                yy1 = int.Parse(b.ReadLine());
                punto1 = int.Parse(b.ReadLine());
                if (b.ReadLine() == "True")
                    poder1 = true;
                else
                    poder1 = false;
                Nombre1 = b.ReadLine();
                if (b.ReadLine() == "True")
                    gane1 = true;
                else
                    gane1 = false;

                //2do jugador
                jug2 = QueTipodeJugador(b.ReadLine());
                xx2 = int.Parse(b.ReadLine());
                yy2 = int.Parse(b.ReadLine());
                punto2 = int.Parse(b.ReadLine());
                if (b.ReadLine() == "True")
                    poder2 = true;
                else
                    poder2 = false;
                Nombre2 = b.ReadLine();
                if (b.ReadLine() == "True")
                    gane2 = true;
                else
                    gane2 = false;

                //3er jugador

                jug3 = QueTipodeJugador(b.ReadLine());
                xx3 = int.Parse(b.ReadLine());
                yy3 = int.Parse(b.ReadLine());
                punto3 = int.Parse(b.ReadLine());
                if (b.ReadLine() == "True")
                    poder3 = true;
                else
                    poder3 = false;
                Nombre3 = b.ReadLine();
                if (b.ReadLine() == "True")
                    gane3 = true;
                else
                    gane3 = false;

                //4to jugador
                jug4 = QueTipodeJugador(b.ReadLine());
                xx4 = int.Parse(b.ReadLine());
                yy4 = int.Parse(b.ReadLine());
                punto4 = int.Parse(b.ReadLine());
                if (b.ReadLine() == "True")
                    poder4 = true;
                else
                    poder4 = false;
                Nombre4 = b.ReadLine();
                if (b.ReadLine() == "True")
                    gane4 = true;
                else
                    gane4 = false;

                //Jugadore que estaba de turno

               turno = int.Parse(b.ReadLine());
            }


            crono.Start();
            jugo = new Game(cantJ, filas, columnas, Temp, jug, jug2, jug3, jug4, Nombre1, Nombre2, Nombre3, Nombre4, Fondo, CualEs, xx1, yy1, xx2, yy2, xx3, yy3, xx4, yy4, punto1, punto2, punto3, punto4, poder1, poder2, poder3, poder4, gane1, gane2, gane3, gane4, turno);

            jugo.ShowDialog();
            crono.Stop();

            if (!jugo.HeVuelto)
            {


                LlenarElRanking(jugo.Para2jugadores, jugo.Para3jugadores, jugo.Para4jugadores);


                matriz[0, 0] = ((int.Parse(matriz[0, 0])) + cantidad).ToString();

                rank = new Ranking(matriz);
                rank.ShowDialog();
            }




        }

        public string QueTipodeJugador(string n)
        {
            if (n == "Proyecto.Clases.Fenix")
            {
                return "fenix";
            }
            else if(n == "Proyecto.Clases.Sirena")
            {
                return "sirena";
            }
            else if (n == "Proyecto.Clases.Pegaso")
            {
                return "caballo";
            }
            else
            {
                return "trex";
            }

        }

       public string CualEra(string n)
        {
           
            if (n == "Proyecto.Clases.Rafaga")
            {
                return "Rafaga";
            }
           else if(n == "Proyecto.Clases.Cristal")
            {
                return  "Cristal";
            }
            else if (n == "Proyecto.Clases.Fuego")
            {
                return  "Fuego";
            }
            else if (n == "Proyecto.Clases.Nautilus")
            {
                return "Nautilus";
            }
            else if (n == "Proyecto.Clases.Tierra")
            {
                return  "Tierra";
            }
            else if (n == "Proyecto.Clases.Tornado")
            {
                return "Tornado";
            }
            else if (n == "Proyecto.Clases.Agua")
            {
                return "Agua";
            }
            else
            {
                return null;
            }




        }

       private void salirToolStripMenuItem_Click(object sender, EventArgs e)
       {
           Close();
       }

        





    }
}
