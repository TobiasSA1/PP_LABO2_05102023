namespace Formulario
{
    partial class frmCalculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtPrimerOperando = new TextBox();
            txtSegundoOperando = new TextBox();
            cmbOperacion = new ComboBox();
            lblPrimerOperando = new Label();
            btnOperar = new Button();
            btnLimpiar = new Button();
            btnCerrar = new Button();
            lblOperacion = new Label();
            lblSegundoOperando = new Label();
            lblResultado = new Label();
            grpSistema = new GroupBox();
            rdbDecimal = new RadioButton();
            rdbBinario = new RadioButton();
            lstHistorial = new ListBox();
            lblHistorial = new Label();
            grpSistema.SuspendLayout();
            SuspendLayout();
            // 
            // txtPrimerOperando
            // 
            txtPrimerOperando.Location = new Point(29, 328);
            txtPrimerOperando.Name = "txtPrimerOperando";
            txtPrimerOperando.Size = new Size(100, 23);
            txtPrimerOperando.TabIndex = 0;
            // 
            // txtSegundoOperando
            // 
            txtSegundoOperando.Location = new Point(354, 328);
            txtSegundoOperando.Name = "txtSegundoOperando";
            txtSegundoOperando.Size = new Size(100, 23);
            txtSegundoOperando.TabIndex = 1;
            // 
            // cmbOperacion
            // 
            cmbOperacion.FormattingEnabled = true;
            cmbOperacion.Location = new Point(182, 328);
            cmbOperacion.Name = "cmbOperacion";
            cmbOperacion.Size = new Size(121, 23);
            cmbOperacion.TabIndex = 2;
            // 
            // lblPrimerOperando
            // 
            lblPrimerOperando.AutoSize = true;
            lblPrimerOperando.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrimerOperando.Location = new Point(12, 291);
            lblPrimerOperando.Name = "lblPrimerOperando";
            lblPrimerOperando.Size = new Size(139, 21);
            lblPrimerOperando.TabIndex = 3;
            lblPrimerOperando.Text = "Primer operando:";
            // 
            // btnOperar
            // 
            btnOperar.Location = new Point(29, 382);
            btnOperar.Name = "btnOperar";
            btnOperar.Size = new Size(100, 28);
            btnOperar.TabIndex = 4;
            btnOperar.Text = "OPERAR";
            btnOperar.UseVisualStyleBackColor = true;
            btnOperar.Click += btnOperar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(182, 382);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(121, 28);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(354, 382);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(100, 28);
            btnCerrar.TabIndex = 6;
            btnCerrar.Text = "CERRAR";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // lblOperacion
            // 
            lblOperacion.AutoSize = true;
            lblOperacion.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblOperacion.Location = new Point(201, 291);
            lblOperacion.Name = "lblOperacion";
            lblOperacion.Size = new Size(87, 21);
            lblOperacion.TabIndex = 7;
            lblOperacion.Text = "Operando:";
            lblOperacion.TextAlign = ContentAlignment.TopRight;
            // 
            // lblSegundoOperando
            // 
            lblSegundoOperando.AutoSize = true;
            lblSegundoOperando.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSegundoOperando.Location = new Point(330, 291);
            lblSegundoOperando.Name = "lblSegundoOperando";
            lblSegundoOperando.Size = new Size(153, 21);
            lblSegundoOperando.TabIndex = 8;
            lblSegundoOperando.Text = "Segundo operando:";
            lblSegundoOperando.TextAlign = ContentAlignment.TopRight;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Yu Gothic", 20.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblResultado.Location = new Point(12, 25);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(161, 36);
            lblResultado.TabIndex = 9;
            lblResultado.Text = "Resultado:";
            // 
            // grpSistema
            // 
            grpSistema.Controls.Add(rdbDecimal);
            grpSistema.Controls.Add(rdbBinario);
            grpSistema.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            grpSistema.Location = new Point(130, 162);
            grpSistema.Name = "grpSistema";
            grpSistema.Size = new Size(231, 77);
            grpSistema.TabIndex = 10;
            grpSistema.TabStop = false;
            grpSistema.Text = "Representar resultado en:";
            // 
            // rdbDecimal
            // 
            rdbDecimal.AutoSize = true;
            rdbDecimal.Location = new Point(17, 33);
            rdbDecimal.Name = "rdbDecimal";
            rdbDecimal.Size = new Size(101, 25);
            rdbDecimal.TabIndex = 1;
            rdbDecimal.TabStop = true;
            rdbDecimal.Text = "DECIMAL";
            rdbDecimal.UseVisualStyleBackColor = true;
            rdbDecimal.CheckedChanged += rdbDecimal_CheckedChanged;
            // 
            // rdbBinario
            // 
            rdbBinario.AutoSize = true;
            rdbBinario.Location = new Point(127, 33);
            rdbBinario.Name = "rdbBinario";
            rdbBinario.Size = new Size(94, 25);
            rdbBinario.TabIndex = 0;
            rdbBinario.TabStop = true;
            rdbBinario.Text = "BINARIO";
            rdbBinario.UseVisualStyleBackColor = true;
            rdbBinario.CheckedChanged += rdbBinario_CheckedChanged;
            // 
            // lstHistorial
            // 
            lstHistorial.FormattingEnabled = true;
            lstHistorial.ItemHeight = 15;
            lstHistorial.Location = new Point(525, 137);
            lstHistorial.Name = "lstHistorial";
            lstHistorial.Size = new Size(529, 289);
            lstHistorial.TabIndex = 11;
            // 
            // lblHistorial
            // 
            lblHistorial.AutoSize = true;
            lblHistorial.Font = new Font("Yu Gothic", 20.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblHistorial.Location = new Point(518, 95);
            lblHistorial.Name = "lblHistorial";
            lblHistorial.Size = new Size(140, 36);
            lblHistorial.TabIndex = 12;
            lblHistorial.Text = "Historial:";
            lblHistorial.TextAlign = ContentAlignment.TopRight;
            // 
            // frmCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1076, 450);
            Controls.Add(lblHistorial);
            Controls.Add(lstHistorial);
            Controls.Add(grpSistema);
            Controls.Add(lblResultado);
            Controls.Add(lblSegundoOperando);
            Controls.Add(lblOperacion);
            Controls.Add(btnCerrar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnOperar);
            Controls.Add(lblPrimerOperando);
            Controls.Add(cmbOperacion);
            Controls.Add(txtSegundoOperando);
            Controls.Add(txtPrimerOperando);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCalculadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora de alumno: Tobias Suarez";
            Load += frmCalculadora_Load;
            grpSistema.ResumeLayout(false);
            grpSistema.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPrimerOperando;
        private TextBox txtSegundoOperando;
        private ComboBox cmbOperacion;
        private Label lblPrimerOperando;
        private Button btnOperar;
        private Button btnLimpiar;
        private Button btnCerrar;
        private Label lblOperacion;
        private Label lblSegundoOperando;
        private Label lblResultado;
        private GroupBox grpSistema;
        private RadioButton rdbDecimal;
        private RadioButton rdbBinario;
        private ListBox lstHistorial;
        private Label lblHistorial;
    }
}