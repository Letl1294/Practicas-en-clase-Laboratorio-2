using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Automovil : Vehiculo
    {
        private ConsoleColor color;
        static int valorHora;

        static Automovil()
        {
            valorHora = 50;
        }

        public Automovil(string patente, ConsoleColor color) : base(patente)
        {
            this.color = color;
        }

        public Automovil(string patente, ConsoleColor color, int valorHora2) : this(patente,color)
        {
            valorHora = valorHora2;
        }

        public override string consultarDatos()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendFormat(this.toString());
            datos.AppendFormat("ValorHora",valorHora);
            datos.AppendFormat("Color",this.color.ToString());
            datos.AppendLine();
            return datos.ToString();
        }

        public bool Equals(object obj)
        {
            if(obj is Automovil)
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
            ticket.AppendFormat("Ticket: ${0}",costo);
            return ticket.ToString();
        }

    }
}
