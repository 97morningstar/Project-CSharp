using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Proyecto.Clases
{
    public class Aire:Estaticos
    {

        public Aire(Tablero t, Point p, Color c)
            : base(t, p, c)
        {
           // base.Imagen = new Bitmap(); aki va la direccion de la imagen para aire
        }




    }
}
