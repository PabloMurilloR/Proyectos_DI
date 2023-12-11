using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenGestionHotelesPablo
{
    class ReservaC
    {
        private string nombre;
        private string apellidos;
        private string fecha;
        private string categoria;

        public ReservaC(string nombre, string apellidos, string fecha, string categoria)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.fecha = fecha;
            this.categoria = categoria;
        }

        public string Nombre {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellidos {
            get { return apellidos; }
            set { apellidos = value; }
        }

        public string Fecha {
            get { return fecha; }
            set { fecha = value; }
        }

        public string Categoria {
            get { return categoria; }
            set { categoria = value; }
        }

    }
}
