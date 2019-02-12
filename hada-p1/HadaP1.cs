using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hada_p1
{
    class HadaP1
    {
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
