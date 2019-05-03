using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Curso
    {
        private List<Alumno> alumnos;
        private short anio;
        private Divisiones division;
        private Profesor profesor;  

        public string AnioDivison
        {
            get
            {
                StringBuilder AnioDiv = new StringBuilder();
                AnioDiv.AppendFormat("{0}°{1}", this.anio,this.division);
                return AnioDiv.ToString();
            }
        }

        private Curso()
        {
            alumnos = new List<Alumno>();
        }

        public Curso(short anio,Divisiones division, Profesor profesor) : this()
        {
            this.anio = anio;
            this.division = division;
            this.profesor = profesor;
        }

        public static explicit operator string(Curso c)
        {
            StringBuilder curso = new StringBuilder();
            curso.AppendFormat("Curso: {0}",c.AnioDivison);
            curso.AppendLine();
            curso.AppendFormat("Profesor: {0}", c.profesor.ExponerDatos());
            curso.AppendLine();
            foreach(Alumno alumno in c.alumnos)
            {
               curso.AppendFormat(alumno.ExponerDatos());
            }
            return curso.ToString();
        }

        public static bool operator !=(Curso c, Alumno a)
        {
            string curso = c.AnioDivison;
            string alumno = a.AnioDivision;
            if (curso != alumno)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Curso operator +(Curso c, Alumno a)
        {
            if (c.AnioDivison == a.AnioDivision)
            {
                c.alumnos.Add(a);
            }
            return c;
        }

        public static bool operator ==(Curso C, Alumno a)
        {
            string curso = C.AnioDivison;
            string alumno = a.AnioDivision;
            if(curso==alumno)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}