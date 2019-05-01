using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : Vehiculo
    {
        private int cilindrada;
        private short ruedas;
        static int valorHora;

        public override string consultarDatos()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendFormat(toString());
            datos.AppendLine();
            datos.AppendFormat("Cilindrada: {0}",this.cilindrada);
            datos.AppendLine();
            datos.AppendFormat("Ruedas: {0}",this.ruedas);
            datos.AppendLine();
            datos.AppendFormat("ValorHora: {0}",valorHora);
            datos.AppendLine();
            return datos.ToString();
        }

        public bool Equals(Object obj)
        {
            if(obj is Moto)
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
            ticket.AppendLine();
            ticket.AppendFormat("Ticket: ${0}", costo);
            ticket.AppendLine();
            return ticket.ToString();
        }

        static Moto()
        {
            valorHora = 30;
        }

        public Moto(string patente, int cilindrada) : base(patente)
        {
            this.cilindrada = cilindrada;
        }

        public Moto(string patente, int cilindrada, short ruedas) :this(patente, cilindrada)
        {
            this.ruedas = 2;
        }

        public Moto(string patente, int cilindrada, short ruedas, int valorHora1) : this(patente, cilindrada,ruedas)
        {
            valorHora = valorHora1;
        }
    }
}