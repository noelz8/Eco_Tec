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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(328, 8);
            label1.Name = "label1";
            label1.Size = new Size(216, 27);
            label1.TabIndex = 0;
            label1.Text = "Vista de desarrollador*";
            // 
            // btn_CrearMaterial
            // 
            btn_CrearMaterial.Location = new Point(31, 112);
            btn_CrearMaterial.Margin = new Padding(3, 2, 3, 2);
            btn_CrearMaterial.Name = "btn_CrearMaterial";
            btn_CrearMaterial.Size = new Size(179, 62);
            btn_CrearMaterial.TabIndex = 1;
            btn_CrearMaterial.Text = "Crear Material";
            btn_CrearMaterial.UseVisualStyleBackColor = true;
            btn_CrearMaterial.Click += btn_CrearMaterial_Click;
            // 
            // btn_CrearSede
            // 
            btn_CrearSede.Location = new Point(239, 112);
            btn_CrearSede.Margin = new Padding(3, 2, 3, 2);
            btn_CrearSede.Name = "btn_CrearSede";
            btn_CrearSede.Size = new Size(179, 62);
            btn_CrearSede.TabIndex = 2;
            btn_CrearSede.Text = "Crear sede y centro";
            btn_CrearSede.UseVisualStyleBackColor = true;
            btn_CrearSede.Click += btn_CrearSede_Click;
            // 
            // btn_CrearTransaccion
            // 
            btn_CrearTransaccion.Location = new Point(436, 112);
            btn_CrearTransaccion.Margin = new Padding(3, 2, 3, 2);
            btn_CrearTransaccion.Name = "btn_CrearTransaccion";
            btn_CrearTransaccion.Size = new Size(183, 62);
            btn_CrearTransaccion.TabIndex = 3;
            btn_CrearTransaccion.Text = "Crear transaccion";
            btn_CrearTransaccion.UseVisualStyleBackColor = true;
            btn_CrearTransaccion.Click += btn_CrearTransaccion_Click;
            // 
            // btn_Historial
            // 
            btn_Historial.Location = new Point(641, 112);
            btn_Historial.Margin = new Padding(3, 2, 3, 2);
            btn_Historial.Name = "btn_Historial";
            btn_Historial.Size = new Size(173, 62);
            btn_Historial.TabIndex = 4;
            btn_Historial.Text = "Ver Historial";
            btn_Historial.UseVisualStyleBackColor = true;
            btn_Historial.Click += btn_Historial_Click;
            // 
            // BtnAnular
            // 
            BtnAnular.Location = new Point(134, 223);
            BtnAnular.Margin = new Padding(3, 2, 3, 2);
            BtnAnular.Name = "BtnAnular";
            BtnAnular.Size = new Size(173, 62);
            BtnAnular.TabIndex = 5;
            BtnAnular.Text = "Anular Transaccion";
            BtnAnular.UseVisualStyleBackColor = true;
            BtnAnular.Click += BtnAnular_Click;
            // 
            // VistaDesarrollador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 362);
            Controls.Add(BtnAnular);
            Controls.Add(btn_Historial);
            Controls.Add(btn_CrearTransaccion);
            Controls.Add(btn_CrearSede);
            Controls.Add(btn_CrearMaterial);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
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
    }
}