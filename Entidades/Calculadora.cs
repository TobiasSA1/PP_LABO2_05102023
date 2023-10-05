using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        private string nombreAlumno;
        private List<string> operaciones;
        private Numeracion primerOperando;
        private Numeracion resultado;
        private Numeracion segundoOperando;
        private static Numeracion.ESistema sistema = Numeracion.ESistema.Decimal;
        public string NombreAlumno
        {
            get { return nombreAlumno; }
            set { nombreAlumno = value; }
        }

        public List<string> Operaciones
        {
            get { return operaciones; }
        }

        public Numeracion PrimerOperando
        {
            get { return primerOperando; }
            set { primerOperando = value; }
        }

        public Numeracion Resultado
        {
            get { return resultado; }
        }

        public Numeracion SegundoOperando
        {
            get { return segundoOperando; }
            set { segundoOperando = value; }
        }

        public static Numeracion.ESistema Sistema
        {
            get { return sistema; }
            set { sistema = value; }
        }

        public Calculadora()
        {
            operaciones = new List<string>();
        }

        public Calculadora(string nombre)
        {
            nombreAlumno = nombre;
            operaciones = new List<string>();
        }

        public void Calcular()
        {
            Calcular('+');
        }

        public void Calcular(char operador)
        {
            if (primerOperando is not null && segundoOperando is not null && primerOperando.GetType() == segundoOperando.GetType())
            {
                double valor1 = (double)primerOperando;
                double valor2 = (double)segundoOperando;

                switch (operador)
                {
                    case '+':
                        resultado = new SistemaDecimal((valor1 + valor2).ToString());
                        break;
                    case '-':
                        resultado = new SistemaDecimal((valor1 - valor2).ToString());
                        break;
                    case '*':
                        resultado = new SistemaDecimal((valor1 * valor2).ToString());
                        break;
                    case '/':
                        if (valor2 != 0)
                        {
                            resultado = new SistemaDecimal((valor1 / valor2).ToString());
                        }
                        else
                        {
                            resultado = new SistemaDecimal("División por cero");
                        }
                        break;
                    default:
                        resultado = new SistemaDecimal("Operador no válido");
                        break;
                }

                // Actualizar el historial de operaciones
                //ActualizaHistorialDeOperaciones(operador);
            }
            else
            {
                resultado = new SistemaDecimal("Operación inválida");
            }
        }

        public void ActualizaHistorialDeOperaciones(char operador)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Sistema: {Sistema}, ");
            sb.Append($"Primer Operando: {primerOperando.ValorNumerico}, ");
            sb.Append($"Segundo Operando: {segundoOperando.ValorNumerico}, ");
            sb.Append($"Operador: {operador}");
            operaciones.Add(sb.ToString());
        }

        public void EliminarHistorialDeOperaciones()
        {
            operaciones.Clear();
        }

        public Numeracion MapeaResultado(double valor)
        {
            switch (Sistema)
            {
                case Numeracion.ESistema.Decimal:
                    return new SistemaDecimal(valor.ToString());
                case Numeracion.ESistema.Binario:
                    return new SistemaBinario(Convert.ToString((int)valor, 2));
                default:
                    // Otros sistemas de numeración podrían ser manejados aquí
                    return new SistemaDecimal(valor.ToString());
            }
        }
    }
}

