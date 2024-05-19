namespace Eco_Tec
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.Nombre_material = new System.Windows.Forms.Label();
            this.txtNombreMaterial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxEstado = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxUnidad = new System.Windows.Forms.ComboBox();
            this.Asignar = new System.Windows.Forms.Label();
            this.txtValorUnitario = new System.Windows.Forms.TextBox();
            this.btnListaMateriales = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "* Campo Obligatorio";
            // 
            // Nombre_material
            // 
            this.Nombre_material.AutoSize = true;
            this.Nombre_material.ForeColor = System.Drawing.Color.Black;
            this.Nombre_material.Location = new System.Drawing.Point(12, 84);
            this.Nombre_material.Name = "Nombre_material";
            this.Nombre_material.Size = new System.Drawing.Size(134, 16);
            this.Nombre_material.TabIndex = 1;
            this.Nombre_material.Text = "Nombre de material *";
            // 
            // txtNombreMaterial
            // 
            this.txtNombreMaterial.Location = new System.Drawing.Point(12, 114);
            this.txtNombreMaterial.Name = "txtNombreMaterial";
            this.txtNombreMaterial.Size = new System.Drawing.Size(233, 22);
            this.txtNombreMaterial.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Estado del material*";
            // 
            // checkBoxEstado
            // 
            this.checkBoxEstado.AutoSize = true;
            this.checkBoxEstado.ForeColor = System.Drawing.Color.Black;
            this.checkBoxEstado.Location = new System.Drawing.Point(15, 246);
            this.checkBoxEstado.Name = "checkBoxEstado";
            this.checkBoxEstado.Size = new System.Drawing.Size(66, 20);
            this.checkBoxEstado.TabIndex = 4;
            this.checkBoxEstado.Text = "Activo";
            this.checkBoxEstado.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Descripción del material";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(12, 341);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(404, 22);
            this.txtDescripcion.TabIndex = 6;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(443, 431);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(141, 50);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(654, 431);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(147, 50);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Salir";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(543, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ingresar datos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(546, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Unidad*";
            // 
            // comboBoxUnidad
            // 
            this.comboBoxUnidad.FormattingEnabled = true;
            this.comboBoxUnidad.Items.AddRange(new object[] {
            "Kg",
            "lb",
            "L",
            "ml"});
            this.comboBoxUnidad.Location = new System.Drawing.Point(516, 114);
            this.comboBoxUnidad.Name = "comboBoxUnidad";
            this.comboBoxUnidad.Size = new System.Drawing.Size(189, 24);
            this.comboBoxUnidad.TabIndex = 11;
            // 
            // Asignar
            // 
            this.Asignar.AutoSize = true;
            this.Asignar.ForeColor = System.Drawing.Color.Black;
            this.Asignar.Location = new System.Drawing.Point(545, 199);
            this.Asignar.Name = "Asignar";
            this.Asignar.Size = new System.Drawing.Size(155, 16);
            this.Asignar.TabIndex = 12;
            this.Asignar.Text = "Asignar TEC COLONES*";
            // 
            // txtValorUnitario
            // 
            this.txtValorUnitario.Location = new System.Drawing.Point(533, 227);
            this.txtValorUnitario.Name = "txtValorUnitario";
            this.txtValorUnitario.Size = new System.Drawing.Size(166, 22);
            this.txtValorUnitario.TabIndex = 13;
            // 
            // btnListaMateriales
            // 
            this.btnListaMateriales.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnListaMateriales.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaMateriales.ForeColor = System.Drawing.Color.Black;
            this.btnListaMateriales.Location = new System.Drawing.Point(961, 96);
            this.btnListaMateriales.Name = "btnListaMateriales";
            this.btnListaMateriales.Size = new System.Drawing.Size(247, 41);
            this.btnListaMateriales.TabIndex = 14;
            this.btnListaMateriales.Text = "Lista de materiales";
            this.btnListaMateriales.UseVisualStyleBackColor = false;
            this.btnListaMateriales.Click += new System.EventHandler(this.btnListaMateriales_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 516);
            this.Controls.Add(this.btnListaMateriales);
            this.Controls.Add(this.txtValorUnitario);
            this.Controls.Add(this.Asignar);
            this.Controls.Add(this.comboBoxUnidad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBoxEstado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombreMaterial);
            this.Controls.Add(this.Nombre_material);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Crimson;
            this.Name = "Form1";
            this.Text = "Crear Material";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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

