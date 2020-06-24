using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class CAdministrativo : CEmpleado
    {
        private string dependencia;
        public CAdministrativo()
        {

        }
        public CAdministrativo(string nombre, string direccion, char sexo, long telefono, string fechaNac, string nss, string titulo, string cargo, float salario, int antiguedad, string dependencia) : base(nombre, direccion, sexo, telefono, fechaNac, nss, titulo, cargo, salario, antiguedad)
        {
            this.dependencia = dependencia;
        }
        public string Dependencia
        {
            set
            {
                dependencia = value;
            }
            get
            {
                return dependencia;
            }
        }
        public override string ToString()
        {
            return string.Format("{0}\n {1} {2}", base.ToString(), "Dependencia: ", Dependencia);
        }
    }
}
