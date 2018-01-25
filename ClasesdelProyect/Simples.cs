using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Proyecto.Clases
{
    public abstract class Simples:Obstaculo
    {
        public Simples(Tablero t, Point p, Color c) : base(t, p, c) { }
    }
}
