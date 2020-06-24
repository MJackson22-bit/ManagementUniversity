using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class CProcesor : CEmpleado
    {
        private string departamento;
        private string categoria;
        public CProcesor()
        {

        }
        public CProcesor(string nombre, string direccion, char sexo, long telefono, string fechaNac, string nss, string titulo, string cargo, float salario, int antiguedad, string departamento, string categoria) : base(nombre, direccion, sexo, telefono, fechaNac, nss, titulo, cargo, salario, antiguedad)
        {
            this.categoria = categoria;
            this.departamento = departamento;
        }
        public string Departamento
        {
            set
            {
                departamento = value;
            }
            get
            {
                return departamento;
            }
        }
        public string Categoria
        {
            set
            {
                categoria = value;
            }
            get
            {
                return categoria;
            }
        }
        public override string ToString()
        {
            return string.Format("{0}\n {1} {2}\n {3} {4}", base.ToString(), "Departamento: ", Departamento, "Categoría: ", Categoria);
        }
    }
}
