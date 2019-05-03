using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private string nombre;
        private string apellido;
        private string documento;

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
        }

        public string Documento
        {
            get
            {
                return this.documento;
            }

            set
            {
                if(ValidarDocumentacion(value))
                {
                    this.documento = value;
                }
            }
        }

        public string Nombre
        {
            get
            {
               return this.nombre;
            }
        }

        public virtual string ExponerDatos()
        {
            StringBuilder persona = new StringBuilder();
            persona.AppendLine();
            persona.AppendFormat("Nombre: {0}",this.Nombre);
            persona.AppendLine();
            persona.AppendFormat("Apellido: {0}",this.apellido);
            persona.AppendLine();
            persona.AppendFormat("Documento: {0}",this.documento);
            persona.AppendLine();
            return persona.ToString();
        }

        public Persona(string nombre, string apellido, string documento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.Documento = documento;
        }

        public abstract bool ValidarDocumentacion(string doc);
    }
}
