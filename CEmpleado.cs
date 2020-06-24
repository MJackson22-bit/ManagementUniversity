using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class CEmpleado : CPersona
    {
        private string numeroSeguroSocial;
        private string titulo;
        private string cargo;
        private float salario;
        private int antiguedad;
        public CEmpleado()
        {

        }
        public CEmpleado(string nombre, string direccion, char sexo, long telefono, string fechaNac, string nss, string titulo, string cargo, float salario, int antiguedad) : base(nombre, direccion, sexo, telefono, fechaNac)
        {
            numeroSeguroSocial = nss;
            this.salario = salario;
            this.titulo = titulo;
            this.cargo = cargo;
            this.antiguedad = antiguedad;
        }
        public string NumeroSeguroSocial
        {
            get
            {
                return numeroSeguroSocial;
            }
            set
            {
                numeroSeguroSocial = value;
            }
        }
        public string Titulo
        {
            get
            {
                return titulo;
            }
            set
            {
                titulo = value;
            }
        }
        public string Cargo
        {
            set
            {
                cargo = value;
            }
            get
            {
                return cargo;
            }
        }
        public float Salario
        {
            get
            {
                return salario;
            }
            set
            {
                salario = value;
            }
        }
        public int Antiguedad
        {
            set
            {
                antiguedad = value;
            }
            get
            {
                return antiguedad;
            }
        }
        public override string ToString()
        {
            return string.Format("{0}\n {1} {2}\n {3} {4}\n {5} {6}\n {7} {8}\n {9} {10}", base.ToString(), "Numero de Seguro Social: ", NumeroSeguroSocial, "Título: ", Titulo,
                "Cargo: ", Cargo, "Salario: ", Salario, "Antiguedad: ", Antiguedad);
        }
    }

}
