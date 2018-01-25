using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JPUtil;
using System.IO;
using Proyecto.Clases;
using System.Media;
namespace Proyecto
    /*
     *      Hello World!
     *      Ya casi casi, no falta casi nada;
     *      Estoy muy alegre de q todo esta saliendo bien
     */ 



{
    public partial class Game : Form
    {
        //Aquí defino las variables que necesito en mi formulario
        #region Variables Necesarias

        #region Sonidos

        SoundPlayer cristal = new SoundPlayer("Sonidos/untitled.wav");
        SoundPlayer agua = new SoundPlayer("Sonidos/agua.wav");
        SoundPlayer fuego = new SoundPlayer("Sonidos/fuego.wav");
        SoundPlayer nautilus = new SoundPlayer("Sonidos/nautilus.wav");
        SoundPlayer rafaga = new SoundPlayer("Sonidos/rafaga.wav");
        SoundPlayer tierra = new SoundPlayer("Sonidos/tierra.wav");
        SoundPlayer tornado = new SoundPlayer("Sonidos/tornado.wav");
        SoundPlayer aplausos = new SoundPlayer("Sonidos/publico aplaudiendo.wav");
        SoundPlayer tirar = new SoundPlayer("Sonidos/Buttons/Salir.wav");
        SoundPlayer volver = new SoundPlayer("Sonidos/Buttons/un boton.wav");

       

        #endregion


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

        bool poder1;
        bool poder2;
        bool poder3;
        bool poder4;

        int cantJug;
        int filas;
        int columnas;
        int cantAgua;
        int cantFuego;
        int cantCristal;
        int cantNautilus;
        int cantRafaga;
        int cantTierra;
        int cantTornado;
        bool JugSeCerro;
        string cualEs1;
        string cualEs2;
        string cualEs3;
        string cualEs4;

        string Nombre1;
        string Nombre2;
        string Nombre3;
        string Nombre4;

        bool gane1;
        bool gane2;
        bool gane3;
        bool gane4;

        Random ranDado = new Random();
   
       // IntroducirJugadores intJug = new IntroducirJugadores(this);
        Tablero tab;
        int lugar = 0;
        int Quedan = 0;
        //Lugares 
        Jugador Primero;
        Jugador Segundo;
        Jugador Tercero;

        //Fin de Lugares
        Jugador jug2;
        Jugador jug3;
        Jugador jug4;
        Jugador jug;

        Image Fondo;
        string CualEs="";

        public bool HeVuelto = false;

        Configuracion conf;
       public int nn=1;
       Muerte muerte;
        #endregion
       #region Constructores

       string Constructor = "";
       string[,] mat;
       public Game(int cantJug, int filas, int columnas, int cantAgua, int cantFuego, int cantNautilus, int cantTornado, int cantTierra, int cantRafaga, int cantCristal, bool JugSeCerro, string cualEs1, string cualEs2, string cualEs3, string cualEs4, string Nombre1, string Nombre2, string Nombre3, string Nombre4, Image fondo, string CualEs)
       {

           InitializeComponent();

           this.cantJug = cantJug;
           this.filas = filas;
           this.columnas = columnas;
           this.Fondo = fondo;
           this.cantAgua = cantAgua;
           this.cantFuego = cantFuego;
           this.cantNautilus = cantNautilus;
           this.cantTornado = cantTornado;
           this.cantTierra = cantTierra;
           this.cantRafaga = cantRafaga;
           this.cantCristal = cantCristal;
           tab = new Tablero(colorTable1, filas, columnas);
           this.JugSeCerro = JugSeCerro;
           this.cualEs1 = cualEs1;
           this.cualEs2 = cualEs2;
           this.cualEs3 = cualEs3;
           this.cualEs4 = cualEs4;

           this.Nombre1 = Nombre1;
           this.Nombre2 = Nombre2;
           this.Nombre3 = Nombre3;
           this.Nombre4 = Nombre4;

           this.CualEs = CualEs;


           btnVolver.Location = new Point(995, 740);

           xx1 = 0;
           xx2=0;
           xx3=0;
           xx4=0;
           yy1=0;
           yy2=0;
           yy3 = 0;
           yy4=0;


           Constructor = "Ramdom";




       }

       public Game(int cantJug, int filas, int columnas, string[,] mat, string cualEs1, string cualEs2, string cualEs3, string cualEs4, string Nombre1, string Nombre2, string Nombre3, string Nombre4, Image fondo, string CualEs, int xx1, int yy1, int xx2, int yy2, int xx3, int yy3, int xx4, int yy4 , int punto1, int punto2, int punto3, int punto4, bool poder1, bool poder2,  bool poder3, bool poder4, bool gane1, bool gane2, bool gane3, bool gane4, int turno)
       {
           InitializeComponent();

           this.cantJug = cantJug;
           this.filas = filas;
           this.columnas = columnas;
           this.mat = mat;
           this.Fondo = fondo;

           tab = new Tablero(colorTable1, filas, columnas);

           CosasDelTableroImportantes();


           tab.ColocarElementos(mat);


           this.cualEs1 = cualEs1;
           this.cualEs2 = cualEs2;
           this.cualEs3 = cualEs3;
           this.cualEs4 = cualEs4;


           this.Nombre1 = Nombre1;
           this.Nombre2 = Nombre2;
           this.Nombre3 = Nombre3;
           this.Nombre4 = Nombre4;

           this.punto1 = punto1;
           this.punto2 = punto2;
           this.punto3 = punto3;
           this.punto4 = punto4;


           this.poder1 = poder1;
           this.poder2 = poder2;
           this.poder3 = poder3;
           this.poder4 = poder4;

           this.gane1 = gane1;
           this.gane2 = gane2;
           this.gane3 = gane3;
           this.gane4 = gane4;
           

           this.CualEs = "";

           if (cantJug == 2)
           {
               this.xx1 = xx1;
               this.xx2 = xx2;
               this.yy1 = yy1;
               this.yy2 = yy2;
           }
           else if (cantJug == 3)
           {
               this.xx1 = xx1;
               this.xx2 = xx2;
               this.yy1 = yy1;
               this.yy2 = yy2;
               this.xx3 = xx3;
               this.yy3 = yy3;


           }
           else if (cantJug == 4)
           {
               this.xx1 = xx1;
               this.xx2 = xx2;
               this.yy1 = yy1;
               this.yy2 = yy2;
               this.xx3 = xx3;
               this.yy3 = yy3;
               this.xx4 = xx4;
               this.yy4 = yy4;
           }


           JugSeCerro = true;


           Primer = turno;
           btnVolver.Location = new Point(995, 740);
           Constructor = "Salva";
       }



       #endregion
       //Definimos nuestros jugadores dependiendo del formulario introducir jugadores
       #region Jugadores
       public Jugador CualEsElPrimerJugador(Tablero tab, int x, int y)
        {
            if (cualEs1 == "fenix")
            {
               Jugador pop = new Fenix(tab, new Point(x, y), Color.AliceBlue, new Bitmap("RealF.png"), Nombre1, CualEs);
               return pop;
            }
            else if (cualEs1 == "sirena")
            {
                Jugador pop = new Sirena(tab, new Point(x, y), Color.AliceBlue, new Bitmap("RealSirena.png"), Nombre1, CualEs);
               return pop;
            }
            else if (cualEs1 == "caballo")
            {
                Jugador pop = new Pegaso(tab, new Point(x, y), Color.AliceBlue, new Bitmap("ahora.png"), Nombre1, CualEs);
              return pop;
            }
            else
            {
                Jugador pop = new TRex(tab, new Point(x, y), Color.AliceBlue, new Bitmap("TrueTRex.png"), Nombre1, CualEs);
              return pop;
            } 
        }
        public Jugador CualEsElSegundoJugador(Tablero tab, int x, int y)
        {
            if (cualEs2 == "fenix")
            {
                Jugador pop = new Fenix(tab, new Point(x, y), Color.AliceBlue, new Bitmap("RealF.png"), Nombre2, CualEs);
                return pop;
            }
            else if (cualEs2 == "sirena")
            {
                Jugador pop = new Sirena(tab, new Point(x, y), Color.AliceBlue, new Bitmap("RealSirena.png"), Nombre2, CualEs);
                return pop;
            }
            else if (cualEs2 == "caballo")
            {
                Jugador pop = new Pegaso(tab, new Point(x, y), Color.AliceBlue, new Bitmap("ahora.png"), Nombre2, CualEs);
                return pop;
            }
            else
            {
                Jugador pop = new TRex(tab, new Point(x, y), Color.AliceBlue, new Bitmap("TrueTRex.png"), Nombre2, CualEs);
                return pop;
            }
        }

        public Jugador CualEsElTercerJugador(Tablero tab, int x, int y)
        {
            if (cualEs3 == "fenix")
            {
                Jugador pop = new Fenix(tab, new Point(x, y), Color.AliceBlue, new Bitmap("RealF.png"), Nombre3, CualEs);
                return pop;
            }
            else if (cualEs3 == "sirena")
            {
                Jugador pop = new Sirena(tab, new Point(x, y), Color.AliceBlue, new Bitmap("RealSirena.png"), Nombre3 , CualEs);
                return pop;
            }
            else if (cualEs3 == "caballo")
            {
                Jugador pop = new Pegaso(tab, new Point(x, y), Color.AliceBlue, new Bitmap("ahora.png"), Nombre3, CualEs);
                return pop;
            }
            else
            {
                Jugador pop = new TRex(tab, new Point(x, y), Color.AliceBlue, new Bitmap("TrueTRex.png"), Nombre3, CualEs);
                return pop;
            }
        }
        public Jugador CualEsElCuartoJugador(Tablero tab, int x, int y)
        {
            if (cualEs4 == "fenix")
            {
                Jugador pop = new Fenix(tab, new Point(x,y), Color.AliceBlue, new Bitmap("RealF.png"), Nombre4, CualEs);
                return pop;
            }
            else if (cualEs4 == "sirena")
            {
                Jugador pop = new Sirena(tab, new Point(x, y), Color.AliceBlue, new Bitmap("RealSirena.png"), Nombre4, CualEs);
                return pop;
            }
            else if (cualEs4 == "caballo")
            {
                Jugador pop = new Pegaso(tab, new Point(x,y), Color.AliceBlue, new Bitmap("ahora.png"), Nombre4,CualEs );
                return pop;
            }
            else
            {
                Jugador pop = new TRex(tab, new Point(x, y), Color.AliceBlue, new Bitmap("TrueTRex.png"), Nombre4, CualEs);
                return pop;
            }
        }
       #endregion
        //Funcion inservible para comenzar el juego
        #region Empezo

        public void Empezo()
        {
     
                TableroConfigurado();
            

        }

        public void Salvado()
        {
            CosasDelTableroImportantes();
        }
        #endregion
        //Esta funcion es muy importante porque aqui se definen las dimensiones y elementos del juego
        #region Crear la muerte
        public Muerte CrearLaMuerte(Tablero tabl)
        {

           Muerte pop = new Muerte(tabl, new Point(5, 5),colorTable1, new Bitmap("center.gif"));
           return pop;
        }
        #endregion
        #region Dimensiones y elementos del tablero

        public void CosasDelTableroImportantes()
        {
           

            colorTable1.Width = 980;
            colorTable1.Height = 795;

            if (filas == 7 && columnas == 7) colorTable1.CellSize = 100;
            else
                colorTable1.CellSize = (795 / columnas);

            tab.ColorTable1.TableHeight = columnas;
            tab.ColorTable1.TableWidth = filas;


            colorTable1.Add(filas - 1, columnas - 1, Color.AliceBlue, new Bitmap("cup.png"));
            colorTable1.AutoScroll = false;
        }


        public void TableroConfigurado()
        {

            CosasDelTableroImportantes();
            
            tab.PonerAgua(cantAgua);
            tab.PonerCristal( cantCristal);
            tab.PonerFuego( cantFuego);
            tab.PonerNautilus(cantNautilus);
            tab.PonerRafaga(cantRafaga);
            tab.PonerTierra(cantTierra);
            tab.PonerTornado(cantTornado);
         
        }

        #endregion
        //El load del formulario, esta funcion es llamada antes que se abra el formulario es extra mega super hiper importamte
        #region Load
        int h;
        
        private void Form1_Load(object sender, EventArgs e)
        {

            this.BackgroundImage = Fondo;



            //OJO NO BORRar  logica del dado
          otroCheckeador.Enabled = true;
          otroCheckeador.Start();

          if (Constructor == "Ramdom")
          Empezo();
          else if (Constructor == "Salva")
          {
              Salvado();
          }


            imgDado.Location = new Point(995, 40);

            btnTirar.Location = new Point(995, 230);
            btnUsarPoder.Location = new Point(995, 280);
   


            timerDado.Enabled = false;
            timerDado.Stop();       

            timerDetenerElDado.Enabled = false;
            timerDetenerElDado.Stop();
            // end logic del dado
            
           //Configuracion

           

            //Informacion
            lblInformacion.Location = new Point(1000, 340);
            lblInformacion.Text = "La puntuación inicial\nde cada jugador es de:\n 1000 puntos";

        


           // MessageBox.Show("d");
          
            timer2.Stop();
            timer3.Stop();
            timer4.Stop();
            timer5.Stop();

           // mp.menuPcpal.Stop();

            
           //Superimportante "La creacion de los jugadores"
            //De seguro que hay otraaas formas más elegantes y eficientes
            //pero esta fue la que se me ocurrió y que funciona

            if (JugSeCerro)
            {
                muerte = CrearLaMuerte(tab);
                timerdeLamuerte.Enabled = true;
                timerdeLamuerte.Start();
            }

            if (JugSeCerro)
            {

                if (cantJug == 2)
                {
                    jug = CualEsElPrimerJugador(tab, xx1, yy1);
                    jug2 = CualEsElSegundoJugador(tab, xx2, yy2);

                    if (Constructor == "Salva")
                    {
                        jug.Puntaje = punto1;
                        jug2.Puntaje = punto2;

                        jug.PoderUsado = poder1;
                        jug2.PoderUsado = poder2;

                        jug.Gane = gane1;
                        jug2.Gane = gane2;

                        colorTable1.Add(xx1, yy1, Color.Aquamarine,jug.imagen);
                        colorTable1.Add(xx2, yy2, Color.Aquamarine, jug2.imagen);
                    }

                    Quedan = 2;
                }
                else if (cantJug == 3)
                {
                    jug = CualEsElPrimerJugador(tab, xx1, yy1);
                    jug2 = CualEsElSegundoJugador( tab, xx2, yy2);
                    jug3 = CualEsElTercerJugador(tab, xx3, yy3);

                    if (Constructor == "Salva")
                    {
                        jug.Puntaje = punto1;
                        jug2.Puntaje = punto2;
                        jug3.Puntaje = punto3;
                        jug.PoderUsado = poder1;
                        jug2.PoderUsado = poder2;
                        jug.Gane = gane1;
                        jug2.Gane = gane2;
                        jug3.PoderUsado = poder3;
                        jug3.Gane = gane3;

                        colorTable1.Add(xx1, yy1, Color.Aquamarine, jug.imagen);
                        colorTable1.Add(xx2, yy2, Color.Aquamarine, jug2.imagen);
                        colorTable1.Add(xx3, yy3, Color.Aquamarine, jug3.imagen);
                    }

                    Quedan = 3;
                }
                else if (cantJug == 4)
                {
                    jug = CualEsElPrimerJugador(tab,xx1, yy1);
                    jug2 = CualEsElSegundoJugador(tab, xx2, yy2);
                    jug3 = CualEsElTercerJugador( tab, xx3, yy3);
                    jug4 = CualEsElCuartoJugador(tab, xx4, yy4);

                    if (Constructor == "Salva")
                    {
                        jug.Puntaje = punto1;
                        jug2.Puntaje = punto2;
                        jug3.Puntaje = punto3;
                        jug4.Puntaje = punto4;
                        jug.Puntaje = punto1;
                        jug2.Puntaje = punto2;
                        jug3.Puntaje = punto3;
                        jug.PoderUsado = poder1;
                        jug2.PoderUsado = poder2;
                        jug.Gane = gane1;
                        jug2.Gane = gane2;
                        jug3.PoderUsado = poder3;
                        jug3.Gane = gane3;
                        jug4.PoderUsado = poder4;
                        jug4.Gane = gane4;

                        colorTable1.Add(xx1, yy1, Color.Aquamarine, jug.imagen);
                        colorTable1.Add(xx2, yy2, Color.Aquamarine, jug2.imagen);
                        colorTable1.Add(xx3, yy3, Color.Aquamarine, jug3.imagen);
                        colorTable1.Add(xx4, yy4, Color.Aquamarine, jug4.imagen);
                    }

                    Quedan = 4;
                }





            }
        













        
            //fin de Superimportante





            WindowState = FormWindowState.Maximized; // Para maximizar la ventana
         

            
         
        }

        #endregion
        //Accion del boton volver, tambien se inicializan las posiciones de los jugadores
        #region Boton Volver



        public bool Volví = false;
        private void btnVolver_Click(object sender, EventArgs e)
        {
            volver.Play();


            if (MessageBox.Show("¿Desea guardar su partida?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
            {
                //  mp.menuPcpal.PlayLooping();

                HeVuelto = true;


                InicializarLugadores();
                if (cantJug == 2)
                {
                    jug.volvio = true;
                    jug2.volvio = true;
                }
                else if (cantJug == 3)
                {
                    jug.volvio = true;
                    jug2.volvio = true;
                    jug3.volvio = true;
                }
                else if (cantJug == 4)
                {
                    jug.volvio = true;
                    jug2.volvio = true;
                    jug3.volvio = true;
                    jug4.volvio = true;
                }

                x1 = 0; y1 = 0;  //esto es porque  a veces el sonido del obstaculo movil se activa solo (ni idea)
                x2 = 0; y2 = 0;
                x3 = 0; y3 = 0;
                x4 = 0; y4 = 0;



                this.Dispose();
                Close();
            }
            else
            {
                HeVuelto = true;

                saveFileDialog1.ShowDialog();
                MessageBox.Show("Tu partida ha sido guardada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
                Close();
            }
        }
        #endregion
        //Esta es la logica del dado y del boton tirar
        #region Dado y boton tirar
        public int num;
       int k;
    
        int Primer = 0;



        bool SeAcabo = false;
        bool SeAcabo3 = false;
   
        private void btnTirar_Click(object sender, EventArgs e)
        {
            tirar.Play();
            btnUsarPoder.Enabled = true;
        

                timerDado.Enabled = true;  //No te actives si algun jugador ya ganó please
                timerDado.Start();

                btnTirar.Enabled = false;

        }
        int w = 4;
       
        private void timerDado_Tick(object sender, EventArgs e)
        {
            //que no se tire si algun jugador ya ganó  no se como voy a hacer eso
            num = ranDado.Next(0, 12);
            imgDado.BackgroundImage = new Bitmap(num + ".png");
            k = num;
            
            Detente(w);
            w--;
        }

        #endregion
        //Esta probablemente sea la funcion mas importante de todo el juego, esta bien larga porque prueba
        //  todas las combinaciones posibles para 2, 3 y 4 jugadores
        #region Detener el dado

        bool Seacabo4 = false;
        public void Detente(int n)
        {
         
            if (n == 0) {
                timerDado.Enabled = false;
                timerDado.Stop();

                //si queda un jugador el juego se acabó

                #region Para 2 jugadores
                if (cantJug == 2)
                {
                    if (Primer == 0)
                    {
                        if(jug.Gane)
                        {
                            SeAcabo = true;
                        }
                        else
                        {
                          

                          
                            timer2.Enabled = true;
                            timer2.Start();

                            Primer = 1;
                        }
                    }
                    else if (Primer == 1)
                    {
                        if (jug2.Gane)
                        {
                            SeAcabo = true;
                        }
                        else
                        {
                         


                            

                            timer3.Enabled = true;
                            timer3.Start();
                            Primer = 0;

                        }
                    }
                }
                #endregion
                #region Para 3 jugadores
                else if (cantJug == 3)
                {
                    if (Primer == 0)
                    {
                        if (jug.Gane)
                        {
                            if (jug2.Gane)
                            {
                                SeAcabo3 = true;
                            }
                            else
                            {
                                if (jug3.Gane)
                                {
                                    SeAcabo3 = true;
                                }
                                else
                                {
                                   

                                    timer3.Enabled = true;
                                    timer3.Start();
                                    Primer = 2;
                                }
                            }
                        }
                        else
                        {
                            if (jug2.Gane)
                            {
                                if (jug3.Gane)
                                {
                                    SeAcabo3 = true;
                                }
                                else
                                {
                                   

                                    timer2.Enabled = true;
                                    timer2.Start();
                                    Primer = 2;
                                }
                            }
                            else
                            {
                              

                                timer2.Enabled = true;
                                timer2.Start();
                                Primer = 1;
                            }
                        }
                    }
                    else if(Primer==1)
                    {
                        if (jug2.Gane)
                        {
                            if (jug3.Gane)
                            {
                                SeAcabo3 = true;
                            }
                            else
                            {
                                if (jug.Gane)
                                {
                                    SeAcabo3 = true;
                                }
                                else
                                {
                                

                                    timer4.Enabled = true;
                                    timer4.Start();
                                    Primer = 0;
                                }
                            }
                        }
                        else
                        {
                            if (jug3.Gane)
                            {
                                if (jug.Gane)
                                {
                                    SeAcabo3 = true;
                                }
                                else
                                {
                                 

                                    timer3.Enabled = true;
                                    timer3.Start();
                                    Primer = 0;
                                }
                            }
                            else
                            {
                               

                                timer3.Enabled = true;
                                timer3.Start();
                                Primer = 2;
                            }
                        }
                    }
                    else if (Primer == 2)
                    {
                        if (jug3.Gane)
                        {
                            if (jug.Gane)
                            {
                                SeAcabo3 = true;
                            }
                            else
                            {
                                if (jug2.Gane)
                                {
                                    SeAcabo3 = true;
                                }
                                else
                                {
                                 

                                    timer2.Enabled = true;
                                    timer2.Start();
                                    Primer = 1;
                                }
                            }
                        }
                        else
                        {
                            if (jug.Gane)
                            {
                                if (jug2.Gane)
                                {
                                    SeAcabo3 = true;
                                }
                                else
                                {
                                  

                                    timer4.Enabled = true;
                                    timer4.Start();
                                    Primer = 1;
                                }
                            }
                            else
                            {
                             

                                timer4.Enabled = true;
                                timer4.Start();
                                Primer = 0;
                            }
                        }
                    }
                }
                #endregion
                #region Para 4 jugadores
                else if (cantJug == 4)
                {
                    if (Primer == 0)
                    {
                        if (jug.Gane)
                        {
                            if (jug2.Gane)
                            {
                                if (jug3.Gane)
                                {
                                    Seacabo4 = true;
                                }
                               else if (jug4.Gane)
                                {
                                    Seacabo4 = true;
                                }
                                else
                                {

                               

                                    timer4.Enabled = true;
                                    timer4.Start();
                                    Primer = 3;
                                }
                            }
                           else if (jug3.Gane)
                            {
                                if (jug4.Gane)
                                {
                                    Seacabo4 = true;
                                }
                                else
                                {
                                  

                                    timer3.Enabled = true;
                                    timer3.Start();
                                    Primer = 3;
                                }
                            }
                            else
                            {
                              

                                timer3.Enabled = true;
                                timer3.Start();
                                Primer = 2; 
                            }
                        }
                        else if (jug2.Gane)
                        {
                            if (jug3.Gane)
                            {
                                if (jug4.Gane)
                                {
                                    Seacabo4 = true;
                                }
                                else
                                {
                                 

                                    timer2.Enabled = true;
                                    timer2.Start();
                                    Primer = 3;
                                }
                            }
                            else
                            {
                             

                                timer2.Enabled = true;
                                timer2.Start();
                                Primer = 2;
                            }
                        }
                        else
                        {
                          

                            timer2.Enabled = true;
                            timer2.Start();
                            Primer = 1;
                        }
                    }
                   else if (Primer == 1)
                    {
                        if (jug2.Gane)
                        {
                            if (jug3.Gane)
                            {
                                if (jug4.Gane)
                                {
                                    Seacabo4 = true;
                                }
                                else if (jug.Gane)
                                {
                                    Seacabo4 = true;
                                }
                                else
                                {
                                    

                                    timer5.Enabled = true;
                                    timer5.Start();
                                    Primer = 0;
                                }
                            }  
                           else if (jug4.Gane)
                            {
                                if (jug.Gane)
                                {
                                    Seacabo4 = true;
                                }
                                else
                                {
                                  

                                    timer4.Enabled = true;
                                    timer4.Start();
                                    Primer = 0;
                                }
                            }
                            else
                            {
                            

                                timer4.Enabled = true;
                                timer4.Start();
                                Primer = 3;
                            }
                        }
                        else if (jug3.Gane)
                        {
                            if (jug4.Gane)
                            {
                                if (jug.Gane)
                                {
                                    Seacabo4 = true;
                                }
                                else
                                {
                                 

                                    timer3.Enabled = true;
                                    timer3.Start();
                                    Primer = 0;
                                }
                            }
                            else
                            {
                             

                                timer3.Enabled = true;
                                timer3.Start();
                                Primer = 3;
                            }
                        }
                        else
                        {
                          

                            timer3.Enabled = true;
                            timer3.Start();
                            Primer = 2;
                        }
                    }
                    else if (Primer == 2)
                    {
                        if (jug3.Gane)
                        {
                            if (jug4.Gane)
                            {
                                if (jug.Gane)
                                {
                                    Seacabo4 = true;
                                }
                                else if (jug2.Gane)
                                {
                                    Seacabo4 = true;
                                }
                                else
                                {
                            

                                    timer2.Enabled = true;
                                    timer2.Start();
                                    Primer = 1;
                                }
                            }
                            else if (jug.Gane)
                            {
                                if (jug2.Gane)
                                {
                                    Seacabo4 = true;
                                }
                                else
                                {
                                  

                                    timer5.Enabled = true;
                                    timer5.Start();
                                    Primer = 1;
                                }
                            }
                            else
                            {
                            

                                timer5.Enabled = true;
                                timer5.Start();
                                Primer = 0;
                            }
                        }
                        else if (jug4.Gane)
                        {
                            if (jug.Gane)
                            {
                                if (jug2.Gane)
                                {
                                    Seacabo4 = true;
                                }
                                else
                                {
                                  

                                    timer4.Enabled = true;
                                    timer4.Start();
                                    Primer = 1;
                                }
                            }
                            else
                            {
                              

                                timer4.Enabled = true;
                                timer4.Start();
                                Primer = 0;
                            }
                        }
                        else
                        {
                         

                            timer4.Enabled = true;
                            timer4.Start();
                            Primer = 3;
                        }
                    }
                    else if (Primer == 3)
                    {
                        if (jug4.Gane)
                        {
                            if (jug.Gane)
                            {
                                if (jug2.Gane)
                                {
                                    Seacabo4 = true;
                                }
                                else if (jug3.Gane)
                                {
                                    Seacabo4 = true;
                                }
                                else
                                {
                                 

                                    timer3.Enabled = true;
                                    timer3.Start();
                                    Primer = 2;
                                }
                            }
                            else if (jug2.Gane)
                            {
                                if (jug3.Gane)
                                {
                                    Seacabo4 = true;
                                }
                                else
                                {
                                   

                                    timer2.Enabled = true;
                                    timer2.Start();
                                    Primer = 2;
                                }
                            }
                            else
                            {
                            

                                timer2.Enabled = true;
                                timer2.Start();
                                Primer = 1;
                            }
                        }
                        else if (jug.Gane)
                        {
                            if (jug2.Gane)
                            {
                                if (jug3.Gane)
                                {
                                    Seacabo4 = true;
                                }
                                else
                                {
                                 

                                    timer5.Enabled = true;
                                    timer5.Start();
                                    Primer = 2;
                                }
                            }
                            else
                            {
                                timer5.Enabled = true;
                                timer5.Start();
                                Primer = 1;
                            }
                        }
                        else
                        {
                           

                            timer5.Enabled = true;
                            timer5.Start();
                            Primer = 0;
                        }
                    }
                }
                #endregion
            }
        }

        #endregion
        //Función para los poderes
        #region Desea usar su poder si o no?

        int sirena = 0;
        int fenix = 0;
        int trex = 0;
        int caballo = 0;


        public void DeseaUsar(ref Jugador pop)
        {
            DeseaUsarSuPoder desea = new DeseaUsarSuPoder();
            desea.imgJugador.BackgroundImage = pop.imagen;
            desea.lblTurno.Text += " " + pop.nombre;
            desea.lblPoder.Text += pop.Poder;
            if (pop.PoderUsado)
            {
                desea.lblDeseaUsar.Text = "Ya usaste tu poder";
                desea.btnNo.Visible = false;
                desea.btnSi.Text = "OK";




            }





            desea.ShowDialog();

            if (!pop.PoderUsado)
            {
                if (desea.cual == DialogResult.Yes)
                {
                    pop.PoderUsado = true;

                    if (pop is Sirena && pop.Gane == false)
                    {
                        if (sirena == 0)
                        {
                            pop.Puntaje += 1000;
                            sirena = 1;
                        }
                    }
                    else if (pop is Fenix && pop.Gane == false)
                    {
                        if (fenix == 0)
                        {
                            if (cantJug == 2)
                            {
                                Poder pod1 = new Poder("¿A cual jugador desea bajar su puntuación en 1000 puntos?", jug.nombre, jug2.nombre, "", "", jug.imagen, jug2.imagen, null, null);
                                pod1.ShowDialog();

                                if (pod1.CualFue == 1)
                                {
                                    jug.Puntaje -= 1000;
                                }
                                else if (pod1.CualFue == 2)
                                {
                                    jug2.Puntaje -= 1000;
                                }
                            }
                            else if (cantJug == 3)
                            {
                                Poder pod1 = new Poder("¿A cual jugador desea bajar su puntuación en 1000 puntos?", jug.nombre, jug2.nombre, jug3.nombre, "", jug.imagen, jug2.imagen, jug3.imagen, null);
                                pod1.ShowDialog();

                                if (pod1.CualFue == 1)
                                {
                                    jug.Puntaje -= 1000;
                                }
                                else if (pod1.CualFue == 2)
                                {
                                    jug2.Puntaje -= 1000;
                                }
                                else if (pod1.CualFue == 3)
                                {
                                    jug3.Puntaje -= 1000;
                                }
                            }
                            else if (cantJug == 4)
                            {
                                Poder pod1 = new Poder("¿A cual jugador desea bajar su puntuación en 1000 puntos?", jug.nombre, jug2.nombre, jug3.nombre, jug4.nombre, jug.imagen, jug2.imagen, jug3.imagen, jug4.imagen);
                                pod1.ShowDialog();

                                if (pod1.CualFue == 1)
                                {
                                    jug.Puntaje -= 1000;
                                }
                                else if (pod1.CualFue == 2)
                                {
                                    jug2.Puntaje -= 1000;
                                }
                                else if (pod1.CualFue == 3)
                                {
                                    jug3.Puntaje -= 1000;
                                }
                                else if (pod1.CualFue == 4)
                                {
                                    jug4.Puntaje -= 1000;
                                }
                            }
                            fenix = 1;
                        }
                    }
                    else if (pop is TRex && pop.Gane == false)
                    {
                        if (trex == 0)
                        {
                            if (cantJug == 2)
                            {
                                Poder pod1 = new Poder("¿A cual jugador desea enviar a la casilla de salida?", jug.nombre, jug2.nombre, "", "", jug.imagen, jug2.imagen, null, null);
                                pod1.ShowDialog();

                                if (pod1.CualFue == 1)
                                {
                                    jug.trex = true;
                                    colorTable1.Clear(x1, y1);
                                    colorTable1.Add(0, 0, Color.AliceBlue, jug.imagen);
                                }
                                else if (pod1.CualFue == 2)
                                {
                                    jug2.trex = true;
                                    colorTable1.Clear(x2, y2);
                                    colorTable1.Add(0, 0, Color.AntiqueWhite, jug2.imagen);
                                }
                            }
                            else if (cantJug == 3)
                            {
                                Poder pod1 = new Poder("¿A cual jugador desea enviar a la casilla de salida?", jug.nombre, jug2.nombre, jug3.nombre, "", jug.imagen, jug2.imagen, jug3.imagen, null);
                                pod1.ShowDialog();

                                if (pod1.CualFue == 1)
                                {
                                    jug.trex = true;
                                    colorTable1.Clear(x1, y1);
                                    colorTable1.Add(0, 0, Color.AliceBlue, jug.imagen);
                                }
                                else if (pod1.CualFue == 2)
                                {
                                    jug2.trex = true;
                                    colorTable1.Clear(x2, y2);
                                    colorTable1.Add(0, 0, Color.AliceBlue, jug2.imagen);
                                }
                                else if (pod1.CualFue == 3)
                                {
                                    jug3.trex = true;
                                    colorTable1.Clear(x3, y3);
                                    colorTable1.Add(0, 0, Color.AliceBlue, jug3.imagen);
                                }
                            }
                            else if (cantJug == 4)
                            {
                                Poder pod1 = new Poder("¿A cual jugador desea enviar a la casilla de salida?", jug.nombre, jug2.nombre, jug3.nombre, jug4.nombre, jug.imagen, jug2.imagen, jug3.imagen, jug4.imagen);
                                pod1.ShowDialog();

                                if (pod1.CualFue == 1)
                                {
                                    jug.trex = true;
                                    colorTable1.Clear(x1, y1);
                                    colorTable1.Add(0, 0, Color.AliceBlue, jug.imagen);
                                }
                                else if (pod1.CualFue == 2)
                                {
                                    jug2.trex = true;
                                    colorTable1.Clear(x2, y2);
                                    colorTable1.Add(0, 0, Color.AliceBlue, jug2.imagen);
                                }
                                else if (pod1.CualFue == 3)
                                {
                                    jug3.trex = true;
                                    colorTable1.Clear(x3, y3);
                                    colorTable1.Add(0, 0, Color.AliceBlue, jug3.imagen);
                                }
                                else if (pod1.CualFue == 4)
                                {
                                    jug4.trex = true;
                                    colorTable1.Clear(x4, y4);
                                    colorTable1.Add(0, 0, Color.AliceBlue, jug4.imagen);
                                }
                            }
                            trex = 1;
                        }
                    }
                    else if (pop is Pegaso && pop.Gane == false)
                    {
                        if (caballo == 0)
                        {
                            PoderDelPegaso((pop as Pegaso).PuntoX, (pop as Pegaso).PuntoY, (pop as Pegaso));
                            caballo = 1;
                        }
                    }

                }
            }
        }

        #endregion
        //Esto no sirvió
        #region No sirve
        private void timerDetenerElDado_Tick(object sender, EventArgs e)
        {

              /*      timerDado.Stop();
                    timerDado.Enabled = false;
                    lblSalida.Text = " " + (num + 1);
                    timerDetenerElDado.Stop();
                    timerDetenerElDado.Enabled = false;
                         // me falta que cuando alguien gane los demas se queden jugando y no se chive el juego


                    timer2.Start();
           
                
               */


               

            
        }
        





        public bool Ganar(int x, int y)
        {
            if (x == tab.fila - 1 && y == tab.columna - 1)
            {
                return true;
            }
            else return false;
        }
        #endregion
        //estas son las variables que me permiten quedarme con cada posicion de los jugadores depues q termino de jugar
        #region Variables Importantes
        int x1 = 0;
        int y1 = 0;
        int x2 = 0;
        int y2 = 0;
        int x3 = 0;
        int y3 = 0;
        int x4 = 0;
        int y4 = 0;
        #endregion
        // A partir de aquí empieza el timer de cada jugador el cual se activa dependiendo del jugador
        //  que está de turno en ese momento
        #region Jugador 1

        public void timer2_Tick(object sender, EventArgs e)
        {

         //   tab.RePintar();//Si hubiera una forma de decirle al tablero que repinte la casilla anterior nada más y no todo el tablero, se lleva demasiada memoria. solucionado
            if (JugSeCerro)
            {
                if(!jug.Retrocediendo)
                jug.Mover(timer2);
                else
                {
                    jug.Retroceder(timer2);


                    x1 = jug.PuntoX;
                    y1 = jug.PuntoY;

                    if (k == 0 || (x1 == 0&&y1==0))
                    {
                        jug.Retrocediendo = false;
                        btnTirar.Enabled = true;
                    }

                    w = 4;
                    
                }

                lblInformacion.Text = "Es el turno de " + jug.nombre + " \ny camina " + (num + 1) + " pasos,\nquedan " + Quedan + "\nTu puntaje es: " + jug.Puntaje;
                


                #region Bloque de código para repintar los jugadores cada vez que otro le pase x arriba
                //"Se debe conocer en todo momento lo que sucede con los jugadores"

                if (cantJug == 2 )
                {
                    if (!jug2.trex)//esto es para que no se pinte si el trex ya usó su poder
                    {
                        if (!jug2.Gane) 
                            colorTable1.Add(x2, y2, Color.AliceBlue, jug2.imagen);
                    }

                    /*
                     * Para que cuando el pegaso use su poder no se quede pintado en donde estaba
                     * debe de haber otra forma de que cuando los jugadores
                     * 
                     * 
                     * 
                     * 
                     * 
                     */


                }
                else if (cantJug == 3) 
                {
                    if (!jug2.trex)
                    {
                        if (!jug2.Gane)
                            colorTable1.Add(x2, y2, Color.AliceBlue, jug2.imagen);
                    }
                    if (!jug3.trex)
                    {
                        if (!jug3.Gane)
                            colorTable1.Add(x3, y3, Color.AntiqueWhite, jug3.imagen);
                    }
                }
                else if (cantJug == 4)
                {
                    if (!jug2.trex)
                    {
                        if (!jug2.Gane)
                            colorTable1.Add(x2, y2, Color.AliceBlue, jug2.imagen);
                    }
                    if (!jug3.trex)
                    {
                        if (!jug3.Gane)
                            colorTable1.Add(x3, y3, Color.AntiqueWhite, jug3.imagen);
                    }
                    if (!jug4.trex)
                    {
                        if (!jug4.Gane)
                            colorTable1.Add(x4, y4, Color.AntiqueWhite, jug4.imagen);
                    }
                }
                #endregion
                #region Bloque de codigo que me dice si ya ganó
                if (jug.PuntoX >= filas - 1 && jug.PuntoY >= columnas - 1)
                {

                  

                    timer2.Stop();
                    timer2.Enabled = false;

                    btnTirar.Enabled = true;
                    Quedan--;
                    jug.lugar = ++lugar;


                    w = jug.PararElTimer;
                    x1 = jug.PuntoX;
                    y1 = jug.PuntoY;
                    jug.Gane = true;


                    if (cantJug == 2)
                    {
                      
                        SeAcabo = true;//por ahora
                        JuegoTerminado2();
                    }
                    else if (cantJug == 3)
                    {
                        if (jug2.Gane)
                        {
                            SeAcabo3 = true;
                            JuegoTerminado3();
                        }
                        else if (jug3.Gane)
                        {
                            SeAcabo3 = true;
                            JuegoTerminado3();
                        }

                    }
                    else if (cantJug == 4)
                    {
                        if (jug2.Gane)
                        {
                            if (jug3.Gane)
                            {
                                Seacabo4 = true;
                                JuegoTerminado4();
                            }
                            else if (jug4.Gane)
                            {
                                Seacabo4 = true;
                                JuegoTerminado4();
                            }
                        }
                        else if (jug3.Gane)
                        {
                            if (jug4.Gane)
                            {
                                Seacabo4 = true;
                                JuegoTerminado4();
                            }
                        }
                    }

                }

                #endregion
                #region Bloque de codigo para evitar que siga caminando el tipo
                if (k == 0) {    //ya casiiii
                    if (tab.Matriz[jug.PuntoX, jug.PuntoY] is Fuego)
                    {

                        k = 7;
                        jug.Retrocediendo = true;
                        x1 = jug.PuntoX;
                        y1 = jug.PuntoY;
                        w = 4;

                    }
                  else  if (tab.Matriz[jug.PuntoX, jug.PuntoY] is Agua)
                    {
                        lblInformacion.Text += "\n caiste en Agua";
                        lblInformacion.Text += "\nTu puntaje es " + jug.Puntaje;
                        lblInformacion.Text += "\nAvanza 5 pasos";
                        k = 5;
                        x1 = jug.PuntoX;
                        y1 = jug.PuntoY;
                        agua.Play();
                    }
                    else
                    {
                        if (jug.Retrocediendo)
                        {
                            jug.Retrocediendo = false;//obviamente ya no tiene porque seguir retrocediendo
                        }

                        timer2.Stop();
                        timer2.Enabled = false;
                        w = 4;
                        x1 = jug.PuntoX;
                        y1 = jug.PuntoY;
                        if (x1 != filas && y1 != columnas)
                        {

                            colorTable1.Add(x1, y1, Color.AliceBlue, jug.imagen); //Esto es por si acaso cae en donde estaba algun jugador
                            DondeCai(x1, y1, jug);
                        }

                        btnTirar.Enabled = true;
                    }


                  
                }
                k--;
                #endregion


            }
        }
        #endregion
        #region Jugador 2
        private void timer3_Tick(object sender, EventArgs e)
        {
            if (JugSeCerro)
            {
                if (!jug2.Retrocediendo)
                    jug2.Mover(timer3);
                else
                {
                    jug2.Retroceder(timer3);
                    x2 = jug2.PuntoX;
                    y2 = jug2.PuntoY;
                    if (k == 0 || (x2 == 0 && y2 == 0))
                    {
                        jug2.Retrocediendo = false;

                        btnTirar.Enabled = true;
                    }
                    w = 4;

                }

                lblInformacion.Text = "Es el turno de " + jug2.nombre + "\n y camina " + (num + 1) + " pasos, \nquedan " + Quedan + "\nTu puntaje es: " + jug2.Puntaje;
              
               #region Bloque de código para repintar los jugadores cada vez que otro le pase x arriba
                //"Se debe conocer en todo momento lo que sucede con los jugadores"

               if (cantJug == 2)//Esto para que cuando le pase por arriba algun jugador no se borre el otro
                {
                    if (!jug.trex)
                    {
                        if (!jug.Gane)
                            colorTable1.Add(x1, y1, Color.AliceBlue, jug.imagen);
                    }
                }
                else if (cantJug == 3)
                {
                    if (!jug.trex)
                    {
                        if (!jug.Gane)
                            colorTable1.Add(x1, y1, Color.AliceBlue, jug.imagen);
                    }
                    if (!jug3.trex)
                    {
                        if (!jug3.Gane)
                            colorTable1.Add(x3, y3, Color.AntiqueWhite, jug3.imagen);
                    }
                }
                else if (cantJug == 4)
                {
                    if (!jug.trex)
                    {
                        if (!jug.Gane)
                            colorTable1.Add(x1, y1, Color.AliceBlue, jug.imagen);
                    }
                    if (!jug3.trex)
                    {
                        if (!jug3.Gane)
                            colorTable1.Add(x3, y3, Color.AntiqueWhite, jug3.imagen);
                    }
                    if (!jug4.trex)
                    {
                        if (!jug4.Gane)
                            colorTable1.Add(x4, y4, Color.AntiqueWhite, jug4.imagen);
                    }
                }
                #endregion
               #region Bloque de código para saber si ya ganó el tipo

               if (jug2.PuntoX >= filas - 1 && jug2.PuntoY >= columnas-1)
                {
                   


                    timer3.Stop();  //para cuando termine el turno
                    timer3.Enabled = false;

                    btnTirar.Enabled = true;
                    Quedan--;
                    jug2.lugar = ++lugar;//esto no funciona, mentira

                    w = jug2.PararElTimer; x2 = jug2.PuntoX;
                    y2 = jug2.PuntoY;
                    jug2.Gane = true;


                    if (cantJug == 2)
                    {

                        SeAcabo = true;
                        JuegoTerminado2();
                    }
                    else if (cantJug == 3)
                    {
                        if (jug.Gane)
                        {
             

                            SeAcabo3 = true;
                            JuegoTerminado3();
                        }
                        else if (jug3.Gane)
                        {
                            SeAcabo3 = true;
                            JuegoTerminado3();
                        }
                    }
                    else if (cantJug == 4)
                    {
                        if (jug3.Gane)
                        {
                            if (jug4.Gane)
                            {
                                Seacabo4 = true;
                                JuegoTerminado4();
                            }
                            else if (jug.Gane)
                            {
                                Seacabo4 = true;
                                JuegoTerminado4();
                            }
                        }
                        else if (jug4.Gane)
                        {
                            if (jug.Gane)
                            {
                                Seacabo4 = true;
                                JuegoTerminado4();
                            }
                        }
                    }


                }

               #endregion
               #region Bloque de código para que se detenga el tipo etcetera, etc zzzzz
               if (k == 0)
                {
                    if (tab.Matriz[jug2.PuntoX, jug2.PuntoY] is Fuego)
                    {
                        k = 7;
                        jug2.Retrocediendo = true;
                        x2 = jug2.PuntoX;
                        y2 = jug2.PuntoY;
                        w = 4;
                    }
                   else if (tab.Matriz[jug2.PuntoX, jug2.PuntoY] is Agua)
                    {
                        lblInformacion.Text += "\n caiste en Agua";
                        lblInformacion.Text += "\nTu puntaje es " + jug2.Puntaje;
                        lblInformacion.Text += "\nAvanza 5 pasos";
                        x2 = jug2.PuntoX;
                        y2 = jug2.PuntoY;
                        k = 5;
                        agua.Play();
                    }
                    else
                    {
                        if (jug2.Retrocediendo)
                        {
                            jug2.Retrocediendo = false;//obviamente ya no tiene porque seguir retrocediendo
                        }

                        timer3.Stop();  //para cuando termine el turno
                        timer3.Enabled = false;

                        w = 4;

                        x2 = jug2.PuntoX;
                        y2 = jug2.PuntoY;
                        if (x2 != filas && y2 != columnas)
                        {
                            colorTable1.Add(x2, y2, Color.AliceBlue, jug2.imagen); //Esto es por si acaso cae en donde estaba algun jugador
                            DondeCai(x2, y2, jug2);
                        }
                        btnTirar.Enabled = true;
                    }

                  
                }
                k--;
               #endregion


            }
        }
    
        int kip = 0;
       

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
         
          
           
         

        }
        #endregion
        #region Jugador 3
        private void timer4_Tick(object sender, EventArgs e)
        {
            if (JugSeCerro)
            {
                if (!jug3.Retrocediendo)
                    jug3.Mover(timer4);
                else
                {
                    jug3.Retroceder(timer4);
                    x3 = jug3.PuntoX;
                    y3 = jug3.PuntoY;
                    if (k == 0 || (x3 == 0 && y3 == 0))
                    {
                        jug3.Retrocediendo = false;

                        btnTirar.Enabled = true;
                    }
                    w = 4;

                }

                lblInformacion.Text = "Es el turno de " + jug3.nombre + "\n y camina " + (num + 1) + " pasos,\n quedan " + Quedan + "\nTu puntaje es: " + jug3.Puntaje;
               

                #region Bloque de código para repintar los jugadores cada vez que otro le pase x arriba
                //"Se debe conocer en todo momento lo que sucede con los jugadores"

                if (cantJug == 3)
                {
                    if (!jug.trex)
                    {
                        if (!jug.Gane)
                            colorTable1.Add(x1, y1, Color.AliceBlue, jug.imagen);
                    }
                    if (!jug2.trex)
                    {
                        if (!jug2.Gane)
                            colorTable1.Add(x2, y2, Color.AntiqueWhite, jug2.imagen);
                    }
                }
                else if (cantJug == 4)
                {
                    if (!jug.trex)
                    {
                        if (!jug.Gane)
                            colorTable1.Add(x1, y1, Color.AliceBlue, jug.imagen);
                    }
                    if (!jug2.trex)
                    {
                        if (!jug2.Gane)
                            colorTable1.Add(x2, y2, Color.AntiqueWhite, jug2.imagen);
                    }
                    if (!jug4.trex)
                    {
                        if (!jug4.Gane)
                            colorTable1.Add(x4, y4, Color.AntiqueWhite, jug4.imagen);
                    }
                }

                #endregion
                #region Bloque de código para saber si ya ganó el tipo y todo lo q eso significa
                if (jug3.PuntoX >= filas - 1 && jug3.PuntoY >= columnas - 1)
                {
                    timer4.Stop();
                    timer4.Enabled = false;

                    btnTirar.Enabled = true;
                    Quedan--;
                    jug3.lugar = ++lugar;



                    w = jug3.PararElTimer;
                    x3 = jug3.PuntoX;
                    y3 = jug3.PuntoY;
                    jug3.Gane = true;
                    if (cantJug == 3)
                    {
                        if (jug.Gane)
                        {

                            SeAcabo3 = true;
                            JuegoTerminado3();
                        }
                        else if (jug2.Gane)
                        {


                            SeAcabo3 = true;
                            JuegoTerminado3();
                        }
                    }
                    else if (cantJug == 4)
                    {
                        if (jug4.Gane)
                        {
                            if (jug.Gane)
                            {
                                Seacabo4 = true;
                                JuegoTerminado4();
                            }
                            else if (jug2.Gane)
                            {
                                Seacabo4 = true;
                                JuegoTerminado4();
                            }
                        }
                        else if (jug.Gane)
                        {
                            if (jug2.Gane)
                            {
                                Seacabo4 = true;
                                JuegoTerminado4();
                            }
                        }


                    }



                }
                #endregion
                #region Bloque de código para saber si ya debe detenerse el jugador
                if (k == 0)
                    {
                        if (tab.Matriz[jug3.PuntoX, jug3.PuntoY] is Fuego)
                        {
                            k = 7;
                            jug3.Retrocediendo = true;

                            x3 = jug3.PuntoX;
                            y3 = jug3.PuntoY;
                            w = 4;
                        }
                      else  if (tab.Matriz[jug3.PuntoX, jug3.PuntoY] is Agua)
                        {
                            lblInformacion.Text += "\n caiste en Agua";
                            lblInformacion.Text += "\nTu puntaje es " + jug3.Puntaje;
                            lblInformacion.Text += "\nAvanza 5 pasos";
                            k = 5;

                            x3 = jug3.PuntoX;
                            y3 = jug3.PuntoY;
                            agua.Play();
                        }
                        else
                        {
                          if (jug3.Retrocediendo)
                        {
                            jug3.Retrocediendo = false;//obviamente ya no tiene porque seguir retrocediendo
                        }

                            timer4.Stop();
                            timer4.Enabled = false;

                            x3 = jug3.PuntoX;
                            y3 = jug3.PuntoY;
                            if (x3 != filas && y3 != columnas)
                            {

                                colorTable1.Add(x3, y3, Color.AliceBlue, jug3.imagen);  //Esto es por si acaso cae en donde estaba algun jugador
                                DondeCai(x3, y3, jug3);
                            }

                            w = 4;

                            btnTirar.Enabled = true;
                        }


                   
                    }
                    k--;
                #endregion



            }
        }
        #endregion
        #region Jugador 4
        private void timer5_Tick(object sender, EventArgs e)
        {
            if (JugSeCerro)
            {
                if (!jug4.Retrocediendo)
                    jug4.Mover(timer5);
                else
                {
                    jug4.Retroceder(timer5);
                    x4 = jug4.PuntoX;
                    y4 = jug4.PuntoY;
                    if (k == 0 || (x4 == 0 && y4 == 0))
                    {
                        jug4.Retrocediendo = false;
                        btnTirar.Enabled = true;
                       
                    }
                    w = 4;

                }


                lblInformacion.Text = "Es el turno de " + jug4.nombre + "\n y camina " + (num + 1) + " pasos,\n quedan "+Quedan+"\nTu puntaje es: "+jug4.Puntaje;
             


                #region Bloque de código para repintar los jugadores cada vez que otro le pase x arriba
                //"Se debe conocer en todo momento lo que sucede con los jugadores"

                    if (cantJug == 4)
                    {
                        if (!jug.trex)//me falta hacer esto para todo los demás jugadores
                        {
                            if (!jug.Gane)
                                colorTable1.Add(x1, y1, Color.AliceBlue, jug.imagen);
                        }
                        if (!jug3.trex)
                        {
                            if (!jug3.Gane)
                                colorTable1.Add(x3, y3, Color.AntiqueWhite, jug3.imagen);
                        }
                        if (!jug2.trex)
                        {
                            if (!jug2.Gane)
                                colorTable1.Add(x2, y2, Color.AntiqueWhite, jug2.imagen);
                        }
                    }
                #endregion
                #region Bloque de codigo para saber si ya gano el tipo
                    if (jug4.PuntoX >= filas - 1 && jug4.PuntoY >= columnas-1)
                    {
                        timer5.Enabled = false;
                        timer5.Stop();
                        btnTirar.Enabled = true;
                        Quedan--;
                        jug4.lugar = ++lugar;

                      
                        w = jug4.PararElTimer;
                        x4 = jug4.PuntoX;
                        y4 = jug4.PuntoY;
                        jug4.Gane = true;

                     
                       if (cantJug == 4)
                    {
                        if (jug.Gane)
                        {
                            if (jug2.Gane)
                            {
                                Seacabo4 = true;
                                JuegoTerminado4();
                            }
                            else if (jug3.Gane)
                            {
                                Seacabo4 = true;
                                JuegoTerminado4();
                            }
                        }
                        else if (jug2.Gane)
                        {
                            if (jug3.Gane)
                            {
                                Seacabo4 = true;
                                JuegoTerminado4();
                            }
                        }


                    }


                    }
                    #endregion
                #region Bloque de codigo para saber si ya debe detenerse el tipo (entre otra cosas más)
                    if (k == 0)
                {

                    if (tab.Matriz[jug4.PuntoX, jug4.PuntoY] is Fuego)
                    {
                        k = 7;
                        jug4.Retrocediendo = true;
                        x4 = jug4.PuntoX;
                        y4 = jug4.PuntoY;
                        w = 4;
                    }
                   else if (tab.Matriz[jug4.PuntoX, jug4.PuntoY] is Agua)
                    {
                        lblInformacion.Text += "\n caiste en Agua";
                        lblInformacion.Text += "\nTu puntaje es " + jug4.Puntaje;
                        lblInformacion.Text += "\nAvanza 5 pasos";
                        k = 5;
                        x4 = jug4.PuntoX;
                        y4 = jug4.PuntoY;
                        agua.Play();
                    }
                    else
                    {
                        if (jug4.Retrocediendo)
                        {
                            jug4.Retrocediendo = false;//obviamente ya no tiene porque seguir retrocediendo
                        }

                        timer5.Enabled = false;
                        timer5.Stop();



                        x4 = jug4.PuntoX;
                        y4 = jug4.PuntoY;
                        if (x4 != filas && y4 != columnas)
                        {

                            colorTable1.Add(x4, y4, Color.AliceBlue, jug4.imagen); //Esto es por si acaso cae en donde estaba algun jugador
                            DondeCai(x4, y4, jug4);

                        }

                        w = 4;
                        btnTirar.Enabled = true;
                    }

                
                }
                k--;
                    #endregion


            }
        }
        #endregion
        //Esta funcion le indica al label lblInformacion todo lo que hay que saber de cada jugador en cada momento del juego
        #region DondeCai

        public void DondeCai(int i, int j, Jugador pop)
        {


            if (tab.Matriz[i, j] is Rafaga)
            {
                lblInformacion.Text += "\n caiste en Ráfaga";


                if (pop is TRex)
                {
                    MessageBox.Show("La Ráfaga no tiene ningun efecto\nsobre el jugador TRex\n"+pop.nombre +" Tu puntuación es "+pop.Puntaje+" puntos");
                }
                else
                {
                    lblInformacion.Text += "\nTu puntuación AUMENTA\nen 500 puntos";
                    pop.Puntaje += 500;
                    tab.Matriz[i, j] = null;
                }
              
                lblInformacion.Text += "\nTu nuevo puntaje es:\n "+pop.Puntaje;
                
                rafaga.Play();
          
            }
            else if (tab.Matriz[i, j] is Agua)
            {
                lblInformacion.Text += "\n caiste en Agua";
                lblInformacion.Text += "\nTu puntaje es " + pop.Puntaje;
                lblInformacion.Text += "\nAvanza 5 pasos";

            }
            else if (tab.Matriz[i, j] is Fuego)
            {
                lblInformacion.Text += "\n caiste en Fuego";
                lblInformacion.Text += "\nTu puntaje es " + pop.Puntaje;
                lblInformacion.Text += "\nRetrocede 7 pasos";
              
                fuego.Play();
            }
            else if (tab.Matriz[i, j] is Nautilus)
            {
                lblInformacion.Text += "\n caiste en Nautilus";
                if (pop is Pegaso)
                {
                    MessageBox.Show("El Caballo es inmune al obstáculo Nautilus\n" + pop.nombre + " Tu puntuación es " + pop.Puntaje + " puntos");
                }
                else
                {
                    lblInformacion.Text += "\ntu puntuación\n DISMINUYE en:\n500 puntos";
                    pop.Puntaje -= 500;
                    tab.Matriz[i, j] = null;
                }
                lblInformacion.Text += "\nTu nuevo puntaje es:\n " + pop.Puntaje;
              
                nautilus.Play();
            }
            else if (tab.Matriz[i, j] is Tornado)
            {
                lblInformacion.Text += "\n caiste en Tornado";

                if(pop is Sirena)
                {
                    MessageBox.Show("El Tornado no tiene ningun efecto\nsobre el jugador Sirena\n" + pop.nombre + " Tu puntuación es " + pop.Puntaje+ " puntos");
                }
                else
                {
                    lblInformacion.Text += "\nTu puntuación AUMENTA\nen 1000 puntos";
                    pop.Puntaje += 1000;
                    tab.Matriz[i, j] = null;
                }
              
                lblInformacion.Text += "\nTu nuevo puntaje es:\n " + pop.Puntaje;
              
                tornado.Play();
            }
            else if (tab.Matriz[i, j] is Cristal)
            {
                lblInformacion.Text += "\n caiste en Cristal\ntu puntuación AUMENTA en:\n2000 puntos";
                lblInformacion.Text += "\nTu puntaje es " + pop.Puntaje;
                pop.Puntaje += 2000;
                lblInformacion.Text += "\nTu nuevo puntaje es:\n " + pop.Puntaje;
            
                cristal.Play();
            }
            else if (tab.Matriz[i, j] is Tierra)
            {
                lblInformacion.Text += "\n caiste en Tierra";
                if (pop is Fenix)
                {
                    MessageBox.Show("El Fenix es inmune al obstáculo Tierra\n" + pop.nombre + " Tu puntuación es " + pop.Puntaje + " puntos");
                }
                else
                {
                    lblInformacion.Text += "\n tu puntuación\n DISMINUYE en:\n 1000 puntos";
                    pop.Puntaje -= 1000;
                    tab.Matriz[i, j] = null;

                }
                lblInformacion.Text += "\nTu nuevo puntaje es:\n " + pop.Puntaje;
                
                tierra.Play();
            }
           

        }
        int pop = 0;
        #endregion
        //Esta region checkea si ya se acabó el juego en dependencia para cada jugador
        #region Checkeador

        public Jugador[] Para2jugadores = new Jugador[2];
        public Jugador[] Para3jugadores = new Jugador[3];
        public Jugador[] Para4jugadores = new Jugador[4];

        void InicializarLugadores()
        {
            if (cantJug == 2)
            {
                Para2jugadores[0] = jug;
                Para2jugadores[1] = jug2;
            }
            else if (cantJug == 3)
            {
                Para3jugadores[0] = jug;
                Para3jugadores[1] = jug2;
                Para3jugadores[2] = jug3;
            }
            else if (cantJug == 4)
            {
                Para4jugadores[0] = jug;
                Para4jugadores[1] = jug2;
                Para4jugadores[2] = jug3;
                Para4jugadores[3] = jug4;
            }
        }

        public void JuegoTerminado2()
        {
            if (SeAcabo)
            {
                if (pop == 0)
                {

                    InicializarLugadores();


                    if (jug.lugar == 1)
                    {
                        Para2jugadores[0].Puntaje += 1000;
                        Para2jugadores[1].Puntaje += 500;
                    }
                    else if (jug2.lugar == 1)
                    {
                        Para2jugadores[0].Puntaje += 500;
                        Para2jugadores[1].Puntaje += 1000;
                    }



                    Array.Sort(Para2jugadores);



                    pop = 1;
                    Checkeador.Enabled = false;
                    Checkeador.Stop();
                    this.Visible = false;




                    aplausos.Play();




                    jug.PuntoX = 0; jug.PuntoY = 0;
                    jug2.PuntoX = 0; jug2.PuntoY = 0;



                    timerdeLamuerte.Enabled = false;
                    Close();
                }
            }
        }

        public void JuegoTerminado3()
        {
            if (SeAcabo3)
            {
                if (pop == 0)
                {


                    InicializarLugadores();

                    if (jug.lugar == 1)   //Esto es para otorgar los puntos de acuerdo a quien llega primero, se entiende (por ahi)
                    {
                        Para3jugadores[0].Puntaje += 1000;

                        if (jug2.lugar == 2)
                        {
                            Para3jugadores[1].Puntaje += 500;
                            Para3jugadores[2].Puntaje += 250;
                        }
                        else if (jug3.lugar == 2)
                        {
                            Para3jugadores[2].Puntaje += 500;
                            Para3jugadores[1].Puntaje += 250;
                        }
                    }
                    else if (jug2.lugar == 1)
                    {
                        Para3jugadores[1].Puntaje += 1000;

                        if (jug.lugar == 2)
                        {
                            Para3jugadores[0].Puntaje += 500;
                            Para3jugadores[2].Puntaje += 250;
                        }
                        else if (jug3.lugar == 2)
                        {
                            Para3jugadores[2].Puntaje += 500;
                            Para3jugadores[0].Puntaje += 250;
                        }
                    }
                    else if (jug3.lugar == 1)
                    {
                        Para3jugadores[2].Puntaje += 1000;

                        if (jug2.lugar == 2)
                        {
                            Para3jugadores[1].Puntaje += 500;
                            Para3jugadores[0].Puntaje += 250;
                        }
                        else if (jug.lugar == 2)
                        {
                            Para3jugadores[0].Puntaje += 500;
                            Para3jugadores[1].Puntaje += 250;
                        }
                    }


                    Array.Sort(Para3jugadores);

                    pop = 1;
                    Checkeador.Enabled = false;
                    Checkeador.Stop();
                    this.Visible = false;

                    aplausos.Play();



                    jug.PuntoX = 0; jug.PuntoY = 0;
                    jug2.PuntoX = 0; jug2.PuntoY = 0;
                    jug3.PuntoX = 0; jug3.PuntoY = 0;

                    timerdeLamuerte.Enabled = false;
                    Close();

                }
            }
        }

        public void JuegoTerminado4()
        {
            if (Seacabo4)
            {
                if (pop == 0)
                {

                    InicializarLugadores();

                    #region Aqui se otorgan las puntuaciones
                    if (jug.lugar == 1)
                    {
                        Para4jugadores[0].Puntaje += 1000;

                        if (jug2.lugar == 2)
                        {
                            Para4jugadores[1].Puntaje += 500;
                            if (jug3.lugar == 3)
                            {
                                Para4jugadores[2].Puntaje += 250;
                            }
                            else
                            {
                                Para4jugadores[3].Puntaje += 250;
                            }
                        }
                        else if (jug3.lugar == 2)
                        {
                            Para4jugadores[2].Puntaje += 500;
                            if (jug2.lugar == 3)
                            {
                                Para4jugadores[1].Puntaje += 250;
                            }
                            else
                            {
                                Para4jugadores[3].Puntaje += 250;
                            }
                        }
                        else if (jug4.lugar == 2)
                        {
                            Para4jugadores[3].Puntaje += 500;
                            if (jug2.lugar == 3)
                            {
                                Para4jugadores[1].Puntaje += 250;
                            }
                            else
                            {
                                Para4jugadores[2].Puntaje += 250;
                            }
                        }
                    }
                    else if (jug2.lugar == 1)
                    {
                        Para4jugadores[1].Puntaje += 1000;

                        if (jug3.lugar == 2)
                        {
                            Para4jugadores[2].Puntaje += 500;
                            if (jug4.lugar == 3)
                            {
                                Para4jugadores[3].Puntaje += 250;
                            }
                            else
                            {
                                Para4jugadores[0].Puntaje += 250;
                            }
                        }
                        else if (jug4.lugar == 2)
                        {
                            Para4jugadores[3].Puntaje += 500;
                            if (jug3.lugar == 3)
                            {
                                Para4jugadores[2].Puntaje += 250;
                            }
                            else
                            {
                                Para4jugadores[0].Puntaje += 250;
                            }
                        }
                        else if (jug.lugar == 2)
                        {
                            Para4jugadores[0].Puntaje += 500;
                            if (jug3.lugar == 3)
                            {
                                Para4jugadores[2].Puntaje += 250;
                            }
                            else
                            {
                                Para4jugadores[3].Puntaje += 250;
                            }
                        }
                    }
                    else if (jug3.lugar == 1)
                    {
                        Para4jugadores[2].Puntaje += 1000;

                        if (jug4.lugar == 2)
                        {
                            Para4jugadores[3].Puntaje += 500;
                            if (jug.lugar == 3)
                            {
                                Para4jugadores[0].Puntaje += 250;
                            }
                            else
                            {
                                Para4jugadores[1].Puntaje += 250;
                            }
                        }
                        else if (jug.lugar == 2)
                        {
                            Para4jugadores[0].Puntaje += 500;
                            if (jug4.lugar == 3)
                            {
                                Para4jugadores[3].Puntaje += 250;
                            }
                            else
                            {
                                Para4jugadores[1].Puntaje += 250;
                            }
                        }
                        else if (jug2.lugar == 2)
                        {
                            Para4jugadores[1].Puntaje += 500;
                            if (jug4.lugar == 3)
                            {
                                Para4jugadores[3].Puntaje += 250;
                            }
                            else
                            {
                                Para4jugadores[0].Puntaje += 250;
                            }
                        }
                    }
                    else if (jug4.lugar == 1)
                    {
                        Para4jugadores[3].Puntaje += 1000;

                        if (jug.lugar == 2)
                        {
                            Para4jugadores[0].Puntaje += 500;
                            if (jug2.lugar == 3)
                            {
                                Para4jugadores[1].Puntaje += 250;
                            }
                            else
                            {
                                Para4jugadores[2].Puntaje += 250;
                            }
                        }
                        else if (jug2.lugar == 2)
                        {
                            Para4jugadores[1].Puntaje += 500;
                            if (jug.lugar == 3)
                            {
                                Para4jugadores[0].Puntaje += 250;
                            }
                            else
                            {
                                Para4jugadores[2].Puntaje += 250;
                            }
                        }
                        else if (jug3.lugar == 2)
                        {
                            Para4jugadores[2].Puntaje += 500;
                            if (jug.lugar == 3)
                            {
                                Para4jugadores[0].Puntaje += 250;
                            }
                            else
                            {
                                Para4jugadores[1].Puntaje += 250;
                            }
                        }
                    }


                    #endregion







                    Array.Sort(Para4jugadores);

                    pop = 1;
                    Checkeador.Enabled = false;
                    Checkeador.Stop();
                    this.Visible = false;








                    aplausos.Play();




                    jug.PuntoX = 0; jug.PuntoY = 0;
                    jug2.PuntoX = 0; jug2.PuntoY = 0;
                    jug3.PuntoX = 0; jug3.PuntoY = 0;
                    jug4.PuntoX = 0; jug4.PuntoY = 0;

                    timerdeLamuerte.Enabled = false;

                    Close();
                }
            }
        }
     
        #endregion
        #region Aquí vemos si desea usar el poder de acuerdo con el jugador que esté de turno

        void Help()
        {
            if (cantJug == 2)
            {
                if (Primer == 1)
                {
                    DeseaUsar(ref jug);
                }
                else if (Primer == 0)
                {
                    DeseaUsar(ref jug2);
                }
            }
            else if (cantJug == 3)
            {
                if (Primer == 1)
                {
                    DeseaUsar(ref jug);
                }
                else if (Primer == 2)
                {
                    DeseaUsar(ref jug2);
                }
                else if (Primer == 0)
                {
                    DeseaUsar(ref jug3);
                }
            }
            else if (cantJug == 4)
            {
                if (Primer == 0)
                {
                    DeseaUsar(ref jug4);
                }
                else if (Primer == 1)
                {
                    DeseaUsar(ref jug);
                }
                else if (Primer == 2)
                {
                    DeseaUsar(ref jug2);
                }
                else if (Primer == 3)
                {
                    DeseaUsar(ref jug3);
                }
            }
        }

        private void btnUsarPoder_Click(object sender, EventArgs e)
        {
            if (cantJug==2)
            {
                if(jug.Gane || jug2.Gane)
                MessageBox.Show("Ya no puedes usar tu poder porque ya un jugador ganó");
                else
                {
                    Help();
                }
            }
            else if (cantJug == 3)
            {
                if (jug.Gane || jug2.Gane || jug3.Gane)
                    MessageBox.Show("Ya no puedes usar tu poder porque ya un jugador ganó");
                else
                {
                    Help();
                }
            }
            else if(cantJug == 4)
            {
                if (jug.Gane || jug2.Gane || jug3.Gane || jug4.Gane)
                    MessageBox.Show("Ya no puedes usar tu poder porque ya un jugador ganó");
                else
                {
                    Help();
                }  
            }
        }

        #endregion
        //Este algoritmo está MUY bueno (e interesante también (me tomo un pokito hacerlo)) para recorrer la matriz como mismo caminan
        //  los jugadores (el de abajo)
        #region Poder del Jugador Pegaso
        public void PoderDelPegaso(int x, int y, Pegaso pop)
        {


            bool entre = false;
            bool entre2 = false;
            int j, k;

            for (int i = y; i <= columnas - 1 && !pop.encontre; i++)
            {
                if (i % 2 == 0)
                {
                    if (entre || entre2)
                    {
                        j = 0;
                    }
                    else
                    {
                        j = x;
                    }
                    for (; j <= filas - 1 && !pop.encontre; j++)
                    {
                        entre = true;
                        if (tab.Matriz[j, i] is Tornado)
                        {

                            pop.encontre = true;
                            colorTable1.Clear(x, y);
                            pop.nuevaX = j;
                            pop.nuevaY = i;
                            colorTable1.Add(j, i, Color.AliceBlue, new Bitmap("ahora.png"));
                         
                         //esto es unua prueba q funcionó siii

                            if (pop == jug)
                            {
                                x1 = j; y1 = i;
                            }
                            else if (pop == jug2)
                            {
                                x2 = j; y2 = i;
                            }
                            else if (pop == jug3)
                            {
                                x3 = j; y3 = i;
                            }
                            else if (pop == jug4)
                            {
                                x4 = j; y4 = i;
                            }

                        }
                    }
                }
                else
                {
                    if (entre2 || entre)
                    {
                        k = filas - 1;
                    }
                    else
                    {
                        k = x;
                    }

                    for (; k >= 0 && !pop.encontre ; k--)
                    {
                        entre2 = true;
                        if (tab.Matriz[k, i] is Tornado)
                        {
                            colorTable1.Clear(x, y);
                            pop.encontre = true;
                            pop.nuevaX = k;
                            pop.nuevaY = i;
                            colorTable1.Add(k, i, Color.AliceBlue, new Bitmap("ahora.png"));

                            //esto es una prueba q funciona por cierto
                            if (pop==jug)
                            {
                                x1 = k; y1 = i;
                            }
                            else if (pop == jug2)
                            {
                                x2 = k; y2 = i;
                            }
                            else if (pop == jug3)
                            {
                                x3 = k; y3 = i;
                            }
                            else if(pop==jug4)
                            {
                            x4 = k; y4 = i;
                            }


                        }
                    }
                }
            }
        }

        #endregion
        private void VolverAlMenu_Tick(object sender, EventArgs e)
        {

        }
        #region La muerte 

      
        private void timerdeLamuerte_Tick(object sender, EventArgs e)
        {
            muerte.Moverse();


            #region Con este simple bloque de cógigo matamos a los jugadores (q macabro sonó eso)
            if (cantJug == 2)
            {
                if (muerte.Punto.X == jug.PuntoX && muerte.Punto.Y == jug.PuntoY)
                {
                    lblInformacion.Text = "NOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO";

                    jug.Murio = true;
                    muerte.Mato = true;

                    jug.PuntoX = 0;
                    jug.PuntoY = 0;
                    x1 = 0;
                    y1 = 0;
                    colorTable1.Add(jug.PuntoX, jug.PuntoY, Color.AliceBlue, jug.imagen);
                }
                else if (muerte.Punto.X == jug2.PuntoX && muerte.Punto.Y == jug2.PuntoY)
                {
                    lblInformacion.Text = "NOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO";

                    jug2.Murio = true;
                    muerte.Mato = true;
                   
                    jug2.PuntoX = 0;
                    jug2.PuntoY = 0;
                    x2 = 0;
                    y2 = 0;
                    colorTable1.Add(jug2.PuntoX, jug2.PuntoY, Color.AliceBlue, jug2.imagen);
                }

            }
            else if (cantJug == 3)
            {
                if (muerte.Punto.X == jug.PuntoX && muerte.Punto.Y == jug.PuntoY)
                {
                    lblInformacion.Text = "NOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO";

                    jug.Murio = true;
                    muerte.Mato = true;

                    jug.PuntoX = 0;
                    jug.PuntoY = 0;
                    x1 = 0;
                    y1 = 0;
                    colorTable1.Add(jug.PuntoX, jug.PuntoY, Color.AliceBlue, jug.imagen);
                }
                else if (muerte.Punto.X == jug2.PuntoX && muerte.Punto.Y == jug2.PuntoY)
                {
                    lblInformacion.Text = "NOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO";

                    jug2.Murio = true;
                    muerte.Mato = true;

                    jug2.PuntoX = 0;
                    jug2.PuntoY = 0;
                    x2 = 0;
                    y2 = 0;
                    colorTable1.Add(jug2.PuntoX, jug2.PuntoY, Color.AliceBlue, jug2.imagen);
                }
                else if (muerte.Punto.X == jug3.PuntoX && muerte.Punto.Y == jug3.PuntoY)
                {
                    lblInformacion.Text = "NOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO";

                    jug3.Murio = true;
                    muerte.Mato = true;

                    jug3.PuntoX = 0;
                    jug3.PuntoY = 0;
                    x3 = 0;
                    y3 = 0;
                    colorTable1.Add(jug3.PuntoX, jug3.PuntoY, Color.AliceBlue, jug3.imagen);
                }
            }
            else if (cantJug == 4)
            {
                if (muerte.Punto.X == jug.PuntoX && muerte.Punto.Y == jug.PuntoY)
                {
                    lblInformacion.Text = "NOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO";
                
                    jug.PuntoX = 0;
                    jug.Murio = true;
                    muerte.Mato = true;

                    jug.PuntoY = 0;
                    x1 = 0;
                    y1 = 0;
                    colorTable1.Add(jug.PuntoX, jug.PuntoY, Color.AliceBlue, jug.imagen);
                }
                else if (muerte.Punto.X == jug2.PuntoX && muerte.Punto.Y == jug2.PuntoY)
                {
                    lblInformacion.Text = "NOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO";

                    jug2.Murio = true;
                    muerte.Mato = true;

                    jug2.PuntoX = 0;
                    jug2.PuntoY = 0;
                    x2 = 0;
                    y2 = 0;
                    colorTable1.Add(jug2.PuntoX, jug2.PuntoY, Color.AliceBlue, jug2.imagen);
                }
                else if (muerte.Punto.X == jug3.PuntoX && muerte.Punto.Y == jug3.PuntoY)
                {
                    lblInformacion.Text = "NOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO";

                    jug3.Murio = true;
                    muerte.Mato = true;

                    jug3.PuntoX = 0;
                    jug3.PuntoY = 0;
                    x3 = 0;
                    y3 = 0;
                    colorTable1.Add(jug3.PuntoX, jug3.PuntoY, Color.AliceBlue, jug3.imagen);
                }
                else if (muerte.Punto.X == jug4.PuntoX && muerte.Punto.Y == jug4.PuntoY)
                {
                    lblInformacion.Text = "NOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO";

                    jug4.Murio = true;
                    muerte.Mato = true;

                    jug4.PuntoX = 0;
                    jug4.PuntoY = 0;
                    x4 = 0;
                    y4 = 0;
                    colorTable1.Add(jug4.PuntoX, jug4.PuntoY, Color.AliceBlue, jug4.imagen);
                }
            }

            #endregion
        }
        #endregion

        private void colorTable1_Paint(object sender, PaintEventArgs e)
        {

        }

        //Para Guardar el juego
        #region Guardar el juego
        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string temp = saveFileDialog1.FileName;

            saveFileDialog1.AddExtension = true;
            saveFileDialog1.DefaultExt = "koe";
            saveFileDialog1.CreatePrompt = true;
            StreamWriter a = new StreamWriter(temp, false);

            a.WriteLine(cantJug);
            a.WriteLine(filas);
            a.WriteLine(columnas);
            a.WriteLine(CualEs);

            for (int i = 0; i < filas; i++)
            {
                for (int k = 0; k < columnas; k++)
                {
                    a.WriteLine(tab.Matriz[i, k]);
                }
            }
           

            if (cantJug == 2)
            {
                a.WriteLine(jug);
                    a.WriteLine(x1);
                    a.WriteLine(y1);
                    a.WriteLine(jug.Puntaje);
                    a.WriteLine(jug.PoderUsado);
                    a.WriteLine(jug.nombre);
                    a.WriteLine(jug.Gane);

                    a.WriteLine(jug2);
                a.WriteLine(x2);
                a.WriteLine(y2);
                a.WriteLine(jug2.Puntaje);
                a.WriteLine(jug2.PoderUsado);
                a.WriteLine(jug2.nombre);
                a.WriteLine(jug2.Gane);
                a.WriteLine(Primer);

            }
            else if (cantJug == 3)
            {
                a.WriteLine(jug);
                a.WriteLine(x1);
                a.WriteLine(y1);
                a.WriteLine(jug.Puntaje);
                a.WriteLine(jug.PoderUsado);
                a.WriteLine(jug.nombre);
                a.WriteLine(jug.Gane);

                a.WriteLine(jug2);
                a.WriteLine(x2);
                a.WriteLine(y2);
                a.WriteLine(jug2.Puntaje);
                a.WriteLine(jug2.PoderUsado);
                a.WriteLine(jug2.nombre);
                a.WriteLine(jug2.Gane);

                a.WriteLine(jug3);
                a.WriteLine(x3);
                a.WriteLine(y3);
                a.WriteLine(jug3.Puntaje);
                a.WriteLine(jug3.PoderUsado);
                a.WriteLine(jug3.nombre);
                a.WriteLine(jug3.Gane);

                a.WriteLine(Primer);
            }
            else if (cantJug == 4)
            {
                a.WriteLine(jug);
                a.WriteLine(x1);
                a.WriteLine(y1);
                a.WriteLine(jug.Puntaje);
                a.WriteLine(jug.PoderUsado);
                a.WriteLine(jug.nombre);
                a.WriteLine(jug.Gane);

                a.WriteLine(jug2);
                a.WriteLine(x2);
                a.WriteLine(y2);
                a.WriteLine(jug2.Puntaje);
                a.WriteLine(jug2.PoderUsado);
                a.WriteLine(jug2.nombre);
                a.WriteLine(jug2.Gane);

                a.WriteLine(jug3);
                a.WriteLine(x3);
                a.WriteLine(y3);
                a.WriteLine(jug3.Puntaje);
                a.WriteLine(jug3.PoderUsado);
                a.WriteLine(jug3.nombre);
                a.WriteLine(jug3.Gane);

                a.WriteLine(jug4);
                a.WriteLine(x4);
                a.WriteLine(y4);
                a.WriteLine(jug4.Puntaje);
                a.WriteLine(jug4.PoderUsado);
                a.WriteLine(jug4.nombre);
                a.WriteLine(jug4.Gane);

                a.WriteLine(Primer);
            }


            a.Close();

        }
        #endregion

    }
}
