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
   public  class Sirena:Jugador
    {
       public string poder = "Aumentar tu puntuación\nen 1000 puntos";
       Image f; SoundPlayer camino = new SoundPlayer("Sonidos/Jugada.wav");



       public Point punto;
       int xx;
       int yy;
       int x, y;
      private bool Retrocediend = false;
      public bool murio = false;
       public Sirena(Tablero t, Point p, Color c, Image d, string nombre, string fondo)
           : base(t, p, c, d, nombre)
       {

           punto = p;
           xx = punto.X;
           yy = punto.Y;



           x = punto.X;
           y = punto.Y;

           if (fondo == "Mar")
           {
               base.Puntaje += 2000;
           }
       }

       public override bool Retrocediendo
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

       public override bool Murio
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

   

       int po = 0;

    



       public override void Retroceder(Timer t)
       {
           Retrocediendo = true;
           if (punto.Y % 2 == 0)
           {
               if (punto.X == 0)
               {
                   tablero.ColorTable1.Clear(punto.X, punto.Y);

                   punto.Y--;
                   if (punto.Y < 0)//esto fue porque a veces cuando esta retrocediendo y la muerte le dio me daba error
                  {
                      punto.Y = 0;
                  }
                       tablero.ColorTable1.Add(punto.X, punto.Y, Color.AliceBlue, imagen);
                       tablero.CualEs(punto.X, punto.Y + 1);
                   
                   camino.Play();
               }
               else
               {
                   tablero.ColorTable1.Clear(punto.X, punto.Y);
                   punto.X--;
                   tablero.ColorTable1.Add(punto.X, punto.Y, Color.AliceBlue, imagen);
                   tablero.CualEs(punto.X + 1, punto.Y);
                   camino.Play();
               }
           }
           else
           {
               if (punto.X == tablero.ColorTable1.TableWidth - 1)
               {
                   tablero.ColorTable1.Clear(punto.X, punto.Y);
                   punto.Y--;
                   tablero.ColorTable1.Add(punto.X, punto.Y, Color.AliceBlue, imagen);
                   tablero.CualEs(punto.X, punto.Y + 1);
                   camino.Play();
               }
               else
               {
                   tablero.ColorTable1.Clear(punto.X, punto.Y);
                   punto.X++;
                   tablero.ColorTable1.Add(punto.X, punto.Y, Color.AliceBlue, imagen);
                   tablero.CualEs(punto.X - 1, punto.Y);
                   camino.Play();
               }
           }

           if (punto.X == 0 && punto.Y == 0)
           {
               t.Enabled = false;
               t.Stop();
           }
       }

   //Wow mucho más elegante, más organizado y muchisimo más sencillo
            public override void Mover(Timer t)
      {
          if (po == 0)
          {
              if (trex)
              {
                  punto.X = 0;
                  punto.Y = 0;
                  po = 1;
                  trex = false;
              }
          }
          if (volvio)
          {
              punto.X = 0;
              punto.Y = 0;
             

              volvio = false;
          }

        
          

          if (punto.Y % 2 == 0)
          {
              if (punto.X == tablero.ColorTable1.TableWidth - 1)
              {
                  tablero.ColorTable1.Clear(punto.X, punto.Y);
                  punto.Y++;

                  tablero.ColorTable1.Add(punto.X, punto.Y, Color.AliceBlue, imagen);
                  tablero.CualEs(punto.X, punto.Y - 1);
                  camino.Play();
              }
              else
              {
                  tablero.ColorTable1.Clear(punto.X, punto.Y);
                  punto.X++;
                  tablero.ColorTable1.Add(punto.X, punto.Y, Color.AliceBlue, imagen);
                  tablero.CualEs(punto.X - 1, punto.Y);
                  camino.Play();

              }
          }
          else
          {
              if (punto.X == 0)
              {
                  tablero.ColorTable1.Clear(punto.X, punto.Y);
                  punto.Y++;
                  tablero.ColorTable1.Add(punto.X, punto.Y, Color.AliceBlue, imagen);
                  tablero.CualEs(punto.X, punto.Y - 1);
                  camino.Play();
              }
              else
              {
                  tablero.ColorTable1.Clear(punto.X, punto.Y);
                  punto.X--;
                  tablero.ColorTable1.Add(punto.X, punto.Y, Color.AliceBlue, imagen);
                  tablero.CualEs(punto.X + 1, punto.Y);
                  camino.Play();
              }
          }

          if (punto.X == tablero.ColorTable1.TableWidth - 1 && punto.Y == tablero.ColorTable1.TableHeight - 1)
          {
              t.Enabled = false;
              t.Stop();
              Gane = true;
              
          }








          }



       



  /* Que gran cochambrera    
   * 
   * public override void Mover(Timer t)
       {

           if (po == 0)
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
           if (volvio)
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
               else if (xx == tablero.ColorTable1.TableWidth - 1 && xxx > 0)
               {
                   tablero.ColorTable1.Clear(xxx, yyy);
                   if (xaux == tablero.ColorTable1.TableWidth - 1)
                   {
                       yyy++;
                       xaux--;
                       a = 1;
                   }
                   else
                   {
                       xxx--;
                       a = 2;
                   }
                   AdondeVoy = "Abajo";


                   if (yyy >= tablero.columna - 1)
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

                   if (a == 1) tablero.CualEs(xaux + 1, yyy - 1);
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


       }
       */

       public override int PuntoX
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
       public override int PuntoY
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

     
     

       public override string Poder
       {
           get
           {
               return poder;
           }
       }

    }
}
