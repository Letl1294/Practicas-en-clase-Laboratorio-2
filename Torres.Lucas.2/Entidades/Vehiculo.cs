using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Vehiculo
    {
        protected DateTime ingreso;
        private string patente;

        public string Patente
        {
            get
            {
                return this.patente;
            }
            set
            {
                if (value.Length == 6)
                {
                    patente = value;
                }
            }
        }
        
        public abstract string consultarDatos();

        public virtual string ImprimirTicket()
        {
            StringBuilder datos = new StringBuilder();
            datos.Append(toString());
            datos.AppendLine();
            datos.AppendFormat("Fecha y hora de ingreso: {0}",this.ingreso.Date.ToString());
            datos.AppendLine();
            datos.AppendLine();
            return datos.ToString();

        }

        public string toString()
        {
            StringBuilder vehiculo = new StringBuilder();
            vehiculo.AppendFormat("Patente: {0}",this.patente);
            vehiculo.AppendLine();
            return vehiculo.ToString();
        }

        public Vehiculo(string patente)
        {
            this.Patente = patente;
            this.ingreso = DateTime.Now.AddHours(-3);
        }

        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            if(v1.patente==v2.patente)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
     }
}
