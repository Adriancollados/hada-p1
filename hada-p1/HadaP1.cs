using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hada_p1
{
    class HadaP1 ///Esta clase permite convertir de segundos a minutos o viceversa

    {  
        /// <summary>
        /// esta clase convierte de segundos a minutos
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

        /// <summary>
        /// esta clase convierte de minutos a segundos
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
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
