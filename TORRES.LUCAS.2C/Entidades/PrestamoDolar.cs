using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public class PrestamoDolar : Prestamo
    {
        private PeridiocidadDePagos peridiocidad;

        public float Interes
        {
            get
            {
                return CalcularInteres();
            }
        }

        public PeridiocidadDePagos Peridiocidad
        {
            get
            {
                return this.peridiocidad;
            }
        }

        private float CalcularInteres()
        {
            if(this.Peridiocidad == PeridiocidadDePagos.Mensual)
            {
                return (float)(this.Monto*1.25);
            }
            if(this.Peridiocidad == PeridiocidadDePagos.Bimestral)
            {
                return (float)(this.Monto * 1.35);
            }
            if(this.Peridiocidad == PeridiocidadDePagos.Trimestral)
            {
                return (float)(this.Monto * 1.50);
            }
            return 0;
        }

        public override void ExtenderPlazo(DateTime nuevoVencimiento)
        {
            TimeSpan diferencia = nuevoVencimiento - this.Vencimiento;
            this.monto = (float)(2.5*diferencia.Days);
            this.Vencimiento = nuevoVencimiento;
        }

        public override string Mostrar()
        {
            StringBuilder datos = new StringBuilder();
            datos.Append(base.Mostrar());
            datos.AppendFormat("\nPeridiocidad: {0}",this.peridiocidad);
            datos.AppendFormat("\nInteres: {0}",this.Interes);
            return datos.ToString();
        }

        public PrestamoDolar(float monto, DateTime vencimiento, PeridiocidadDePagos peridiocidad) :base(monto,vencimiento)
        {
            this.peridiocidad = peridiocidad;
        }

        public PrestamoDolar(Prestamo prestamo, PeridiocidadDePagos peridiocidad) : this(prestamo.Monto,prestamo.Vencimiento,peridiocidad)
        {       
        }

    }
}
