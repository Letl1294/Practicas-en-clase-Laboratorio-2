using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
  public class Comic : Producto
  {
    private string autor;
    private TipoComic tipoComic;

        public enum TipoComic
        {
            Occidental,
            Oriental,
        };

        public Comic(string descripcion, int stock, double precio, string autor, TipoComic tipoComic) :base(descripcion,precio,stock)
    {
      this.autor = autor;
      this.tipoComic = tipoComic;
    }

    public override string ToString()
    {
      StringBuilder datos = new StringBuilder();
      datos.AppendFormat("{0}",base.ToString());
      datos.AppendFormat("\nAutor: {0}",this.autor);
      datos.AppendFormat("\nTipo: {0}", this.tipoComic);
      return datos.ToString();
    }
  }
}
