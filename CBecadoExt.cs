using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class CBecadoExt : CAlumno
    {
        private float monto;
        public CBecadoExt()
        {

        }
        public CBecadoExt(string nombre, string direccion, char sexo, long telefono, string fechaNac, string carnet, string carrera, float monto) : base(nombre, direccion, sexo, telefono, fechaNac, carnet, carrera)
        {
            this.monto = monto;
        }
        public float Monto
        {
            set
            {
                monto = value;
            }
            get
            {
                return monto;
            }
        }
        public override string ToString()
        {
            return string.Format("{0}\n {1} {2}", base.ToString(), "Monto: ", Monto);
        }
    }
}
