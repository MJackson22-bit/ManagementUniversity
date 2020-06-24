using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Ejercicio_3
{
    class CFecha : CPersona
    {
        private int dia;
        private int mes;
        private int año;
        public CFecha()
        {

        }
        public int Dia
        {
            set
            {
                dia = value;
            }
            get
            {
                return dia;
            }
        }
        public int Mes
        {
            set
            {
                mes = value;
            }
            get
            {
                return mes;
            }
        }
        public int Año
        {
            get
            {
                return año;
            }
            set
            {
                año = value;
            }
        }
        public string VerificarFecha()
        {
            DateTime dateTime;
            Console.Write("Dia: ");
            Dia = int.Parse(Console.ReadLine());
            Console.Write("Mes: ");
            Mes = int.Parse(Console.ReadLine());
            Console.Write("Año: ");
            Año = int.Parse(Console.ReadLine());
            while (Año > 2020)
            {
                Console.WriteLine("El año supeera los limites - vuelve a intentarlo");
                Console.Write("Año: ");
                Año = int.Parse(Console.ReadLine());
            }
            string fecha = Dia + "/" + Mes + "/" + Año;
            Console.WriteLine("fecha: {0}", fecha);
            if (DateTime.TryParse(fecha, out dateTime))
            {
                return fecha;
            }
            else
            {
                return "\t¡¡¡NO ES UNA FECHA DE NACIMIENTO!!!";
            }
        }
    }
}
