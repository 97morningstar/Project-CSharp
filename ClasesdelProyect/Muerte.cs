using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Proyecto.Clases
{
   public class Muerte : Moviles
    {
       public Muerte(Tablero t, Point p, Color c)
           : base(t, p, c)
       {
           //base.Image = new BitMap()  aki va la direccion de la imagen 
       }

       public override void Moverse()
       {
           throw new NotImplementedException();
       }

    }
}
