using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class CAlumno : CPersona
    {
        private string carnet;
        private string carrera;
        public CAlumno()
        {

        }
        public CAlumno(string nombre, string direccion, char sexo, long telefono, string fechaNac, string carnet, string carrera) : base(nombre, direccion, sexo, telefono, fechaNac)
        {
            this.carnet = carnet;
            this.carrera = carrera;
        }
        public string Carrera
        {
            set
            {
                carrera = value;
            }
            get
            {
                return carrera;
            }
        }
        public string Carnet
        {
            set
            {
                carnet = value;
            }
            get
            {
                return carnet;
            }
        }
        public override string ToString()
        {
            return string.Format("{0}\n {1} {2}\n {3} {4}", base.ToString(), "Carnet: ", Carnet, "Carrera: ", Carrera);
        }
    }
}
