
namespace CE_1105
{
    partial class Sede
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
            CProvincias = new ComboBox();
            ActivoInactivo = new CheckBox();
            LblIngresar = new Label();
            BtnAceptar = new Button();
            Ayuda = new HelpProvider();
            NombreSede = new TextBox();
            NumeroContacto = new TextBox();
            LblNombreSede = new Label();
            LblUbicacion = new Label();
            LblContacto = new Label();
            LblEstado = new Label();
            BRegreso = new Button();
            SuspendLayout();
            // 
            // CProvincias
            // 
            CProvincias.AutoCompleteCustomSource.AddRange(new string[] { "Alajuela", "Guanacaste", "Puntarenas", "Limon", "Heredia", "San Jose", "Caartago" });
            CProvincias.BackColor = Color.White;
            CProvincias.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CProvincias.FormattingEnabled = true;
            CProvincias.Items.AddRange(new object[] { "Alajuela", "Cartago", "Guanacaste", "Heredia", "Limón", "Puntarenas", "San José" });
            CProvincias.Location = new Point(301, 125);
            CProvincias.Name = "CProvincias";
            CProvincias.Size = new Size(156, 27);
            CProvincias.TabIndex = 0;
            CProvincias.Text = "Provincias";
            // 
            // ActivoInactivo
            // 
            ActivoInactivo.AutoSize = true;
            ActivoInactivo.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ActivoInactivo.Location = new Point(31, 218);
            ActivoInactivo.Name = "ActivoInactivo";
            ActivoInactivo.Size = new Size(76, 23);
            ActivoInactivo.TabIndex = 1;
            ActivoInactivo.Text = "Activo";
            ActivoInactivo.UseVisualStyleBackColor = true;
            // 
            // LblIngresar
            // 
            LblIngresar.AutoSize = true;
            LblIngresar.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblIngresar.Location = new Point(177, 34);
            LblIngresar.Name = "LblIngresar";
            LblIngresar.Size = new Size(396, 29);
            LblIngresar.TabIndex = 2;
            LblIngresar.Text = "Por favor ingrese todos los datos";
            // 
            // BtnAceptar
            // 
            BtnAceptar.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAceptar.Location = new Point(255, 275);
            BtnAceptar.Name = "BtnAceptar";
            BtnAceptar.Size = new Size(236, 59);
            BtnAceptar.TabIndex = 3;
            BtnAceptar.Text = "Aceptar";
            BtnAceptar.UseVisualStyleBackColor = true;
            BtnAceptar.Click += Aceptar_Click;
            // 
            // NombreSede
            // 
            NombreSede.ForeColor = SystemColors.Desktop;
            NombreSede.Location = new Point(53, 130);
            NombreSede.Name = "NombreSede";
            NombreSede.Size = new Size(176, 23);
            NombreSede.TabIndex = 5;
            // 
            // NumeroContacto
            // 
            NumeroContacto.Location = new Point(535, 130);
            NumeroContacto.Name = "NumeroContacto";
            NumeroContacto.Size = new Size(176, 23);
            NumeroContacto.TabIndex = 6;
            // 
            // LblNombreSede
            // 
            LblNombreSede.AutoSize = true;
            LblNombreSede.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblNombreSede.Location = new Point(52, 99);
            LblNombreSede.Name = "LblNombreSede";
            LblNombreSede.Size = new Size(177, 23);
            LblNombreSede.TabIndex = 8;
            LblNombreSede.Text = "Nombre de la Sede";
            // 
            // LblUbicacion
            // 
            LblUbicacion.AutoSize = true;
            LblUbicacion.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblUbicacion.Location = new Point(323, 99);
            LblUbicacion.Name = "LblUbicacion";
            LblUbicacion.Size = new Size(99, 23);
            LblUbicacion.TabIndex = 9;
            LblUbicacion.Text = "Ubicacion";
            // 
            // LblContacto
            // 
            LblContacto.AutoSize = true;
            LblContacto.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblContacto.Location = new Point(535, 99);
            LblContacto.Name = "LblContacto";
            LblContacto.Size = new Size(192, 23);
            LblContacto.TabIndex = 10;
            LblContacto.Text = "Numero de Contacto";
            // 
            // LblEstado
            // 
            LblEstado.AutoSize = true;
            LblEstado.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblEstado.Location = new Point(31, 182);
            LblEstado.Name = "LblEstado";
            LblEstado.Size = new Size(72, 23);
            LblEstado.TabIndex = 11;
            LblEstado.Text = "Estado";
            // 
            // BRegreso
            // 
            BRegreso.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BRegreso.Location = new Point(650, 291);
            BRegreso.Name = "BRegreso";
            BRegreso.Size = new Size(148, 66);
            BRegreso.TabIndex = 12;
            BRegreso.Text = "Regresar";
            BRegreso.UseVisualStyleBackColor = true;
            BRegreso.Click += Regresar_Click;
            // 
            // Sede
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 359);
            Controls.Add(BRegreso);
            Controls.Add(LblEstado);
            Controls.Add(LblContacto);
            Controls.Add(LblUbicacion);
            Controls.Add(LblNombreSede);
            Controls.Add(NumeroContacto);
            Controls.Add(NombreSede);
            Controls.Add(BtnAceptar);
            Controls.Add(LblIngresar);
            Controls.Add(ActivoInactivo);
            Controls.Add(CProvincias);
            Name = "Sede";
            Text = "Crear Sede";
            TransparencyKey = SystemColors.ActiveBorder;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CProvincias;
        private CheckBox ActivoInactivo;
        private Label LblIngresar;
        private Button BtnAceptar;
        private HelpProvider Ayuda;
        private TextBox NombreSede;
        private TextBox NumeroContacto;
        private Label LblNombreSede;
        private Label LblUbicacion;
        private Label LblContacto;
        private Label LblEstado;
        private Button BRegreso;
    }
}