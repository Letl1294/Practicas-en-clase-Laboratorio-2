using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
  public sealed class Venta
  {
    static int porcentajeIva;
    private DateTime fecha;
    private double precioFinal;
    private Producto producto;

    private DateTime Fecha
    {
      get
      {
        return fecha;
      }
    }

    static Venta()
    {
      porcentajeIva = 21;
    }

    internal Venta(Producto producto, int cantidad)
    {
      this.producto = producto;
      Vender(cantidad);
    }

    private void Vender(int cantidad)
    {
      this.producto.Stock -= cantidad;
      this.fecha = DateTime.Now;
      this.precioFinal = CalcularPrecioFinal(producto.Precio,cantidad);
    }

    public static double CalcularPrecioFinal(double precioUnidad,int cantidad)
    {
      double precio = precioUnidad * cantidad;
      precio += (precio * porcentajeIva) / 100;
      return precio;
    }

    public string ObtenerDescripcionBreve()
    {
      StringBuilder datos = new StringBuilder();
      datos.AppendFormat("Fecha: {0} - Descripcion: {1}", this.Fecha, producto.Descripcion);
      datos.AppendFormat(" - Precio Final: {0:0.00}",this.precioFinal);
      return datos.ToString();
    }

  }
}
