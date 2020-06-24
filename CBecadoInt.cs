using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class CBecadoInt : CAlumno
    {
        private string residencia;
        private int nCuarto;
        public CBecadoInt()
        {

        }
        public CBecadoInt(string nombre, string direccion, char sexo, long telefono , string fechaNac, string carnet, string carrera, string residencia, int nCuarto) : base(nombre, direccion, sexo, telefono, fechaNac, carnet, carrera)
        {
            this.residencia = residencia;
            this.nCuarto = nCuarto;
        }
        public string Residencia
        {
            set
            {
                residencia = value;
            }
            get
            {
                return residencia;
            }
        }
        public int NCuarto
        {
            set
            {
                nCuarto = value;
            }
            get
            {
                return nCuarto;
            }
        }
        public override string ToString()
        {
            return string.Format("{0}\n {1} {2}\n {3} {4}", base.ToString(), "Residencia: ", Residencia, "N° Cuarto: ", NCuarto);
        }
    }
}
