using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Comiqueria
    {
        List<Producto> productos;
        List<Venta> ventas;

        public Comiqueria()
        {
            productos = new List<Producto>();
            ventas = new List<Venta>();
        }

        public Producto this[Guid codigo]
        {
            get
            {
                foreach (Producto p in productos)
                {
                    if ((Guid)(p) == codigo)
                    {
                        return p;
                    }
                }
                return null;
            }
        }

        public static bool operator ==(Comiqueria comiqueria, Producto producto)
        {
            foreach (Producto p in comiqueria.productos)
            {
                if (p.Descripcion == producto.Descripcion)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Comiqueria comiqueria, Producto producto)
        {
            return !(comiqueria == producto);
        }

        public static Comiqueria operator +(Comiqueria comiqueria, Producto producto)
        {
            if (comiqueria != producto)
            {
                comiqueria.productos.Add(producto);
            }
            return comiqueria;
        }

        public void Vender(Producto producto)
        {
            this.Vender(producto, 1);
        }

        public void Vender(Producto producto, int cantidad)
        {
            Venta venta = new Venta(producto, cantidad);
            this.ventas.Add(venta);
        }



        public string ListarVentas()
        {
            StringBuilder datos = new StringBuilder();
            //IEnumerable<Venta> ListaOrdenada = ventas.OrderBy(fecha => fecha);
            foreach(Venta v in ventas)
            {
                datos.AppendLine(v.ObtenerDescripcionBreve());
            }
            return datos.ToString();
        }

        public Dictionary <Guid,string> ListarProductos()
        {
            Dictionary<Guid, string> dictionary = new Dictionary<Guid, string>();
            foreach(Producto p in this.productos)
            {
                dictionary.Add((Guid)p,p.Descripcion);
            }
            return dictionary;
        }
  }
}
