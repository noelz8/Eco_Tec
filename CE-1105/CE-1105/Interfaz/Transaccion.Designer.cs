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
            textBox1 = new TextBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            listBox1 = new ListBox();
            label4 = new Label();
            textBox3 = new TextBox();
            button2 = new Button();
            button3 = new Button();
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
            // textBox1
            // 
            textBox1.Location = new Point(348, 160);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(304, 31);
            textBox1.TabIndex = 4;
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
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(1124, 160);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(304, 33);
            comboBox1.TabIndex = 7;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(60, 343);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(576, 33);
            comboBox2.TabIndex = 8;
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
            // textBox2
            // 
            textBox2.Location = new Point(695, 345);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(184, 31);
            textBox2.TabIndex = 11;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.BlanchedAlmond;
            button1.Location = new Point(1205, 324);
            button1.Name = "button1";
            button1.Size = new Size(170, 69);
            button1.TabIndex = 12;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = false;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(60, 532);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(576, 404);
            listBox1.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(695, 605);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(310, 86);
            label4.TabIndex = 14;
            label4.Text = "Total de Material \r\nIngresado";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(695, 746);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(287, 31);
            textBox3.TabIndex = 15;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Highlight;
            button2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.BlanchedAlmond;
            button2.Location = new Point(1205, 532);
            button2.Name = "button2";
            button2.Size = new Size(170, 69);
            button2.TabIndex = 16;
            button2.Text = "Cancelar La Transacción";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Highlight;
            button3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.BlanchedAlmond;
            button3.Location = new Point(1205, 746);
            button3.Name = "button3";
            button3.Size = new Size(170, 69);
            button3.TabIndex = 17;
            button3.Text = "Finalizar";
            button3.UseVisualStyleBackColor = false;
            // 
            // Transaccion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1590, 1021);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(LblIngresar);
            Controls.Add(titulo);
            Name = "Transaccion";
            Text = "Transacción (Estudiante)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titulo;
        private Label LblIngresar;
        private TextBox textBox1;
        private Label label1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Button button1;
        private ListBox listBox1;
        private Label label4;
        private TextBox textBox3;
        private Button button2;
        private Button button3;
    }
}