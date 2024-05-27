namespace CE_1105.Interfaz
{
    partial class VistaDesarrollador
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
            label1 = new Label();
            btn_CrearMaterial = new Button();
            btn_CrearSedes = new Button();
            btn_CrearTransacciones = new Button();
            btn_Historial = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(388, 19);
            label1.Name = "label1";
            label1.Size = new Size(297, 37);
            label1.TabIndex = 0;
            label1.Text = "Vista de desarrollador*";
            // 
            // btn_CrearMaterial
            // 
            btn_CrearMaterial.Location = new Point(28, 108);
            btn_CrearMaterial.Name = "btn_CrearMaterial";
            btn_CrearMaterial.Size = new Size(179, 61);
            btn_CrearMaterial.TabIndex = 1;
            btn_CrearMaterial.Text = "Crear Material";
            btn_CrearMaterial.UseVisualStyleBackColor = true;
            btn_CrearMaterial.Click += btn_CrearMaterial_Click;
            // 
            // btn_CrearSedes
            // 
            btn_CrearSedes.Location = new Point(301, 108);
            btn_CrearSedes.Name = "btn_CrearSedes";
            btn_CrearSedes.Size = new Size(160, 61);
            btn_CrearSedes.TabIndex = 2;
            btn_CrearSedes.Text = "Crear sedes y centros";
            btn_CrearSedes.UseVisualStyleBackColor = true;
            btn_CrearSedes.Click += btn_CrearSedes_Click;
            // 
            // btn_CrearTransacciones
            // 
            btn_CrearTransacciones.Location = new Point(543, 108);
            btn_CrearTransacciones.Name = "btn_CrearTransacciones";
            btn_CrearTransacciones.Size = new Size(179, 61);
            btn_CrearTransacciones.TabIndex = 3;
            btn_CrearTransacciones.Text = "Crear transaciones";
            btn_CrearTransacciones.UseVisualStyleBackColor = true;
            btn_CrearTransacciones.Click += btn_CrearTransacciones_Click;
            // 
            // btn_Historial
            // 
            btn_Historial.Location = new Point(802, 107);
            btn_Historial.Name = "btn_Historial";
            btn_Historial.Size = new Size(150, 62);
            btn_Historial.TabIndex = 4;
            btn_Historial.Text = "Ver historial";
            btn_Historial.UseVisualStyleBackColor = true;
            // 
            // VistaDesarrollador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1057, 484);
            Controls.Add(btn_Historial);
            Controls.Add(btn_CrearTransacciones);
            Controls.Add(btn_CrearSedes);
            Controls.Add(btn_CrearMaterial);
            Controls.Add(label1);
            Name = "VistaDesarrollador";
            Text = "VistaDesarrollador";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_CrearMaterial;
        private Button btn_CrearSedes;
        private Button btn_CrearTransacciones;
        private Button btn_Historial;
    }
}