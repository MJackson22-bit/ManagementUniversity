using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Leer
    {
        public static short datoShort()
        {
            try
            {
                return Int16.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                return Int16.MinValue;
            }
        }
        public static int datoInt()
        {
            try
            {
                return Int32.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                return Int32.MinValue;
            }
        }
        public static long datoLong()
        {
            try
            {
                return Int64.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                return Int64.MinValue;
            }
        }
        public static float datoFloat()
        {
            try
            {
                return Single.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                return Single.NaN;
            }
        }
        public static double datoDouble()
        {
            try
            {
                return Double.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                return Double.NaN;
            }
        }
    }
}
