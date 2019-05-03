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
                return InteresEnDolares;
            }
        }

        public float InteresEnPesos
        {
            get
            {
                return InteresEnPesos;
            }
        }

        public float InteresesTotales
        {
            get
            {
                return InteresesTotales; 
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
            return 2;
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
            return "";
        }

        public void OrdenarPrestamos()
        {

        }

        public static explicit operator string(Financiera financiera)
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendFormat("Razon Social: {0}",financiera.RazonSocial);
            datos.AppendFormat("\nIntereses ganados: {0}",financiera.InteresesTotales);
            datos.AppendFormat("\nIntereses en Dolares:{0}",financiera.InteresEnDolares);
            datos.AppendFormat("\nIntereses en Pesos:{0}",financiera.InteresEnPesos);
            

            return datos.ToString();
        }

        public static bool operator !=(Financiera financiera, Prestamo prestamo)
        {
            return !(financiera == prestamo);
        }

        public static bool operator ==(Financiera financiera, Prestamo prestamo)
        {
            if (financiera == prestamo)
                return true;
            return false;
        }

        public static Financiera operator +(Financiera financiera, Prestamo prestamosNuevo)
        {
            financiera.ListaDePrestamos.Add(prestamosNuevo);
            return financiera;
        }


    }
}
