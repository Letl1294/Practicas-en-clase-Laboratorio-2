using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Profesor : Persona
    {
        private DateTime fechaIngreso;

        public int Antiguedad
        {
            get
            {
                TimeSpan antiguedad = DateTime.Now - this.fechaIngreso;
                return antiguedad.Days;
            }
        }

        public override string ExponerDatos()
        {
            StringBuilder profesor = new StringBuilder();
            profesor.AppendFormat(base.ExponerDatos());
            profesor.AppendFormat("Fecha ingreso: {0} - Antiguedad en dias: {1}",this.fechaIngreso,this.Antiguedad);
            return profesor.ToString();
        }

        public Profesor(string nombre, string apellido, string documento):base(nombre,apellido,documento)
        {
        }

        public Profesor(string nombre, string apellido, string documento, DateTime fechaIngreso) : this(nombre,apellido,documento)
        {
            this.fechaIngreso = fechaIngreso;
        }

        public override bool ValidarDocumentacion(string doc)
        {
            if(doc!=null)
            {
                if(doc.Length==8)
                {
                    return true;
                }
                return false;  
            }
            return false;
        }
    }
}
