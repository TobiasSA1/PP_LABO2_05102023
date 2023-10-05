using Entidades;
using static Entidades.Numeracion;

namespace Formulario
{
    public partial class frmCalculadora : Form
    {
        private Calculadora calculadora;
        public frmCalculadora()
        {
            InitializeComponent();
            this.calculadora = new Calculadora("Tobias Suarez");
        }

        private void frmCalculadora_Load(object sender, EventArgs e)
        {
            this.cmbOperacion.DataSource = new char[] { '+', '-', '*', '/' };
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            char operador;
            string valorPrimerOperando = this.txtPrimerOperando.Text;
            string valorSegundoOperando = this.txtSegundoOperando.Text;

            // Validar el sistema actual de la calculadora
            if (Calculadora.Sistema == Numeracion.ESistema.Decimal)
            {
                if (!SistemaDecimal.EsSistemaDecimalValido(valorPrimerOperando) || !SistemaDecimal.EsSistemaDecimalValido(valorSegundoOperando))
                {
                    MessageBox.Show("Por favor, ingrese números válidos en sistema decimal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Detener la operación si los operandos no son válidos.
                }
            }
            else if (Calculadora.Sistema == Numeracion.ESistema.Binario)
            {
                if (!SistemaBinario.EsSistemaBinarioValido(valorPrimerOperando) || !SistemaBinario.EsSistemaBinarioValido(valorSegundoOperando))
                {
                    MessageBox.Show("Por favor, ingrese números válidos en sistema binario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Detener la operación si los operandos no son válidos.
                }
            }

            operador = (char)this.cmbOperacion.SelectedItem;
            this.calculadora.PrimerOperando = this.GetOperando(valorPrimerOperando);
            this.calculadora.SegundoOperando = this.GetOperando(valorSegundoOperando);
            this.calculadora.Calcular(operador);
            this.calculadora.ActualizaHistorialDeOperaciones(operador);
            this.lblResultado.Text = $"Resultado: {calculadora.Resultado.Valor}";
            this.MostrarHistorial();
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.calculadora.EliminarHistorialDeOperaciones();
            this.txtPrimerOperando.Text = string.Empty;
            this.txtSegundoOperando.Text = string.Empty;
            this.lblResultado.Text = $"Resultado:";
            this.MostrarHistorial();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdbDecimal_CheckedChanged(object sender, EventArgs e)
        {
            Calculadora.Sistema = ESistema.Decimal;
        }
        private void rdbBinario_CheckedChanged(object sender, EventArgs e)
        {
            Calculadora.Sistema = ESistema.Binario;
        }
        void MostrarHistorial()
        {
            this.lstHistorial.DataSource = null;
            this.lstHistorial.DataSource =
            this.calculadora.Operaciones;
        }

        public Numeracion GetOperando(string value)
        {
            if (Calculadora.Sistema == ESistema.Binario)
            {
                return new SistemaBinario(value);
            }
            return new SistemaDecimal(value);
        }
    }
}