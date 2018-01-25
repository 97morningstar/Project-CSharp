using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Proyecto.Clases
{
    public abstract class Moviles: Obstaculo
    {
        public Moviles(Tablero t, Point p, Color c)
            : base(t, p, c)
        {

        }

        public abstract void Moverse();
    }
}
