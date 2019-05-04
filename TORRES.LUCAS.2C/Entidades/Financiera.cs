using PrestamosPersonales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadFinanciera
{
    public class Financiera
    {
        private List<Prestamo> listaDePrestamos;
        private string razonSocial;
        
        public float InteresEnDolares
        {
            get
            {
                return CalcularInteresGanando(TipoDePrestamo.Dolares);
            }
        }

        public float InteresEnPesos
        {
            get
            {
                return CalcularInteresGanando(TipoDePrestamo.Pesos);
            }
        }

        public float InteresesTotales
        {
            get
            {
                return CalcularInteresGanando(TipoDePrestamo.Todos);
            }
        }

        public List<Prestamo> ListaDePrestamos
        {
            get
            {
                return listaDePrestamos;
            }
        }

        public string RazonSocial
        {
            get
            {
                return razonSocial;
            }
        }

        private float CalcularInteresGanando(TipoDePrestamo tipoPrestamo)
        {
            float intereses=0;

            switch (tipoPrestamo)
            {
                case TipoDePrestamo.Dolares:
                foreach (Prestamo prestamo in this.ListaDePrestamos)
                {
                    if (prestamo is PrestamoDolar)
                    {
                        intereses += ((PrestamoDolar)(prestamo)).Interes;
                    }
                 
                }
                break;

                case TipoDePrestamo.Pesos:
                foreach(Prestamo prestamo in this.ListaDePrestamos)
                {
                    if(prestamo is PrestamoPesos)
                    {
                        intereses += ((PrestamoPesos)(prestamo)).Interes;
                    }
                }
                break;

                case TipoDePrestamo.Todos:
                intereses +=this.InteresEnDolares+this.InteresEnPesos;
                break;
            }
     
            return intereses;
        }

        private Financiera()
        {
            listaDePrestamos = new List<Prestamo>();
        }

        public Financiera(string razonSocial) :this()
        {
            this.razonSocial = razonSocial;
        }

        public static string Mostrar(Financiera financiera)
        {
            return (string)financiera;
        }

        public void OrdenarPrestamos()
        {
            this.ListaDePrestamos.Sort(Prestamo.OrdenarPorFecha);
        }

        public static explicit operator string(Financiera financiera)
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendFormat("Razon Social: {0}", financiera.RazonSocial);
            datos.AppendFormat("\nIntereses ganados: {0}", financiera.InteresesTotales);
            datos.AppendFormat("\nIntereses en Dolares:{0}", financiera.InteresEnDolares);
            datos.AppendFormat("\nIntereses en Pesos:{0}", financiera.InteresEnPesos);

            foreach (Prestamo prestamo in financiera.ListaDePrestamos)
            {
                if(prestamo is PrestamoPesos)
                {
                    datos.AppendLine(prestamo.Mostrar());
                    datos.Append(TipoDePrestamo.Pesos);
                }
                else
                {
                    datos.AppendLine(prestamo.Mostrar());
                    datos.Append(TipoDePrestamo.Dolares);
                }
            }
            return datos.ToString();
        }

        public static bool operator !=(Financiera financiera, Prestamo prestamo)
        {
            return !(financiera == prestamo);
        }

        public static bool operator ==(Financiera financiera, Prestamo prestamo)
        {
            if (financiera.ListaDePrestamos.Contains(prestamo))
            {
                return true;
            }
            return false;
        }

        public static Financiera operator +(Financiera financiera, Prestamo prestamosNuevo)
        {
            if(financiera!=prestamosNuevo)
            {
                financiera.ListaDePrestamos.Add(prestamosNuevo);
            }
            return financiera;
        }


    }
}
