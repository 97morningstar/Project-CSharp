using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Proyecto.Clases
{
   public abstract class Juego
    {
       Tablero tablero;
       Image imagen;
       Point punto;
       Color color;
       public Juego(Tablero t, Point p, Color c, Image d)
       {
           tablero = t;
           punto = p;
           color = c;
           imagen = d;
       }


       //Propiedades
       #region Prop

       public Image img
       {
           get
           {
               return imagen;
           }
       }
       public Tablero Tablero
       {
           get
           {
               return tablero;
           }
           set
           {
               tablero = value;
           }
       }

       public Point Punto
       {
           get
           {
               return punto;
           }
           set
           {
               punto = value;
           }
       }

       public Image Imagen
       {
           get
           {
               return imagen;
           }
           set
           {
               imagen = value;
           }
       }

       public Color Color
       {
           get
           {
               return color;
           }
           set
           {
               color = value;
           }
       }
       #endregion
       //Metodos Abstractos
      

    }

}
