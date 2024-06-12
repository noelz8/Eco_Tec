namespace CE_1105.Interfaz
{
    partial class VistaCentroAcopio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCrearTransaccion = new Button();
            btnTransaccionCentros = new Button();
            btnAnularTransacciones = new Button();
            btnSalirVistaCentroAcopio = new Button();
            SuspendLayout();
            // 
            // btnCrearTransaccion
            // 
            btnCrearTransaccion.Location = new Point(50, 130);
            btnCrearTransaccion.Name = "btnCrearTransaccion";
            btnCrearTransaccion.Size = new Size(178, 53);
            btnCrearTransaccion.TabIndex = 0;
            btnCrearTransaccion.Text = "Crear transacción";
            btnCrearTransaccion.UseVisualStyleBackColor = true;
            btnCrearTransaccion.Click += btnCrearTransaccion_Click;
            // 
            // btnTransaccionCentros
            // 
            btnTransaccionCentros.Location = new Point(269, 130);
            btnTransaccionCentros.Name = "btnTransaccionCentros";
            btnTransaccionCentros.Size = new Size(204, 53);
            btnTransaccionCentros.TabIndex = 1;
            btnTransaccionCentros.Text = "Ver transacciones de los centros";
            btnTransaccionCentros.UseVisualStyleBackColor = true;
            btnTransaccionCentros.Click += btnTransaccionCentros_Click;
            // 
            // btnAnularTransacciones
            // 
            btnAnularTransacciones.Location = new Point(521, 130);
            btnAnularTransacciones.Name = "btnAnularTransacciones";
            btnAnularTransacciones.Size = new Size(173, 53);
            btnAnularTransacciones.TabIndex = 2;
            btnAnularTransacciones.Text = "Anular transacciones";
            btnAnularTransacciones.UseVisualStyleBackColor = true;
            btnAnularTransacciones.Click += btnAnularTransacciones_Click;
            // 
            // btnSalirVistaCentroAcopio
            // 
            btnSalirVistaCentroAcopio.Location = new Point(300, 317);
            btnSalirVistaCentroAcopio.Name = "btnSalirVistaCentroAcopio";
            btnSalirVistaCentroAcopio.Size = new Size(137, 41);
            btnSalirVistaCentroAcopio.TabIndex = 3;
            btnSalirVistaCentroAcopio.Text = "Salir";
            btnSalirVistaCentroAcopio.UseVisualStyleBackColor = true;
            btnSalirVistaCentroAcopio.Click += btnSalirVistaCentroAcopio_Click;
            // 
            // VistaCentroAcopio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalirVistaCentroAcopio);
            Controls.Add(btnAnularTransacciones);
            Controls.Add(btnTransaccionCentros);
            Controls.Add(btnCrearTransaccion);
            Name = "VistaCentroAcopio";
            Text = "VistaCentroAcopio";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCrearTransaccion;
        private Button btnTransaccionCentros;
        private Button btnAnularTransacciones;
        private Button btnSalirVistaCentroAcopio;
    }
}