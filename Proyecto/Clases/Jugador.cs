using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
namespace Proyecto.Clases
{
   public abstract class Jugador:Juego, IComparable, Retrocede
    {
       SoundPlayer camino = new SoundPlayer("Sonidos/Jugada.wav");

       public int lugar;
       int cantidadJugadores;
       public int ranking;

      public Tablero tablero;
      public Image imagen;
    
       Color color;
     public  string AdondeVoy;

     public string nombre;
     public int Puntaje;
     public bool Gane = false;
     public bool PoderUsado = false;
     public bool trex = false;
     public bool muerte = false;
     public bool volvio = false;
    private Point punto;
     string poder;
     private bool murio;
     private bool Retrocediend;
       public Jugador(Tablero t, Point p, Color c, Image d, string nombre):base(t,p,c,d)
       {
           lugar = 0;
           tablero = t;
         
           color = c;
           imagen = d;
           this.nombre = nombre;

           
           Puntaje = 1000;
       }
  public virtual bool Retrocediendo
  {
      get
      {
          return Retrocediend;
      }
      set
      {
          Retrocediend = value;
      }

   }
  public virtual bool Murio
  {
      get
      {
          return murio;
      }
      set
      {
          murio = value;
      }

  }

       public abstract void Retroceder(Timer t);

       public virtual string Poder
       {
           get
           {
               return poder;
           }
       }
       public virtual int PuntoX
       {
           get
           {
               return punto.X;
           }
           set
           {
               punto.X = value;
           }
       }
       public virtual int PuntoY
       {
           get
           {
               return punto.Y;
           }
           set
           {
               punto.Y = value;
           }
       }

       public void Gana(int x, int y)
       {
          // tablero.Matriz[x,y]
       }
       public bool SePuedeMover(int x, int y)
       {
           if (x >= 0 && y >= 0 && x < tablero.fila && y < tablero.columna)
               return true;
           else
               return false;
       }
       public void Inicial()
       {

       }   
      public int a = 0;
       public int PararElTimer = 4;
       public int CompareTo(object o)
       {
           Jugador otro = o as Jugador;

           if (otro.Puntaje.CompareTo(this.Puntaje) == 0)
           {
               return this.lugar.CompareTo(otro.lugar);
           }
               else
        return otro.Puntaje.CompareTo(this.Puntaje);



       }  
       int po = 0;
       int po1 = 0;
       public abstract void Mover(Timer t);
       
           /*if (po == 0)
           {
               if (trex)
               {
                   xx = 0;
                   yy = 0;
                   x = 0;
                   y = 0;
                   po = 1;
                   trex = false;
               }
           }
           if(volvio)
           {
               xx = 0;
               yy = 0;
               x = 0;
               y = 0;
               punto.X = xx;
               punto.Y = yy;
          
               volvio = false;
           }
        

               if (SePuedeMover(punto.X, punto.Y))
               {
                   if (xx < tablero.ColorTable1.TableWidth - 1 && x >= 0)
                   {
                       tablero.ColorTable1.Clear(xx, yy);
                       xx++;
                       tablero.ColorTable1.Add(xx, yy, Color.Beige, imagen);
                       camino.Play();
                       tablero.CualEs(xx - 1, yy);
                       xxx = xx;
                       xaux = xx;
                       yyy = yy;
                       dd++;
                       PuntoX = xx;
                       PuntoY = yy;
                       AdondeVoy = "Derecha";

                   }
                   else if (xx == tablero.ColorTable1.TableWidth - 1 && xxx > 0 )
                   {
                       tablero.ColorTable1.Clear(xxx, yyy);
                       if (xaux == tablero.ColorTable1.TableWidth - 1) { 
                           yyy++;
                           xaux--;
                           a = 1;
                       }
                       else { 
                           xxx--;
                           a = 2;
                       }
                       AdondeVoy = "Abajo";


                       if (yyy>=tablero.columna-1)
                       {

                           t.Enabled = false;
                           t.Stop();
                           Gane = true;
                       }

                       else
                       {

                           tablero.ColorTable1.Add(xxx, yyy, Color.Beige, imagen);
                           camino.Play();
                       }

                       if (a == 1) tablero.CualEs( xaux + 1, yyy - 1);
                       else if (a == 2) tablero.CualEs(xxx + 1, yyy);

                       dd++;

                       PuntoX = xxx;
                       PuntoY = yyy;
                       AdondeVoy = "Izquierda";

                   }
                   else
                   {
                       tablero.ColorTable1.Clear(xxx, yyy);
                       xx = 0;
                       yy = yyy + 1;
                       AdondeVoy = "Abajo";
                       tablero.ColorTable1.Add(xx, yy, Color.Beige, imagen);
                       camino.Play();
                       tablero.CualEs(xx, yy - 1);
                       PuntoX = xx;
                       PuntoY = yy;
                       dd++;
                   }
                  
               }
           
          


           */
       public int Llegue(int d)
       {
           int a = (tablero.ColorTable1.Width) * tablero.ColorTable1.Height;

           if (d < a) return 1;
           else if (d == a)
               return 2;
           else
               return 3;

       }

      

    }
}
