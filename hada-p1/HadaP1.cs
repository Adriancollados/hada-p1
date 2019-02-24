using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hada_p1
{
    class HadaP1 ///Esta clase contiene metodos para convertir de segundos a minutos y viceversa
    {
        /// <summary>
        /// esta clase permite cambiar de segundos a minutos
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static double Seconds2Minutes(double s)
        {
            double m = 0;
            if(s == 0)
            {
                return m;
            }
            else
            {
                m = s / 60;
            }
            return m;
        }

        ///En este metodo pasamos unos minutos como parametro
        ///y comprobamos si son 0 o no y realizamos las operaciones
        /// y devolvemos los segundos
        public static double Minutes2Seconds(double m)
        {
            double s = 0;
            if(m == 0)
            {
                return s;
            }
            else
            {
                s = m * 60;
            }
            return s;
        }
    }
}
