using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace Proyecto.Clases
{
   public abstract  class Jugador: Juego
    {
       int cantidadJugadores = 2;
       public Jugador(int cantidadJugadores,Tablero t, Point p, Color c)
           : base(t, p, c)
       {
           this.cantidadJugadores = cantidadJugadores;
       }

       public Jugador(Clases.Tablero t, Point p, System.Drawing.Color c)
       {
           // TODO: Complete member initialization
           this.t = t;
           this.p = p;
           this.c = c;
       }

       public bool SePuedeMover(int x, int y)
       {
           if (x >= 0 && y >= 0 && x < base.Tablero.Matriz.GetLength(0) && y < base.Tablero.Matriz.GetLength(1))
               return true;
           else
               return false;
       }
       int xx = 0;
       int yy = 0;
       int xxx = 0;
       int yyy = 0;
       int xaux = 0;
       int dd = 1;
       private Clases.Tablero t;
       private Point p;
       private System.Drawing.Color c;
       public void Mover()
       {
           
           if (xx < base.Tablero.Matriz.GetLength(0) - 1 && x >= 0)
           {
               base.Tablero.ColorTable1.Clear(xx, yy);
               xx++;
               base.Tablero.ColorTable1.Add(xx, yy, Color.Beige, d);
               xxx = xx;
               xaux = xx;
               yyy = yy;
               dd++;
           }
           else if (xx == base.Tablero.Matriz.GetLength(0) - 1 && xxx > 0)
           {
               base.Tablero.ColorTable1.Clear(xxx, yyy);
               if (xaux == base.Tablero.Matriz.GetLength(0) - 1) { yyy++; xaux--; }
               else xxx--;
               base.Tablero.ColorTable1.Add(xxx, yyy, Color.Beige, d);
               dd++;
           }
           else
           {
               base.Tablero.ColorTable1.Clear(xxx, yyy);
               xx = 0;
               yy = yyy + 1;
               base.Tablero.ColorTable1.Add(xx, yy, Color.Beige, d);
               dd++;
           }




       }
       private void Ganar()
       {
           MessageBox.Show("Ganaste");

       }
       private int Llegue(int d)
       {
           int a = (base.Tablero.Matriz.GetLength(0)) * base.Tablero.Matriz.GetLength(1);

           if (d < a) return 1;
           else if (d == a)
               return 2;
           else
               return 3;

       }




    }
}
