namespace CE_1105
{
    partial class Centro
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
            BtnAceptar = new Button();
            comboBox1 = new ComboBox();
            TBContacto = new TextBox();
            TBIde = new TextBox();
            TBUbicacion = new TextBox();
            LblDatos = new Label();
            LblSede = new Label();
            LblIde = new Label();
            LblContacto = new Label();
            LblUbicacion = new Label();
            BtnRegresar = new Button();
            ActivoInactivo = new CheckBox();
            SuspendLayout();
            // 
            // BtnAceptar
            // 
            BtnAceptar.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAceptar.Location = new Point(323, 215);
            BtnAceptar.Name = "BtnAceptar";
            BtnAceptar.Size = new Size(131, 48);
            BtnAceptar.TabIndex = 0;
            BtnAceptar.Text = "Aceptar";
            BtnAceptar.UseVisualStyleBackColor = true;
            BtnAceptar.Click += BtnAceptar_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(221, 160);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(155, 26);
            comboBox1.TabIndex = 1;
            // 
            // TBContacto
            // 
            TBContacto.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TBContacto.Location = new Point(395, 160);
            TBContacto.Name = "TBContacto";
            TBContacto.Size = new Size(155, 26);
            TBContacto.TabIndex = 2;
            // 
            // TBIde
            // 
            TBIde.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TBIde.Location = new Point(24, 160);
            TBIde.Name = "TBIde";
            TBIde.Size = new Size(155, 26);
            TBIde.TabIndex = 3;
            // 
            // TBUbicacion
            // 
            TBUbicacion.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TBUbicacion.Location = new Point(580, 160);
            TBUbicacion.Name = "TBUbicacion";
            TBUbicacion.Size = new Size(155, 26);
            TBUbicacion.TabIndex = 4;
            // 
            // LblDatos
            // 
            LblDatos.AutoSize = true;
            LblDatos.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblDatos.Location = new Point(126, 27);
            LblDatos.Name = "LblDatos";
            LblDatos.Size = new Size(464, 32);
            LblDatos.TabIndex = 5;
            LblDatos.Text = "Por favor ingresar todos los datos";
            // 
            // LblSede
            // 
            LblSede.AutoSize = true;
            LblSede.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblSede.Location = new Point(275, 107);
            LblSede.Name = "LblSede";
            LblSede.Size = new Size(48, 19);
            LblSede.TabIndex = 6;
            LblSede.Text = "Sede";
            // 
            // LblIde
            // 
            LblIde.AutoSize = true;
            LblIde.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblIde.Location = new Point(12, 107);
            LblIde.Name = "LblIde";
            LblIde.Size = new Size(194, 19);
            LblIde.TabIndex = 7;
            LblIde.Text = "Codigo de Identificacion";
            // 
            // LblContacto
            // 
            LblContacto.AutoSize = true;
            LblContacto.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblContacto.Location = new Point(386, 107);
            LblContacto.Name = "LblContacto";
            LblContacto.Size = new Size(164, 19);
            LblContacto.TabIndex = 8;
            LblContacto.Text = "Numero de contacto";
            // 
            // LblUbicacion
            // 
            LblUbicacion.AutoSize = true;
            LblUbicacion.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblUbicacion.Location = new Point(609, 107);
            LblUbicacion.Name = "LblUbicacion";
            LblUbicacion.Size = new Size(86, 19);
            LblUbicacion.TabIndex = 9;
            LblUbicacion.Text = "Ubicacion";
            // 
            // BtnRegresar
            // 
            BtnRegresar.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnRegresar.Location = new Point(637, 242);
            BtnRegresar.Name = "BtnRegresar";
            BtnRegresar.Size = new Size(110, 37);
            BtnRegresar.TabIndex = 10;
            BtnRegresar.Text = "Regresar";
            BtnRegresar.UseVisualStyleBackColor = true;
            BtnRegresar.Click += BtnRegresar_Click;
            // 
            // ActivoInactivo
            // 
            ActivoInactivo.AutoSize = true;
            ActivoInactivo.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ActivoInactivo.Location = new Point(12, 215);
            ActivoInactivo.Name = "ActivoInactivo";
            ActivoInactivo.Size = new Size(94, 26);
            ActivoInactivo.TabIndex = 11;
            ActivoInactivo.Text = "Estado";
            ActivoInactivo.UseVisualStyleBackColor = true;
            // 
            // Centro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(759, 291);
            Controls.Add(ActivoInactivo);
            Controls.Add(BtnRegresar);
            Controls.Add(LblUbicacion);
            Controls.Add(LblContacto);
            Controls.Add(LblIde);
            Controls.Add(LblSede);
            Controls.Add(LblDatos);
            Controls.Add(TBUbicacion);
            Controls.Add(TBIde);
            Controls.Add(TBContacto);
            Controls.Add(comboBox1);
            Controls.Add(BtnAceptar);
            Name = "Centro";
            Text = "Centro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnAceptar;
        private ComboBox comboBox1;
        private Label LblDatos;
        private Label LblSede;
        private Label LblIde;
        private Label LblContacto;
        private Label LblUbicacion;
        private Button BtnRegresar;
        private TextBox TBContacto;
        private TextBox TBIde;
        private TextBox TBUbicacion;
        private CheckBox ActivoInactivo;
    }
}