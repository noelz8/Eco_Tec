namespace CE_1105.Interfaz
{
    partial class Transaccion
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
            titulo = new Label();
            LblIngresar = new Label();
            identificacion = new TextBox();
            label1 = new Label();
            centros = new ComboBox();
            listaMateriales = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            cantidad = new TextBox();
            agregar = new Button();
            listBox1 = new ListBox();
            label4 = new Label();
            total = new TextBox();
            cancelarTransaccion = new Button();
            finalizar = new Button();
            SuspendLayout();
            // 
            // titulo
            // 
            titulo.AutoSize = true;
            titulo.Font = new Font("Microsoft Tai Le", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titulo.Location = new Point(60, 43);
            titulo.Margin = new Padding(4, 0, 4, 0);
            titulo.Name = "titulo";
            titulo.Size = new Size(592, 67);
            titulo.TabIndex = 1;
            titulo.Text = "Registro de Materiales";
            titulo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LblIngresar
            // 
            LblIngresar.AutoSize = true;
            LblIngresar.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblIngresar.Location = new Point(60, 149);
            LblIngresar.Margin = new Padding(4, 0, 4, 0);
            LblIngresar.Name = "LblIngresar";
            LblIngresar.Size = new Size(247, 43);
            LblIngresar.TabIndex = 3;
            LblIngresar.Text = "Identificación";
            // 
            // identificacion
            // 
            identificacion.Location = new Point(348, 160);
            identificacion.Name = "identificacion";
            identificacion.Size = new Size(304, 31);
            identificacion.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(770, 149);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(315, 43);
            label1.TabIndex = 5;
            label1.Text = "Centro de Acopio";
            // 
            // centros
            // 
            centros.DropDownStyle = ComboBoxStyle.DropDownList;
            centros.FormattingEnabled = true;
            centros.Location = new Point(1124, 160);
            centros.Name = "centros";
            centros.Size = new Size(304, 33);
            centros.TabIndex = 7;
            // 
            // listaMateriales
            // 
            listaMateriales.DropDownStyle = ComboBoxStyle.DropDownList;
            listaMateriales.FormattingEnabled = true;
            listaMateriales.Location = new Point(60, 343);
            listaMateriales.Name = "listaMateriales";
            listaMateriales.Size = new Size(576, 33);
            listaMateriales.Sorted = true;
            listaMateriales.TabIndex = 8;
            listaMateriales.SelectedIndexChanged += listaMateriales_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(60, 266);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(193, 43);
            label2.TabIndex = 9;
            label2.Text = "Materiales";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(695, 266);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(173, 43);
            label3.TabIndex = 10;
            label3.Text = "Cantidad";
            // 
            // cantidad
            // 
            cantidad.Location = new Point(695, 345);
            cantidad.Name = "cantidad";
            cantidad.Size = new Size(184, 31);
            cantidad.TabIndex = 11;
            // 
            // agregar
            // 
            agregar.BackColor = SystemColors.Highlight;
            agregar.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            agregar.ForeColor = Color.BlanchedAlmond;
            agregar.Location = new Point(1205, 324);
            agregar.Name = "agregar";
            agregar.Size = new Size(170, 69);
            agregar.TabIndex = 12;
            agregar.Text = "Agregar";
            agregar.UseVisualStyleBackColor = false;
            agregar.Click += agregar_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(60, 532);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(759, 404);
            listBox1.TabIndex = 13;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(826, 640);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(310, 86);
            label4.TabIndex = 14;
            label4.Text = "Total de Material \r\nIngresado";
            // 
            // total
            // 
            total.Location = new Point(839, 746);
            total.Name = "total";
            total.ReadOnly = true;
            total.Size = new Size(287, 31);
            total.TabIndex = 15;
            // 
            // cancelarTransaccion
            // 
            cancelarTransaccion.BackColor = SystemColors.Highlight;
            cancelarTransaccion.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelarTransaccion.ForeColor = Color.BlanchedAlmond;
            cancelarTransaccion.Location = new Point(1205, 532);
            cancelarTransaccion.Name = "cancelarTransaccion";
            cancelarTransaccion.Size = new Size(170, 69);
            cancelarTransaccion.TabIndex = 16;
            cancelarTransaccion.Text = "Cancelar La Transacción";
            cancelarTransaccion.UseVisualStyleBackColor = false;
            cancelarTransaccion.Click += Cancelar_Click;
            // 
            // finalizar
            // 
            finalizar.BackColor = SystemColors.Highlight;
            finalizar.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            finalizar.ForeColor = Color.BlanchedAlmond;
            finalizar.Location = new Point(1205, 746);
            finalizar.Name = "finalizar";
            finalizar.Size = new Size(170, 69);
            finalizar.TabIndex = 17;
            finalizar.Text = "Finalizar";
            finalizar.UseVisualStyleBackColor = false;
            finalizar.Click += finalizar_Click;
            // 
            // Transaccion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1590, 1021);
            Controls.Add(finalizar);
            Controls.Add(cancelarTransaccion);
            Controls.Add(total);
            Controls.Add(label4);
            Controls.Add(listBox1);
            Controls.Add(agregar);
            Controls.Add(cantidad);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listaMateriales);
            Controls.Add(centros);
            Controls.Add(label1);
            Controls.Add(identificacion);
            Controls.Add(LblIngresar);
            Controls.Add(titulo);
            Name = "Transaccion";
            Text = "Transacción (Estudiante)";
            Load += Cargar;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titulo;
        private Label LblIngresar;
        private TextBox identificacion;
        private Label label1;
        private ComboBox centros;
        private ComboBox listaMateriales;
        private Label label2;
        private Label label3;
        private TextBox cantidad;
        private Button agregar;
        private ListBox listBox1;
        private Label label4;
        private TextBox total;
        private Button cancelarTransaccion;
        private Button finalizar;
    }
}