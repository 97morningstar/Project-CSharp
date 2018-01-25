using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using JPUtil;
using System.Media;
namespace Proyecto.Clases
{
   public class Muerte
    {
       Point punto;
       Tablero tabb;
       ColorTable coloT;
       public int DeadX;
       public int DeadY;
       public bool Mato = false;
       SoundPlayer NOOOOOO = new SoundPlayer("Sonidos/voice-2016-05-14-17-51.wav");
       public Muerte(Tablero t, Point p, ColorTable coloT, Image d)
       {

           this.Punto = p;
           tabb = t;
           this.coloT = coloT;
           DeadX = p.X;
           DeadY = p.Y;
       }

       public Tablero tab
       {
           get
           {
               return tabb;
           }
       }
       public Point Punto
       {
           get
           {
               return punto;
           }
           set
           {
               punto = value;
           }
       }

       public bool SeMueve(int x, int y)
       {
           if (x >= 0 && y >= 0 && x < tabb.fila && y < tabb.columna)
               return true;
           else
               return false;
       }

       int pop = 0;
       int x = 5;
       int y = 5;
       int aux;

       public void Moverse()
       {
           //Esta es una prueba que quizas funcione o quizas no quien sabe, ejem Si funcionó

           if (Mato)
           {
               NOOOOOO.Play();
               Mato = false;
           }

           Random num = new Random();
           aux = num.Next(1, 5);

           if (aux == 1)
           {
               coloT.Clear(punto.X, punto.Y);
            
               if (SeMueve(punto.X, punto.Y-1))
               {
                   punto.Y--;
                   coloT.Add(punto.X, punto.Y, Color.AliceBlue, new Bitmap("Fresa.png"));
                   tabb.CualEs(punto.X, punto.Y+1);
               }
               else
               {
                   coloT.Add(punto.X, punto.Y, Color.AliceBlue, new Bitmap("Fresa.png"));
               }
           }
           else if (aux == 2)
           {
               coloT.Clear(punto.X, punto.Y);
            
               if (SeMueve(punto.X+1, punto.Y))
               {
                   punto.X++;
                   coloT.Add(punto.X, punto.Y, Color.AliceBlue, new Bitmap("Fresa.png"));
                   tabb.CualEs(punto.X-1, punto.Y);
               }
               else
               {
                   coloT.Add(punto.X, punto.Y, Color.AliceBlue, new Bitmap("Fresa.png"));
               }
           }
           else if (aux == 3)
           {
               coloT.Clear(punto.X, punto.Y);
           
               if (SeMueve(punto.X, punto.Y+1))
               {
                   punto.Y++;
                   coloT.Add(punto.X, punto.Y, Color.AliceBlue, new Bitmap("Fresa.png"));
                   tabb.CualEs(punto.X,punto.Y-1);
               }
               else
               {
                   coloT.Add(punto.X, punto.Y, Color.AliceBlue, new Bitmap("Fresa.png"));
               }
           }
           else if (aux == 4)
           {
               coloT.Clear(punto.X, punto.Y);
              
               if (SeMueve(punto.X-1, punto.Y))
               {
                   punto.X--;
                   coloT.Add(punto.X, punto.Y, Color.AliceBlue, new Bitmap("Fresa.png"));
                   tabb.CualEs(punto.X+1, punto.Y);
               }
               else
               {
                   coloT.Add(punto.X, punto.Y, Color.AliceBlue, new Bitmap("Fresa.png"));
               }
           }









           /*
           if (pop == 0)
           {
               if (SeMueve(punto.X, punto.Y))
               {
                   coloT.Add(punto.X, punto.Y, Color.AliceBlue, new Bitmap("Vendajes.gif"));
          
                   tabb.CualEs(DeadX, DeadY);

               }
               pop = 1;
           }
           else
           {
               Random r = new Random();

               x = r.Next(-1, 2);
               y = r.Next(-1, 2);

               coloT.Clear(punto.X, punto.Y);


               if (SeMueve(punto.X + x, punto.Y + y))
               {
                   DeadX = punto.X;
                   DeadY = punto.Y;

                   punto.X += x;
                   punto.Y += y;

                
               } 


               while (!SeMueve(punto.X + x, punto.Y + y))
               {
                      x = r.Next(-1, 2);
                      y = r.Next(-1, 2);

                      DeadX = punto.X;
                      DeadY = punto.Y;
                   
                       punto.X += x;
                       punto.Y += y;
                   


               }


               pop = 0;

           }

           */


       }



       /*
      public void Moverse()
       {
           
              if (pop == 0)
              {
                  if (SeMueve(punto.X, punto.Y))
                  {
                      coloT.Add(punto.X, punto.Y, Color.AliceBlue, new Bitmap("Vendajes.gif"));
                     
                  }
                  pop = 1;
              }
              else if (pop == 1)
              {
                  Random r = new Random();
                   x = r.Next(-1, 2);
                   y = r.Next(-1, 2);

                  coloT.Clear(punto.X, punto.Y);
                  punto.X += x;
                  punto.Y += y;


                  while (tabb.Matriz[punto.X-1, punto.Y-1] != null || (punto.X == 0 && punto.Y == 0) || (punto.X == coloT.TableWidth - 1 && punto.Y == coloT.TableHeight - 1))
                  {
                       x = r.Next(-1, 2);
                       y = r.Next(-1, 2);
                       punto.X += x;
                       punto.Y += y;
                  }


                
                  pop = 0;
              }



         
       


       }
       
       int pop1 = 0;
       
       public void Moverse()
       {


          if (pop1 == 0)
          {
              if(punto.X < coloT.TableWidth-1 && punto.Y < coloT.TableHeight-1 )
                  coloT.Add(x, y, Color.AliceBlue, new Bitmap("Vendajes.gif"));

              pop1 = 1;
          }
          else if(pop1==1)
          {
              coloT.Clear(x,y);
              Random r = new Random();

              
              y = r.Next(0, coloT.TableHeight);
              x = r.Next(0, coloT.TableWidth);

              while (tabb.Matriz[x, y] != null || (x == 0 && y == 0) || (x == coloT.TableWidth - 1 && y == coloT.TableHeight - 1))
              {
                  x = r.Next(0, coloT.TableWidth);
                  y = r.Next(0, coloT.TableHeight);
              }
              punto.X = x;
              punto.Y = y;
              

              pop1 = 0;
          }

       }*/

    }
}
