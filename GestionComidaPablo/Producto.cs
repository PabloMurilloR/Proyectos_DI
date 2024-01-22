using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperacion1EvaPablo
{
    public class Producto
    {
        private string id;
        private string nombre;
        private string stock;
        private string categoria;
        private int precio;

        public Producto(string id, string nombre, string stock, string categoria)
        {
            this.id = id;
            this.nombre = nombre;
            this.stock = stock;
            this.categoria = categoria;
            this.precio = 0;
        }

        #region Getter y Setter
        public string Id {
            get { return id; }
            set { id = value; }
        }
        public string Nombre {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Stock {
            get { return stock; }
            set { stock = value; }
        }
        public string Categoria {
            get { return categoria; }
            set { categoria = value; }
        }
        public int Precio {
            get { return precio; }
            set { precio = value; }
        }
        #endregion
    }
}
