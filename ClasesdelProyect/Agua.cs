using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Proyecto.Clases
{
    public class Agua:Estaticos
    {
        public Agua(Tablero t, Point p, Color c)
            : base(t, p, c)
        {
            // base.Imagen = new BitMap()  aki va la direccion de la imagen
        }

    }
}
