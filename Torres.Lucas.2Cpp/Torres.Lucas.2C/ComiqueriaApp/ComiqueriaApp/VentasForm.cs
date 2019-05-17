using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComiqueriaLogic;

namespace ComiqueriaApp
{
  public partial class VentasForm : Form
  {
    private Producto producto;
    private Comiqueria comiqueria;

    private VentasForm()
    {
      InitializeComponent();
    }


    public VentasForm(Comiqueria comiqueria, Producto producto) : this()
    {
      this.producto = producto;
      this.comiqueria = comiqueria;
    }

    private void btnVender_Click(object sender, EventArgs e)
    {
      if (numericUpDownCantidad.Value <= comiqueria[(Guid)producto].Stock && numericUpDownCantidad.Value != 0)
      {
        comiqueria.Vender(producto, (int)numericUpDownCantidad.Value);
        this.DialogResult = DialogResult.OK;
        this.Close();
      }
      else
      {
        MessageBox.Show("Stock no disponible", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void VentasForm_Load(object sender, EventArgs e)
    {
      this.lblDescripcion.Text = this.producto.Descripcion;
      this.lblPrecioFinal.Text = "Precio Final: $" + this.producto.Precio;
    }

    private void numericUpDownCantidad_ValueChanged(object sender, EventArgs e)
    {
      lblPrecioFinal.Text = "Precio de Venta: $" + Venta.CalcularPrecioFinal(producto.Precio,(int)numericUpDownCantidad.Value);
    }
  }
}
