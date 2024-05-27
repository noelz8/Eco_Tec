namespace Eco_Tec
{
    partial class InterfazMaterial
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            Nombre_material = new Label();
            txtNombreMaterial = new TextBox();
            label3 = new Label();
            checkBoxEstado = new CheckBox();
            label4 = new Label();
            txtDescripcion = new TextBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            label5 = new Label();
            label6 = new Label();
            comboBoxUnidad = new ComboBox();
            Asignar = new Label();
            txtValorUnitario = new TextBox();
            btnListaMateriales = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(148, 20);
            label1.TabIndex = 0;
            label1.Text = "* Campo Obligatorio";
            // 
            // Nombre_material
            // 
            Nombre_material.AutoSize = true;
            Nombre_material.ForeColor = Color.Black;
            Nombre_material.Location = new Point(12, 105);
            Nombre_material.Name = "Nombre_material";
            Nombre_material.Size = new Size(154, 20);
            Nombre_material.TabIndex = 1;
            Nombre_material.Text = "Nombre de material *";
            // 
            // txtNombreMaterial
            // 
            txtNombreMaterial.Location = new Point(12, 142);
            txtNombreMaterial.Margin = new Padding(3, 4, 3, 4);
            txtNombreMaterial.Name = "txtNombreMaterial";
            txtNombreMaterial.Size = new Size(233, 27);
            txtNombreMaterial.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(12, 266);
            label3.Name = "label3";
            label3.Size = new Size(144, 20);
            label3.TabIndex = 3;
            label3.Text = "Estado del material*";
            // 
            // checkBoxEstado
            // 
            checkBoxEstado.AutoSize = true;
            checkBoxEstado.ForeColor = Color.Black;
            checkBoxEstado.Location = new Point(15, 308);
            checkBoxEstado.Margin = new Padding(3, 4, 3, 4);
            checkBoxEstado.Name = "checkBoxEstado";
            checkBoxEstado.Size = new Size(73, 24);
            checkBoxEstado.TabIndex = 4;
            checkBoxEstado.Text = "Activo";
            checkBoxEstado.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(12, 388);
            label4.Name = "label4";
            label4.Size = new Size(171, 20);
            label4.TabIndex = 5;
            label4.Text = "Descripción del material";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(12, 426);
            txtDescripcion.Margin = new Padding(3, 4, 3, 4);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(404, 27);
            txtDescripcion.TabIndex = 6;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.MenuHighlight;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(443, 539);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(141, 62);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Location = new Point(654, 539);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(147, 62);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Salir";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(543, 11);
            label5.Name = "label5";
            label5.Size = new Size(194, 32);
            label5.TabIndex = 9;
            label5.Text = "Ingresar datos";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Black;
            label6.Location = new Point(546, 105);
            label6.Name = "label6";
            label6.Size = new Size(63, 20);
            label6.TabIndex = 10;
            label6.Text = "Unidad*";
            // 
            // comboBoxUnidad
            // 
            comboBoxUnidad.FormattingEnabled = true;
            comboBoxUnidad.Items.AddRange(new object[] { "Kg", "lb", "L", "ml" });
            comboBoxUnidad.Location = new Point(516, 142);
            comboBoxUnidad.Margin = new Padding(3, 4, 3, 4);
            comboBoxUnidad.Name = "comboBoxUnidad";
            comboBoxUnidad.Size = new Size(189, 28);
            comboBoxUnidad.TabIndex = 11;
            // 
            // Asignar
            // 
            Asignar.AutoSize = true;
            Asignar.ForeColor = Color.Black;
            Asignar.Location = new Point(545, 249);
            Asignar.Name = "Asignar";
            Asignar.Size = new Size(162, 20);
            Asignar.TabIndex = 12;
            Asignar.Text = "Asignar TEC COLONES*";
            // 
            // txtValorUnitario
            // 
            txtValorUnitario.Location = new Point(533, 284);
            txtValorUnitario.Margin = new Padding(3, 4, 3, 4);
            txtValorUnitario.Name = "txtValorUnitario";
            txtValorUnitario.Size = new Size(166, 27);
            txtValorUnitario.TabIndex = 13;
            // 
            // btnListaMateriales
            // 
            btnListaMateriales.BackColor = SystemColors.ControlDarkDark;
            btnListaMateriales.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnListaMateriales.ForeColor = Color.Black;
            btnListaMateriales.Location = new Point(961, 120);
            btnListaMateriales.Margin = new Padding(3, 4, 3, 4);
            btnListaMateriales.Name = "btnListaMateriales";
            btnListaMateriales.Size = new Size(247, 51);
            btnListaMateriales.TabIndex = 14;
            btnListaMateriales.Text = "Lista de materiales";
            btnListaMateriales.UseVisualStyleBackColor = false;
            btnListaMateriales.Click += btnListaMateriales_Click;
            // 
            // InterfazMaterial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1224, 645);
            Controls.Add(btnListaMateriales);
            Controls.Add(txtValorUnitario);
            Controls.Add(Asignar);
            Controls.Add(comboBoxUnidad);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txtDescripcion);
            Controls.Add(label4);
            Controls.Add(checkBoxEstado);
            Controls.Add(label3);
            Controls.Add(txtNombreMaterial);
            Controls.Add(Nombre_material);
            Controls.Add(label1);
            ForeColor = Color.Crimson;
            Margin = new Padding(3, 4, 3, 4);
            Name = "InterfazMaterial";
            Text = "Crear Material";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Nombre_material;
        private System.Windows.Forms.TextBox txtNombreMaterial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxEstado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxUnidad;
        private System.Windows.Forms.Label Asignar;
        private System.Windows.Forms.TextBox txtValorUnitario;
        private System.Windows.Forms.Button btnListaMateriales;
    }
}

