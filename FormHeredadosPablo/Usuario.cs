using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormHeredadosPablo
{
    public class Usuario
    {
        private string nombre;
        private string apellidos;
        private string ciudad;
        private string correo;
        private string comentario;
        private bool esVip;

        public Usuario(string nombre, string apellidos, string ciudad, string correo, string comentario, bool esVip)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.ciudad = ciudad;
            this.correo = correo;
            this.comentario = comentario;
            this.esVip = esVip;
        }

        #region Getter y Setter
        public string Nombre {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellidos {
            get { return apellidos; }
            set { apellidos = value; }
        }

        public string Ciudad {
            get { return ciudad; }
            set { ciudad = value; }
        }

        public string Correo {
            get { return correo; }
            set { correo = value; }
        }

        public string Comentario {
            get { return comentario; }
            set { comentario = value; }
        }

        public bool EsVip {
            get { return esVip; }
            set { esVip = value; }
        }
        #endregion

        public string ToString()
        {
            return $"Nombre: {nombre}, Apellidos: {apellidos}, Ciudad: {ciudad}, Correo: {correo}, Comentario: {comentario}, EsVip: {esVip}";
        }

    }
}
