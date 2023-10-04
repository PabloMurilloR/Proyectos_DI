using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaPablo
{
    public class Libro
    {
        private string titulo;
        private string autor;
        private string editorial;
        private bool nuevo;
        private string rutaFoto;

        public Libro(string titulo, string autor, string editorial, bool nuevo, string rutaFoto)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.editorial = editorial;
            this.nuevo = nuevo;
            this.rutaFoto = rutaFoto;
        }
        
        public override string ToString()
        {
            return $"Título: {titulo}, Autor: {autor}, Editorial: {editorial}, Nuevo: {nuevo}";
        }

        public string Titulo {
            get { return titulo; }
            set { titulo = value; }
        }

        public string Autor {
            get { return autor; }
            set { autor = value; }
        }

        public string Editorial {
            get { return editorial; }
            set { editorial = value; }
        }

        public bool Nuevo {
            get { return nuevo; }
            set { nuevo = value; }
        }

        public string RutaFoto {
            get { return rutaFoto; }
            set { rutaFoto = value; }
        }

    }
}
