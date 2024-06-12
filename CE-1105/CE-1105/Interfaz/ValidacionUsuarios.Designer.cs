namespace CE_1105.Interfaz
{
    partial class ValidacionUsuarios
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
            BotonVerificacion = new Button();
            TituloPagina = new Label();
            Usuario = new Label();
            Contrasena = new Label();
            datoUsuario = new TextBox();
            datoContrasena = new TextBox();
            SuspendLayout();
            // 
            // BotonVerificacion
            // 
            BotonVerificacion.BackColor = Color.Blue;
            BotonVerificacion.ForeColor = SystemColors.ButtonFace;
            BotonVerificacion.Location = new Point(342, 322);
            BotonVerificacion.Name = "BotonVerificacion";
            BotonVerificacion.Size = new Size(120, 41);
            BotonVerificacion.TabIndex = 0;
            BotonVerificacion.Text = "Continuar";
            BotonVerificacion.UseVisualStyleBackColor = false;
            BotonVerificacion.Click += BotonVerificacion_Click;
            // 
            // TituloPagina
            // 
            TituloPagina.AutoSize = true;
            TituloPagina.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TituloPagina.Location = new Point(257, 9);
            TituloPagina.Name = "TituloPagina";
            TituloPagina.Size = new Size(300, 38);
            TituloPagina.TabIndex = 1;
            TituloPagina.Text = "Centro de acopio XTEC";
            // 
            // Usuario
            // 
            Usuario.AutoSize = true;
            Usuario.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Usuario.Location = new Point(367, 107);
            Usuario.Name = "Usuario";
            Usuario.Size = new Size(68, 23);
            Usuario.TabIndex = 2;
            Usuario.Text = "Usuario";
            // 
            // Contrasena
            // 
            Contrasena.AutoSize = true;
            Contrasena.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Contrasena.Location = new Point(352, 216);
            Contrasena.Name = "Contrasena";
            Contrasena.Size = new Size(97, 23);
            Contrasena.TabIndex = 3;
            Contrasena.Text = "Contraseña";
            // 
            // datoUsuario
            // 
            datoUsuario.Location = new Point(342, 145);
            datoUsuario.Name = "datoUsuario";
            datoUsuario.Size = new Size(125, 27);
            datoUsuario.TabIndex = 4;
            // 
            // datoContrasena
            // 
            datoContrasena.Location = new Point(342, 251);
            datoContrasena.Name = "datoContrasena";
            datoContrasena.Size = new Size(125, 27);
            datoContrasena.TabIndex = 5;
            // 
            // ValidacionUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(datoContrasena);
            Controls.Add(datoUsuario);
            Controls.Add(Contrasena);
            Controls.Add(Usuario);
            Controls.Add(TituloPagina);
            Controls.Add(BotonVerificacion);
            Name = "ValidacionUsuarios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BotonVerificacion;
        private Label TituloPagina;
        private Label Usuario;
        private Label Contrasena;
        private TextBox datoUsuario;
        private TextBox datoContrasena;
    }
}