using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public class PrestamoPesos : Prestamo
    {
        private float porcentajeInteres;

        public float Interes
        {
            get
            {
                return CalcularInteres();
            }
        }

        private float CalcularInteres()
        {
            return (this.Monto * this.porcentajeInteres)/100;
        }

        public override void ExtenderPlazo(DateTime nuevoVencimiento)
        {
            TimeSpan diferencia = nuevoVencimiento - this.Vencimiento;
            this.porcentajeInteres = (float)(this.porcentajeInteres + (0.25 * diferencia.Days));
            this.Vencimiento = nuevoVencimiento;
        }

        public override string Mostrar()
        {
            StringBuilder datos = new StringBuilder();
            datos.Append(base.Mostrar());
            datos.AppendFormat("\nPorcentaje de interes: {0}",this.porcentajeInteres);
            datos.AppendFormat("\nInteres: {0}",this.Interes);
            return datos.ToString();
        }

        public PrestamoPesos(float monto, DateTime vencimiento, float interes) :base(monto,vencimiento)
        {
            this.porcentajeInteres = interes;
        }

        public PrestamoPesos(Prestamo prestamo,float porcentajeInteres) :this(prestamo.Monto,prestamo.Vencimiento,porcentajeInteres)
        {

        }
    }
}
