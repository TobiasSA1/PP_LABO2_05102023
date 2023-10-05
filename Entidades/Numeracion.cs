using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Numeracion
    {
        //Esistema de Numeracion
        public enum ESistema
        {
            Decimal,
            Binario
        }

        //Atributos Numeracion
        protected static string msgError;
        protected string valor;

        //Constructor Numeracion
        protected Numeracion(string valor)
        {
            InicializaValor(valor);
        }

        static Numeracion()
        {
            msgError = "Numero Invalido";
        }

        //Metodo para inicializar el valor
        private void InicializaValor(string valor)
        {
            if (EsNumeracionValida(valor))
            {
                this.valor = valor;
            }
            else
            {
                this.valor = msgError;
            }
        }

        //Aplicar de forma obligatoria en clases derivadas
        abstract internal double ValorNumerico
        {
            get;
        }
        //Propiedad Valor
        public string Valor 
        { 
            get 
            {
                return valor; 
            }
        }
        public abstract Numeracion CambiarSistemaDeNumeracion(ESistema sistema);

        // Método protegido para verificar si la numeración es válida
        protected bool EsNumeracionValida(string value)
        {
            return !string.IsNullOrWhiteSpace(value);
        }

        public static explicit operator double(Numeracion numeracion)
        {
            if (numeracion is null || !numeracion.EsNumeracionValida(numeracion.valor))
            {
                return 0.0;
            }

            if (double.TryParse(numeracion.valor, out double result))
            {
                return result;
            }

            return 0.0;
        }

        //Sobrecarga para decir que dos numeraciones serán iguales si no son nulas y son del mismo tipo.
        public static bool operator ==(Numeracion n1, Numeracion n2)
        {
            if (ReferenceEquals(n1, null) && ReferenceEquals(n2, null))
            {
                return true;
            }

            if (ReferenceEquals(n1, null) || ReferenceEquals(n2, null))
            {
                return false;
            }

            return n1.GetType() == n2.GetType() && n1.Valor == n2.Valor;
        }
        //Sobrecarga para decir que dos numeraciones serán iguales si no son nulas y son del mismo tipo.

        public static bool operator !=(Numeracion n1, Numeracion n2)
        {
            return !(n1 == n2);
        }

        //agregaer get hashcode y equals?
    }
}
