using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenBibliotecaPablo
{
    class Libro
    {
        private string titulo;
        private int anyo;
        private string isbn;
        private int edid;

        public Libro(string titulo, int anyo, string isbn, int edid)
        {
            this.titulo = titulo;
            this.anyo = anyo;
            this.isbn = isbn;
            this.edid = edid;
        }

        #region Getter y Setter
        public string Titulo {
            get { return titulo; }
            set { titulo = value; }
        }

        public int Anyo {
            get { return anyo; }
            set { anyo = value; }
        }

        public string Isbn {
            get { return isbn; }
            set { isbn = value; }
        }

        public int Edid {
            get { return edid; }
            set { edid = value; }
        }
        #endregion
        public override string ToString()
        {
            return titulo;
        }
    }
}
