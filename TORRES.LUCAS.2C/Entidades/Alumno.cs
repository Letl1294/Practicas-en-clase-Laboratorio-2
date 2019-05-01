using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno : Persona
    {
        private short anio;
        private Divisiones division;
        
        public string AnioDivision
        {
            get
            {
                StringBuilder AnioDiv = new StringBuilder();
                AnioDiv.AppendFormat("{0}°{1}", this.anio, this.division);
                return AnioDiv.ToString();
            }
        }

        public Alumno(string nombre, string apellido, string documento, short anio, Divisiones division):base(nombre, apellido, documento)
        {
            this.anio = anio;
            this.division = division;
        }

        public override string ExponerDatos()
        {
            StringBuilder alumno = new StringBuilder();
            alumno.AppendLine();
            alumno.AppendFormat(base.ExponerDatos());
            alumno.AppendFormat(this.AnioDivision);
            return alumno.ToString();
        }

        public override bool ValidarDocumentacion(string doc)
        {
            if(doc!=null)
            {
               Char[] auxDoc = doc.ToArray<char>();
               for(int i=0;i<auxDoc.Length;i++)
               {
                   if(auxDoc[2]!='-' ||auxDoc[7]!='-'|| auxDoc[i]<0 && auxDoc[i]>9)
                   {
                       return false;
                   }
               }
               return true;
            }
            return false;
        }
    }
}