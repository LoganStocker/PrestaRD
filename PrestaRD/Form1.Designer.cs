namespace PrestaRD
{
    partial class Form1
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
            txtCliente = new TextBox();
            nudEdad = new NumericUpDown();
            cmbTipo = new ComboBox();
            nudIngreso = new NumericUpDown();
            nudMonto = new NumericUpDown();
            nudPlazo = new NumericUpDown();
            chkAtrasos = new CheckBox();
            nudPago = new NumericUpDown();
            btnEvaluar = new Button();
            btnTabla = new Button();
            btnSimular = new Button();
            btnRegistrar = new Button();
            btnCartera = new Button();
            lblResultado = new Label();
            lblResumen = new Label();
            lstSalida = new ListBox();
            lstPrestamos = new ListBox();
            ((System.ComponentModel.ISupportInitialize)nudEdad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudIngreso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMonto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPlazo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPago).BeginInit();
            SuspendLayout();
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(20, 40);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(150, 27);
            txtCliente.TabIndex = 0;
            // 
            // nudEdad
            // 
            nudEdad.Location = new Point(20, 96);
            nudEdad.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
            nudEdad.Name = "nudEdad";
            nudEdad.Size = new Size(150, 27);
            nudEdad.TabIndex = 1;
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(20, 155);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(151, 28);
            cmbTipo.TabIndex = 2;
            // 
            // nudIngreso
            // 
            nudIngreso.Location = new Point(201, 96);
            nudIngreso.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nudIngreso.Name = "nudIngreso";
            nudIngreso.Size = new Size(150, 27);
            nudIngreso.TabIndex = 3;
            // 
            // nudMonto
            // 
            nudMonto.Location = new Point(20, 218);
            nudMonto.Maximum = new decimal(new int[] { 50000000, 0, 0, 0 });
            nudMonto.Name = "nudMonto";
            nudMonto.Size = new Size(150, 27);
            nudMonto.TabIndex = 4;
            // 
            // nudPlazo
            // 
            nudPlazo.Location = new Point(201, 218);
            nudPlazo.Maximum = new decimal(new int[] { 240, 0, 0, 0 });
            nudPlazo.Name = "nudPlazo";
            nudPlazo.Size = new Size(150, 27);
            nudPlazo.TabIndex = 5;
            // 
            // chkAtrasos
            // 
            chkAtrasos.AutoSize = true;
            chkAtrasos.Location = new Point(20, 260);
            chkAtrasos.Name = "chkAtrasos";
            chkAtrasos.Size = new Size(249, 24);
            chkAtrasos.TabIndex = 6;
            chkAtrasos.Text = "Tiene atrasos en otros prestamos";
            chkAtrasos.UseVisualStyleBackColor = true;
            // 
            // nudPago
            // 
            nudPago.Location = new Point(20, 302);
            nudPago.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudPago.Name = "nudPago";
            nudPago.Size = new Size(150, 27);
            nudPago.TabIndex = 7;
            // 
            // btnEvaluar
            // 
            btnEvaluar.Location = new Point(20, 361);
            btnEvaluar.Name = "btnEvaluar";
            btnEvaluar.Size = new Size(94, 29);
            btnEvaluar.TabIndex = 8;
            btnEvaluar.Text = "Evaluar";
            btnEvaluar.UseVisualStyleBackColor = true;
            // 
            // btnTabla
            // 
            btnTabla.Location = new Point(140, 361);
            btnTabla.Name = "btnTabla";
            btnTabla.Size = new Size(94, 29);
            btnTabla.TabIndex = 9;
            btnTabla.Text = "Tabla";
            btnTabla.UseVisualStyleBackColor = true;
            // 
            // btnSimular
            // 
            btnSimular.Location = new Point(257, 361);
            btnSimular.Name = "btnSimular";
            btnSimular.Size = new Size(113, 29);
            btnSimular.TabIndex = 10;
            btnSimular.Text = "Simular Pago";
            btnSimular.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(401, 361);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(94, 29);
            btnRegistrar.TabIndex = 11;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // btnCartera
            // 
            btnCartera.Location = new Point(531, 361);
            btnCartera.Name = "btnCartera";
            btnCartera.Size = new Size(94, 29);
            btnCartera.TabIndex = 12;
            btnCartera.Text = "Cartera";
            btnCartera.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(21, 407);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(75, 20);
            lblResultado.TabIndex = 13;
            lblResultado.Text = "Resultado";
            // 
            // lblResumen
            // 
            lblResumen.AutoSize = true;
            lblResumen.Location = new Point(119, 409);
            lblResumen.Name = "lblResumen";
            lblResumen.Size = new Size(69, 20);
            lblResumen.TabIndex = 14;
            lblResumen.Text = "Resumen";
            // 
            // lstSalida
            // 
            lstSalida.FormattingEnabled = true;
            lstSalida.Location = new Point(21, 439);
            lstSalida.Name = "lstSalida";
            lstSalida.Size = new Size(433, 184);
            lstSalida.TabIndex = 15;
            // 
            // lstPrestamos
            // 
            lstPrestamos.FormattingEnabled = true;
            lstPrestamos.Location = new Point(460, 439);
            lstPrestamos.Name = "lstPrestamos";
            lstPrestamos.Size = new Size(417, 184);
            lstPrestamos.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 637);
            Controls.Add(lstPrestamos);
            Controls.Add(lstSalida);
            Controls.Add(lblResumen);
            Controls.Add(lblResultado);
            Controls.Add(btnCartera);
            Controls.Add(btnRegistrar);
            Controls.Add(btnSimular);
            Controls.Add(btnTabla);
            Controls.Add(btnEvaluar);
            Controls.Add(nudPago);
            Controls.Add(chkAtrasos);
            Controls.Add(nudPlazo);
            Controls.Add(nudMonto);
            Controls.Add(nudIngreso);
            Controls.Add(cmbTipo);
            Controls.Add(nudEdad);
            Controls.Add(txtCliente);
            Name = "Form1";
            Text = "PrestaRD";
            ((System.ComponentModel.ISupportInitialize)nudEdad).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudIngreso).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMonto).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPlazo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPago).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCliente;
        private NumericUpDown nudEdad;
        private ComboBox cmbTipo;
        private NumericUpDown nudIngreso;
        private NumericUpDown nudMonto;
        private NumericUpDown nudPlazo;
        private CheckBox chkAtrasos;
        private NumericUpDown nudPago;
        private Button btnEvaluar;
        private Button btnTabla;
        private Button btnSimular;
        private Button btnRegistrar;
        private Button btnCartera;
        private Label lblResultado;
        private Label lblResumen;
        private ListBox lstSalida;
        private ListBox lstPrestamos;
    }
}
