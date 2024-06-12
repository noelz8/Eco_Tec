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
            btn_CrearSede = new Button();
            btn_CrearTransaccion = new Button();
            btn_Historial = new Button();
            BtnAnular = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(375, 11);
            label1.Name = "label1";
            label1.Size = new Size(276, 35);
            label1.TabIndex = 0;
            label1.Text = "Vista de desarrollador*";
            // 
            // btn_CrearMaterial
            // 
            btn_CrearMaterial.Location = new Point(35, 149);
            btn_CrearMaterial.Name = "btn_CrearMaterial";
            btn_CrearMaterial.Size = new Size(205, 83);
            btn_CrearMaterial.TabIndex = 1;
            btn_CrearMaterial.Text = "Crear Material";
            btn_CrearMaterial.UseVisualStyleBackColor = true;
            btn_CrearMaterial.Click += btn_CrearMaterial_Click;
            // 
            // btn_CrearSede
            // 
            btn_CrearSede.Location = new Point(273, 149);
            btn_CrearSede.Name = "btn_CrearSede";
            btn_CrearSede.Size = new Size(205, 83);
            btn_CrearSede.TabIndex = 2;
            btn_CrearSede.Text = "Crear sede y centro";
            btn_CrearSede.UseVisualStyleBackColor = true;
            btn_CrearSede.Click += btn_CrearSede_Click;
            // 
            // btn_CrearTransaccion
            // 
            btn_CrearTransaccion.Location = new Point(498, 149);
            btn_CrearTransaccion.Name = "btn_CrearTransaccion";
            btn_CrearTransaccion.Size = new Size(209, 83);
            btn_CrearTransaccion.TabIndex = 3;
            btn_CrearTransaccion.Text = "Crear transaccion";
            btn_CrearTransaccion.UseVisualStyleBackColor = true;
            btn_CrearTransaccion.Click += btn_CrearTransaccion_Click;
            // 
            // btn_Historial
            // 
            btn_Historial.Location = new Point(733, 149);
            btn_Historial.Name = "btn_Historial";
            btn_Historial.Size = new Size(198, 83);
            btn_Historial.TabIndex = 4;
            btn_Historial.Text = "Ver Historial";
            btn_Historial.UseVisualStyleBackColor = true;
            btn_Historial.Click += btn_Historial_Click;
            // 
            // BtnAnular
            // 
            BtnAnular.Location = new Point(153, 297);
            BtnAnular.Name = "BtnAnular";
            BtnAnular.Size = new Size(198, 83);
            BtnAnular.TabIndex = 5;
            BtnAnular.Text = "Anular Transaccion";
            BtnAnular.UseVisualStyleBackColor = true;
            BtnAnular.Click += BtnAnular_Click;
            // 
            // button1
            // 
            button1.Location = new Point(733, 297);
            button1.Name = "button1";
            button1.Size = new Size(193, 84);
            button1.TabIndex = 6;
            button1.Text = "Registro Globales";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // VistaDesarrollador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 483);
            Controls.Add(button1);
            Controls.Add(BtnAnular);
            Controls.Add(btn_Historial);
            Controls.Add(btn_CrearTransaccion);
            Controls.Add(btn_CrearSede);
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
        private Button btn_CrearSede;
        private Button btn_CrearTransaccion;
        private Button btn_Historial;
        private Button BtnAnular;
        private Button button1;
    }
}