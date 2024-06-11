namespace CE_1105.Interfaz
{
    partial class VistaAdministrador
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
            bthSedesCentros = new Button();
            btnHistorial = new Button();
            btnCrearMaterial = new Button();
            btnSalirVistaAdmin = new Button();
            SuspendLayout();
            // 
            // bthSedesCentros
            // 
            bthSedesCentros.Location = new Point(53, 141);
            bthSedesCentros.Name = "bthSedesCentros";
            bthSedesCentros.Size = new Size(165, 63);
            bthSedesCentros.TabIndex = 0;
            bthSedesCentros.Text = "Crear sedes y centros de acopio";
            bthSedesCentros.UseVisualStyleBackColor = true;
            bthSedesCentros.Click += bthSedesCentros_Click;
            // 
            // btnHistorial
            // 
            btnHistorial.Location = new Point(280, 142);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(158, 65);
            btnHistorial.TabIndex = 1;
            btnHistorial.Text = "Ver historial global";
            btnHistorial.UseVisualStyleBackColor = true;
            btnHistorial.Click += btnHistorial_Click;
            // 
            // btnCrearMaterial
            // 
            btnCrearMaterial.Location = new Point(535, 139);
            btnCrearMaterial.Name = "btnCrearMaterial";
            btnCrearMaterial.Size = new Size(149, 67);
            btnCrearMaterial.TabIndex = 2;
            btnCrearMaterial.Text = "Crear material";
            btnCrearMaterial.UseVisualStyleBackColor = true;
            btnCrearMaterial.Click += btnCrearMaterial_Click;
            // 
            // btnSalirVistaAdmin
            // 
            btnSalirVistaAdmin.Location = new Point(314, 319);
            btnSalirVistaAdmin.Name = "btnSalirVistaAdmin";
            btnSalirVistaAdmin.Size = new Size(94, 29);
            btnSalirVistaAdmin.TabIndex = 3;
            btnSalirVistaAdmin.Text = "Salir";
            btnSalirVistaAdmin.UseVisualStyleBackColor = true;
            btnSalirVistaAdmin.Click += btnSalirVistaAdmin_Click;
            // 
            // VistaAdministrador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalirVistaAdmin);
            Controls.Add(btnCrearMaterial);
            Controls.Add(btnHistorial);
            Controls.Add(bthSedesCentros);
            Name = "VistaAdministrador";
            Text = "VistaAdministrador";
            ResumeLayout(false);
        }

        #endregion

        private Button bthSedesCentros;
        private Button btnHistorial;
        private Button btnCrearMaterial;
        private Button btnSalirVistaAdmin;
    }
}