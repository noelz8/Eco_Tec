namespace CE_1105.Interfaz
{
    partial class CrearMaterial
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
            label2 = new Label();
            txtNombreMaterial = new TextBox();
            label3 = new Label();
            checkBoxEstado = new CheckBox();
            label4 = new Label();
            txtDescripcion = new TextBox();
            Unidad = new Label();
            comboBoxUnidad = new ComboBox();
            label5 = new Label();
            txtValorUnitario = new TextBox();
            btnListaMateriales = new Button();
            btnGuardar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(357, 9);
            label1.Name = "label1";
            label1.Size = new Size(292, 41);
            label1.TabIndex = 0;
            label1.Text = "Crear nuevo material";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 101);
            label2.Name = "label2";
            label2.Size = new Size(144, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre de material";
            // 
            // txtNombreMaterial
            // 
            txtNombreMaterial.Location = new Point(12, 147);
            txtNombreMaterial.Name = "txtNombreMaterial";
            txtNombreMaterial.Size = new Size(229, 27);
            txtNombreMaterial.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 210);
            label3.Name = "label3";
            label3.Size = new Size(138, 20);
            label3.TabIndex = 3;
            label3.Text = "Estado del material";
            // 
            // checkBoxEstado
            // 
            checkBoxEstado.AutoSize = true;
            checkBoxEstado.Location = new Point(12, 244);
            checkBoxEstado.Name = "checkBoxEstado";
            checkBoxEstado.Size = new Size(73, 24);
            checkBoxEstado.TabIndex = 4;
            checkBoxEstado.Text = "Activo";
            checkBoxEstado.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 301);
            label4.Name = "label4";
            label4.Size = new Size(171, 20);
            label4.TabIndex = 5;
            label4.Text = "Descripción del material";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(12, 336);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(157, 27);
            txtDescripcion.TabIndex = 6;
            // 
            // Unidad
            // 
            Unidad.AutoSize = true;
            Unidad.Location = new Point(451, 101);
            Unidad.Name = "Unidad";
            Unidad.Size = new Size(137, 20);
            Unidad.TabIndex = 7;
            Unidad.Text = "Unidad de material";
            // 
            // comboBoxUnidad
            // 
            comboBoxUnidad.FormattingEnabled = true;
            comboBoxUnidad.Items.AddRange(new object[] { "Kg", "lb", "L", "g", "otro" });
            comboBoxUnidad.Location = new Point(451, 146);
            comboBoxUnidad.Name = "comboBoxUnidad";
            comboBoxUnidad.Size = new Size(156, 28);
            comboBoxUnidad.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(451, 210);
            label5.Name = "label5";
            label5.Size = new Size(146, 20);
            label5.TabIndex = 9;
            label5.Text = "Valor en Tec Colones";
            // 
            // txtValorUnitario
            // 
            txtValorUnitario.Location = new Point(451, 241);
            txtValorUnitario.Name = "txtValorUnitario";
            txtValorUnitario.Size = new Size(162, 27);
            txtValorUnitario.TabIndex = 10;
            // 
            // btnListaMateriales
            // 
            btnListaMateriales.Location = new Point(812, 123);
            btnListaMateriales.Name = "btnListaMateriales";
            btnListaMateriales.Size = new Size(203, 51);
            btnListaMateriales.TabIndex = 11;
            btnListaMateriales.Text = "Lista de materiales";
            btnListaMateriales.UseVisualStyleBackColor = true;
            btnListaMateriales.Click += btnListaMateriales_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.MenuHighlight;
            btnGuardar.ForeColor = SystemColors.ControlLightLight;
            btnGuardar.Location = new Point(357, 388);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(150, 58);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(561, 387);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(168, 59);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Salir";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // CrearMaterial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 471);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(btnListaMateriales);
            Controls.Add(txtValorUnitario);
            Controls.Add(label5);
            Controls.Add(comboBoxUnidad);
            Controls.Add(Unidad);
            Controls.Add(txtDescripcion);
            Controls.Add(label4);
            Controls.Add(checkBoxEstado);
            Controls.Add(label3);
            Controls.Add(txtNombreMaterial);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CrearMaterial";
            Text = "CrearMaterial";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNombreMaterial;
        private Label label3;
        private CheckBox checkBoxEstado;
        private Label label4;
        private TextBox txtDescripcion;
        private Label Unidad;
        private ComboBox comboBoxUnidad;
        private Label label5;
        private TextBox txtValorUnitario;
        private Button btnListaMateriales;
        private Button btnGuardar;
        private Button btnCancelar;
    }
}