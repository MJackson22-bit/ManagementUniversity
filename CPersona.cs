using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class CPersona : CFacultad
    {
        private string nombre;
        private string direccion;
        private char sexo;
        private long telefono;
        private string fechaNac;
        public CPersona()
        {
            
        }
        public CPersona(string nombre, string direccion, char sexo, long telefono, string fechaNac)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.sexo = sexo;
            this.telefono = telefono;
            this.fechaNac = fechaNac;
        }
        public string Nombre
        {
            set
            {
                nombre = value;
            }
            get
            {
                return nombre;
            }
        }
        public string Direccion
        {
            set
            {
                direccion = value;
            }
            get
            {
                return direccion;
            }
        }
        public char Sexo
        {
            get
            {
                return sexo;
            }
            set
            {
                sexo = value;
            }
        }
        public long Telefono
        {
            get
            {
                return telefono;
            }
            set
            {
                telefono = value;
            }
        }
        public string FechaNac
        {
            set
            {
                fechaNac = value;
            }
            get
            {
                return fechaNac;
            }
        }
        public override string ToString()
        {
            return string.Format("{0} {1} \n {2} {3}\n {4} {5}\n {6} {7}\n {8} {9}", "Nombre: ", Nombre, "Direccion: ", Direccion, "Sexo", Sexo, "Teléfono: ",Telefono, "Fecha de Nacimineto: ", FechaNac);
        }
    }
}
