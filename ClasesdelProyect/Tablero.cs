using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using JPUtil;
using System.Windows.Forms;
namespace Proyecto.Clases
{
   public class Tablero
    {
        Juego[,] matriz;
        ColorTable colortable1;
    //   List<Point>  aki van varias listas de los elementos fundamentales del juego
       //Propiedades de los atributos
        public Juego[,] Matriz
        {
            get
            {
                return matriz;
            }
        }
        public ColorTable ColorTable1
        {
            get
            {
                return colortable1;
            }
        }





    }
}
