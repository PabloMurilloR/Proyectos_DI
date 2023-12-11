using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenGestionHotelesPablo
{
    class Persona
    {
        private string nombre;
        private string apellido;
        private string telefono;
        private string comentario;

        public Persona(string nombre, string apellido, string telefono, string comentario)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.comentario = comentario;
        }

        public string Nombre {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Telefono {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Comentario {
            get { return comentario; }
            set { comentario = value; }
        }
    }
}
