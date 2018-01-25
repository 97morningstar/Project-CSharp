using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using JPUtil;

namespace Proyecto.Clases
{
   public class TRex:Jugador
    {
       
       public TRex(Tablero t, Point p, Color c, Image d)
           : base(t, p, c)
       {
           d = Image.FromFile("Sirena.gif");// aki va la direccion
       }

    }
}
