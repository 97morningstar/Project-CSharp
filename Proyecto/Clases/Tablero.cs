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
       public ColorTable colortable1;
       public int fila, columna;
       public int[,] Temp;
        public Tablero(ColorTable colorT, int fila, int columna)
        {
            this.colortable1 = colorT;
            matriz = new Juego[fila,columna];
            this.fila = fila;
            this.columna = columna;
            Temp = new int[fila, columna];
        }
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

       

        public void Clear()
        {
            for (int i = 0; i < fila; i++)
            {
                for (int j = 0; j < columna; j++)
                {
                    Matriz[i, j] = null;
                    colortable1.Clear(i, j);
                }
            }
        }

        public void CualEs(int i, int j)
        {
            if (i>=0 && j>=0 && i <= fila - 1 && j <= columna - 1)
            {
                if (Matriz[i, j] is Rafaga)
                {
                    colortable1.Add(i, j, Color.AliceBlue, new Bitmap("fuego.png"));
                }
                else if (Matriz[i, j] is Agua)
                {
                    colortable1.Add(i, j, Color.AliceBlue, new Bitmap("agua.png"));
                }
                else if (Matriz[i, j] is Fuego)
                {
                    colortable1.Add(i, j, Color.AliceBlue, new Bitmap("fuego.gif"));
                }
                else if (Matriz[i, j] is Nautilus)
                {
                    colortable1.Add(i, j, Color.AliceBlue, new Bitmap("si.png"));
                }
                else if (Matriz[i, j] is Tornado)
                {
                    colortable1.Add(i, j, Color.AliceBlue, new Bitmap("PoderDePegaso.png"));
                }
                else if (Matriz[i, j] is Cristal)
                {
                    colortable1.Add(i, j, Color.AliceBlue, new Bitmap("cosa.png"));
                }
                else if (Matriz[i, j] is Tierra)
                {
                    colortable1.Add(i, j, Color.AliceBlue, new Bitmap("PoderdeTRex.png"));
                }
                

            }

        }
        public void RePintar()
        {
            for (int i = 0; i < fila; i++)
            {

                for (int j = 0; j < columna; j++)
                {


                    if (matriz[i, j] is Rafaga)
                    {
                        colortable1.Add(i, j, Color.AliceBlue, new Bitmap("fuego.png"));
                    }
                    else if (matriz[i, j] is Agua)
                    {
                        colortable1.Add(i, j, Color.AliceBlue, new Bitmap("agua.png"));
                    }
                    else if (matriz[i, j] is Fuego)
                    {
                        colortable1.Add(i, j, Color.AliceBlue, new Bitmap("fuego.gif"));
                    }
                    else if (matriz[i, j] is Nautilus)
                    {
                        colortable1.Add(i, j, Color.AliceBlue, new Bitmap("si.png"));
                    }
                    else if (matriz[i, j] is Tornado)
                    {
                        colortable1.Add(i, j, Color.AliceBlue, new Bitmap("PoderDePegaso.png"));
                    }
                    else if (matriz[i, j] is Cristal)
                    {
                        colortable1.Add(i, j, Color.AliceBlue, new Bitmap("cosa.png"));
                    }
                    else if (matriz[i, j] is Tierra)
                    {
                        colortable1.Add(i, j, Color.AliceBlue, new Bitmap("PoderdeTRex.png"));
                    }






                }
            }


                
                
            }
        
        public void PonerRafaga(int cant)
        {
            for(int i = 0 ;i< cant; i++)
            {
                Random rdm = new Random();
                int x = rdm.Next(0, fila);
                int y = rdm.Next(0, columna);

                while (Matriz[x, y] != null || (x == 0 && y == 0) || (x==fila-1&&y==columna-1))
              { 
                   x = rdm.Next(0, fila);
                   y = rdm.Next(0, columna);
              }
                Point p = new Point(x,y);
             
                    Matriz[x, y] = new Rafaga(this, p, Color.AliceBlue, new Bitmap("fuego.png"));
               
                    colortable1.Add(p, Color.AliceBlue, new Bitmap("fuego.png"));
                
            }
        }

        public void PonerTornado(int cant)
        {
            for (int i = 0; i < cant; i++)
            {
                Random rdm = new Random();
                int x = rdm.Next(0, fila);
                int y = rdm.Next(0, columna);

                while (Matriz[x, y] != null || (x == 0 && y == 0) || (x == fila-1 && y == columna-1))
                {
                    x = rdm.Next(0, fila);
                    y = rdm.Next(0, columna);
                }
                Point p = new Point(x, y);
               
                    Matriz[x, y] = new Tornado(this, p, Color.AliceBlue, new Bitmap("PoderDePegaso.png"));
                    colortable1.Add(p, Color.AliceBlue, new Bitmap("PoderDePegaso.png"));
                
            }
        }
        public void PonerNautilus(int cant)
        {
            for (int i = 0; i < cant; i++)
            {
                Random rdm = new Random();
                int x = rdm.Next(0, fila);
                int y = rdm.Next(0, columna);

                while (Matriz[x, y] != null || (x == 0 && y == 0) || (x == fila-1 && y == columna-1))
                {
                    x = rdm.Next(0, fila);
                    y = rdm.Next(0, columna);
                }
                Point p = new Point(x, y);
                
                    Matriz[x, y] = new Nautilus(this, p, Color.AliceBlue, new Bitmap("si.png"));
                    colortable1.Add(p, Color.AliceBlue, new Bitmap("si.png"));
                
            }
        }
        public void PonerTierra(int cant)
        {
            for (int i = 0; i < cant; i++)
            {
                Random rdm = new Random();
                int x = rdm.Next(0, fila);
                int y = rdm.Next(0, columna);

                while (Matriz[x, y] != null || (x == 0 && y == 0) || (x == fila-1 && y == columna-1))
                {
                    x = rdm.Next(0, fila);
                    y = rdm.Next(0, columna);
                }
                Point p = new Point(x, y);
               
                    Matriz[x, y] = new Tierra(this, p, Color.AliceBlue, new Bitmap("PoderdeTRex.png"));
                    colortable1.Add(p, Color.AliceBlue, new Bitmap("PoderdeTRex.png"));
            
            }
        }
   
        public void PonerFuego(int cant)
        {
            for (int i = 0; i < cant; i++)
            {
                Random rdm = new Random();
                int x = rdm.Next(0, fila);
                int y = rdm.Next(0, columna);

                while (Matriz[x, y] != null || (x == 0 && y == 0) || (x == fila-1 && y == columna-1))
                {
                    x = rdm.Next(0, fila);
                    y = rdm.Next(0, columna);
                }
                Point p = new Point(x, y);
               
                    Matriz[x, y] = new Fuego(this, p, Color.AliceBlue, new Bitmap("fuego.gif"));
                    colortable1.Add(p, Color.AliceBlue, new Bitmap("fuego.gif"));
                
            }
        }

        public void PonerCristal(int cant)
        {
            for (int i = 0; i < cant; i++)
            {
                Random rdm = new Random();
                int x = rdm.Next(0, fila);
                int y = rdm.Next(0, columna);

                while (Matriz[x, y] != null || (x == 0 && y == 0) || (x == fila-1 && y == columna-1))
                {
                    x = rdm.Next(0, fila);
                    y = rdm.Next(0, columna);
                }
                Point p = new Point(x, y);

                Matriz[x, y] = new Cristal(this, p, Color.AliceBlue, new Bitmap("cosa.png"));
                    colortable1.Add(p, Color.AliceBlue, new Bitmap("cosa.png"));
                
            }
        }


        public void PonerAgua(int cant)
        {
            for (int i = 0; i < cant; i++)
            {
                Random rdm = new Random();
                int x = rdm.Next(0, fila);
                int y = rdm.Next(0, columna);

                while (Matriz[x, y] != null || (x == 0 && y == 0) || (x == fila-1 && y == columna-1))
                {
                    x = rdm.Next(0, fila);
                    y = rdm.Next(0, columna);
                }
                Point p = new Point(x, y);
               
                    Matriz[x, y] = new Agua(this, p, Color.AliceBlue, new Bitmap("agua.png"));
                    colortable1.Add(p, Color.AliceBlue, new Bitmap("agua.png"));
                
            }
        }


        public int[,] ConvertiMatrizToInt()
        {
            for (int i = 0; i < fila; i++)
            {
                for (int j = 0; j < columna; j++)
                {
                    if (matriz[i, j] is Rafaga)
                    {
                        Temp[i, j] = 1;
                    }
                    else if (matriz[i, j] is Agua)
                    {
                        Temp[i, j] = 1;
                    }
                    else if (matriz[i, j] is Fuego)
                    {
                        Temp[i, j] = 1;
                    }
                    else if (matriz[i, j] is Nautilus)
                    {
                        Temp[i, j] = 1;
                    }
                    else if (matriz[i, j] is Tornado)
                    {
                        Temp[i, j] = 1;
                    }
                    else if (matriz[i, j] is Cristal)
                    {
                        Temp[i, j] = 1;
                    }
                    else if (matriz[i, j] is Tierra)
                    {
                        Temp[i, j] = 1;
                    }

                }
                
            }


            return Temp;


        }

        public void ColocarElementos(string[,] mat)
        {
            for (int i = 0; i <fila; i++)
            {
                for (int j = 0; j < columna; j++)
                {
                    if (mat[i, j] == "Rafaga")
                    {
                        Point p = new Point(i, j);

                        Matriz[i, j] = new Rafaga(this, p, Color.AliceBlue, new Bitmap("fuego.png"));

                        colortable1.Add(p, Color.AliceBlue, new Bitmap("fuego.png"));


                    }
                    else if(mat[i, j] == "Cristal")
                    {
                        Point p = new Point(i, j);

                        Matriz[i, j] = new Cristal(this, p, Color.AliceBlue, new Bitmap("cosa.png"));
                        colortable1.Add(p, Color.AliceBlue, new Bitmap("cosa.png"));
                    }
                    else if(mat[i,j] == "Fuego")
                    {
                        Point p = new Point(i, j);

                        Matriz[i, j] = new Fuego(this, p, Color.AliceBlue, new Bitmap("fuego.gif"));
                        colortable1.Add(p, Color.AliceBlue, new Bitmap("fuego.gif"));
                    }
                    else if (mat[i, j] == "Nautilus")
                    {
                        Point p = new Point(i, j);

                        Matriz[i, j] = new Nautilus(this, p, Color.AliceBlue, new Bitmap("si.png"));
                        colortable1.Add(p, Color.AliceBlue, new Bitmap("si.png"));
                    }
                    else if (mat[i, j] == "Tierra")
                    {
                        Point p = new Point(i, j);

                        Matriz[i, j] = new Tierra(this, p, Color.AliceBlue, new Bitmap("PoderdeTRex.png"));
                        colortable1.Add(p, Color.AliceBlue, new Bitmap("PoderdeTRex.png"));
                    }
                    else if (mat[i, j] == "Tornado")
                    {
                        Point p = new Point(i, j);

                        Matriz[i, j] = new Tornado(this, p, Color.AliceBlue, new Bitmap("PoderDePegaso.png"));
                        colortable1.Add(p, Color.AliceBlue, new Bitmap("PoderDePegaso.png"));
                    }
                    else if (mat[i, j] == "Agua")
                    {
                        Point p = new Point(i, j);

                        Matriz[i, j] = new Agua(this, p, Color.AliceBlue, new Bitmap("agua.png"));
                        colortable1.Add(p, Color.AliceBlue, new Bitmap("agua.png"));
                    }

                }
            }



        }
    }
}
