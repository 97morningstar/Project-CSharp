using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using JPUtil;

namespace Proyecto.Clases
{
    public interface Poder{

    }
    public interface PoderPropio:Poder{

    }
    public interface PoderEstatico:Poder{

}
   public interface Adelanta:PoderEstatico
    {
       void PoderAdelantar();
    }

   public interface Terremoto : PoderPropio
   {
       void EscapadeLaMuerte();
   }

   public interface Rayo : PoderPropio
   {
       void InmuneaRetroceder();
   }
   public interface Tsunami : PoderPropio
   {
       void InmuneaEsperarTurno();
   }

   public interface Retrocede : PoderEstatico
   {
       void Retroceder(Timer t);
   }

   public interface EsperaTurno : PoderEstatico
   {
       void Espera();
   }


}
