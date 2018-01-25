using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace Proyecto.Clases
{
    public abstract class Juego
    {
      public  Tablero t;
      public  Point p;
        Color c;
        Image d;


        public Juego(Tablero t, Point p, Color c, Image d)
        {
            this.t = t;
            this.p = p;
            this.c = c;
            this.d = d;
        }

    }
}
