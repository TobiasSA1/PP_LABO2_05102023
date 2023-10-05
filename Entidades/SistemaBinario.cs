using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SistemaBinario : Numeracion
    {
        public SistemaBinario(string valor) : base(valor) { }

        public override Numeracion CambiarSistemaDeNumeracion(ESistema sistema)
        {
            if (sistema == ESistema.Binario)
            {
                return this;
            }
            else if (sistema == ESistema.Decimal)
            {
                return BinarioADecimal();
            }
            else
            {
                // Otros sistemas de numeración podrían ser manejados aquí
                return this;
            }
        }

        public SistemaDecimal BinarioADecimal()
        {
            if (!Valor.Contains(msgError))
            {
                int valorDecimal = 0;
                int binario = 1;

                for (int i = Valor.Length - 1; i >= 0; i--)
                {
                    if (Valor[i] == '1')
                    {
                        valorDecimal += binario;
                    }
                    binario *= 2;
                }

                return new SistemaDecimal(valorDecimal.ToString());
            }
            else
            {
                return new SistemaDecimal(msgError);
            }
        }

        internal override double ValorNumerico
        {
            get
            {
                if (!Valor.Contains(msgError) && !string.IsNullOrWhiteSpace(Valor))
                {
                    return BinarioADecimal().ValorNumerico;
                }
                return 0.0;
            }
        }

        // Método para verificar si la cadena es un sistema binario válido
        public static bool EsSistemaBinarioValido(string valor)
        {
            foreach (char digito in valor)
            {
                if (digito != '0' && digito != '1')
                {
                    return false;
                }
            }

            return true;
        }

        // Conversión implícita de string a SistemaBinario
        public static implicit operator SistemaBinario(string valor)
        {
            return new SistemaBinario(valor);
        }
    }


}

