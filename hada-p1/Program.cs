using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hada_p1;

namespace hada_p1
{
    class Program
    {
        static void Main(string[] args)
        {
            string respuesta1, respuesta2;
            string seg, min;
            do
            {
                Console.WriteLine("Segundos(s) o minutos(m) ?");
                respuesta1 = Console.ReadLine();
                if(respuesta1 == "s")
                {
                    Console.WriteLine("Cantidad de segundos: ");
                    seg = Console.ReadLine();
                    double aux = HadaP1.Seconds2Minutes(double.Parse(seg));
                    Console.WriteLine("Conversion a minutos: " + aux + "min");
                }
                else
                {
                    if(respuesta1 == "m")
                    {
                        Console.WriteLine("Cantidad de minutos: ");
                        min = Console.ReadLine();
                        double aux = HadaP1.Minutes2Seconds(double.Parse(min));
                        Console.WriteLine("Conversion a segundos: " + aux + "segs");
                    }
                }
                Console.WriteLine("Desea continuar(s/n)?");
                respuesta2 = Console.ReadLine();
            } while (respuesta2 != "n");
        }
    }
}
