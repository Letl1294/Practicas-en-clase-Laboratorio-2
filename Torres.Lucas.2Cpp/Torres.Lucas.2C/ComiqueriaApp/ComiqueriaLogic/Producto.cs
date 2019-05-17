using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
  public abstract class Producto
  {
    private Guid codigo;
    private string descripcion;
    private double precio;
    private int stock;

    protected Producto(string descripcion, double precio, int stock)
    {
      Guid guid = Guid.NewGuid();
      codigo = guid;
      this.descripcion = descripcion;
      this.precio = precio;
      this.Stock = stock;
    }

    public string Descripcion
    {
      get
      {
        return this.descripcion;
      }
    }

    public double Precio
    {
      get
      {
        return this.precio;
      }
    }

    public int Stock
    {
      get
      {
        return this.stock;
      }

      set
      {
        if (value >= 0)
        {
          this.stock = value;
        }
      }
    }

    public static explicit operator Guid(Producto p)
    {
      return p.codigo;
    }

    public override string ToString()
    {
      StringBuilder datos = new StringBuilder();
      datos.AppendFormat("Descripcion: {0}",this.Descripcion);
      datos.AppendFormat("\nCodigo: {0}",this.codigo);
      datos.AppendFormat("\nPrecio: {0}",this.Precio);
      datos.AppendFormat("\nStock: {0}",this.Stock);
      return datos.ToString();
    }
  }
}
