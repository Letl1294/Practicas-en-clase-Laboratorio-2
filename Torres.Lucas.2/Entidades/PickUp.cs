using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PickUp : Vehiculo
    {
        private string modelo;
        static int valorHora;

        public override string consultarDatos()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendFormat(this.ToString());
            datos.AppendFormat("Modelo: {0}",this.modelo);
            datos.AppendLine();
            datos.AppendFormat("ValorHora: {0}",valorHora);
            datos.AppendLine();
            return datos.ToString();
        }

        public bool Equals(Object obj)
        {
            if(obj is PickUp)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ImprimirTicket()
        {
            StringBuilder ticket = new StringBuilder();
            TimeSpan diferencia = DateTime.Now - this.ingreso;
            int intDiferencia = Convert.ToInt32(diferencia.Hours);
            int costo = intDiferencia * valorHora;
            ticket.AppendFormat(toString());
            ticket.AppendFormat(this.consultarDatos());
            ticket.AppendFormat("Ticket: ${0}", costo);
            return ticket.ToString();
        }

        static PickUp()
        {
            valorHora = 70;
        }

        public PickUp(string patente, string modelo) : base(patente)
        {
            this.modelo = modelo;
        }

        public PickUp(string patente, string modelo, int valorHora1) : this(patente, modelo)
        {
            valorHora = valorHora1;
        }

    }
}
