using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estacionamiento
    {
        private int espacioDisponible;
        private string nombre;
        private List<Vehiculo> vehiculos;

        private Estacionamiento()
        {
            this.vehiculos = new List<Vehiculo>();
        }

        public Estacionamiento(string nombre,int espacioDisponible) :this()
        {
            this.nombre = nombre;
            this.espacioDisponible = espacioDisponible;
        }
        
        public static explicit operator string(Estacionamiento e)
        {
            StringBuilder estacionamiento = new StringBuilder();
            estacionamiento.AppendFormat("Nombre: {0}",e.nombre);
            estacionamiento.AppendLine();
            estacionamiento.AppendFormat("Espacios: {0}",e.espacioDisponible);

            foreach(Vehiculo auxVehiculo in  e.vehiculos)
            {
                estacionamiento.AppendLine("Datos vehiculo: \n"+auxVehiculo.consultarDatos());
            }

            return estacionamiento.ToString();
        }

        public static bool operator ==(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            foreach(Vehiculo auxVehiculo in estacionamiento.vehiculos)
            {
                if(auxVehiculo == vehiculo)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            return !(estacionamiento == vehiculo);
        }

        public static Estacionamiento operator +(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            if(estacionamiento != vehiculo && vehiculo.Patente!=null && estacionamiento.espacioDisponible > estacionamiento.vehiculos.Count)
            {
                estacionamiento.vehiculos.Add(vehiculo);
                return estacionamiento;
            }
            return estacionamiento;
        }

        public static string operator -(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            foreach(Vehiculo auxVehiculo in estacionamiento.vehiculos)
            {
                if (auxVehiculo == vehiculo)
                {
                    estacionamiento.vehiculos.Remove(vehiculo);
                    return vehiculo.ImprimirTicket();
                }
            }
            return "El vehiculo no es parte del estacionamiento";
        }
    }
}
