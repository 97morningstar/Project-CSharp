﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Proyecto.Clases
{
    public abstract class Obstaculo : Juego
    {
        public Obstaculo(Tablero t, Point p, Color c, Image d) : base(t, p, c, d) { }

    }
}
