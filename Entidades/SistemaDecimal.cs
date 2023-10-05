namespace Entidades
{
    public class SistemaDecimal : Numeracion
    {
        public SistemaDecimal(string valor) : base(valor)
        {
        }
        internal override double ValorNumerico
        {
            get
            {
                if (double.TryParse(Valor, out double result))
                {
                    return result;
                }
                return 0.0;
            }
        }
        public override Numeracion CambiarSistemaDeNumeracion(ESistema sistema)
        {
            if (sistema == ESistema.Decimal)
            {
                return this;
            }
            else if (sistema == ESistema.Binario)
            {
                return DecimalABinario();
            }
            else
            {
                // Otros sistemas de numeración podrían ser manejados aquí
                return this;
            }
        }
        public SistemaBinario DecimalABinario()
        {
            if (double.TryParse(Valor, out double numero) && numero > 0)
            {
                int numeroEntero = (int)numero;
                return new SistemaBinario(Convert.ToString(numeroEntero, 2));
            }
            else
            {
                return new SistemaBinario(msgError);
            }
        }

        public static bool EsSistemaDecimalValido(string valor)
        {
            return double.TryParse(valor, out _);
        }

        // Conversiones implícitas
        public static implicit operator SistemaDecimal(double valor)
        {
            return new SistemaDecimal(valor.ToString());
        }

        public static implicit operator SistemaDecimal(string valor)
        {
            return new SistemaDecimal(valor);
        }
    }
}
