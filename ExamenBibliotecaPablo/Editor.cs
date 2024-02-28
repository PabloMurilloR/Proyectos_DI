using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenBibliotecaPablo
{
    class Editor
    {
        private int edid;
        private string nombre;
        private string direccion;
        private string ciudad;

        public Editor(int edid, string nombre, string direccion, string ciudad)
        {
            this.edid = edid;
            this.nombre = nombre;
            this.direccion = direccion;
            this.ciudad = ciudad;
        }

        #region Getter y Setter
        public int Edid {
            get { return edid; }
            set { edid = value; }
        }

        public string Nombre {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Direccion {
            get { return direccion; }
            set { direccion = value; }
        }

        public string Ciudad {
            get { return ciudad; }
            set { ciudad = value; }
        }
        #endregion

        public override string ToString()
        {
            return nombre;
        }
    }
}
